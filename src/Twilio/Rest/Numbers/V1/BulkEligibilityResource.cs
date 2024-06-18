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



namespace Twilio.Rest.Numbers.V1
{
    public class BulkEligibilityResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateBulkEligibilityOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/HostedNumber/Eligibility/Bulk";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Numbers,
                path,

                contentType: EnumConstants.ContentTypeEnum.JSON,
                body: options.GetBody(),
                headerParams: null
            );
        }

        /// <summary> Create a bulk eligibility check for a set of numbers that you want to host in Twilio. </summary>
        /// <param name="options"> Create BulkEligibility parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BulkEligibility </returns>
        public static BulkEligibilityResource Create(CreateBulkEligibilityOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a bulk eligibility check for a set of numbers that you want to host in Twilio. </summary>
        /// <param name="options"> Create BulkEligibility parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BulkEligibility </returns>
        public static async System.Threading.Tasks.Task<BulkEligibilityResource> CreateAsync(CreateBulkEligibilityOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a bulk eligibility check for a set of numbers that you want to host in Twilio. </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BulkEligibility </returns>
        public static BulkEligibilityResource Create(
                                          ITwilioRestClient client = null)
        {
            var options = new CreateBulkEligibilityOptions(){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a bulk eligibility check for a set of numbers that you want to host in Twilio. </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BulkEligibility </returns>
        public static async System.Threading.Tasks.Task<BulkEligibilityResource> CreateAsync(
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateBulkEligibilityOptions(){  };
            return await CreateAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchBulkEligibilityOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/HostedNumber/Eligibility/Bulk/{RequestId}";

            string PathRequestId = options.PathRequestId;
            path = path.Replace("{"+"RequestId"+"}", PathRequestId);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Numbers,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch an eligibility bulk check that you requested to host in Twilio. </summary>
        /// <param name="options"> Fetch BulkEligibility parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BulkEligibility </returns>
        public static BulkEligibilityResource Fetch(FetchBulkEligibilityOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch an eligibility bulk check that you requested to host in Twilio. </summary>
        /// <param name="options"> Fetch BulkEligibility parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BulkEligibility </returns>
        public static async System.Threading.Tasks.Task<BulkEligibilityResource> FetchAsync(FetchBulkEligibilityOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch an eligibility bulk check that you requested to host in Twilio. </summary>
        /// <param name="pathRequestId"> The SID of the bulk eligibility check that you want to know about. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BulkEligibility </returns>
        public static BulkEligibilityResource Fetch(
                                         string pathRequestId, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchBulkEligibilityOptions(pathRequestId){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch an eligibility bulk check that you requested to host in Twilio. </summary>
        /// <param name="pathRequestId"> The SID of the bulk eligibility check that you want to know about. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BulkEligibility </returns>
        public static async System.Threading.Tasks.Task<BulkEligibilityResource> FetchAsync(string pathRequestId, ITwilioRestClient client = null)
        {
            var options = new FetchBulkEligibilityOptions(pathRequestId){  };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a BulkEligibilityResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BulkEligibilityResource object represented by the provided JSON </returns>
        public static BulkEligibilityResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<BulkEligibilityResource>(json);
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

    
        ///<summary> The SID of the bulk eligibility check that you want to know about. </summary> 
        [JsonProperty("request_id")]
        public string RequestId { get; private set; }

        ///<summary> This is the url of the request that you're trying to reach out to locate the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The result set that contains the eligibility check response for each requested number, each result has at least the following attributes:  phone_number: The requested phone number ,hosting_account_sid: The account sid where the phone number will be hosted, country: Phone number’s country, eligibility_status: Indicates the eligibility status of the PN (Eligible/Ineligible), eligibility_sub_status: Indicates the sub status of the eligibility , ineligibility_reason: Reason for number's ineligibility (if applicable), next_step: Suggested next step in the hosting process based on the eligibility status. </summary> 
        [JsonProperty("results")]
        public List<object> Results { get; private set; }

        ///<summary> This is the string that you assigned as a friendly name for describing the eligibility check request. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> This is the status of the bulk eligibility check request. (Example: COMPLETE, IN_PROGRESS) </summary> 
        [JsonProperty("status")]
        public string Status { get; private set; }

        ///<summary> The date_created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date_completed </summary> 
        [JsonProperty("date_completed")]
        public DateTime? DateCompleted { get; private set; }



        private BulkEligibilityResource() {

        }
    }
}

