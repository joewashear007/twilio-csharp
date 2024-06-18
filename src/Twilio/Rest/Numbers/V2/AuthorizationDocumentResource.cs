/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Numbers
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


namespace Twilio.Rest.Numbers.V2
{
    public class AuthorizationDocumentResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum Opened = new StatusEnum("opened");
            public static readonly StatusEnum Signing = new StatusEnum("signing");
            public static readonly StatusEnum Signed = new StatusEnum("signed");
            public static readonly StatusEnum Canceled = new StatusEnum("canceled");
            public static readonly StatusEnum Failed = new StatusEnum("failed");

        }

        
        private static Request BuildCreateRequest(CreateAuthorizationDocumentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/HostedNumber/AuthorizationDocuments";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Numbers,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create an AuthorizationDocument for authorizing the hosting of phone number capabilities on Twilio's platform. </summary>
        /// <param name="options"> Create AuthorizationDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthorizationDocument </returns>
        public static AuthorizationDocumentResource Create(CreateAuthorizationDocumentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create an AuthorizationDocument for authorizing the hosting of phone number capabilities on Twilio's platform. </summary>
        /// <param name="options"> Create AuthorizationDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthorizationDocument </returns>
        public static async System.Threading.Tasks.Task<AuthorizationDocumentResource> CreateAsync(CreateAuthorizationDocumentOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create an AuthorizationDocument for authorizing the hosting of phone number capabilities on Twilio's platform. </summary>
        /// <param name="addressSid"> A 34 character string that uniquely identifies the Address resource that is associated with this AuthorizationDocument. </param>
        /// <param name="email"> Email that this AuthorizationDocument will be sent to for signing. </param>
        /// <param name="contactPhoneNumber"> The contact phone number of the person authorized to sign the Authorization Document. </param>
        /// <param name="hostedNumberOrderSids"> A list of HostedNumberOrder sids that this AuthorizationDocument will authorize for hosting phone number capabilities on Twilio's platform. </param>
        /// <param name="contactTitle"> The title of the person authorized to sign the Authorization Document for this phone number. </param>
        /// <param name="ccEmails"> Email recipients who will be informed when an Authorization Document has been sent and signed. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthorizationDocument </returns>
        public static AuthorizationDocumentResource Create(
                                          string addressSid,
                                          string email,
                                          Types.PhoneNumber contactPhoneNumber,
                                          List<string> hostedNumberOrderSids,
                                          string contactTitle = null,
                                          List<string> ccEmails = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateAuthorizationDocumentOptions(addressSid, email, contactPhoneNumber, hostedNumberOrderSids){  ContactTitle = contactTitle, CcEmails = ccEmails };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create an AuthorizationDocument for authorizing the hosting of phone number capabilities on Twilio's platform. </summary>
        /// <param name="addressSid"> A 34 character string that uniquely identifies the Address resource that is associated with this AuthorizationDocument. </param>
        /// <param name="email"> Email that this AuthorizationDocument will be sent to for signing. </param>
        /// <param name="contactPhoneNumber"> The contact phone number of the person authorized to sign the Authorization Document. </param>
        /// <param name="hostedNumberOrderSids"> A list of HostedNumberOrder sids that this AuthorizationDocument will authorize for hosting phone number capabilities on Twilio's platform. </param>
        /// <param name="contactTitle"> The title of the person authorized to sign the Authorization Document for this phone number. </param>
        /// <param name="ccEmails"> Email recipients who will be informed when an Authorization Document has been sent and signed. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthorizationDocument </returns>
        public static async System.Threading.Tasks.Task<AuthorizationDocumentResource> CreateAsync(
                                                                                  string addressSid,
                                                                                  string email,
                                                                                  Types.PhoneNumber contactPhoneNumber,
                                                                                  List<string> hostedNumberOrderSids,
                                                                                  string contactTitle = null,
                                                                                  List<string> ccEmails = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateAuthorizationDocumentOptions(addressSid, email, contactPhoneNumber, hostedNumberOrderSids){  ContactTitle = contactTitle, CcEmails = ccEmails };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Cancel the AuthorizationDocument request. </summary>
        /// <param name="options"> Delete AuthorizationDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthorizationDocument </returns>
        private static Request BuildDeleteRequest(DeleteAuthorizationDocumentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/HostedNumber/AuthorizationDocuments/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Numbers,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Cancel the AuthorizationDocument request. </summary>
        /// <param name="options"> Delete AuthorizationDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthorizationDocument </returns>
        public static bool Delete(DeleteAuthorizationDocumentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Cancel the AuthorizationDocument request. </summary>
        /// <param name="options"> Delete AuthorizationDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthorizationDocument </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAuthorizationDocumentOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Cancel the AuthorizationDocument request. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this AuthorizationDocument. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthorizationDocument </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteAuthorizationDocumentOptions(pathSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Cancel the AuthorizationDocument request. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this AuthorizationDocument. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthorizationDocument </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteAuthorizationDocumentOptions(pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchAuthorizationDocumentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/HostedNumber/AuthorizationDocuments/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Numbers,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific AuthorizationDocument. </summary>
        /// <param name="options"> Fetch AuthorizationDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthorizationDocument </returns>
        public static AuthorizationDocumentResource Fetch(FetchAuthorizationDocumentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific AuthorizationDocument. </summary>
        /// <param name="options"> Fetch AuthorizationDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthorizationDocument </returns>
        public static async System.Threading.Tasks.Task<AuthorizationDocumentResource> FetchAsync(FetchAuthorizationDocumentOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific AuthorizationDocument. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this AuthorizationDocument. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthorizationDocument </returns>
        public static AuthorizationDocumentResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchAuthorizationDocumentOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific AuthorizationDocument. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this AuthorizationDocument. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthorizationDocument </returns>
        public static async System.Threading.Tasks.Task<AuthorizationDocumentResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchAuthorizationDocumentOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadAuthorizationDocumentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/HostedNumber/AuthorizationDocuments";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Numbers,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of AuthorizationDocuments belonging to the account initiating the request. </summary>
        /// <param name="options"> Read AuthorizationDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthorizationDocument </returns>
        public static ResourceSet<AuthorizationDocumentResource> Read(ReadAuthorizationDocumentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<AuthorizationDocumentResource>.FromJson("items", response.Content);
            return new ResourceSet<AuthorizationDocumentResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of AuthorizationDocuments belonging to the account initiating the request. </summary>
        /// <param name="options"> Read AuthorizationDocument parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthorizationDocument </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AuthorizationDocumentResource>> ReadAsync(ReadAuthorizationDocumentOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AuthorizationDocumentResource>.FromJson("items", response.Content);
            return new ResourceSet<AuthorizationDocumentResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of AuthorizationDocuments belonging to the account initiating the request. </summary>
        /// <param name="email"> Email that this AuthorizationDocument will be sent to for signing. </param>
        /// <param name="status"> Status of an instance resource. It can hold one of the values: 1. opened 2. signing, 3. signed LOA, 4. canceled, 5. failed. See the section entitled [Status Values](https://www.twilio.com/docs/phone-numbers/hosted-numbers/hosted-numbers-api/authorization-document-resource#status-values) for more information on each of these statuses. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AuthorizationDocument </returns>
        public static ResourceSet<AuthorizationDocumentResource> Read(
                                                     string email = null,
                                                     AuthorizationDocumentResource.StatusEnum status = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadAuthorizationDocumentOptions(){ Email = email, Status = status, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of AuthorizationDocuments belonging to the account initiating the request. </summary>
        /// <param name="email"> Email that this AuthorizationDocument will be sent to for signing. </param>
        /// <param name="status"> Status of an instance resource. It can hold one of the values: 1. opened 2. signing, 3. signed LOA, 4. canceled, 5. failed. See the section entitled [Status Values](https://www.twilio.com/docs/phone-numbers/hosted-numbers/hosted-numbers-api/authorization-document-resource#status-values) for more information on each of these statuses. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AuthorizationDocument </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AuthorizationDocumentResource>> ReadAsync(
                                                                                             string email = null,
                                                                                             AuthorizationDocumentResource.StatusEnum status = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadAuthorizationDocumentOptions(){ Email = email, Status = status, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<AuthorizationDocumentResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AuthorizationDocumentResource>.FromJson("items", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<AuthorizationDocumentResource> NextPage(Page<AuthorizationDocumentResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AuthorizationDocumentResource>.FromJson("items", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<AuthorizationDocumentResource> PreviousPage(Page<AuthorizationDocumentResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AuthorizationDocumentResource>.FromJson("items", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a AuthorizationDocumentResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AuthorizationDocumentResource object represented by the provided JSON </returns>
        public static AuthorizationDocumentResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AuthorizationDocumentResource>(json);
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

    
        ///<summary> A 34 character string that uniquely identifies this AuthorizationDocument. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> A 34 character string that uniquely identifies the Address resource that is associated with this AuthorizationDocument. </summary> 
        [JsonProperty("address_sid")]
        public string AddressSid { get; private set; }

        
        [JsonProperty("status")]
        public AuthorizationDocumentResource.StatusEnum Status { get; private set; }

        ///<summary> Email that this AuthorizationDocument will be sent to for signing. </summary> 
        [JsonProperty("email")]
        public string Email { get; private set; }

        ///<summary> Email recipients who will be informed when an Authorization Document has been sent and signed. </summary> 
        [JsonProperty("cc_emails")]
        public List<string> CcEmails { get; private set; }

        ///<summary> The date this resource was created, given as [GMT RFC 2822](http://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this resource was updated, given as [GMT RFC 2822](http://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The links </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private AuthorizationDocumentResource() {

        }
    }
}

