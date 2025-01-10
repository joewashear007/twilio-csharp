/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Messaging
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



namespace Twilio.Rest.Messaging.V1.BrandRegistration
{
    public class BrandRegistrationOtpResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateBrandRegistrationOtpOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/a2p/BrandRegistrations/{BrandRegistrationSid}/SmsOtp";

            string PathBrandRegistrationSid = options.PathBrandRegistrationSid;
            path = path.Replace("{"+"BrandRegistrationSid"+"}", PathBrandRegistrationSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Messaging,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create BrandRegistrationOtp parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandRegistrationOtp </returns>
        public static BrandRegistrationOtpResource Create(CreateBrandRegistrationOtpOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create BrandRegistrationOtp parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandRegistrationOtp </returns>
        public static async System.Threading.Tasks.Task<BrandRegistrationOtpResource> CreateAsync(CreateBrandRegistrationOtpOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="pathBrandRegistrationSid"> Brand Registration Sid of Sole Proprietor Brand. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandRegistrationOtp </returns>
        public static BrandRegistrationOtpResource Create(
                                          string pathBrandRegistrationSid,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateBrandRegistrationOtpOptions(pathBrandRegistrationSid){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="pathBrandRegistrationSid"> Brand Registration Sid of Sole Proprietor Brand. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandRegistrationOtp </returns>
        public static async System.Threading.Tasks.Task<BrandRegistrationOtpResource> CreateAsync(
                                                                                  string pathBrandRegistrationSid,
                                                                                    ITwilioRestClient client = null)
        {
        var options = new CreateBrandRegistrationOtpOptions(pathBrandRegistrationSid){  };
            return await CreateAsync(options, client, cancellationToken);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a BrandRegistrationOtpResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BrandRegistrationOtpResource object represented by the provided JSON </returns>
        public static BrandRegistrationOtpResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<BrandRegistrationOtpResource>(json);
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

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Brand Registration resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique string to identify Brand Registration of Sole Proprietor Brand </summary> 
        [JsonProperty("brand_registration_sid")]
        public string BrandRegistrationSid { get; private set; }



        private BrandRegistrationOtpResource() {

        }
    }
}

