/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Accounts
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



namespace Twilio.Rest.Accounts.V1.Credential
{
    public class AwsResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateAwsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Credentials/AWS";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Accounts,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new AWS Credential </summary>
        /// <param name="options"> Create Aws parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Aws </returns>
        public static AwsResource Create(CreateAwsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new AWS Credential </summary>
        /// <param name="options"> Create Aws parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Aws </returns>
        public static async System.Threading.Tasks.Task<AwsResource> CreateAsync(CreateAwsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new AWS Credential </summary>
        /// <param name="credentials"> A string that contains the AWS access credentials in the format `<AWS_ACCESS_KEY_ID>:<AWS_SECRET_ACCESS_KEY>`. For example, `AKIAIOSFODNN7EXAMPLE:wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY` </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </param>
        /// <param name="accountSid"> The SID of the Subaccount that this Credential should be associated with. Must be a valid Subaccount of the account issuing the request. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Aws </returns>
        public static AwsResource Create(
                                          string credentials,
                                          string friendlyName = null,
                                          string accountSid = null,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateAwsOptions(credentials){  FriendlyName = friendlyName, AccountSid = accountSid };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new AWS Credential </summary>
        /// <param name="credentials"> A string that contains the AWS access credentials in the format `<AWS_ACCESS_KEY_ID>:<AWS_SECRET_ACCESS_KEY>`. For example, `AKIAIOSFODNN7EXAMPLE:wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY` </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </param>
        /// <param name="accountSid"> The SID of the Subaccount that this Credential should be associated with. Must be a valid Subaccount of the account issuing the request. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Aws </returns>
        public static async System.Threading.Tasks.Task<AwsResource> CreateAsync(
                                                                                  string credentials,
                                                                                  string friendlyName = null,
                                                                                  string accountSid = null,
                                                                                    ITwilioRestClient client = null)
        {
        var options = new CreateAwsOptions(credentials){  FriendlyName = friendlyName, AccountSid = accountSid };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete a Credential from your account </summary>
        /// <param name="options"> Delete Aws parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Aws </returns>
        private static Request BuildDeleteRequest(DeleteAwsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Credentials/AWS/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Accounts,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a Credential from your account </summary>
        /// <param name="options"> Delete Aws parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Aws </returns>
        public static bool Delete(DeleteAwsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a Credential from your account </summary>
        /// <param name="options"> Delete Aws parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Aws </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAwsOptions options,
                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a Credential from your account </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the AWS resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Aws </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteAwsOptions(pathSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a Credential from your account </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the AWS resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Aws </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteAwsOptions(pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchAwsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Credentials/AWS/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Accounts,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch the AWS credentials specified by the provided Credential Sid </summary>
        /// <param name="options"> Fetch Aws parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Aws </returns>
        public static AwsResource Fetch(FetchAwsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch the AWS credentials specified by the provided Credential Sid </summary>
        /// <param name="options"> Fetch Aws parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Aws </returns>
        public static async System.Threading.Tasks.Task<AwsResource> FetchAsync(FetchAwsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch the AWS credentials specified by the provided Credential Sid </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the AWS resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Aws </returns>
        public static AwsResource Fetch(
                                         string pathSid, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchAwsOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch the AWS credentials specified by the provided Credential Sid </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the AWS resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Aws </returns>
        public static async System.Threading.Tasks.Task<AwsResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchAwsOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadAwsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Credentials/AWS";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Accounts,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieves a collection of AWS Credentials belonging to the account used to make the request </summary>
        /// <param name="options"> Read Aws parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Aws </returns>
        public static ResourceSet<AwsResource> Read(ReadAwsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<AwsResource>.FromJson("credentials", response.Content);
            return new ResourceSet<AwsResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieves a collection of AWS Credentials belonging to the account used to make the request </summary>
        /// <param name="options"> Read Aws parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Aws </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AwsResource>> ReadAsync(ReadAwsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AwsResource>.FromJson("credentials", response.Content);
            return new ResourceSet<AwsResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieves a collection of AWS Credentials belonging to the account used to make the request </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Aws </returns>
        public static ResourceSet<AwsResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadAwsOptions(){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieves a collection of AWS Credentials belonging to the account used to make the request </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Aws </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AwsResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadAwsOptions(){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<AwsResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AwsResource>.FromJson("credentials", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<AwsResource> NextPage(Page<AwsResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AwsResource>.FromJson("credentials", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<AwsResource> PreviousPage(Page<AwsResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AwsResource>.FromJson("credentials", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateAwsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Credentials/AWS/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Accounts,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Modify the properties of a given Account </summary>
        /// <param name="options"> Update Aws parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Aws </returns>
        public static AwsResource Update(UpdateAwsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Modify the properties of a given Account </summary>
        /// <param name="options"> Update Aws parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Aws </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<AwsResource> UpdateAsync(UpdateAwsOptions options,
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Modify the properties of a given Account </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the AWS resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Aws </returns>
        public static AwsResource Update(
                                          string pathSid,
                                          string friendlyName = null,
                                            ITwilioRestClient client = null)
        {
            var options = new UpdateAwsOptions(pathSid){ FriendlyName = friendlyName };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Modify the properties of a given Account </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the AWS resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Aws </returns>
        public static async System.Threading.Tasks.Task<AwsResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string friendlyName = null,
                                                                                ITwilioRestClient client = null)
        {
            var options = new UpdateAwsOptions(pathSid){ FriendlyName = friendlyName };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a AwsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AwsResource object represented by the provided JSON </returns>
        public static AwsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AwsResource>(json);
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

    
        ///<summary> The unique string that we created to identify the AWS resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the AWS resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The URI for this resource, relative to `https://accounts.twilio.com` </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private AwsResource() {

        }
    }
}

