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



namespace Twilio.Rest.Trusthub.V1
{
    public class ComplianceInquiriesResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateComplianceInquiriesOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/ComplianceInquiries/Customers/Initialize";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trusthub,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Compliance Inquiry for the authenticated account. This is necessary to start a new embedded session. </summary>
        /// <param name="options"> Create ComplianceInquiries parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ComplianceInquiries </returns>
        public static ComplianceInquiriesResource Create(CreateComplianceInquiriesOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Compliance Inquiry for the authenticated account. This is necessary to start a new embedded session. </summary>
        /// <param name="options"> Create ComplianceInquiries parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ComplianceInquiries </returns>
        public static async System.Threading.Tasks.Task<ComplianceInquiriesResource> CreateAsync(CreateComplianceInquiriesOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Compliance Inquiry for the authenticated account. This is necessary to start a new embedded session. </summary>
        /// <param name="primaryProfileSid"> The unique SID identifier of the Primary Customer Profile that should be used as a parent. Only necessary when creating a secondary Customer Profile. </param>
        /// <param name="notificationEmail"> The email address that approval status updates will be sent to. If not specified, the email address associated with your primary customer profile will be used. </param>
        /// <param name="themeSetId"> Theme id for styling the inquiry form. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ComplianceInquiries </returns>
        public static ComplianceInquiriesResource Create(
                                          string primaryProfileSid,
                                          string notificationEmail = null,
                                          string themeSetId = null,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateComplianceInquiriesOptions(primaryProfileSid){  NotificationEmail = notificationEmail, ThemeSetId = themeSetId };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Compliance Inquiry for the authenticated account. This is necessary to start a new embedded session. </summary>
        /// <param name="primaryProfileSid"> The unique SID identifier of the Primary Customer Profile that should be used as a parent. Only necessary when creating a secondary Customer Profile. </param>
        /// <param name="notificationEmail"> The email address that approval status updates will be sent to. If not specified, the email address associated with your primary customer profile will be used. </param>
        /// <param name="themeSetId"> Theme id for styling the inquiry form. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ComplianceInquiries </returns>
        public static async System.Threading.Tasks.Task<ComplianceInquiriesResource> CreateAsync(
                                                                                  string primaryProfileSid,
                                                                                  string notificationEmail = null,
                                                                                  string themeSetId = null,
                                                                                    ITwilioRestClient client = null)
        {
        var options = new CreateComplianceInquiriesOptions(primaryProfileSid){  NotificationEmail = notificationEmail, ThemeSetId = themeSetId };
            return await CreateAsync(options, client, cancellationToken);
        }
        #endif
        
        private static Request BuildUpdateRequest(UpdateComplianceInquiriesOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/ComplianceInquiries/Customers/{CustomerId}/Initialize";

            string PathCustomerId = options.PathCustomerId;
            path = path.Replace("{"+"CustomerId"+"}", PathCustomerId);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trusthub,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Resume a specific Compliance Inquiry that has expired, or re-open a rejected Compliance Inquiry for editing. </summary>
        /// <param name="options"> Update ComplianceInquiries parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ComplianceInquiries </returns>
        public static ComplianceInquiriesResource Update(UpdateComplianceInquiriesOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Resume a specific Compliance Inquiry that has expired, or re-open a rejected Compliance Inquiry for editing. </summary>
        /// <param name="options"> Update ComplianceInquiries parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ComplianceInquiries </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<ComplianceInquiriesResource> UpdateAsync(UpdateComplianceInquiriesOptions options, 
                                                                                                    ITwilioRestClient client = null,
                                                                                                    CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Resume a specific Compliance Inquiry that has expired, or re-open a rejected Compliance Inquiry for editing. </summary>
        /// <param name="pathCustomerId"> The unique CustomerId matching the Customer Profile/Compliance Inquiry that should be resumed or resubmitted. This value will have been returned by the initial Compliance Inquiry creation call. </param>
        /// <param name="primaryProfileSid"> The unique SID identifier of the Primary Customer Profile that should be used as a parent. Only necessary when creating a secondary Customer Profile. </param>
        /// <param name="themeSetId"> Theme id for styling the inquiry form. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ComplianceInquiries </returns>
        public static ComplianceInquiriesResource Update(
                                          string pathCustomerId,
                                          string primaryProfileSid,
                                          string themeSetId = null,
                                            ITwilioRestClient client = null)
        {
            var options = new UpdateComplianceInquiriesOptions(pathCustomerId, primaryProfileSid){ ThemeSetId = themeSetId };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Resume a specific Compliance Inquiry that has expired, or re-open a rejected Compliance Inquiry for editing. </summary>
        /// <param name="pathCustomerId"> The unique CustomerId matching the Customer Profile/Compliance Inquiry that should be resumed or resubmitted. This value will have been returned by the initial Compliance Inquiry creation call. </param>
        /// <param name="primaryProfileSid"> The unique SID identifier of the Primary Customer Profile that should be used as a parent. Only necessary when creating a secondary Customer Profile. </param>
        /// <param name="themeSetId"> Theme id for styling the inquiry form. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ComplianceInquiries </returns>
        public static async System.Threading.Tasks.Task<ComplianceInquiriesResource> UpdateAsync(
                                                                              string pathCustomerId,
                                                                              string primaryProfileSid,
                                                                              string themeSetId = null,
                                                                                ITwilioRestClient client = null)
        {
            var options = new UpdateComplianceInquiriesOptions(pathCustomerId, primaryProfileSid){ ThemeSetId = themeSetId };
            return await UpdateAsync(options, client, cancellationToken);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a ComplianceInquiriesResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ComplianceInquiriesResource object represented by the provided JSON </returns>
        public static ComplianceInquiriesResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ComplianceInquiriesResource>(json);
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

    
        ///<summary> The unique ID used to start an embedded compliance registration session. </summary> 
        [JsonProperty("inquiry_id")]
        public string InquiryId { get; private set; }

        ///<summary> The session token used to start an embedded compliance registration session. </summary> 
        [JsonProperty("inquiry_session_token")]
        public string InquirySessionToken { get; private set; }

        ///<summary> The CustomerID matching the Customer Profile that should be resumed or resubmitted for editing. </summary> 
        [JsonProperty("customer_id")]
        public string CustomerId { get; private set; }

        ///<summary> The URL of this resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private ComplianceInquiriesResource() {

        }
    }
}

