/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Trusthub
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


namespace Twilio.Rest.Trusthub.V1.CustomerProfiles
{
    public class CustomerProfilesEvaluationsResource : Resource
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
            public static readonly StatusEnum Compliant = new StatusEnum("compliant");
            public static readonly StatusEnum Noncompliant = new StatusEnum("noncompliant");

        }

        
        private static Request BuildCreateRequest(CreateCustomerProfilesEvaluationsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/CustomerProfiles/{CustomerProfileSid}/Evaluations";

            string PathCustomerProfileSid = options.PathCustomerProfileSid;
            path = path.Replace("{"+"CustomerProfileSid"+"}", PathCustomerProfileSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trusthub,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Evaluation </summary>
        /// <param name="options"> Create CustomerProfilesEvaluations parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CustomerProfilesEvaluations </returns>
        public static CustomerProfilesEvaluationsResource Create(CreateCustomerProfilesEvaluationsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Evaluation </summary>
        /// <param name="options"> Create CustomerProfilesEvaluations parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CustomerProfilesEvaluations </returns>
        public static async System.Threading.Tasks.Task<CustomerProfilesEvaluationsResource> CreateAsync(CreateCustomerProfilesEvaluationsOptions options, ITwilioRestClient client = null,  System.Threading.CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Evaluation </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="policySid"> The unique string of a policy that is associated to the customer_profile resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CustomerProfilesEvaluations </returns>
        public static CustomerProfilesEvaluationsResource Create(
                                          string pathCustomerProfileSid,
                                          string policySid,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateCustomerProfilesEvaluationsOptions(pathCustomerProfileSid, policySid){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Evaluation </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="policySid"> The unique string of a policy that is associated to the customer_profile resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CustomerProfilesEvaluations </returns>
        public static async System.Threading.Tasks.Task<CustomerProfilesEvaluationsResource> CreateAsync(
                                                                                  string pathCustomerProfileSid,
                                                                                  string policySid,
                                                                                    ITwilioRestClient client = null , System.Threading.CancellationToken cancellationToken = default)
        {
        var options = new CreateCustomerProfilesEvaluationsOptions(pathCustomerProfileSid, policySid){  };
            return await CreateAsync(options, client, cancellationToken);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchCustomerProfilesEvaluationsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/CustomerProfiles/{CustomerProfileSid}/Evaluations/{Sid}";

            string PathCustomerProfileSid = options.PathCustomerProfileSid;
            path = path.Replace("{"+"CustomerProfileSid"+"}", PathCustomerProfileSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trusthub,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch specific Evaluation Instance. </summary>
        /// <param name="options"> Fetch CustomerProfilesEvaluations parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CustomerProfilesEvaluations </returns>
        public static CustomerProfilesEvaluationsResource Fetch(FetchCustomerProfilesEvaluationsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch specific Evaluation Instance. </summary>
        /// <param name="options"> Fetch CustomerProfilesEvaluations parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CustomerProfilesEvaluations </returns>
        public static async System.Threading.Tasks.Task<CustomerProfilesEvaluationsResource> FetchAsync(FetchCustomerProfilesEvaluationsOptions options, ITwilioRestClient client = null,  System.Threading.CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch specific Evaluation Instance. </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the customer_profile resource. </param>
        /// <param name="pathSid"> The unique string that identifies the Evaluation resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CustomerProfilesEvaluations </returns>
        public static CustomerProfilesEvaluationsResource Fetch(
                                         string pathCustomerProfileSid, 
                                         string pathSid, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchCustomerProfilesEvaluationsOptions(pathCustomerProfileSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch specific Evaluation Instance. </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the customer_profile resource. </param>
        /// <param name="pathSid"> The unique string that identifies the Evaluation resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CustomerProfilesEvaluations </returns>
        public static async System.Threading.Tasks.Task<CustomerProfilesEvaluationsResource> FetchAsync(string pathCustomerProfileSid, string pathSid, ITwilioRestClient client = null , System.Threading.CancellationToken cancellationToken = default)
        {
            var options = new FetchCustomerProfilesEvaluationsOptions(pathCustomerProfileSid, pathSid){  };
            return await FetchAsync(options, client, cancellationToken);
        }
        #endif
        
        private static Request BuildReadRequest(ReadCustomerProfilesEvaluationsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/CustomerProfiles/{CustomerProfileSid}/Evaluations";

            string PathCustomerProfileSid = options.PathCustomerProfileSid;
            path = path.Replace("{"+"CustomerProfileSid"+"}", PathCustomerProfileSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trusthub,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of Evaluations associated to the customer_profile resource. </summary>
        /// <param name="options"> Read CustomerProfilesEvaluations parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CustomerProfilesEvaluations </returns>
        public static ResourceSet<CustomerProfilesEvaluationsResource> Read(ReadCustomerProfilesEvaluationsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<CustomerProfilesEvaluationsResource>.FromJson("results", response.Content);
            return new ResourceSet<CustomerProfilesEvaluationsResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Evaluations associated to the customer_profile resource. </summary>
        /// <param name="options"> Read CustomerProfilesEvaluations parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CustomerProfilesEvaluations </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CustomerProfilesEvaluationsResource>> ReadAsync(ReadCustomerProfilesEvaluationsOptions options, ITwilioRestClient client = null,  System.Threading.CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client), cancellationToken);

            var page = Page<CustomerProfilesEvaluationsResource>.FromJson("results", response.Content);
            return new ResourceSet<CustomerProfilesEvaluationsResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of Evaluations associated to the customer_profile resource. </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CustomerProfilesEvaluations </returns>
        public static ResourceSet<CustomerProfilesEvaluationsResource> Read(
                                                     string pathCustomerProfileSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadCustomerProfilesEvaluationsOptions(pathCustomerProfileSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Evaluations associated to the customer_profile resource. </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CustomerProfilesEvaluations </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CustomerProfilesEvaluationsResource>> ReadAsync(
                                                                                             string pathCustomerProfileSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                            ITwilioRestClient client = null , System.Threading.CancellationToken cancellationToken = default)
        {
            var options = new ReadCustomerProfilesEvaluationsOptions(pathCustomerProfileSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client, cancellationToken);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<CustomerProfilesEvaluationsResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CustomerProfilesEvaluationsResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<CustomerProfilesEvaluationsResource> NextPage(Page<CustomerProfilesEvaluationsResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CustomerProfilesEvaluationsResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<CustomerProfilesEvaluationsResource> PreviousPage(Page<CustomerProfilesEvaluationsResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CustomerProfilesEvaluationsResource>.FromJson("results", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a CustomerProfilesEvaluationsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CustomerProfilesEvaluationsResource object represented by the provided JSON </returns>
        public static CustomerProfilesEvaluationsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<CustomerProfilesEvaluationsResource>(json);
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

    
        ///<summary> The unique string that identifies the Evaluation resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the customer_profile resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique string of a policy that is associated to the customer_profile resource. </summary> 
        [JsonProperty("policy_sid")]
        public string PolicySid { get; private set; }

        ///<summary> The unique string that we created to identify the customer_profile resource. </summary> 
        [JsonProperty("customer_profile_sid")]
        public string CustomerProfileSid { get; private set; }

        
        [JsonProperty("status")]
        public CustomerProfilesEvaluationsResource.StatusEnum Status { get; private set; }

        ///<summary> The results of the Evaluation which includes the valid and invalid attributes. </summary> 
        [JsonProperty("results")]
        public List<object> Results { get; private set; }

        ///<summary> The date_created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private CustomerProfilesEvaluationsResource() {

        }
    }
}

