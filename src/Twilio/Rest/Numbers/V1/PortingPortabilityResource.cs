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


namespace Twilio.Rest.Numbers.V1
{
    public class PortingPortabilityResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class NumberTypeEnum : StringEnum
        {
            private NumberTypeEnum(string value) : base(value) {}
            public NumberTypeEnum() {}
            public static implicit operator NumberTypeEnum(string value)
            {
                return new NumberTypeEnum(value);
            }
            public static readonly NumberTypeEnum Local = new NumberTypeEnum("LOCAL");
            public static readonly NumberTypeEnum Unknown = new NumberTypeEnum("UNKNOWN");
            public static readonly NumberTypeEnum Mobile = new NumberTypeEnum("MOBILE");
            public static readonly NumberTypeEnum TollFree = new NumberTypeEnum("TOLL-FREE");

        }

        
        private static Request BuildFetchRequest(FetchPortingPortabilityOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Porting/Portability/PhoneNumber/{PhoneNumber}";

            string PathPhoneNumber = options.PathPhoneNumber.ToString();
            path = path.Replace("{"+"PhoneNumber"+"}", PathPhoneNumber);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Numbers,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Check if a single phone number can be ported to Twilio </summary>
        /// <param name="options"> Fetch PortingPortability parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PortingPortability </returns>
        public static PortingPortabilityResource Fetch(FetchPortingPortabilityOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Check if a single phone number can be ported to Twilio </summary>
        /// <param name="options"> Fetch PortingPortability parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PortingPortability </returns>
        public static async System.Threading.Tasks.Task<PortingPortabilityResource> FetchAsync(FetchPortingPortabilityOptions options, ITwilioRestClient client = null,  System.Threading.CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Check if a single phone number can be ported to Twilio </summary>
        /// <param name="pathPhoneNumber"> Phone number to check portability in e164 format. </param>
        /// <param name="targetAccountSid"> Account Sid to which the number will be ported. This can be used to determine if a sub account already has the number in its inventory or a different sub account. If this is not provided, the authenticated account will be assumed to be the target account. </param>
        /// <param name="addressSid"> Address Sid of customer to which the number will be ported. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PortingPortability </returns>
        public static PortingPortabilityResource Fetch(
                                         Types.PhoneNumber pathPhoneNumber, 
                                         string targetAccountSid = null, 
                                         string addressSid = null, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchPortingPortabilityOptions(pathPhoneNumber){ TargetAccountSid = targetAccountSid,AddressSid = addressSid };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Check if a single phone number can be ported to Twilio </summary>
        /// <param name="pathPhoneNumber"> Phone number to check portability in e164 format. </param>
        /// <param name="targetAccountSid"> Account Sid to which the number will be ported. This can be used to determine if a sub account already has the number in its inventory or a different sub account. If this is not provided, the authenticated account will be assumed to be the target account. </param>
        /// <param name="addressSid"> Address Sid of customer to which the number will be ported. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PortingPortability </returns>
        public static async System.Threading.Tasks.Task<PortingPortabilityResource> FetchAsync(Types.PhoneNumber pathPhoneNumber, string targetAccountSid = null, string addressSid = null, ITwilioRestClient client = null , System.Threading.CancellationToken cancellationToken = default)
        {
            var options = new FetchPortingPortabilityOptions(pathPhoneNumber){ TargetAccountSid = targetAccountSid,AddressSid = addressSid };
            return await FetchAsync(options, client, cancellationToken);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a PortingPortabilityResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PortingPortabilityResource object represented by the provided JSON </returns>
        public static PortingPortabilityResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<PortingPortabilityResource>(json);
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

    
        ///<summary> The phone number which portability is to be checked. Phone numbers are in E.164 format (e.g. +16175551212). </summary> 
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }

        ///<summary> Account Sid that the phone number belongs to in Twilio. This is only returned for phone numbers that already exist in Twilio’s inventory and belong to your account or sub account. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> Boolean flag indicates if the phone number can be ported into Twilio through the Porting API or not. </summary> 
        [JsonProperty("portable")]
        public bool? Portable { get; private set; }

        ///<summary> Indicates if the port in process will require a personal identification number (PIN) and an account number for this phone number. If this is true you will be required to submit both a PIN and account number from the losing carrier for this number when opening a port in request. These fields will be required in order to complete the port in process to Twilio. </summary> 
        [JsonProperty("pin_and_account_number_required")]
        public bool? PinAndAccountNumberRequired { get; private set; }

        ///<summary> Reason why the phone number cannot be ported into Twilio, `null` otherwise. </summary> 
        [JsonProperty("not_portable_reason")]
        public string NotPortableReason { get; private set; }

        ///<summary> The Portability Reason Code for the phone number if it cannot be ported into Twilio, `null` otherwise. </summary> 
        [JsonProperty("not_portable_reason_code")]
        public int? NotPortableReasonCode { get; private set; }

        
        [JsonProperty("number_type")]
        public PortingPortabilityResource.NumberTypeEnum NumberType { get; private set; }

        ///<summary> Country the phone number belongs to. </summary> 
        [JsonProperty("country")]
        public string Country { get; private set; }

        ///<summary> This is the url of the request that you're trying to reach out to locate the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private PortingPortabilityResource() {

        }
    }
}

