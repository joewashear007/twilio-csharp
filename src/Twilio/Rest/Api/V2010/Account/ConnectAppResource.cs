/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
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


namespace Twilio.Rest.Api.V2010.Account
{
    public class ConnectAppResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class PermissionEnum : StringEnum
        {
            private PermissionEnum(string value) : base(value) {}
            public PermissionEnum() {}
            public static implicit operator PermissionEnum(string value)
            {
                return new PermissionEnum(value);
            }

            public static readonly PermissionEnum GetAll = new PermissionEnum("get-all");
            public static readonly PermissionEnum PostAll = new PermissionEnum("post-all");
        }

        
        /// <summary> Delete an instance of a connect-app </summary>
        /// <param name="options"> Delete ConnectApp parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConnectApp </returns>
        private static Request BuildDeleteRequest(DeleteConnectAppOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/ConnectApps/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete an instance of a connect-app </summary>
        /// <param name="options"> Delete ConnectApp parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConnectApp </returns>
        public static bool Delete(DeleteConnectAppOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete an instance of a connect-app </summary>
        /// <param name="options"> Delete ConnectApp parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConnectApp </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteConnectAppOptions options,
                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete an instance of a connect-app </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the ConnectApp resource to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the ConnectApp resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConnectApp </returns>
        public static bool Delete(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteConnectAppOptions(pathSid)      { PathAccountSid = pathAccountSid }   ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete an instance of a connect-app </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the ConnectApp resource to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the ConnectApp resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConnectApp </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteConnectAppOptions(pathSid)  { PathAccountSid = pathAccountSid };
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchConnectAppOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/ConnectApps/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch an instance of a connect-app </summary>
        /// <param name="options"> Fetch ConnectApp parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConnectApp </returns>
        public static ConnectAppResource Fetch(FetchConnectAppOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch an instance of a connect-app </summary>
        /// <param name="options"> Fetch ConnectApp parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConnectApp </returns>
        public static async System.Threading.Tasks.Task<ConnectAppResource> FetchAsync(FetchConnectAppOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch an instance of a connect-app </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the ConnectApp resource to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the ConnectApp resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConnectApp </returns>
        public static ConnectAppResource Fetch(
                                         string pathSid, 
                                         string pathAccountSid = null, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchConnectAppOptions(pathSid){ PathAccountSid = pathAccountSid };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch an instance of a connect-app </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the ConnectApp resource to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the ConnectApp resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConnectApp </returns>
        public static async System.Threading.Tasks.Task<ConnectAppResource> FetchAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchConnectAppOptions(pathSid){ PathAccountSid = pathAccountSid };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadConnectAppOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/ConnectApps.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of connect-apps belonging to the account used to make the request </summary>
        /// <param name="options"> Read ConnectApp parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConnectApp </returns>
        public static ResourceSet<ConnectAppResource> Read(ReadConnectAppOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<ConnectAppResource>.FromJson("connect_apps", response.Content);
            return new ResourceSet<ConnectAppResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of connect-apps belonging to the account used to make the request </summary>
        /// <param name="options"> Read ConnectApp parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConnectApp </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ConnectAppResource>> ReadAsync(ReadConnectAppOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ConnectAppResource>.FromJson("connect_apps", response.Content);
            return new ResourceSet<ConnectAppResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of connect-apps belonging to the account used to make the request </summary>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the ConnectApp resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConnectApp </returns>
        public static ResourceSet<ConnectAppResource> Read(
                                                     string pathAccountSid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadConnectAppOptions(){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of connect-apps belonging to the account used to make the request </summary>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the ConnectApp resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConnectApp </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ConnectAppResource>> ReadAsync(
                                                                                             string pathAccountSid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadConnectAppOptions(){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<ConnectAppResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ConnectAppResource>.FromJson("connect_apps", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<ConnectAppResource> NextPage(Page<ConnectAppResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ConnectAppResource>.FromJson("connect_apps", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<ConnectAppResource> PreviousPage(Page<ConnectAppResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ConnectAppResource>.FromJson("connect_apps", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateConnectAppOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/ConnectApps/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update a connect-app with the specified parameters </summary>
        /// <param name="options"> Update ConnectApp parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConnectApp </returns>
        public static ConnectAppResource Update(UpdateConnectAppOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update a connect-app with the specified parameters </summary>
        /// <param name="options"> Update ConnectApp parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConnectApp </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<ConnectAppResource> UpdateAsync(UpdateConnectAppOptions options,
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update a connect-app with the specified parameters </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the ConnectApp resource to update. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the ConnectApp resources to update. </param>
        /// <param name="authorizeRedirectUrl"> The URL to redirect the user to after we authenticate the user and obtain authorization to access the Connect App. </param>
        /// <param name="companyName"> The company name to set for the Connect App. </param>
        /// <param name="deauthorizeCallbackMethod"> The HTTP method to use when calling `deauthorize_callback_url`. </param>
        /// <param name="deauthorizeCallbackUrl"> The URL to call using the `deauthorize_callback_method` to de-authorize the Connect App. </param>
        /// <param name="description"> A description of the Connect App. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </param>
        /// <param name="homepageUrl"> A public URL where users can obtain more information about this Connect App. </param>
        /// <param name="permissions"> A comma-separated list of the permissions you will request from the users of this ConnectApp.  Can include: `get-all` and `post-all`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConnectApp </returns>
        public static ConnectAppResource Update(
                                          string pathSid,
                                          string pathAccountSid = null,
                                          Uri authorizeRedirectUrl = null,
                                          string companyName = null,
                                          Twilio.Http.HttpMethod deauthorizeCallbackMethod = null,
                                          Uri deauthorizeCallbackUrl = null,
                                          string description = null,
                                          string friendlyName = null,
                                          Uri homepageUrl = null,
                                          List<ConnectAppResource.PermissionEnum> permissions = null,
                                            ITwilioRestClient client = null)
        {
            var options = new UpdateConnectAppOptions(pathSid){ PathAccountSid = pathAccountSid, AuthorizeRedirectUrl = authorizeRedirectUrl, CompanyName = companyName, DeauthorizeCallbackMethod = deauthorizeCallbackMethod, DeauthorizeCallbackUrl = deauthorizeCallbackUrl, Description = description, FriendlyName = friendlyName, HomepageUrl = homepageUrl, Permissions = permissions };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update a connect-app with the specified parameters </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the ConnectApp resource to update. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the ConnectApp resources to update. </param>
        /// <param name="authorizeRedirectUrl"> The URL to redirect the user to after we authenticate the user and obtain authorization to access the Connect App. </param>
        /// <param name="companyName"> The company name to set for the Connect App. </param>
        /// <param name="deauthorizeCallbackMethod"> The HTTP method to use when calling `deauthorize_callback_url`. </param>
        /// <param name="deauthorizeCallbackUrl"> The URL to call using the `deauthorize_callback_method` to de-authorize the Connect App. </param>
        /// <param name="description"> A description of the Connect App. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </param>
        /// <param name="homepageUrl"> A public URL where users can obtain more information about this Connect App. </param>
        /// <param name="permissions"> A comma-separated list of the permissions you will request from the users of this ConnectApp.  Can include: `get-all` and `post-all`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConnectApp </returns>
        public static async System.Threading.Tasks.Task<ConnectAppResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string pathAccountSid = null,
                                                                              Uri authorizeRedirectUrl = null,
                                                                              string companyName = null,
                                                                              Twilio.Http.HttpMethod deauthorizeCallbackMethod = null,
                                                                              Uri deauthorizeCallbackUrl = null,
                                                                              string description = null,
                                                                              string friendlyName = null,
                                                                              Uri homepageUrl = null,
                                                                              List<ConnectAppResource.PermissionEnum> permissions = null,
                                                                                ITwilioRestClient client = null)
        {
            var options = new UpdateConnectAppOptions(pathSid){ PathAccountSid = pathAccountSid, AuthorizeRedirectUrl = authorizeRedirectUrl, CompanyName = companyName, DeauthorizeCallbackMethod = deauthorizeCallbackMethod, DeauthorizeCallbackUrl = deauthorizeCallbackUrl, Description = description, FriendlyName = friendlyName, HomepageUrl = homepageUrl, Permissions = permissions };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a ConnectAppResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ConnectAppResource object represented by the provided JSON </returns>
        public static ConnectAppResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ConnectAppResource>(json);
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

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the ConnectApp resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The URL we redirect the user to after we authenticate the user and obtain authorization to access the Connect App. </summary> 
        [JsonProperty("authorize_redirect_url")]
        public Uri AuthorizeRedirectUrl { get; private set; }

        ///<summary> The company name set for the Connect App. </summary> 
        [JsonProperty("company_name")]
        public string CompanyName { get; private set; }

        ///<summary> The HTTP method we use to call `deauthorize_callback_url`. </summary> 
        [JsonProperty("deauthorize_callback_method")]
        public Twilio.Http.HttpMethod DeauthorizeCallbackMethod { get; private set; }

        ///<summary> The URL we call using the `deauthorize_callback_method` to de-authorize the Connect App. </summary> 
        [JsonProperty("deauthorize_callback_url")]
        public Uri DeauthorizeCallbackUrl { get; private set; }

        ///<summary> The description of the Connect App. </summary> 
        [JsonProperty("description")]
        public string Description { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The public URL where users can obtain more information about this Connect App. </summary> 
        [JsonProperty("homepage_url")]
        public Uri HomepageUrl { get; private set; }

        ///<summary> The set of permissions that your ConnectApp requests. </summary> 
        [JsonProperty("permissions")]
        public List<ConnectAppResource.PermissionEnum> Permissions { get; private set; }

        ///<summary> The unique string that that we created to identify the ConnectApp resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The URI of the resource, relative to `https://api.twilio.com`. </summary> 
        [JsonProperty("uri")]
        public string Uri { get; private set; }



        private ConnectAppResource() {

        }
    }
}

