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



namespace Twilio.Rest.Api.V2010.Account.Sip.CredentialList
{
    public class CredentialResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateCredentialOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/CredentialLists/{CredentialListSid}/Credentials.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathCredentialListSid = options.PathCredentialListSid;
            path = path.Replace("{"+"CredentialListSid"+"}", PathCredentialListSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new credential resource. </summary>
        /// <param name="options"> Create Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Create(CreateCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new credential resource. </summary>
        /// <param name="options"> Create Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<CredentialResource> CreateAsync(CreateCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new credential resource. </summary>
        /// <param name="pathCredentialListSid"> The unique id that identifies the credential list to include the created credential. </param>
        /// <param name="username"> The username that will be passed when authenticating SIP requests. The username should be sent in response to Twilio's challenge of the initial INVITE. It can be up to 32 characters long. </param>
        /// <param name="password"> The password that the username will use when authenticating SIP requests. The password must be a minimum of 12 characters, contain at least 1 digit, and have mixed case. (eg `IWasAtSignal2018`) </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Create(
                                          string pathCredentialListSid,
                                          string username,
                                          string password,
                                          string pathAccountSid = null,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateCredentialOptions(pathCredentialListSid, username, password){  PathAccountSid = pathAccountSid };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new credential resource. </summary>
        /// <param name="pathCredentialListSid"> The unique id that identifies the credential list to include the created credential. </param>
        /// <param name="username"> The username that will be passed when authenticating SIP requests. The username should be sent in response to Twilio's challenge of the initial INVITE. It can be up to 32 characters long. </param>
        /// <param name="password"> The password that the username will use when authenticating SIP requests. The password must be a minimum of 12 characters, contain at least 1 digit, and have mixed case. (eg `IWasAtSignal2018`) </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<CredentialResource> CreateAsync(
                                                                                  string pathCredentialListSid,
                                                                                  string username,
                                                                                  string password,
                                                                                  string pathAccountSid = null,
                                                                                    ITwilioRestClient client = null)
        {
        var options = new CreateCredentialOptions(pathCredentialListSid, username, password){  PathAccountSid = pathAccountSid };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete a credential resource. </summary>
        /// <param name="options"> Delete Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        private static Request BuildDeleteRequest(DeleteCredentialOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/CredentialLists/{CredentialListSid}/Credentials/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathCredentialListSid = options.PathCredentialListSid;
            path = path.Replace("{"+"CredentialListSid"+"}", PathCredentialListSid);
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

        /// <summary> Delete a credential resource. </summary>
        /// <param name="options"> Delete Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static bool Delete(DeleteCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a credential resource. </summary>
        /// <param name="options"> Delete Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteCredentialOptions options,
                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a credential resource. </summary>
        /// <param name="pathCredentialListSid"> The unique id that identifies the credential list that contains the desired credentials. </param>
        /// <param name="pathSid"> The unique id that identifies the resource to delete. </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static bool Delete(string pathCredentialListSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteCredentialOptions(pathCredentialListSid, pathSid)         { PathAccountSid = pathAccountSid }   ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a credential resource. </summary>
        /// <param name="pathCredentialListSid"> The unique id that identifies the credential list that contains the desired credentials. </param>
        /// <param name="pathSid"> The unique id that identifies the resource to delete. </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathCredentialListSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteCredentialOptions(pathCredentialListSid, pathSid)  { PathAccountSid = pathAccountSid };
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchCredentialOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/CredentialLists/{CredentialListSid}/Credentials/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathCredentialListSid = options.PathCredentialListSid;
            path = path.Replace("{"+"CredentialListSid"+"}", PathCredentialListSid);
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

        /// <summary> Fetch a single credential. </summary>
        /// <param name="options"> Fetch Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Fetch(FetchCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a single credential. </summary>
        /// <param name="options"> Fetch Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<CredentialResource> FetchAsync(FetchCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a single credential. </summary>
        /// <param name="pathCredentialListSid"> The unique id that identifies the credential list that contains the desired credential. </param>
        /// <param name="pathSid"> The unique id that identifies the resource to fetch. </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Fetch(
                                         string pathCredentialListSid, 
                                         string pathSid, 
                                         string pathAccountSid = null, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchCredentialOptions(pathCredentialListSid, pathSid){ PathAccountSid = pathAccountSid };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a single credential. </summary>
        /// <param name="pathCredentialListSid"> The unique id that identifies the credential list that contains the desired credential. </param>
        /// <param name="pathSid"> The unique id that identifies the resource to fetch. </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<CredentialResource> FetchAsync(string pathCredentialListSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchCredentialOptions(pathCredentialListSid, pathSid){ PathAccountSid = pathAccountSid };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadCredentialOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/CredentialLists/{CredentialListSid}/Credentials.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathCredentialListSid = options.PathCredentialListSid;
            path = path.Replace("{"+"CredentialListSid"+"}", PathCredentialListSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of credentials. </summary>
        /// <param name="options"> Read Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static ResourceSet<CredentialResource> Read(ReadCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<CredentialResource>.FromJson("credentials", response.Content);
            return new ResourceSet<CredentialResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of credentials. </summary>
        /// <param name="options"> Read Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CredentialResource>> ReadAsync(ReadCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<CredentialResource>.FromJson("credentials", response.Content);
            return new ResourceSet<CredentialResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of credentials. </summary>
        /// <param name="pathCredentialListSid"> The unique id that identifies the credential list that contains the desired credentials. </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static ResourceSet<CredentialResource> Read(
                                                     string pathCredentialListSid,
                                                     string pathAccountSid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadCredentialOptions(pathCredentialListSid){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of credentials. </summary>
        /// <param name="pathCredentialListSid"> The unique id that identifies the credential list that contains the desired credentials. </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CredentialResource>> ReadAsync(
                                                                                             string pathCredentialListSid,
                                                                                             string pathAccountSid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadCredentialOptions(pathCredentialListSid){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<CredentialResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CredentialResource>.FromJson("credentials", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<CredentialResource> NextPage(Page<CredentialResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CredentialResource>.FromJson("credentials", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<CredentialResource> PreviousPage(Page<CredentialResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CredentialResource>.FromJson("credentials", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateCredentialOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SIP/CredentialLists/{CredentialListSid}/Credentials/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathCredentialListSid = options.PathCredentialListSid;
            path = path.Replace("{"+"CredentialListSid"+"}", PathCredentialListSid);
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

        /// <summary> Update a credential resource. </summary>
        /// <param name="options"> Update Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Update(UpdateCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update a credential resource. </summary>
        /// <param name="options"> Update Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<CredentialResource> UpdateAsync(UpdateCredentialOptions options,
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update a credential resource. </summary>
        /// <param name="pathCredentialListSid"> The unique id that identifies the credential list that includes this credential. </param>
        /// <param name="pathSid"> The unique id that identifies the resource to update. </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="password"> The password that the username will use when authenticating SIP requests. The password must be a minimum of 12 characters, contain at least 1 digit, and have mixed case. (eg `IWasAtSignal2018`) </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Update(
                                          string pathCredentialListSid,
                                          string pathSid,
                                          string pathAccountSid = null,
                                          string password = null,
                                            ITwilioRestClient client = null)
        {
            var options = new UpdateCredentialOptions(pathCredentialListSid, pathSid){ PathAccountSid = pathAccountSid, Password = password };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update a credential resource. </summary>
        /// <param name="pathCredentialListSid"> The unique id that identifies the credential list that includes this credential. </param>
        /// <param name="pathSid"> The unique id that identifies the resource to update. </param>
        /// <param name="pathAccountSid"> The unique id of the Account that is responsible for this resource. </param>
        /// <param name="password"> The password that the username will use when authenticating SIP requests. The password must be a minimum of 12 characters, contain at least 1 digit, and have mixed case. (eg `IWasAtSignal2018`) </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<CredentialResource> UpdateAsync(
                                                                              string pathCredentialListSid,
                                                                              string pathSid,
                                                                              string pathAccountSid = null,
                                                                              string password = null,
                                                                                ITwilioRestClient client = null)
        {
            var options = new UpdateCredentialOptions(pathCredentialListSid, pathSid){ PathAccountSid = pathAccountSid, Password = password };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a CredentialResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CredentialResource object represented by the provided JSON </returns>
        public static CredentialResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<CredentialResource>(json);
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

    
        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique id of the Account that is responsible for this resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique id that identifies the credential list that includes this credential. </summary> 
        [JsonProperty("credential_list_sid")]
        public string CredentialListSid { get; private set; }

        ///<summary> The username for this credential. </summary> 
        [JsonProperty("username")]
        public string Username { get; private set; }

        ///<summary> The date that this resource was created, given as GMT in [RFC 2822](https://www.php.net/manual/en/class.datetime.php#datetime.constants.rfc2822) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this resource was last updated, given as GMT in [RFC 2822](https://www.php.net/manual/en/class.datetime.php#datetime.constants.rfc2822) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The URI for this resource, relative to `https://api.twilio.com` </summary> 
        [JsonProperty("uri")]
        public string Uri { get; private set; }



        private CredentialResource() {

        }
    }
}

