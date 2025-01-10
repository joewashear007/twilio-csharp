/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Ip_messaging
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


namespace Twilio.Rest.IpMessaging.V2.Service.User
{
    public class UserBindingResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class BindingTypeEnum : StringEnum
        {
            private BindingTypeEnum(string value) : base(value) {}
            public BindingTypeEnum() {}
            public static implicit operator BindingTypeEnum(string value)
            {
                return new BindingTypeEnum(value);
            }
            public static readonly BindingTypeEnum Gcm = new BindingTypeEnum("gcm");
            public static readonly BindingTypeEnum Apn = new BindingTypeEnum("apn");
            public static readonly BindingTypeEnum Fcm = new BindingTypeEnum("fcm");

        }

        
        /// <summary> delete </summary>
        /// <param name="options"> Delete UserBinding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserBinding </returns>
        private static Request BuildDeleteRequest(DeleteUserBindingOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Users/{UserSid}/Bindings/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathUserSid = options.PathUserSid;
            path = path.Replace("{"+"UserSid"+"}", PathUserSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.IpMessaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete UserBinding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserBinding </returns>
        public static bool Delete(DeleteUserBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete UserBinding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserBinding </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteUserBindingOptions options, 
                                                                        ITwilioRestClient client = null,
                                                                        CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client), cancellationToken);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathUserSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserBinding </returns>
        public static bool Delete(string pathServiceSid, string pathUserSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteUserBindingOptions(pathServiceSid, pathUserSid, pathSid)           ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathUserSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserBinding </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathUserSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteUserBindingOptions(pathServiceSid, pathUserSid, pathSid) ;
            return await DeleteAsync(options, client, cancellationToken);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchUserBindingOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Users/{UserSid}/Bindings/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathUserSid = options.PathUserSid;
            path = path.Replace("{"+"UserSid"+"}", PathUserSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch UserBinding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserBinding </returns>
        public static UserBindingResource Fetch(FetchUserBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch UserBinding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserBinding </returns>
        public static async System.Threading.Tasks.Task<UserBindingResource> FetchAsync(FetchUserBindingOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathUserSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserBinding </returns>
        public static UserBindingResource Fetch(
                                         string pathServiceSid, 
                                         string pathUserSid, 
                                         string pathSid, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchUserBindingOptions(pathServiceSid, pathUserSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathUserSid">  </param>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserBinding </returns>
        public static async System.Threading.Tasks.Task<UserBindingResource> FetchAsync(string pathServiceSid, string pathUserSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchUserBindingOptions(pathServiceSid, pathUserSid, pathSid){  };
            return await FetchAsync(options, client, cancellationToken);
        }
        #endif
        
        private static Request BuildReadRequest(ReadUserBindingOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Users/{UserSid}/Bindings";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathUserSid = options.PathUserSid;
            path = path.Replace("{"+"UserSid"+"}", PathUserSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read UserBinding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserBinding </returns>
        public static ResourceSet<UserBindingResource> Read(ReadUserBindingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<UserBindingResource>.FromJson("bindings", response.Content);
            return new ResourceSet<UserBindingResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read UserBinding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserBinding </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<UserBindingResource>> ReadAsync(ReadUserBindingOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client), cancellationToken);

            var page = Page<UserBindingResource>.FromJson("bindings", response.Content);
            return new ResourceSet<UserBindingResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathUserSid">  </param>
        /// <param name="bindingType">  </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserBinding </returns>
        public static ResourceSet<UserBindingResource> Read(
                                                     string pathServiceSid,
                                                     string pathUserSid,
                                                     List<UserBindingResource.BindingTypeEnum> bindingType = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadUserBindingOptions(pathServiceSid, pathUserSid){ BindingType = bindingType, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathUserSid">  </param>
        /// <param name="bindingType">  </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserBinding </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<UserBindingResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             string pathUserSid,
                                                                                             List<UserBindingResource.BindingTypeEnum> bindingType = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadUserBindingOptions(pathServiceSid, pathUserSid){ BindingType = bindingType, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client, cancellationToken);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<UserBindingResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<UserBindingResource>.FromJson("bindings", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<UserBindingResource> NextPage(Page<UserBindingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<UserBindingResource>.FromJson("bindings", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<UserBindingResource> PreviousPage(Page<UserBindingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<UserBindingResource>.FromJson("bindings", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a UserBindingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> UserBindingResource object represented by the provided JSON </returns>
        public static UserBindingResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<UserBindingResource>(json);
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

    
        ///<summary> The sid </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The account_sid </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The service_sid </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The date_created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date_updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The endpoint </summary> 
        [JsonProperty("endpoint")]
        public string Endpoint { get; private set; }

        ///<summary> The identity </summary> 
        [JsonProperty("identity")]
        public string Identity { get; private set; }

        ///<summary> The user_sid </summary> 
        [JsonProperty("user_sid")]
        public string UserSid { get; private set; }

        ///<summary> The credential_sid </summary> 
        [JsonProperty("credential_sid")]
        public string CredentialSid { get; private set; }

        
        [JsonProperty("binding_type")]
        public UserBindingResource.BindingTypeEnum BindingType { get; private set; }

        ///<summary> The message_types </summary> 
        [JsonProperty("message_types")]
        public List<string> MessageTypes { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private UserBindingResource() {

        }
    }
}

