/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Proxy
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
using Twilio.Types;


namespace Twilio.Rest.Proxy.V1
{
    public class ServiceResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class GeoMatchLevelEnum : StringEnum
        {
            private GeoMatchLevelEnum(string value) : base(value) {}
            public GeoMatchLevelEnum() {}
            public static implicit operator GeoMatchLevelEnum(string value)
            {
                return new GeoMatchLevelEnum(value);
            }
            public static readonly GeoMatchLevelEnum AreaCode = new GeoMatchLevelEnum("area-code");
            public static readonly GeoMatchLevelEnum Overlay = new GeoMatchLevelEnum("overlay");
            public static readonly GeoMatchLevelEnum Radius = new GeoMatchLevelEnum("radius");
            public static readonly GeoMatchLevelEnum Country = new GeoMatchLevelEnum("country");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class NumberSelectionBehaviorEnum : StringEnum
        {
            private NumberSelectionBehaviorEnum(string value) : base(value) {}
            public NumberSelectionBehaviorEnum() {}
            public static implicit operator NumberSelectionBehaviorEnum(string value)
            {
                return new NumberSelectionBehaviorEnum(value);
            }
            public static readonly NumberSelectionBehaviorEnum AvoidSticky = new NumberSelectionBehaviorEnum("avoid-sticky");
            public static readonly NumberSelectionBehaviorEnum PreferSticky = new NumberSelectionBehaviorEnum("prefer-sticky");

        }

        
        private static Request BuildCreateRequest(CreateServiceOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Proxy,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Service for Twilio Proxy </summary>
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Create(CreateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Service for Twilio Proxy </summary>
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(CreateServiceOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Service for Twilio Proxy </summary>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. This value must be 191 characters or fewer in length and be unique. **This value should not have PII.** </param>
        /// <param name="defaultTtl"> The default `ttl` value to set for Sessions created in the Service. The TTL (time to live) is measured in seconds after the Session's last create or last Interaction. The default value of `0` indicates an unlimited Session length. You can override a Session's default TTL value by setting its `ttl` value. </param>
        /// <param name="callbackUrl"> The URL we should call when the interaction status changes. </param>
        /// <param name="geoMatchLevel">  </param>
        /// <param name="numberSelectionBehavior">  </param>
        /// <param name="interceptCallbackUrl"> The URL we call on each interaction. If we receive a 403 status, we block the interaction; otherwise the interaction continues. </param>
        /// <param name="outOfSessionCallbackUrl"> The URL we should call when an inbound call or SMS action occurs on a closed or non-existent Session. If your server (or a Twilio [function](https://www.twilio.com/en-us/serverless/functions)) responds with valid [TwiML](https://www.twilio.com/docs/voice/twiml), we will process it. This means it is possible, for example, to play a message for a call, send an automated text message response, or redirect a call to another Phone Number. See [Out-of-Session Callback Response Guide](https://www.twilio.com/docs/proxy/out-session-callback-response-guide) for more information. </param>
        /// <param name="chatInstanceSid"> The SID of the Chat Service Instance managed by Proxy Service. The Chat Service enables Proxy to forward SMS and channel messages to this chat instance. This is a one-to-one relationship. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Create(
                                          string uniqueName,
                                          int? defaultTtl = null,
                                          Uri callbackUrl = null,
                                          ServiceResource.GeoMatchLevelEnum geoMatchLevel = null,
                                          ServiceResource.NumberSelectionBehaviorEnum numberSelectionBehavior = null,
                                          Uri interceptCallbackUrl = null,
                                          Uri outOfSessionCallbackUrl = null,
                                          string chatInstanceSid = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateServiceOptions(uniqueName){  DefaultTtl = defaultTtl, CallbackUrl = callbackUrl, GeoMatchLevel = geoMatchLevel, NumberSelectionBehavior = numberSelectionBehavior, InterceptCallbackUrl = interceptCallbackUrl, OutOfSessionCallbackUrl = outOfSessionCallbackUrl, ChatInstanceSid = chatInstanceSid };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Service for Twilio Proxy </summary>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. This value must be 191 characters or fewer in length and be unique. **This value should not have PII.** </param>
        /// <param name="defaultTtl"> The default `ttl` value to set for Sessions created in the Service. The TTL (time to live) is measured in seconds after the Session's last create or last Interaction. The default value of `0` indicates an unlimited Session length. You can override a Session's default TTL value by setting its `ttl` value. </param>
        /// <param name="callbackUrl"> The URL we should call when the interaction status changes. </param>
        /// <param name="geoMatchLevel">  </param>
        /// <param name="numberSelectionBehavior">  </param>
        /// <param name="interceptCallbackUrl"> The URL we call on each interaction. If we receive a 403 status, we block the interaction; otherwise the interaction continues. </param>
        /// <param name="outOfSessionCallbackUrl"> The URL we should call when an inbound call or SMS action occurs on a closed or non-existent Session. If your server (or a Twilio [function](https://www.twilio.com/en-us/serverless/functions)) responds with valid [TwiML](https://www.twilio.com/docs/voice/twiml), we will process it. This means it is possible, for example, to play a message for a call, send an automated text message response, or redirect a call to another Phone Number. See [Out-of-Session Callback Response Guide](https://www.twilio.com/docs/proxy/out-session-callback-response-guide) for more information. </param>
        /// <param name="chatInstanceSid"> The SID of the Chat Service Instance managed by Proxy Service. The Chat Service enables Proxy to forward SMS and channel messages to this chat instance. This is a one-to-one relationship. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(
                                                                                  string uniqueName,
                                                                                  int? defaultTtl = null,
                                                                                  Uri callbackUrl = null,
                                                                                  ServiceResource.GeoMatchLevelEnum geoMatchLevel = null,
                                                                                  ServiceResource.NumberSelectionBehaviorEnum numberSelectionBehavior = null,
                                                                                  Uri interceptCallbackUrl = null,
                                                                                  Uri outOfSessionCallbackUrl = null,
                                                                                  string chatInstanceSid = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateServiceOptions(uniqueName){  DefaultTtl = defaultTtl, CallbackUrl = callbackUrl, GeoMatchLevel = geoMatchLevel, NumberSelectionBehavior = numberSelectionBehavior, InterceptCallbackUrl = interceptCallbackUrl, OutOfSessionCallbackUrl = outOfSessionCallbackUrl, ChatInstanceSid = chatInstanceSid };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete a specific Service. </summary>
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        private static Request BuildDeleteRequest(DeleteServiceOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Proxy,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific Service. </summary>
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static bool Delete(DeleteServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a specific Service. </summary>
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteServiceOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a specific Service. </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Service resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteServiceOptions(pathSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a specific Service. </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Service resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteServiceOptions(pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchServiceOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Proxy,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific Service. </summary>
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Fetch(FetchServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific Service. </summary>
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(FetchServiceOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific Service. </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Service resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchServiceOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific Service. </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Service resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchServiceOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadServiceOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Proxy,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Services for Twilio Proxy. A maximum of 100 records will be returned per page. </summary>
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ResourceSet<ServiceResource> Read(ReadServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Services for Twilio Proxy. A maximum of 100 records will be returned per page. </summary>
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ServiceResource>> ReadAsync(ReadServiceOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Services for Twilio Proxy. A maximum of 100 records will be returned per page. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ResourceSet<ServiceResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadServiceOptions(){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Services for Twilio Proxy. A maximum of 100 records will be returned per page. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ServiceResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadServiceOptions(){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<ServiceResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<ServiceResource> NextPage(Page<ServiceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<ServiceResource> PreviousPage(Page<ServiceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateServiceOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Proxy,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update a specific Service. </summary>
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Update(UpdateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update a specific Service. </summary>
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(UpdateServiceOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update a specific Service. </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Service resource to update. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. This value must be 191 characters or fewer in length and be unique. **This value should not have PII.** </param>
        /// <param name="defaultTtl"> The default `ttl` value to set for Sessions created in the Service. The TTL (time to live) is measured in seconds after the Session's last create or last Interaction. The default value of `0` indicates an unlimited Session length. You can override a Session's default TTL value by setting its `ttl` value. </param>
        /// <param name="callbackUrl"> The URL we should call when the interaction status changes. </param>
        /// <param name="geoMatchLevel">  </param>
        /// <param name="numberSelectionBehavior">  </param>
        /// <param name="interceptCallbackUrl"> The URL we call on each interaction. If we receive a 403 status, we block the interaction; otherwise the interaction continues. </param>
        /// <param name="outOfSessionCallbackUrl"> The URL we should call when an inbound call or SMS action occurs on a closed or non-existent Session. If your server (or a Twilio [function](https://www.twilio.com/en-us/serverless/functions)) responds with valid [TwiML](https://www.twilio.com/docs/voice/twiml), we will process it. This means it is possible, for example, to play a message for a call, send an automated text message response, or redirect a call to another Phone Number. See [Out-of-Session Callback Response Guide](https://www.twilio.com/docs/proxy/out-session-callback-response-guide) for more information. </param>
        /// <param name="chatInstanceSid"> The SID of the Chat Service Instance managed by Proxy Service. The Chat Service enables Proxy to forward SMS and channel messages to this chat instance. This is a one-to-one relationship. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Update(
                                          string pathSid,
                                          string uniqueName = null,
                                          int? defaultTtl = null,
                                          Uri callbackUrl = null,
                                          ServiceResource.GeoMatchLevelEnum geoMatchLevel = null,
                                          ServiceResource.NumberSelectionBehaviorEnum numberSelectionBehavior = null,
                                          Uri interceptCallbackUrl = null,
                                          Uri outOfSessionCallbackUrl = null,
                                          string chatInstanceSid = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid){ UniqueName = uniqueName, DefaultTtl = defaultTtl, CallbackUrl = callbackUrl, GeoMatchLevel = geoMatchLevel, NumberSelectionBehavior = numberSelectionBehavior, InterceptCallbackUrl = interceptCallbackUrl, OutOfSessionCallbackUrl = outOfSessionCallbackUrl, ChatInstanceSid = chatInstanceSid };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update a specific Service. </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Service resource to update. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. This value must be 191 characters or fewer in length and be unique. **This value should not have PII.** </param>
        /// <param name="defaultTtl"> The default `ttl` value to set for Sessions created in the Service. The TTL (time to live) is measured in seconds after the Session's last create or last Interaction. The default value of `0` indicates an unlimited Session length. You can override a Session's default TTL value by setting its `ttl` value. </param>
        /// <param name="callbackUrl"> The URL we should call when the interaction status changes. </param>
        /// <param name="geoMatchLevel">  </param>
        /// <param name="numberSelectionBehavior">  </param>
        /// <param name="interceptCallbackUrl"> The URL we call on each interaction. If we receive a 403 status, we block the interaction; otherwise the interaction continues. </param>
        /// <param name="outOfSessionCallbackUrl"> The URL we should call when an inbound call or SMS action occurs on a closed or non-existent Session. If your server (or a Twilio [function](https://www.twilio.com/en-us/serverless/functions)) responds with valid [TwiML](https://www.twilio.com/docs/voice/twiml), we will process it. This means it is possible, for example, to play a message for a call, send an automated text message response, or redirect a call to another Phone Number. See [Out-of-Session Callback Response Guide](https://www.twilio.com/docs/proxy/out-session-callback-response-guide) for more information. </param>
        /// <param name="chatInstanceSid"> The SID of the Chat Service Instance managed by Proxy Service. The Chat Service enables Proxy to forward SMS and channel messages to this chat instance. This is a one-to-one relationship. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string uniqueName = null,
                                                                              int? defaultTtl = null,
                                                                              Uri callbackUrl = null,
                                                                              ServiceResource.GeoMatchLevelEnum geoMatchLevel = null,
                                                                              ServiceResource.NumberSelectionBehaviorEnum numberSelectionBehavior = null,
                                                                              Uri interceptCallbackUrl = null,
                                                                              Uri outOfSessionCallbackUrl = null,
                                                                              string chatInstanceSid = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid){ UniqueName = uniqueName, DefaultTtl = defaultTtl, CallbackUrl = callbackUrl, GeoMatchLevel = geoMatchLevel, NumberSelectionBehavior = numberSelectionBehavior, InterceptCallbackUrl = interceptCallbackUrl, OutOfSessionCallbackUrl = outOfSessionCallbackUrl, ChatInstanceSid = chatInstanceSid };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a ServiceResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ServiceResource object represented by the provided JSON </returns>
        public static ServiceResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ServiceResource>(json);
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

    
        ///<summary> The unique string that we created to identify the Service resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> An application-defined string that uniquely identifies the resource. This value must be 191 characters or fewer in length and be unique. Supports UTF-8 characters. **This value should not have PII.** </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Service resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Chat Service Instance managed by Proxy Service. The Chat Service enables Proxy to forward SMS and channel messages to this chat instance. This is a one-to-one relationship. </summary> 
        [JsonProperty("chat_instance_sid")]
        public string ChatInstanceSid { get; private set; }

        ///<summary> The URL we call when the interaction status changes. </summary> 
        [JsonProperty("callback_url")]
        public Uri CallbackUrl { get; private set; }

        ///<summary> The default `ttl` value for Sessions created in the Service. The TTL (time to live) is measured in seconds after the Session's last create or last Interaction. The default value of `0` indicates an unlimited Session length. You can override a Session's default TTL value by setting its `ttl` value. </summary> 
        [JsonProperty("default_ttl")]
        public int? DefaultTtl { get; private set; }

        
        [JsonProperty("number_selection_behavior")]
        public ServiceResource.NumberSelectionBehaviorEnum NumberSelectionBehavior { get; private set; }

        
        [JsonProperty("geo_match_level")]
        public ServiceResource.GeoMatchLevelEnum GeoMatchLevel { get; private set; }

        ///<summary> The URL we call on each interaction. If we receive a 403 status, we block the interaction; otherwise the interaction continues. </summary> 
        [JsonProperty("intercept_callback_url")]
        public Uri InterceptCallbackUrl { get; private set; }

        ///<summary> The URL we call when an inbound call or SMS action occurs on a closed or non-existent Session. If your server (or a Twilio [function](https://www.twilio.com/en-us/serverless/functions)) responds with valid [TwiML](https://www.twilio.com/docs/voice/twiml), we will process it. This means it is possible, for example, to play a message for a call, send an automated text message response, or redirect a call to another Phone Number. See [Out-of-Session Callback Response Guide](https://www.twilio.com/docs/proxy/out-session-callback-response-guide) for more information. </summary> 
        [JsonProperty("out_of_session_callback_url")]
        public Uri OutOfSessionCallbackUrl { get; private set; }

        ///<summary> The [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date and time in GMT when the resource was created. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date and time in GMT when the resource was last updated. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the Service resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The URLs of resources related to the Service. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private ServiceResource() {

        }
    }
}

