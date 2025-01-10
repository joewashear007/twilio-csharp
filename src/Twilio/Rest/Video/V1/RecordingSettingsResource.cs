/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Video
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



namespace Twilio.Rest.Video.V1
{
    public class RecordingSettingsResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateRecordingSettingsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/RecordingSettings/Default";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Video,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create RecordingSettings parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RecordingSettings </returns>
        public static RecordingSettingsResource Create(CreateRecordingSettingsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create RecordingSettings parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RecordingSettings </returns>
        public static async System.Threading.Tasks.Task<RecordingSettingsResource> CreateAsync(CreateRecordingSettingsOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource and be shown to users in the console </param>
        /// <param name="awsCredentialsSid"> The SID of the stored Credential resource. </param>
        /// <param name="encryptionKeySid"> The SID of the Public Key resource to use for encryption. </param>
        /// <param name="awsS3Url"> The URL of the AWS S3 bucket where the recordings should be stored. We only support DNS-compliant URLs like `https://documentation-example-twilio-bucket/recordings`, where `recordings` is the path in which you want the recordings to be stored. This URL accepts only URI-valid characters, as described in the [RFC 3986](https://tools.ietf.org/html/rfc3986#section-2). </param>
        /// <param name="awsStorageEnabled"> Whether all recordings should be written to the `aws_s3_url`. When `false`, all recordings are stored in our cloud. </param>
        /// <param name="encryptionEnabled"> Whether all recordings should be stored in an encrypted form. The default is `false`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RecordingSettings </returns>
        public static RecordingSettingsResource Create(
                                          string friendlyName,
                                          string awsCredentialsSid = null,
                                          string encryptionKeySid = null,
                                          Uri awsS3Url = null,
                                          bool? awsStorageEnabled = null,
                                          bool? encryptionEnabled = null,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateRecordingSettingsOptions(friendlyName){  AwsCredentialsSid = awsCredentialsSid, EncryptionKeySid = encryptionKeySid, AwsS3Url = awsS3Url, AwsStorageEnabled = awsStorageEnabled, EncryptionEnabled = encryptionEnabled };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource and be shown to users in the console </param>
        /// <param name="awsCredentialsSid"> The SID of the stored Credential resource. </param>
        /// <param name="encryptionKeySid"> The SID of the Public Key resource to use for encryption. </param>
        /// <param name="awsS3Url"> The URL of the AWS S3 bucket where the recordings should be stored. We only support DNS-compliant URLs like `https://documentation-example-twilio-bucket/recordings`, where `recordings` is the path in which you want the recordings to be stored. This URL accepts only URI-valid characters, as described in the [RFC 3986](https://tools.ietf.org/html/rfc3986#section-2). </param>
        /// <param name="awsStorageEnabled"> Whether all recordings should be written to the `aws_s3_url`. When `false`, all recordings are stored in our cloud. </param>
        /// <param name="encryptionEnabled"> Whether all recordings should be stored in an encrypted form. The default is `false`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RecordingSettings </returns>
        public static async System.Threading.Tasks.Task<RecordingSettingsResource> CreateAsync(
                                                                                  string friendlyName,
                                                                                  string awsCredentialsSid = null,
                                                                                  string encryptionKeySid = null,
                                                                                  Uri awsS3Url = null,
                                                                                  bool? awsStorageEnabled = null,
                                                                                  bool? encryptionEnabled = null,
                                                                                    ITwilioRestClient client = null)
        {
        var options = new CreateRecordingSettingsOptions(friendlyName){  AwsCredentialsSid = awsCredentialsSid, EncryptionKeySid = encryptionKeySid, AwsS3Url = awsS3Url, AwsStorageEnabled = awsStorageEnabled, EncryptionEnabled = encryptionEnabled };
            return await CreateAsync(options, client, cancellationToken);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchRecordingSettingsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/RecordingSettings/Default";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch RecordingSettings parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RecordingSettings </returns>
        public static RecordingSettingsResource Fetch(FetchRecordingSettingsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch RecordingSettings parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RecordingSettings </returns>
        public static async System.Threading.Tasks.Task<RecordingSettingsResource> FetchAsync(FetchRecordingSettingsOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RecordingSettings </returns>
        public static RecordingSettingsResource Fetch(
                                        ITwilioRestClient client = null)
        {
            var options = new FetchRecordingSettingsOptions(){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RecordingSettings </returns>
        public static async System.Threading.Tasks.Task<RecordingSettingsResource> FetchAsync(ITwilioRestClient client = null, CancellationToken cancellationToken = default)
        {
            var options = new FetchRecordingSettingsOptions(){  };
            return await FetchAsync(options, client, cancellationToken);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a RecordingSettingsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> RecordingSettingsResource object represented by the provided JSON </returns>
        public static RecordingSettingsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<RecordingSettingsResource>(json);
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

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the RecordingSettings resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The string that you assigned to describe the resource and show the user in the console </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The SID of the stored Credential resource. </summary> 
        [JsonProperty("aws_credentials_sid")]
        public string AwsCredentialsSid { get; private set; }

        ///<summary> The URL of the AWS S3 bucket where the recordings are stored. We only support DNS-compliant URLs like `https://documentation-example-twilio-bucket/recordings`, where `recordings` is the path in which you want the recordings to be stored. This URL accepts only URI-valid characters, as described in the [RFC 3986](https://tools.ietf.org/html/rfc3986#section-2). </summary> 
        [JsonProperty("aws_s3_url")]
        public Uri AwsS3Url { get; private set; }

        ///<summary> Whether all recordings are written to the `aws_s3_url`. When `false`, all recordings are stored in our cloud. </summary> 
        [JsonProperty("aws_storage_enabled")]
        public bool? AwsStorageEnabled { get; private set; }

        ///<summary> The SID of the Public Key resource used for encryption. </summary> 
        [JsonProperty("encryption_key_sid")]
        public string EncryptionKeySid { get; private set; }

        ///<summary> Whether all recordings are stored in an encrypted form. The default is `false`. </summary> 
        [JsonProperty("encryption_enabled")]
        public bool? EncryptionEnabled { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private RecordingSettingsResource() {

        }
    }
}

