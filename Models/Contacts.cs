using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMServiceDusan.Models
{
    public class Contacts
    {
        [JsonProperty("value")]
        public List<Contact> value { get; set; }
    }

    public class Contact
    {
        [JsonProperty("customertypecode")]
        public int customertypecode { get; set; }
        [JsonProperty("address2_addresstypecode")]
        public int address2_addresstypecode { get; set; }
        [JsonProperty("merged")]
        public bool merged { get; set; }
        [JsonProperty("territorycode")]
        public int territorycode { get; set; }
        [JsonProperty("emailaddress1")]
        public string emailaddress1 { get; set; }
        [JsonProperty("haschildrencode")]
        public int haschildrencode { get; set; }
        [JsonProperty("preferredappointmenttimecode")]
        public int preferredappointmenttimecode { get; set; }
        [JsonProperty("msdyn_orgchangestatus")]
        public int msdyn_orgchangestatus { get; set; }
        [JsonProperty("isbackofficecustomer")]
        public bool isbackofficecustomer { get; set; }
        [JsonProperty("modifiedon")]
        public DateTime modifiedon { get; set; }
        [JsonProperty("_owninguser_value")]
        public string _owninguser_value { get; set; }
        [JsonProperty("address1_composite")]
        public string address1_composite { get; set; }
        [JsonProperty("lastname")]
        public string lastname { get; set; }
        [JsonProperty("donotpostalmail")]
        public bool donotpostalmail { get; set; }
        [JsonProperty("marketingonly")]
        public bool marketingonly { get; set; }
        [JsonProperty("donotphone")]
        public bool donotphone { get; set; }
        [JsonProperty("preferredcontactmethodcode")]
        public int preferredcontactmethodcode { get; set; }
        [JsonProperty("educationcode")]
        public int educationcode { get; set; }
        [JsonProperty("_ownerid_value")]
        public string _ownerid_value { get; set; }
        [JsonProperty("customersizecode")]
        public int customersizecode { get; set; }
        [JsonProperty("firstname")]
        public string firstname { get; set; }
        [JsonProperty("yomifullname")]
        public string yomifullname { get; set; }
        [JsonProperty("donotemail")]
        public bool donotemail { get; set; }
        [JsonProperty("address2_shippingmethodcode")]
        public int address2_shippingmethodcode { get; set; }
        [JsonProperty("fullname")]
        public string fullname { get; set; }
        [JsonProperty("timezoneruleversionnumber")]
        public int? timezoneruleversionnumber { get; set; }
        [JsonProperty("address1_addressid")]
        public string address1_addressid { get; set; }
        [JsonProperty("msdyn_gdproptout")]
        public bool msdyn_gdproptout { get; set; }
        [JsonProperty("address2_freighttermscode")]
        public int address2_freighttermscode { get; set; }
        [JsonProperty("statuscode")]
        public int statuscode { get; set; }
        [JsonProperty("createdon")]
        public DateTime createdon { get; set; }
        [JsonProperty("versionnumber")]
        public int versionnumber { get; set; }
        [JsonProperty("address1_stateorprovince")]
        public string address1_stateorprovince { get; set; }
        [JsonProperty("donotsendmm")]
        public bool donotsendmm { get; set; }
        [JsonProperty("donotfax")]
        public bool donotfax { get; set; }
        [JsonProperty("leadsourcecode")]
        public int leadsourcecode { get; set; }
        [JsonProperty("address1_country")]
        public string address1_country { get; set; }
        [JsonProperty("address1_line1")]
        public string address1_line1 { get; set; }
        [JsonProperty("address1_line2")]
        public string address1_line2 { get; set; }
        [JsonProperty("creditonhold")]
        public bool creditonhold { get; set; }
        [JsonProperty("telephone1")]
        public string telephone1 { get; set; }
        [JsonProperty("address3_addressid")]
        public string address3_addressid { get; set; }
        [JsonProperty("donotbulkemail")]
        public bool donotbulkemail { get; set; }
        [JsonProperty("_modifiedby_value")]
        public string _modifiedby_value { get; set; }
        [JsonProperty("followemail")]
        public bool followemail { get; set; }
        [JsonProperty("shippingmethodcode")]
        public int shippingmethodcode { get; set; }
        [JsonProperty("_createdby_value")]
        public string _createdby_value { get; set; }
        [JsonProperty("address1_city")]
        public string address1_city { get; set; }
        [JsonProperty("donotbulkpostalmail")]
        public bool donotbulkpostalmail { get; set; }
        [JsonProperty("nickname")]
        public string nickname { get; set; }
        [JsonProperty("contactid")]
        public string contactid { get; set; }
        [JsonProperty("participatesinworkflow")]
        public bool participatesinworkflow { get; set; }
        [JsonProperty("statecode")]
        public int statecode { get; set; }
        [JsonProperty("_owningbusinessunit_value")]
        public string _owningbusinessunit_value { get; set; }
        [JsonProperty("address2_addressid")]
        public string address2_addressid { get; set; }
        [JsonProperty("address1_postalcode")]
        public string address1_postalcode { get; set; }
        [JsonProperty("spousesname")]
        public string spousesname { get; set; }
        [JsonProperty("emailaddress3")]
        public object emailaddress3 { get; set; }
        [JsonProperty("address3_telephone3")]
        public object address3_telephone3 { get; set; }
        [JsonProperty("mobilephone")]
        public string mobilephone { get; set; }
        [JsonProperty("utcconversiontimezonecode")]
        public object utcconversiontimezonecode { get; set; }
        [JsonProperty("_preferredserviceid_value")]
        public object _preferredserviceid_value { get; set; }
        [JsonProperty("address3_shippingmethodcode")]
        public object address3_shippingmethodcode { get; set; }
        [JsonProperty("address3_postalcode")]
        public object address3_postalcode { get; set; }
        [JsonProperty("annualincome")]
        public object annualincome { get; set; }
        [JsonProperty("fax")]
        public object fax { get; set; }
        [JsonProperty("address3_name")]
        public object address3_name { get; set; }
        [JsonProperty("telephone3")]
        public object telephone3 { get; set; }
        [JsonProperty("address1_primarycontactname")]
        public object address1_primarycontactname { get; set; }
        [JsonProperty("address3_city")]
        public object address3_city { get; set; }
        [JsonProperty("lastonholdtime")]
        public object lastonholdtime { get; set; }
        [JsonProperty("address2_stateorprovince")]
        public object address2_stateorprovince { get; set; }
        public object address2_line1 { get; set; }
        [JsonProperty("assistantphone")]
        public object assistantphone { get; set; }
        [JsonProperty("lastusedincampaign")]
        public object lastusedincampaign { get; set; }
        [JsonProperty("pager")]
        public object pager { get; set; }
        [JsonProperty("employeeid")]
        public object employeeid { get; set; }
        [JsonProperty("address1_latitude")]
        public double? address1_latitude { get; set; }
        [JsonProperty("_parentcustomerid_value")]
        public string _parentcustomerid_value { get; set; }
        [JsonProperty("managername")]
        public object managername { get; set; }
        [JsonProperty("birthdate")]
        public string birthdate { get; set; }
        [JsonProperty("address1_name")]
        public object address1_name { get; set; }
        [JsonProperty("department")]
        public object department { get; set; }
        [JsonProperty("address3_country")]
        public object address3_country { get; set; }
        [JsonProperty("address2_telephone1")]
        public object address2_telephone1 { get; set; }
        [JsonProperty("address2_primarycontactname")]
        public object address2_primarycontactname { get; set; }
        [JsonProperty("address2_latitude")]
        public object address2_latitude { get; set; }
        [JsonProperty("address2_postalcode")]
        public object address2_postalcode { get; set; }
        [JsonProperty("entityimage_timestamp")]
        public long? entityimage_timestamp { get; set; }
        [JsonProperty("_originatingleadid_value")]
        public object _originatingleadid_value { get; set; }
        [JsonProperty("_masterid_value")]
        public object _masterid_value { get; set; }
        [JsonProperty("_createdonbehalfby_value")]
        public object _createdonbehalfby_value { get; set; }
        [JsonProperty("address3_postofficebox")]
        public object address3_postofficebox { get; set; }
        [JsonProperty("subscriptionid")]
        public object subscriptionid { get; set; }
        [JsonProperty("address3_county")]
        public object address3_county { get; set; }
        [JsonProperty("address1_freighttermscode")]
        public object address1_freighttermscode { get; set; }
        [JsonProperty("address3_addresstypecode")]
        public object address3_addresstypecode { get; set; }
        [JsonProperty("address1_longitude")]
        public double? address1_longitude { get; set; }
        [JsonProperty("address1_addresstypecode")]
        public object address1_addresstypecode { get; set; }
        [JsonProperty("aging90_base")]
        public object aging90_base { get; set; }
        [JsonProperty("address3_primarycontactname")]
        public object address3_primarycontactname { get; set; }
        [JsonProperty("familystatuscode")]
        public int? familystatuscode { get; set; }
        [JsonProperty("home2")]
        public object home2 { get; set; }
        [JsonProperty("address2_utcoffset")]
        public object address2_utcoffset { get; set; }
        [JsonProperty("aging60")]
        public object aging60 { get; set; }
        [JsonProperty("telephone2")]
        public object telephone2 { get; set; }
        [JsonProperty("yomimiddlename")]
        public object yomimiddlename { get; set; }
        [JsonProperty("_modifiedonbehalfby_value")]
        public object _modifiedonbehalfby_value { get; set; }
        [JsonProperty("jobtitle")]
        public string jobtitle { get; set; }
        [JsonProperty("address3_utcoffset")]
        public object address3_utcoffset { get; set; }
        [JsonProperty("address1_telephone3")]
        public object address1_telephone3 { get; set; }
        [JsonProperty("importsequencenumber")]
        public int? importsequencenumber { get; set; }
        [JsonProperty("gendercode")]
        public int? gendercode { get; set; }
        [JsonProperty("address2_line2")]
        public object address2_line2 { get; set; }
        [JsonProperty("creditlimit_base")]
        public object creditlimit_base { get; set; }
        [JsonProperty("address3_line1")]
        public object address3_line1 { get; set; }
        [JsonProperty("address1_county")]
        public object address1_county { get; set; }
        [JsonProperty("_createdbyexternalparty_value")]
        public object _createdbyexternalparty_value { get; set; }
        [JsonProperty("entityimageid")]
        public string entityimageid { get; set; }
        [JsonProperty("processid")]
        public object processid { get; set; }
        [JsonProperty("address1_telephone2")]
        public object address1_telephone2 { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("address1_fax")]
        public object address1_fax { get; set; }
        [JsonProperty("address3_line2")]
        public object address3_line2 { get; set; }
        [JsonProperty("externaluseridentifier")]
        public object externaluseridentifier { get; set; }
        [JsonProperty("aging30_base")]
        public object aging30_base { get; set; }
        [JsonProperty("callback")]
        public object callback { get; set; }
        [JsonProperty("emailaddress2")]
        public object emailaddress2 { get; set; }
        [JsonProperty("address2_line3")]
        public object address2_line3 { get; set; }
        [JsonProperty("managerphone")]
        public object managerphone { get; set; }
        [JsonProperty("preferredappointmentdaycode")]
        public object preferredappointmentdaycode { get; set; }
        [JsonProperty("websiteurl")]
        public string websiteurl { get; set; }
        [JsonProperty("exchangerate")]
        public object exchangerate { get; set; }
        [JsonProperty("address1_telephone1")]
        public object address1_telephone1 { get; set; }
        [JsonProperty("address3_composite")]
        public object address3_composite { get; set; }
        [JsonProperty("address3_fax")]
        public object address3_fax { get; set; }
        [JsonProperty("childrensnames")]
        public object childrensnames { get; set; }
        [JsonProperty("_owningteam_value")]
        public object _owningteam_value { get; set; }
        [JsonProperty("numberofchildren")]
        public object numberofchildren { get; set; }
        [JsonProperty("address2_postofficebox")]
        public object address2_postofficebox { get; set; }
        [JsonProperty("aging90")]
        public object aging90 { get; set; }
        [JsonProperty("address3_latitude")]
        public object address3_latitude { get; set; }
        [JsonProperty("aging60_base")]
        public object aging60_base { get; set; }
        [JsonProperty("_transactioncurrencyid_value")]
        public object _transactioncurrencyid_value { get; set; }
        [JsonProperty("entityimage")]
        public string entityimage { get; set; }
        [JsonProperty("_modifiedbyexternalparty_value")]
        public object _modifiedbyexternalparty_value { get; set; }
        [JsonProperty("paymenttermscode")]
        public object paymenttermscode { get; set; }
        [JsonProperty("address3_freighttermscode")]
        public object address3_freighttermscode { get; set; }
        [JsonProperty("ftpsiteurl")]
        public object ftpsiteurl { get; set; }
        [JsonProperty("address1_shippingmethodcode")]
        public object address1_shippingmethodcode { get; set; }
        [JsonProperty("_preferredsystemuserid_value")]
        public object _preferredsystemuserid_value { get; set; }
        [JsonProperty("address2_telephone2")]
        public object address2_telephone2 { get; set; }
        [JsonProperty("_slainvokedid_value")]
        public object _slainvokedid_value { get; set; }
        [JsonProperty("address3_telephone1")]
        public object address3_telephone1 { get; set; }
        [JsonProperty("address1_postofficebox")]
        public object address1_postofficebox { get; set; }
        [JsonProperty("_preferredequipmentid_value")]
        public object _preferredequipmentid_value { get; set; }
        [JsonProperty("assistantname")]
        public object assistantname { get; set; }
        [JsonProperty("address2_country")]
        public object address2_country { get; set; }
        [JsonProperty("_accountid_value")]
        public object _accountid_value { get; set; }
        [JsonProperty("address2_name")]
        public object address2_name { get; set; }
        [JsonProperty("stageid")]
        public object stageid { get; set; }
        [JsonProperty("address3_longitude")]
        public object address3_longitude { get; set; }
        [JsonProperty("onholdtime")]
        public object onholdtime { get; set; }
        [JsonProperty("address2_telephone3")]
        public object address2_telephone3 { get; set; }
        [JsonProperty("address3_upszone")]
        public object address3_upszone { get; set; }
        [JsonProperty("aging30")]
        public object aging30 { get; set; }
        [JsonProperty("address2_upszone")]
        public object address2_upszone { get; set; }
        [JsonProperty("address1_upszone")]
        public object address1_upszone { get; set; }
        [JsonProperty("creditlimit")]
        public object creditlimit { get; set; }
        [JsonProperty("accountrolecode")]
        public object accountrolecode { get; set; }
        [JsonProperty("salutation")]
        public object salutation { get; set; }
        [JsonProperty("suffix")]
        public object suffix { get; set; }
        [JsonProperty("traversedpath")]
        public object traversedpath { get; set; }
        [JsonProperty("address1_utcoffset")]
        public object address1_utcoffset { get; set; }
        [JsonProperty("governmentid")]
        public object governmentid { get; set; }
        [JsonProperty("annualincome_base")]
        public object annualincome_base { get; set; }
        [JsonProperty("address3_stateorprovince")]
        public object address3_stateorprovince { get; set; }
        [JsonProperty("address2_city")]
        public object address2_city { get; set; }
        [JsonProperty("company")]
        public object company { get; set; }
        [JsonProperty("address2_longitude")]
        public object address2_longitude { get; set; }
        [JsonProperty("address3_telephone2")]
        public object address3_telephone2 { get; set; }
        [JsonProperty("yomifirstname")]
        public object yomifirstname { get; set; }
        [JsonProperty("address2_composite")]
        public object address2_composite { get; set; }
        [JsonProperty("address2_county")]
        public object address2_county { get; set; }
        [JsonProperty("anniversary")]
        public string anniversary { get; set; }
        [JsonProperty("business2")]
        public object business2 { get; set; }
        [JsonProperty("_parentcontactid_value")]
        public object _parentcontactid_value { get; set; }
        [JsonProperty("address2_fax")]
        public object address2_fax { get; set; }
        [JsonProperty("yomilastname")]
        public object yomilastname { get; set; }
        [JsonProperty("entityimage_url")]
        public string entityimage_url { get; set; }
        [JsonProperty("address1_line3")]
        public object address1_line3 { get; set; }
        [JsonProperty("_defaultpricelevelid_value")]
        public object _defaultpricelevelid_value { get; set; }
        [JsonProperty("_slaid_value")]
        public object _slaid_value { get; set; }
        [JsonProperty("middlename")]
        public object middlename { get; set; }
        [JsonProperty("address3_line3")]
        public object address3_line3 { get; set; }
        [JsonProperty("overriddencreatedon")]
        public DateTime? overriddencreatedon { get; set; }
        [JsonProperty("timespentbymeonemailandmeetings")]
        public object timespentbymeonemailandmeetings { get; set; }
    }
}