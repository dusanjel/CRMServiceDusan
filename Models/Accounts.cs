using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMServiceDusan.Models
{
    public class Accounts
    {
        [JsonProperty("value")]
        public List<Account> value { get; set; }
    }

    public class Account
    {
        [JsonProperty("missingAllContactInformation")]
        public bool missingAllContactInformation { get; set; }
        [JsonProperty("address2_addresstypecode")]
        public int address2_addresstypecode { get; set; }
        [JsonProperty("merged")]
        public bool merged { get; set; }
        [JsonProperty("statecode")]
        public int statecode { get; set; }
        [JsonProperty("exchangerate")]
        public double exchangerate { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("opendeals")]
        public int opendeals { get; set; }
        [JsonProperty("modifiedon")]
        public DateTime modifiedon { get; set; }
        [JsonProperty("_owninguser_value")]
        public string _owninguser_value { get; set; }
        [JsonProperty("openrevenue_state")]
        public int openrevenue_state { get; set; }
        [JsonProperty("accountratingcode")]
        public int accountratingcode { get; set; }
        [JsonProperty("marketingonly")]
        public bool marketingonly { get; set; }
        [JsonProperty("donotphone")]
        public bool donotphone { get; set; }
        [JsonProperty("preferredcontactmethodcode")]
        public int preferredcontactmethodcode { get; set; }
        [JsonProperty("_ownerid_value")]
        public string _ownerid_value { get; set; }
        [JsonProperty("customersizecode")]
        public int customersizecode { get; set; }
        [JsonProperty("openrevenue_date")]
        public DateTime openrevenue_date { get; set; }
        [JsonProperty("openrevenue_base")]
        public double openrevenue_base { get; set; }
        [JsonProperty("businesstypecode")]
        public int businesstypecode { get; set; }
        [JsonProperty("donotemail")]
        public bool donotemail { get; set; }
        [JsonProperty("address2_shippingmethodcode")]
        public int address2_shippingmethodcode { get; set; }
        [JsonProperty("address1_addressid")]
        public string address1_addressid { get; set; }
        [JsonProperty("address2_freighttermscode")]
        public int address2_freighttermscode { get; set; }
        [JsonProperty("statuscode")]
        public int statuscode { get; set; }
        [JsonProperty("createdon")]
        public DateTime createdon { get; set; }
        [JsonProperty("msdyn_travelchargetype")]
        public int msdyn_travelchargetype { get; set; }
        [JsonProperty("opendeals_state")]
        public int opendeals_state { get; set; }
        [JsonProperty("versionnumber")]
        public int versionnumber { get; set; }
        [JsonProperty("donotpostalmail")]
        public bool donotpostalmail { get; set; }
        [JsonProperty("openrevenue")]
        public double openrevenue { get; set; }
        [JsonProperty("donotsendmm")]
        public bool donotsendmm { get; set; }
        [JsonProperty("donotfax")]
        public bool donotfax { get; set; }
        [JsonProperty("donotbulkpostalmail")]
        public bool donotbulkpostalmail { get; set; }
        [JsonProperty("creditonhold")]
        public bool creditonhold { get; set; }
        [JsonProperty("_transactioncurrencyid_value")]
        public string _transactioncurrencyid_value { get; set; }
        [JsonProperty("accountid")]
        public string accountid { get; set; }
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
        [JsonProperty("territorycode")]
        public int territorycode { get; set; }
        [JsonProperty("msdyn_taxexempt")]
        public bool msdyn_taxexempt { get; set; }
        [JsonProperty("participatesinworkflow")]
        public bool participatesinworkflow { get; set; }
        [JsonProperty("accountclassificationcode")]
        public int accountclassificationcode { get; set; }
        [JsonProperty("_owningbusinessunit_value")]
        public string _owningbusinessunit_value { get; set; }
        [JsonProperty("address2_addressid")]
        public string address2_addressid { get; set; }
        [JsonProperty("opendeals_date")]
        public DateTime opendeals_date { get; set; }
        [JsonProperty("lastusedincampaign")]
        public object lastusedincampaign { get; set; }
        [JsonProperty("address1_name")]
        public object address1_name { get; set; }
        [JsonProperty("timezoneruleversionnumber")]
        public int? timezoneruleversionnumber { get; set; }
        [JsonProperty("industrycode")]
        public int? industrycode { get; set; }
        [JsonProperty("msdyn_taxexemptnumber")]
        public object msdyn_taxexemptnumber { get; set; }
        [JsonProperty("msdyn_externalaccountid")]
        public object msdyn_externalaccountid { get; set; }
        [JsonProperty("entityimageid")]
        public string entityimageid { get; set; }
        [JsonProperty("ownershipcode")]
        public int? ownershipcode { get; set; }
        [JsonProperty("_primarycontactid_value")]
        public string _primarycontactid_value { get; set; }
        [JsonProperty("creditlimit")]
        public object creditlimit { get; set; }
        [JsonProperty("entityimage_url")]
        public string entityimage_url { get; set; }
        [JsonProperty("overriddencreatedon")]
        public DateTime? overriddencreatedon { get; set; }
        [JsonProperty("_territoryid_value")]
        public object _territoryid_value { get; set; }
        [JsonProperty("entityimage_timestamp")]
        public long? entityimage_timestamp { get; set; }
        [JsonProperty("telephone3")]
        public object telephone3 { get; set; }
        [JsonProperty("address1_freighttermscode")]
        public object address1_freighttermscode { get; set; }
        [JsonProperty("address2_line1")]
        public object address2_line1 { get; set; }
        [JsonProperty("onholdtime")]
        public object onholdtime { get; set; }
        [JsonProperty("telephone2")]
        public object telephone2 { get; set; }
        [JsonProperty("address2_telephone1")]
        public object address2_telephone1 { get; set; }
        [JsonProperty("address1_fax")]
        public object address1_fax { get; set; }
        [JsonProperty("address1_composite")]
        public string address1_composite { get; set; }
        [JsonProperty("_createdonbehalfby_value")]
        public object _createdonbehalfby_value { get; set; }
        [JsonProperty("address2_city")]
        public object address2_city { get; set; }
        [JsonProperty("address2_latitude")]
        public object address2_latitude { get; set; }
        [JsonProperty("entityimage")]
        public string entityimage { get; set; }
        [JsonProperty("address1_postofficebox")]
        public object address1_postofficebox { get; set; }
        [JsonProperty("address1_telephone2")]
        public object address1_telephone2 { get; set; }
        [JsonProperty("address2_postalcode")]
        public object address2_postalcode { get; set; }
        [JsonProperty("address2_name")]
        public object address2_name { get; set; }
        [JsonProperty("primarysatoriid")]
        public object primarysatoriid { get; set; }
        [JsonProperty("aging30")]
        public object aging30 { get; set; }
        [JsonProperty("address2_county")]
        public object address2_county { get; set; }
        [JsonProperty("_originatingleadid_value")]
        public object _originatingleadid_value { get; set; }
        [JsonProperty("emailaddress3")]
        public object emailaddress3 { get; set; }
        [JsonProperty("_modifiedbyexternalparty_value")]
        public object _modifiedbyexternalparty_value { get; set; }
        [JsonProperty("paymenttermscode")]
        public int? paymenttermscode { get; set; }
        [JsonProperty("websiteurl")]
        public string websiteurl { get; set; }
        [JsonProperty("revenue")]
        public double? revenue { get; set; }
        [JsonProperty("address1_shippingmethodcode")]
        public object address1_shippingmethodcode { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("aging90_base")]
        public object aging90_base { get; set; }
        [JsonProperty("fax")]
        public string fax { get; set; }
        [JsonProperty("_msdyn_salestaxcode_value")]
        public object _msdyn_salestaxcode_value { get; set; }
        [JsonProperty("address1_stateorprovince")]
        public string address1_stateorprovince { get; set; }
        [JsonProperty("utcconversiontimezonecode")]
        public object utcconversiontimezonecode { get; set; }
        [JsonProperty("sharesoutstanding")]
        public object sharesoutstanding { get; set; }
        [JsonProperty("address1_line2")]
        public string address1_line2 { get; set; }
        [JsonProperty("creditlimit_base")]
        public object creditlimit_base { get; set; }
        [JsonProperty("_preferredsystemuserid_value")]
        public object _preferredsystemuserid_value { get; set; }
        [JsonProperty("_masterid_value")]
        public object _masterid_value { get; set; }
        [JsonProperty("_defaultpricelevelid_value")]
        public object _defaultpricelevelid_value { get; set; }
        [JsonProperty("address1_primarycontactname")]
        public object address1_primarycontactname { get; set; }
        [JsonProperty("address1_latitude")]
        public double? address1_latitude { get; set; }
        [JsonProperty("address1_county")]
        public object address1_county { get; set; }
        [JsonProperty("address1_utcoffset")]
        public object address1_utcoffset { get; set; }
        [JsonProperty("address2_postofficebox")]
        public object address2_postofficebox { get; set; }
        [JsonProperty("_preferredserviceid_value")]
        public object _preferredserviceid_value { get; set; }
        [JsonProperty("_msdyn_serviceterritory_value")]
        public string _msdyn_serviceterritory_value { get; set; }
        [JsonProperty("customertypecode")]
        public int? customertypecode { get; set; }
        [JsonProperty("address1_upszone")]
        public object address1_upszone { get; set; }
        [JsonProperty("stageid")]
        public object stageid { get; set; }
        [JsonProperty("address2_composite")]
        public object address2_composite { get; set; }
        [JsonProperty("marketcape")]
        public object marketcap { get; set; }
        [JsonProperty("aging60")]
        public object aging60 { get; set; }
        [JsonProperty("telephone1")]
        public string telephone1 { get; set; }
        [JsonProperty("address2_longitude")]
        public object address2_longitude { get; set; }
        [JsonProperty("yominame")]
        public object yominame { get; set; }
        [JsonProperty("address2_primarycontactname")]
        public object address2_primarycontactname { get; set; }
        [JsonProperty("msdyn_workorderinstructions")]
        public object msdyn_workorderinstructions { get; set; }
        [JsonProperty("address2_country")]
        public object address2_country { get; set; }
        [JsonProperty("_msdyn_preferredresource_value")]
        public object _msdyn_preferredresource_value { get; set; }
        [JsonProperty("address1_postalcode")]
        public string address1_postalcode { get; set; }
        [JsonProperty("traversedpath")]
        public object traversedpath { get; set; }
        [JsonProperty("numberofemployees")]
        public int? numberofemployees { get; set; }
        [JsonProperty("numberofcontacts")]
        public int? numberofcontacts { get; set; }
        [JsonProperty("tickersymbol")]
        public string tickersymbol { get; set; }
        [JsonProperty("msdyn_travelcharge_base")]
        public object msdyn_travelcharge_base { get; set; }
        [JsonProperty("address1_city")]
        public string address1_city { get; set; }
        [JsonProperty("aging90")]
        public object aging90 { get; set; }
        [JsonProperty("msdyn_travelcharge")]
        public object msdyn_travelcharge { get; set; }
        [JsonProperty("address1_longitude")]
        public double? address1_longitude { get; set; }
        [JsonProperty("address2_utcoffset")]
        public object address2_utcoffset { get; set; }
        [JsonProperty("revenue_base")]
        public double? revenue_base { get; set; }
        [JsonProperty("address1_telephone1")]
        public object address1_telephone1 { get; set; }
        [JsonProperty("address2_telephone3")]
        public object address2_telephone3 { get; set; }
        [JsonProperty("_owningteam_value")]
        public object _owningteam_value { get; set; }
        [JsonProperty("lastonholdtime")]
        public object lastonholdtime { get; set; }
        [JsonProperty("address2_line2")]
        public object address2_line2 { get; set; }
        [JsonProperty("primarytwitterid")]
        public object primarytwitterid { get; set; }
        [JsonProperty("timespentbymeonemailandmeetings")]
        public object timespentbymeonemailandmeetings { get; set; }
        [JsonProperty("accountnumber")]
        public string accountnumber { get; set; }
        [JsonProperty("address1_line1")]
        public string address1_line1 { get; set; }
        [JsonProperty("_slaid_value")]
        public object _slaid_value { get; set; }
        [JsonProperty("ftpsiteurl")]
        public object ftpsiteurl { get; set; }
        [JsonProperty("_preferredequipmentid_value")]
        public object _preferredequipmentid_value { get; set; }
        [JsonProperty("sic")]
        public string sic { get; set; }
        [JsonProperty("processid")]
        public object processid { get; set; }
        [JsonProperty("address2_telephone2")]
        public object address2_telephone2 { get; set; }
        [JsonProperty("address1_addresstypecode")]
        public object address1_addresstypecode { get; set; }
        [JsonProperty("_parentaccountid_value")]
        public string _parentaccountid_value { get; set; }
        [JsonProperty("_createdbyexternalparty_value")]
        public object _createdbyexternalparty_value { get; set; }
        [JsonProperty("address2_fax")]
        public object address2_fax { get; set; }
        [JsonProperty("aging60_base")]
        public object aging60_base { get; set; }
        [JsonProperty("_modifiedonbehalfby_value")]
        public object _modifiedonbehalfby_value { get; set; }
        [JsonProperty("_msdyn_billingaccount_value")]
        public string _msdyn_billingaccount_value { get; set; }
        [JsonProperty("stockexchange")]
        public object stockexchange { get; set; }
        [JsonProperty("preferredappointmentdaycode")]
        public object preferredappointmentdaycode { get; set; }
        [JsonProperty("address1_line3")]
        public object address1_line3 { get; set; }
        [JsonProperty("aging30_base")]
        public object aging30_base { get; set; }
        [JsonProperty("address2_upszone")]
        public object address2_upszone { get; set; }
        [JsonProperty("_slainvokedid_value")]
        public object _slainvokedid_value { get; set; }
        [JsonProperty("address1_country")]
        public string address1_country { get; set; }
        [JsonProperty("address2_line3")]
        public object address2_line3 { get; set; }
        [JsonProperty("_msdyn_workhourtemplate_value")]
        public object _msdyn_workhourtemplate_value { get; set; }
        [JsonProperty("emailaddress1")]
        public string emailaddress1 { get; set; }
        [JsonProperty("address2_stateorprovince")]
        public object address2_stateorprovince { get; set; }
        [JsonProperty("preferredappointmenttimecode")]
        public object preferredappointmenttimecode { get; set; }
        [JsonProperty("emailaddress2")]
        public object emailaddress2 { get; set; }
        [JsonProperty("marketcap_base")]
        public object marketcap_base { get; set; }
        [JsonProperty("importsequencenumber")]
        public int? importsequencenumber { get; set; }
        [JsonProperty("address1_telephone3")]
        public object address1_telephone3 { get; set; }
        [JsonProperty("accountcategorycode")]
        public int? accountcategorycode { get; set; }
    }
}