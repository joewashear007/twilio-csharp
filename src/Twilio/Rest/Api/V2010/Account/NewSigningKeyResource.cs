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



namespace Twilio.Rest.Api.V2010.Account
{
    public class NewSigningKeyResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateNewSigningKeyOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SigningKeys.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Signing Key for the account making the request. </summary>
        /// <param name="options"> Create NewSigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NewSigningKey </returns>
        public static NewSigningKeyResource Create(CreateNewSigningKeyOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Signing Key for the account making the request. </summary>
        /// <param name="options"> Create NewSigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NewSigningKey </returns>
        public static async System.Threading.Tasks.Task<NewSigningKeyResource> CreateAsync(CreateNewSigningKeyOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Signing Key for the account making the request. </summary>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will be responsible for the new Key resource. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NewSigningKey </returns>
        public static NewSigningKeyResource Create(
                                          string pathAccountSid = null,
                                          string friendlyName = null,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateNewSigningKeyOptions(){  PathAccountSid = pathAccountSid, FriendlyName = friendlyName };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Signing Key for the account making the request. </summary>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will be responsible for the new Key resource. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NewSigningKey </returns>
        public static async System.Threading.Tasks.Task<NewSigningKeyResource> CreateAsync(
                                                                                  string pathAccountSid = null,
                                                                                  string friendlyName = null,
                                                                                    ITwilioRestClient client = null)
        {
        var options = new CreateNewSigningKeyOptions(){  PathAccountSid = pathAccountSid, FriendlyName = friendlyName };
            return await CreateAsync(options, client, cancellationToken);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a NewSigningKeyResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> NewSigningKeyResource object represented by the provided JSON </returns>
        public static NewSigningKeyResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<NewSigningKeyResource>(json);
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

    
        ///<summary> The unique string that that we created to identify the NewSigningKey resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The date and time in GMT that the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT that the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The secret your application uses to sign Access Tokens and to authenticate to the REST API (you will use this as the basic-auth `password`).  **Note that for security reasons, this field is ONLY returned when the API Key is first created.** </summary> 
        [JsonProperty("secret")]
        public string Secret { get; private set; }



        private NewSigningKeyResource() {

        }
    }
}

