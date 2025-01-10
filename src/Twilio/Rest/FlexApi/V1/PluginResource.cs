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
    public class PluginResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreatePluginOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/PluginService/Plugins";


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
        /// <param name="options"> Create Plugin parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Plugin </returns>
        public static PluginResource Create(CreatePluginOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Plugin parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Plugin </returns>
        public static async System.Threading.Tasks.Task<PluginResource> CreateAsync(CreatePluginOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="uniqueName"> The Flex Plugin's unique name. </param>
        /// <param name="friendlyName"> The Flex Plugin's friendly name. </param>
        /// <param name="description"> A descriptive string that you create to describe the plugin resource. It can be up to 500 characters long </param>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Plugin </returns>
        public static PluginResource Create(
                                          string uniqueName,
                                          string friendlyName = null,
                                          string description = null,
                                          string flexMetadata = null,
                                            ITwilioRestClient client = null)
        {
            var options = new CreatePluginOptions(uniqueName){  FriendlyName = friendlyName, Description = description, FlexMetadata = flexMetadata };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="uniqueName"> The Flex Plugin's unique name. </param>
        /// <param name="friendlyName"> The Flex Plugin's friendly name. </param>
        /// <param name="description"> A descriptive string that you create to describe the plugin resource. It can be up to 500 characters long </param>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Plugin </returns>
        public static async System.Threading.Tasks.Task<PluginResource> CreateAsync(
                                                                                  string uniqueName,
                                                                                  string friendlyName = null,
                                                                                  string description = null,
                                                                                  string flexMetadata = null,
                                                                                    ITwilioRestClient client = null)
        {
        var options = new CreatePluginOptions(uniqueName){  FriendlyName = friendlyName, Description = description, FlexMetadata = flexMetadata };
            return await CreateAsync(options, client, cancellationToken);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchPluginOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/PluginService/Plugins/{Sid}";

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
        /// <param name="options"> Fetch Plugin parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Plugin </returns>
        public static PluginResource Fetch(FetchPluginOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Plugin parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Plugin </returns>
        public static async System.Threading.Tasks.Task<PluginResource> FetchAsync(FetchPluginOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The SID of the Flex Plugin resource to fetch. </param>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Plugin </returns>
        public static PluginResource Fetch(
                                         string pathSid, 
                                         string flexMetadata = null, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchPluginOptions(pathSid){ FlexMetadata = flexMetadata };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The SID of the Flex Plugin resource to fetch. </param>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Plugin </returns>
        public static async System.Threading.Tasks.Task<PluginResource> FetchAsync(string pathSid, string flexMetadata = null, ITwilioRestClient client = null)
        {
            var options = new FetchPluginOptions(pathSid){ FlexMetadata = flexMetadata };
            return await FetchAsync(options, client, cancellationToken);
        }
        #endif
        
        private static Request BuildReadRequest(ReadPluginOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/PluginService/Plugins";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Plugin parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Plugin </returns>
        public static ResourceSet<PluginResource> Read(ReadPluginOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<PluginResource>.FromJson("plugins", response.Content);
            return new ResourceSet<PluginResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Plugin parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Plugin </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<PluginResource>> ReadAsync(ReadPluginOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client), cancellationToken);

            var page = Page<PluginResource>.FromJson("plugins", response.Content);
            return new ResourceSet<PluginResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Plugin </returns>
        public static ResourceSet<PluginResource> Read(
                                                     string flexMetadata = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadPluginOptions(){ FlexMetadata = flexMetadata, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Plugin </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<PluginResource>> ReadAsync(
                                                                                             string flexMetadata = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadPluginOptions(){ FlexMetadata = flexMetadata, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client, cancellationToken);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<PluginResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<PluginResource>.FromJson("plugins", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<PluginResource> NextPage(Page<PluginResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<PluginResource>.FromJson("plugins", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<PluginResource> PreviousPage(Page<PluginResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<PluginResource>.FromJson("plugins", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdatePluginOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/PluginService/Plugins/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Plugin parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Plugin </returns>
        public static PluginResource Update(UpdatePluginOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Plugin parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Plugin </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<PluginResource> UpdateAsync(UpdatePluginOptions options, 
                                                                                                    ITwilioRestClient client = null,
                                                                                                    CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathSid"> The SID of the Flex Plugin resource to update. </param>
        /// <param name="friendlyName"> The Flex Plugin's friendly name. </param>
        /// <param name="description"> A descriptive string that you update to describe the plugin resource. It can be up to 500 characters long </param>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Plugin </returns>
        public static PluginResource Update(
                                          string pathSid,
                                          string friendlyName = null,
                                          string description = null,
                                          string flexMetadata = null,
                                            ITwilioRestClient client = null)
        {
            var options = new UpdatePluginOptions(pathSid){ FriendlyName = friendlyName, Description = description, FlexMetadata = flexMetadata };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathSid"> The SID of the Flex Plugin resource to update. </param>
        /// <param name="friendlyName"> The Flex Plugin's friendly name. </param>
        /// <param name="description"> A descriptive string that you update to describe the plugin resource. It can be up to 500 characters long </param>
        /// <param name="flexMetadata"> The Flex-Metadata HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Plugin </returns>
        public static async System.Threading.Tasks.Task<PluginResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string friendlyName = null,
                                                                              string description = null,
                                                                              string flexMetadata = null,
                                                                                ITwilioRestClient client = null)
        {
            var options = new UpdatePluginOptions(pathSid){ FriendlyName = friendlyName, Description = description, FlexMetadata = flexMetadata };
            return await UpdateAsync(options, client, cancellationToken);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a PluginResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PluginResource object represented by the provided JSON </returns>
        public static PluginResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<PluginResource>(json);
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

    
        ///<summary> The unique string that we created to identify the Flex Plugin resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Flex Plugin resource and owns this resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The name that uniquely identifies this Flex Plugin resource. </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> The friendly name this Flex Plugin resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> A descriptive string that you create to describe the plugin resource. It can be up to 500 characters long </summary> 
        [JsonProperty("description")]
        public string Description { get; private set; }

        ///<summary> Whether the Flex Plugin is archived. The default value is false. </summary> 
        [JsonProperty("archived")]
        public bool? Archived { get; private set; }

        ///<summary> The date and time in GMT-7 when the Flex Plugin was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT-7 when the Flex Plugin was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the Flex Plugin resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The links </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private PluginResource() {

        }
    }
}

