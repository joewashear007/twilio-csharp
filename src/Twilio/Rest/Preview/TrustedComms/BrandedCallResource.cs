/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// BrandedCallResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.TrustedComms
{

    public class BrandedCallResource : Resource
    {
        private static Request BuildCreateRequest(CreateBrandedCallOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/TrustedComms/Business/BrandedCalls",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Brands a Call without actually placing it. Useful for cases when the Customer wants to initiate the call themselves
        /// right after calling this endpoint. This can be used also through a TwiML using `<Brand callerId="+1500123"
        /// callReason="This is the call reason" callSid="CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa">+1500456</Brand>`, and right after
        /// doing `<Dial callerId="+1500123">+1500456</Dial>`
        /// </summary>
        /// <param name="options"> Create BrandedCall parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandedCall </returns>
        public static BrandedCallResource Create(CreateBrandedCallOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Brands a Call without actually placing it. Useful for cases when the Customer wants to initiate the call themselves
        /// right after calling this endpoint. This can be used also through a TwiML using `<Brand callerId="+1500123"
        /// callReason="This is the call reason" callSid="CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa">+1500456</Brand>`, and right after
        /// doing `<Dial callerId="+1500123">+1500456</Dial>`
        /// </summary>
        /// <param name="options"> Create BrandedCall parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandedCall </returns>
        public static async System.Threading.Tasks.Task<BrandedCallResource> CreateAsync(CreateBrandedCallOptions options,
                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Brands a Call without actually placing it. Useful for cases when the Customer wants to initiate the call themselves
        /// right after calling this endpoint. This can be used also through a TwiML using `<Brand callerId="+1500123"
        /// callReason="This is the call reason" callSid="CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa">+1500456</Brand>`, and right after
        /// doing `<Dial callerId="+1500123">+1500456</Dial>`
        /// </summary>
        /// <param name="from"> Twilio number from which to brand the call </param>
        /// <param name="to"> The terminating Phone Number </param>
        /// <param name="reason"> The business reason for this phone call </param>
        /// <param name="callSid"> The Call sid this Branded Call should link to </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandedCall </returns>
        public static BrandedCallResource Create(string from,
                                                 string to,
                                                 string reason,
                                                 string callSid = null,
                                                 ITwilioRestClient client = null)
        {
            var options = new CreateBrandedCallOptions(from, to, reason){CallSid = callSid};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Brands a Call without actually placing it. Useful for cases when the Customer wants to initiate the call themselves
        /// right after calling this endpoint. This can be used also through a TwiML using `<Brand callerId="+1500123"
        /// callReason="This is the call reason" callSid="CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa">+1500456</Brand>`, and right after
        /// doing `<Dial callerId="+1500123">+1500456</Dial>`
        /// </summary>
        /// <param name="from"> Twilio number from which to brand the call </param>
        /// <param name="to"> The terminating Phone Number </param>
        /// <param name="reason"> The business reason for this phone call </param>
        /// <param name="callSid"> The Call sid this Branded Call should link to </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandedCall </returns>
        public static async System.Threading.Tasks.Task<BrandedCallResource> CreateAsync(string from,
                                                                                         string to,
                                                                                         string reason,
                                                                                         string callSid = null,
                                                                                         ITwilioRestClient client = null)
        {
            var options = new CreateBrandedCallOptions(from, to, reason){CallSid = callSid};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a BrandedCallResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BrandedCallResource object represented by the provided JSON </returns>
        public static BrandedCallResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<BrandedCallResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// Background color of the current phone call
        /// </summary>
        [JsonProperty("bg_color")]
        public string BgColor { get; private set; }
        /// <summary>
        /// Brand Sid.
        /// </summary>
        [JsonProperty("brand_sid")]
        public string BrandSid { get; private set; }
        /// <summary>
        /// Branded Channel Sid.
        /// </summary>
        [JsonProperty("branded_channel_sid")]
        public string BrandedChannelSid { get; private set; }
        /// <summary>
        /// Business Sid.
        /// </summary>
        [JsonProperty("business_sid")]
        public string BusinessSid { get; private set; }
        /// <summary>
        /// A string that uniquely identifies this phone call.
        /// </summary>
        [JsonProperty("call_sid")]
        public string CallSid { get; private set; }
        /// <summary>
        /// Caller name of the current phone call
        /// </summary>
        [JsonProperty("caller")]
        public string Caller { get; private set; }
        /// <summary>
        /// The date this current phone call was created
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; private set; }
        /// <summary>
        /// Font color of the current phone call
        /// </summary>
        [JsonProperty("font_color")]
        public string FontColor { get; private set; }
        /// <summary>
        /// The originating phone number
        /// </summary>
        [JsonProperty("from")]
        public string From { get; private set; }
        /// <summary>
        /// Logo URL of the caller
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; private set; }
        /// <summary>
        /// Phone Number Sid.
        /// </summary>
        [JsonProperty("phone_number_sid")]
        public string PhoneNumberSid { get; private set; }
        /// <summary>
        /// The business reason for this current phone call
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; private set; }
        /// <summary>
        /// A string that uniquely identifies this current branded phone call.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The status of the current phone call
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; private set; }
        /// <summary>
        /// The terminating phone number
        /// </summary>
        [JsonProperty("to")]
        public string To { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The use case for the current phone call
        /// </summary>
        [JsonProperty("use_case")]
        public string UseCase { get; private set; }

        private BrandedCallResource()
        {

        }
    }

}