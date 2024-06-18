/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Marketplace
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Constant;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Twilio.Rest.Marketplace.V1
{
    public class InstalledAddOnResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateInstalledAddOnOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/InstalledAddOns";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Marketplace,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Install an Add-on for the Account specified. </summary>
        /// <param name="options"> Create InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns>
        public static InstalledAddOnResource Create(CreateInstalledAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Install an Add-on for the Account specified. </summary>
        /// <param name="options"> Create InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns>
        public static async System.Threading.Tasks.Task<InstalledAddOnResource> CreateAsync(CreateInstalledAddOnOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Install an Add-on for the Account specified. </summary>
        /// <param name="availableAddOnSid"> The SID of the AvaliableAddOn to install. </param>
        /// <param name="acceptTermsOfService"> Whether the Terms of Service were accepted. </param>
        /// <param name="configuration"> The JSON object that represents the configuration of the new Add-on being installed. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. This value must be unique within the Account. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns>
        public static InstalledAddOnResource Create(
                                          string availableAddOnSid,
                                          bool? acceptTermsOfService,
                                          object configuration = null,
                                          string uniqueName = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateInstalledAddOnOptions(availableAddOnSid, acceptTermsOfService){  Configuration = configuration, UniqueName = uniqueName };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Install an Add-on for the Account specified. </summary>
        /// <param name="availableAddOnSid"> The SID of the AvaliableAddOn to install. </param>
        /// <param name="acceptTermsOfService"> Whether the Terms of Service were accepted. </param>
        /// <param name="configuration"> The JSON object that represents the configuration of the new Add-on being installed. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. This value must be unique within the Account. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns>
        public static async System.Threading.Tasks.Task<InstalledAddOnResource> CreateAsync(
                                                                                  string availableAddOnSid,
                                                                                  bool? acceptTermsOfService,
                                                                                  object configuration = null,
                                                                                  string uniqueName = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateInstalledAddOnOptions(availableAddOnSid, acceptTermsOfService){  Configuration = configuration, UniqueName = uniqueName };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Remove an Add-on installation from your account </summary>
        /// <param name="options"> Delete InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns>
        private static Request BuildDeleteRequest(DeleteInstalledAddOnOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/InstalledAddOns/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Marketplace,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Remove an Add-on installation from your account </summary>
        /// <param name="options"> Delete InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns>
        public static bool Delete(DeleteInstalledAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Remove an Add-on installation from your account </summary>
        /// <param name="options"> Delete InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteInstalledAddOnOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Remove an Add-on installation from your account </summary>
        /// <param name="pathSid"> The SID of the InstalledAddOn resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteInstalledAddOnOptions(pathSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Remove an Add-on installation from your account </summary>
        /// <param name="pathSid"> The SID of the InstalledAddOn resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteInstalledAddOnOptions(pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchInstalledAddOnOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/InstalledAddOns/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Marketplace,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch an instance of an Add-on currently installed on this Account. </summary>
        /// <param name="options"> Fetch InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns>
        public static InstalledAddOnResource Fetch(FetchInstalledAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch an instance of an Add-on currently installed on this Account. </summary>
        /// <param name="options"> Fetch InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns>
        public static async System.Threading.Tasks.Task<InstalledAddOnResource> FetchAsync(FetchInstalledAddOnOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch an instance of an Add-on currently installed on this Account. </summary>
        /// <param name="pathSid"> The SID of the InstalledAddOn resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns>
        public static InstalledAddOnResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchInstalledAddOnOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch an instance of an Add-on currently installed on this Account. </summary>
        /// <param name="pathSid"> The SID of the InstalledAddOn resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns>
        public static async System.Threading.Tasks.Task<InstalledAddOnResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchInstalledAddOnOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadInstalledAddOnOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/InstalledAddOns";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Marketplace,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of Add-ons currently installed on this Account. </summary>
        /// <param name="options"> Read InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns>
        public static ResourceSet<InstalledAddOnResource> Read(ReadInstalledAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<InstalledAddOnResource>.FromJson("installed_add_ons", response.Content);
            return new ResourceSet<InstalledAddOnResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Add-ons currently installed on this Account. </summary>
        /// <param name="options"> Read InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InstalledAddOnResource>> ReadAsync(ReadInstalledAddOnOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<InstalledAddOnResource>.FromJson("installed_add_ons", response.Content);
            return new ResourceSet<InstalledAddOnResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of Add-ons currently installed on this Account. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns>
        public static ResourceSet<InstalledAddOnResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadInstalledAddOnOptions(){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Add-ons currently installed on this Account. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InstalledAddOnResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadInstalledAddOnOptions(){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<InstalledAddOnResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<InstalledAddOnResource>.FromJson("installed_add_ons", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<InstalledAddOnResource> NextPage(Page<InstalledAddOnResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<InstalledAddOnResource>.FromJson("installed_add_ons", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<InstalledAddOnResource> PreviousPage(Page<InstalledAddOnResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<InstalledAddOnResource>.FromJson("installed_add_ons", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateInstalledAddOnOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/InstalledAddOns/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Marketplace,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update an Add-on installation for the Account specified. </summary>
        /// <param name="options"> Update InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns>
        public static InstalledAddOnResource Update(UpdateInstalledAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update an Add-on installation for the Account specified. </summary>
        /// <param name="options"> Update InstalledAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<InstalledAddOnResource> UpdateAsync(UpdateInstalledAddOnOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update an Add-on installation for the Account specified. </summary>
        /// <param name="pathSid"> The SID of the InstalledAddOn resource to update. </param>
        /// <param name="configuration"> Valid JSON object that conform to the configuration schema exposed by the associated AvailableAddOn resource. This is only required by Add-ons that need to be configured </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. This value must be unique within the Account. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InstalledAddOn </returns>
        public static InstalledAddOnResource Update(
                                          string pathSid,
                                          object configuration = null,
                                          string uniqueName = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateInstalledAddOnOptions(pathSid){ Configuration = configuration, UniqueName = uniqueName };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update an Add-on installation for the Account specified. </summary>
        /// <param name="pathSid"> The SID of the InstalledAddOn resource to update. </param>
        /// <param name="configuration"> Valid JSON object that conform to the configuration schema exposed by the associated AvailableAddOn resource. This is only required by Add-ons that need to be configured </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. This value must be unique within the Account. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InstalledAddOn </returns>
        public static async System.Threading.Tasks.Task<InstalledAddOnResource> UpdateAsync(
                                                                              string pathSid,
                                                                              object configuration = null,
                                                                              string uniqueName = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateInstalledAddOnOptions(pathSid){ Configuration = configuration, UniqueName = uniqueName };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a InstalledAddOnResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> InstalledAddOnResource object represented by the provided JSON </returns>
        public static InstalledAddOnResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<InstalledAddOnResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
        /// <summary>
    /// Converts an object into a json string
    /// </summary>
    /// <param name="model"> C# model </param>
    /// <returns> JSON string </returns>
    public static string ToJson(object model)
    {
        try
        {
            return JsonConvert.SerializeObject(model);
        }
        catch (JsonException e)
        {
            throw new ApiException(e.Message, e);
        }
    }

    
        ///<summary> The unique string that we created to identify the InstalledAddOn resource. This Sid can also be found in the Console on that specific Add-ons page as the 'Available Add-on Sid'. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the InstalledAddOn resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> A short description of the Add-on's functionality. </summary> 
        [JsonProperty("description")]
        public string Description { get; private set; }

        ///<summary> The JSON object that represents the current configuration of installed Add-on. </summary> 
        [JsonProperty("configuration")]
        public object Configuration { get; private set; }

        ///<summary> An application-defined string that uniquely identifies the resource. </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The URLs of related resources. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private InstalledAddOnResource() {

        }
    }
}

