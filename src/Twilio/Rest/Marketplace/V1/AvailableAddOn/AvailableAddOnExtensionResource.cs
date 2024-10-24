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



namespace Twilio.Rest.Marketplace.V1.AvailableAddOn
{
    public class AvailableAddOnExtensionResource : Resource
    {
    

    

        
        private static Request BuildFetchRequest(FetchAvailableAddOnExtensionOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/AvailableAddOns/{AvailableAddOnSid}/Extensions/{Sid}";

            string PathAvailableAddOnSid = options.PathAvailableAddOnSid;
            path = path.Replace("{"+"AvailableAddOnSid"+"}", PathAvailableAddOnSid);
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

        /// <summary> Fetch an instance of an Extension for the Available Add-on. </summary>
        /// <param name="options"> Fetch AvailableAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailableAddOnExtension </returns>
        public static AvailableAddOnExtensionResource Fetch(FetchAvailableAddOnExtensionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch an instance of an Extension for the Available Add-on. </summary>
        /// <param name="options"> Fetch AvailableAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailableAddOnExtension </returns>
        public static async System.Threading.Tasks.Task<AvailableAddOnExtensionResource> FetchAsync(FetchAvailableAddOnExtensionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch an instance of an Extension for the Available Add-on. </summary>
        /// <param name="pathAvailableAddOnSid"> The SID of the AvailableAddOn resource with the extension to fetch. </param>
        /// <param name="pathSid"> The SID of the AvailableAddOn Extension resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailableAddOnExtension </returns>
        public static AvailableAddOnExtensionResource Fetch(
                                         string pathAvailableAddOnSid, 
                                         string pathSid, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchAvailableAddOnExtensionOptions(pathAvailableAddOnSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch an instance of an Extension for the Available Add-on. </summary>
        /// <param name="pathAvailableAddOnSid"> The SID of the AvailableAddOn resource with the extension to fetch. </param>
        /// <param name="pathSid"> The SID of the AvailableAddOn Extension resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailableAddOnExtension </returns>
        public static async System.Threading.Tasks.Task<AvailableAddOnExtensionResource> FetchAsync(string pathAvailableAddOnSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchAvailableAddOnExtensionOptions(pathAvailableAddOnSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadAvailableAddOnExtensionOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/AvailableAddOns/{AvailableAddOnSid}/Extensions";

            string PathAvailableAddOnSid = options.PathAvailableAddOnSid;
            path = path.Replace("{"+"AvailableAddOnSid"+"}", PathAvailableAddOnSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Marketplace,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of Extensions for the Available Add-on. </summary>
        /// <param name="options"> Read AvailableAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailableAddOnExtension </returns>
        public static ResourceSet<AvailableAddOnExtensionResource> Read(ReadAvailableAddOnExtensionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<AvailableAddOnExtensionResource>.FromJson("extensions", response.Content);
            return new ResourceSet<AvailableAddOnExtensionResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Extensions for the Available Add-on. </summary>
        /// <param name="options"> Read AvailableAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailableAddOnExtension </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AvailableAddOnExtensionResource>> ReadAsync(ReadAvailableAddOnExtensionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AvailableAddOnExtensionResource>.FromJson("extensions", response.Content);
            return new ResourceSet<AvailableAddOnExtensionResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of Extensions for the Available Add-on. </summary>
        /// <param name="pathAvailableAddOnSid"> The SID of the AvailableAddOn resource with the extensions to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailableAddOnExtension </returns>
        public static ResourceSet<AvailableAddOnExtensionResource> Read(
                                                     string pathAvailableAddOnSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadAvailableAddOnExtensionOptions(pathAvailableAddOnSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Extensions for the Available Add-on. </summary>
        /// <param name="pathAvailableAddOnSid"> The SID of the AvailableAddOn resource with the extensions to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailableAddOnExtension </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AvailableAddOnExtensionResource>> ReadAsync(
                                                                                             string pathAvailableAddOnSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadAvailableAddOnExtensionOptions(pathAvailableAddOnSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<AvailableAddOnExtensionResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AvailableAddOnExtensionResource>.FromJson("extensions", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<AvailableAddOnExtensionResource> NextPage(Page<AvailableAddOnExtensionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AvailableAddOnExtensionResource>.FromJson("extensions", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<AvailableAddOnExtensionResource> PreviousPage(Page<AvailableAddOnExtensionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AvailableAddOnExtensionResource>.FromJson("extensions", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a AvailableAddOnExtensionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AvailableAddOnExtensionResource object represented by the provided JSON </returns>
        public static AvailableAddOnExtensionResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AvailableAddOnExtensionResource>(json);
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

    
        ///<summary> The unique string that we created to identify the AvailableAddOnExtension resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the AvailableAddOn resource to which this extension applies. </summary> 
        [JsonProperty("available_add_on_sid")]
        public string AvailableAddOnSid { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The name of the Product this Extension is used within. </summary> 
        [JsonProperty("product_name")]
        public string ProductName { get; private set; }

        ///<summary> An application-defined string that uniquely identifies the resource. </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private AvailableAddOnExtensionResource() {

        }
    }
}

