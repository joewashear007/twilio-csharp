/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
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



namespace Twilio.Rest.FlexApi.V1
{
    public class PluginReleaseResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreatePluginReleaseOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/PluginService/Releases";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create PluginRelease parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PluginRelease </returns>
        public static PluginReleaseResource Create(CreatePluginReleaseOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create PluginRelease parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PluginRelease </returns>
        public static async System.Threading.Tasks.Task<PluginReleaseResource> CreateAsync(CreatePluginReleaseOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="configurationId"> The SID or the Version of the Flex Plugin Configuration to release. </param>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PluginRelease </returns>
        public static PluginReleaseResource Create(
                                          string configurationId,
                                          string flexMetadata = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreatePluginReleaseOptions(configurationId){  FlexMetadata = flexMetadata };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="configurationId"> The SID or the Version of the Flex Plugin Configuration to release. </param>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PluginRelease </returns>
        public static async System.Threading.Tasks.Task<PluginReleaseResource> CreateAsync(
                                                                                  string configurationId,
                                                                                  string flexMetadata = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreatePluginReleaseOptions(configurationId){  FlexMetadata = flexMetadata };
            return await CreateAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchPluginReleaseOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/PluginService/Releases/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch PluginRelease parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PluginRelease </returns>
        public static PluginReleaseResource Fetch(FetchPluginReleaseOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch PluginRelease parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PluginRelease </returns>
        public static async System.Threading.Tasks.Task<PluginReleaseResource> FetchAsync(FetchPluginReleaseOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The SID of the Flex Plugin Release resource to fetch. </param>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PluginRelease </returns>
        public static PluginReleaseResource Fetch(
                                         string pathSid, 
                                         string flexMetadata = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchPluginReleaseOptions(pathSid){ FlexMetadata = flexMetadata };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The SID of the Flex Plugin Release resource to fetch. </param>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PluginRelease </returns>
        public static async System.Threading.Tasks.Task<PluginReleaseResource> FetchAsync(string pathSid, string flexMetadata = null, ITwilioRestClient client = null)
        {
            var options = new FetchPluginReleaseOptions(pathSid){ FlexMetadata = flexMetadata };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadPluginReleaseOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/PluginService/Releases";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read PluginRelease parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PluginRelease </returns>
        public static ResourceSet<PluginReleaseResource> Read(ReadPluginReleaseOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<PluginReleaseResource>.FromJson("releases", response.Content);
            return new ResourceSet<PluginReleaseResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read PluginRelease parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PluginRelease </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<PluginReleaseResource>> ReadAsync(ReadPluginReleaseOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<PluginReleaseResource>.FromJson("releases", response.Content);
            return new ResourceSet<PluginReleaseResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PluginRelease </returns>
        public static ResourceSet<PluginReleaseResource> Read(
                                                     string flexMetadata = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadPluginReleaseOptions(){ FlexMetadata = flexMetadata, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PluginRelease </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<PluginReleaseResource>> ReadAsync(
                                                                                             string flexMetadata = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadPluginReleaseOptions(){ FlexMetadata = flexMetadata, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<PluginReleaseResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<PluginReleaseResource>.FromJson("releases", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<PluginReleaseResource> NextPage(Page<PluginReleaseResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<PluginReleaseResource>.FromJson("releases", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<PluginReleaseResource> PreviousPage(Page<PluginReleaseResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<PluginReleaseResource>.FromJson("releases", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a PluginReleaseResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PluginReleaseResource object represented by the provided JSON </returns>
        public static PluginReleaseResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<PluginReleaseResource>(json);
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

    
        ///<summary> The unique string that we created to identify the Plugin Release resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Plugin Release resource and owns this resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Plugin Configuration resource to release. </summary> 
        [JsonProperty("configuration_sid")]
        public string ConfigurationSid { get; private set; }

        ///<summary> The date and time in GMT when the Flex Plugin Release was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The absolute URL of the Plugin Release resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private PluginReleaseResource() {

        }
    }
}

