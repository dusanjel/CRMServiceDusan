
using CRMServiceDusan.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;

namespace CRMServiceDusan.Controllers
{
    public class HomeController : Controller
    {
        static AuthenticationContext authContext;
        static AuthenticationResult authToken;
        static string apiUrl = "https://codeflakes.crm4.dynamics.com//api/data";
        static string clientId = "5edeb9c5-0829-4c7d-9dc3-f82145fc2123";
        static string redirectUrl = "https://localhost:44312/";

        public ActionResult Index()
        {
            var accounts = GetAccoounts();
            return View(accounts.value);
        }

        private Accounts GetAccoounts()
        {
            AuthenticationParameters ap = AuthenticationParameters.CreateFromResourceUrlAsync(new Uri(apiUrl)).Result;

            string resourceUrl = ap.Resource;
            string authorityUrl = ap.Authority;

            Accounts accounts;
            Contacts contacts;

            authContext = new AuthenticationContext(authorityUrl, false);

            try
            {
                authToken = authContext.AcquireTokenAsync(resourceUrl, clientId, new Uri(redirectUrl), new PlatformParameters(PromptBehavior.Never)).GetAwaiter().GetResult();
            }
            catch (AdalException e)
            {
                if (e.ErrorCode == "user_interaction_required")
                {
                    authToken = authContext.AcquireTokenAsync(resourceUrl, clientId, new Uri(redirectUrl), new PlatformParameters(PromptBehavior.Auto)).GetAwaiter().GetResult(); ;
                }
                else
                {
                    throw;
                }
            }

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.Timeout = new TimeSpan(0, 2, 0);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken.AccessToken);
                
                var dataAccount = httpClient.GetAsync("https://codeflakes.crm4.dynamics.com/api/data/v8.2/accounts").GetAwaiter().GetResult();

                var dataContact = httpClient.GetAsync("https://codeflakes.crm4.dynamics.com/api/data/v8.2/contacts").GetAwaiter().GetResult();

                if (dataAccount.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var accountJson = dataAccount.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                    accounts = JsonConvert.DeserializeObject<Accounts>(accountJson, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

                    if (dataContact.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var contactJson = dataContact.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                        contacts = JsonConvert.DeserializeObject<Contacts>(contactJson, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

                        accounts.value.ForEach(a =>
                        {
                            a.numberofcontacts = contacts.value.Where(x => x.contactid == a._primarycontactid_value).Count();
                            a.missingAllContactInformation = contacts.GetType().GetProperties()
                            .All(p => p.GetValue(contacts) == null);

                        });

                        return accounts;
                    }
                    else
                    {
                        return null;

                    }
                }
                else
                {
                    return null;
                    
                }
            }
        }
    }
}