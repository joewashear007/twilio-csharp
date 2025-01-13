/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Verify
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


namespace Twilio.Rest.Verify.V2.Service.Entity
{
    public class NewFactorResource : Resource
    {
    

    
        public sealed class NotificationPlatformsEnum : StringEnum
        {
            private NotificationPlatformsEnum(string value) : base(value) {}
            public NotificationPlatformsEnum() {}
            public static implicit operator NotificationPlatformsEnum(string value)
            {
                return new NotificationPlatformsEnum(value);
            }
            public static readonly NotificationPlatformsEnum Apn = new NotificationPlatformsEnum("apn");
            public static readonly NotificationPlatformsEnum Fcm = new NotificationPlatformsEnum("fcm");
            public static readonly NotificationPlatformsEnum None = new NotificationPlatformsEnum("none");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class FactorTypesEnum : StringEnum
        {
            private FactorTypesEnum(string value) : base(value) {}
            public FactorTypesEnum() {}
            public static implicit operator FactorTypesEnum(string value)
            {
                return new FactorTypesEnum(value);
            }
            public static readonly FactorTypesEnum Push = new FactorTypesEnum("push");
            public static readonly FactorTypesEnum Totp = new FactorTypesEnum("totp");

        }
        public sealed class TotpAlgorithmsEnum : StringEnum
        {
            private TotpAlgorithmsEnum(string value) : base(value) {}
            public TotpAlgorithmsEnum() {}
            public static implicit operator TotpAlgorithmsEnum(string value)
            {
                return new TotpAlgorithmsEnum(value);
            }
            public static readonly TotpAlgorithmsEnum Sha1 = new TotpAlgorithmsEnum("sha1");
            public static readonly TotpAlgorithmsEnum Sha256 = new TotpAlgorithmsEnum("sha256");
            public static readonly TotpAlgorithmsEnum Sha512 = new TotpAlgorithmsEnum("sha512");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class FactorStatusesEnum : StringEnum
        {
            private FactorStatusesEnum(string value) : base(value) {}
            public FactorStatusesEnum() {}
            public static implicit operator FactorStatusesEnum(string value)
            {
                return new FactorStatusesEnum(value);
            }
            public static readonly FactorStatusesEnum Unverified = new FactorStatusesEnum("unverified");
            public static readonly FactorStatusesEnum Verified = new FactorStatusesEnum("verified");

        }

        
        private static Request BuildCreateRequest(CreateNewFactorOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Entities/{Identity}/Factors";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathIdentity = options.PathIdentity;
            path = path.Replace("{"+"Identity"+"}", PathIdentity);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Factor for the Entity </summary>
        /// <param name="options"> Create NewFactor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NewFactor </returns>
        public static NewFactorResource Create(CreateNewFactorOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Factor for the Entity </summary>
        /// <param name="options"> Create NewFactor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NewFactor </returns>
        public static async System.Threading.Tasks.Task<NewFactorResource> CreateAsync(CreateNewFactorOptions options, ITwilioRestClient client = null,  System.Threading.CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Factor for the Entity </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>
        /// <param name="friendlyName"> The friendly name of this Factor. This can be any string up to 64 characters, meant for humans to distinguish between Factors. For `factor_type` `push`, this could be a device name. For `factor_type` `totp`, this value is used as the “account name” in constructing the `binding.uri` property. At the same time, we recommend avoiding providing PII. </param>
        /// <param name="factorType">  </param>
        /// <param name="bindingAlg"> The algorithm used when `factor_type` is `push`. Algorithm supported: `ES256` </param>
        /// <param name="bindingPublicKey"> The Ecdsa public key in PKIX, ASN.1 DER format encoded in Base64.  Required when `factor_type` is `push` </param>
        /// <param name="configAppId"> The ID that uniquely identifies your app in the Google or Apple store, such as `com.example.myapp`. It can be up to 100 characters long.  Required when `factor_type` is `push`. </param>
        /// <param name="configNotificationPlatform">  </param>
        /// <param name="configNotificationToken"> For APN, the device token. For FCM, the registration token. It is used to send the push notifications. Must be between 32 and 255 characters long.  Required when `factor_type` is `push`. </param>
        /// <param name="configSdkVersion"> The Verify Push SDK version used to configure the factor  Required when `factor_type` is `push` </param>
        /// <param name="bindingSecret"> The shared secret for TOTP factors encoded in Base32. This can be provided when creating the Factor, otherwise it will be generated.  Used when `factor_type` is `totp` </param>
        /// <param name="configTimeStep"> Defines how often, in seconds, are TOTP codes generated. i.e, a new TOTP code is generated every time_step seconds. Must be between 20 and 60 seconds, inclusive. The default value is defined at the service level in the property `totp.time_step`. Defaults to 30 seconds if not configured.  Used when `factor_type` is `totp` </param>
        /// <param name="configSkew"> The number of time-steps, past and future, that are valid for validation of TOTP codes. Must be between 0 and 2, inclusive. The default value is defined at the service level in the property `totp.skew`. If not configured defaults to 1.  Used when `factor_type` is `totp` </param>
        /// <param name="configCodeLength"> Number of digits for generated TOTP codes. Must be between 3 and 8, inclusive. The default value is defined at the service level in the property `totp.code_length`. If not configured defaults to 6.  Used when `factor_type` is `totp` </param>
        /// <param name="configAlg">  </param>
        /// <param name="metadata"> Custom metadata associated with the factor. This is added by the Device/SDK directly to allow for the inclusion of device information. It must be a stringified JSON with only strings values eg. `{\\\"os\\\": \\\"Android\\\"}`. Can be up to 1024 characters in length. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NewFactor </returns>
        public static NewFactorResource Create(
                                          string pathServiceSid,
                                          string pathIdentity,
                                          string friendlyName,
                                          NewFactorResource.FactorTypesEnum factorType,
                                          string bindingAlg = null,
                                          string bindingPublicKey = null,
                                          string configAppId = null,
                                          NewFactorResource.NotificationPlatformsEnum configNotificationPlatform = null,
                                          string configNotificationToken = null,
                                          string configSdkVersion = null,
                                          string bindingSecret = null,
                                          int? configTimeStep = null,
                                          int? configSkew = null,
                                          int? configCodeLength = null,
                                          NewFactorResource.TotpAlgorithmsEnum configAlg = null,
                                          object metadata = null,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateNewFactorOptions(pathServiceSid, pathIdentity, friendlyName, factorType){  BindingAlg = bindingAlg, BindingPublicKey = bindingPublicKey, ConfigAppId = configAppId, ConfigNotificationPlatform = configNotificationPlatform, ConfigNotificationToken = configNotificationToken, ConfigSdkVersion = configSdkVersion, BindingSecret = bindingSecret, ConfigTimeStep = configTimeStep, ConfigSkew = configSkew, ConfigCodeLength = configCodeLength, ConfigAlg = configAlg, Metadata = metadata };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Factor for the Entity </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>
        /// <param name="friendlyName"> The friendly name of this Factor. This can be any string up to 64 characters, meant for humans to distinguish between Factors. For `factor_type` `push`, this could be a device name. For `factor_type` `totp`, this value is used as the “account name” in constructing the `binding.uri` property. At the same time, we recommend avoiding providing PII. </param>
        /// <param name="factorType">  </param>
        /// <param name="bindingAlg"> The algorithm used when `factor_type` is `push`. Algorithm supported: `ES256` </param>
        /// <param name="bindingPublicKey"> The Ecdsa public key in PKIX, ASN.1 DER format encoded in Base64.  Required when `factor_type` is `push` </param>
        /// <param name="configAppId"> The ID that uniquely identifies your app in the Google or Apple store, such as `com.example.myapp`. It can be up to 100 characters long.  Required when `factor_type` is `push`. </param>
        /// <param name="configNotificationPlatform">  </param>
        /// <param name="configNotificationToken"> For APN, the device token. For FCM, the registration token. It is used to send the push notifications. Must be between 32 and 255 characters long.  Required when `factor_type` is `push`. </param>
        /// <param name="configSdkVersion"> The Verify Push SDK version used to configure the factor  Required when `factor_type` is `push` </param>
        /// <param name="bindingSecret"> The shared secret for TOTP factors encoded in Base32. This can be provided when creating the Factor, otherwise it will be generated.  Used when `factor_type` is `totp` </param>
        /// <param name="configTimeStep"> Defines how often, in seconds, are TOTP codes generated. i.e, a new TOTP code is generated every time_step seconds. Must be between 20 and 60 seconds, inclusive. The default value is defined at the service level in the property `totp.time_step`. Defaults to 30 seconds if not configured.  Used when `factor_type` is `totp` </param>
        /// <param name="configSkew"> The number of time-steps, past and future, that are valid for validation of TOTP codes. Must be between 0 and 2, inclusive. The default value is defined at the service level in the property `totp.skew`. If not configured defaults to 1.  Used when `factor_type` is `totp` </param>
        /// <param name="configCodeLength"> Number of digits for generated TOTP codes. Must be between 3 and 8, inclusive. The default value is defined at the service level in the property `totp.code_length`. If not configured defaults to 6.  Used when `factor_type` is `totp` </param>
        /// <param name="configAlg">  </param>
        /// <param name="metadata"> Custom metadata associated with the factor. This is added by the Device/SDK directly to allow for the inclusion of device information. It must be a stringified JSON with only strings values eg. `{\\\"os\\\": \\\"Android\\\"}`. Can be up to 1024 characters in length. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NewFactor </returns>
        public static async System.Threading.Tasks.Task<NewFactorResource> CreateAsync(
                                                                                  string pathServiceSid,
                                                                                  string pathIdentity,
                                                                                  string friendlyName,
                                                                                  NewFactorResource.FactorTypesEnum factorType,
                                                                                  string bindingAlg = null,
                                                                                  string bindingPublicKey = null,
                                                                                  string configAppId = null,
                                                                                  NewFactorResource.NotificationPlatformsEnum configNotificationPlatform = null,
                                                                                  string configNotificationToken = null,
                                                                                  string configSdkVersion = null,
                                                                                  string bindingSecret = null,
                                                                                  int? configTimeStep = null,
                                                                                  int? configSkew = null,
                                                                                  int? configCodeLength = null,
                                                                                  NewFactorResource.TotpAlgorithmsEnum configAlg = null,
                                                                                  object metadata = null,
                                                                                    ITwilioRestClient client = null , System.Threading.CancellationToken cancellationToken = default)
        {
        var options = new CreateNewFactorOptions(pathServiceSid, pathIdentity, friendlyName, factorType){  BindingAlg = bindingAlg, BindingPublicKey = bindingPublicKey, ConfigAppId = configAppId, ConfigNotificationPlatform = configNotificationPlatform, ConfigNotificationToken = configNotificationToken, ConfigSdkVersion = configSdkVersion, BindingSecret = bindingSecret, ConfigTimeStep = configTimeStep, ConfigSkew = configSkew, ConfigCodeLength = configCodeLength, ConfigAlg = configAlg, Metadata = metadata };
            return await CreateAsync(options, client, cancellationToken);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a NewFactorResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> NewFactorResource object represented by the provided JSON </returns>
        public static NewFactorResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<NewFactorResource>(json);
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

    
        ///<summary> A 34 character string that uniquely identifies this Factor. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique SID identifier of the Account. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique SID identifier of the Service. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The unique SID identifier of the Entity. </summary> 
        [JsonProperty("entity_sid")]
        public string EntitySid { get; private set; }

        ///<summary> Customer unique identity for the Entity owner of the Factor. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </summary> 
        [JsonProperty("identity")]
        public string Identity { get; private set; }

        ///<summary> Contains the `factor_type` specific secret and metadata. For push, this is `binding.public_key` and `binding.alg`. For totp, this is `binding.secret` and `binding.uri`. The `binding.uri` property is generated following the [google authenticator key URI format](https://github.com/google/google-authenticator/wiki/Key-Uri-Format), and `Factor.friendly_name` is used for the “accountname” value and `Service.friendly_name` or `Service.totp.issuer` is used for the `issuer` value.   The Binding property is ONLY returned upon Factor creation. </summary> 
        [JsonProperty("binding")]
        public object Binding { get; private set; }

        ///<summary> The date that this Factor was created, given in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this Factor was updated, given in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The friendly name of this Factor. This can be any string up to 64 characters, meant for humans to distinguish between Factors. For `factor_type` `push`, this could be a device name. For `factor_type` `totp`, this value is used as the “account name” in constructing the `binding.uri` property. At the same time, we recommend avoiding providing PII. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        
        [JsonProperty("status")]
        public NewFactorResource.FactorStatusesEnum Status { get; private set; }

        
        [JsonProperty("factor_type")]
        public NewFactorResource.FactorTypesEnum FactorType { get; private set; }

        ///<summary> An object that contains configurations specific to a `factor_type`. </summary> 
        [JsonProperty("config")]
        public object Config { get; private set; }

        ///<summary> Custom metadata associated with the factor. This is added by the Device/SDK directly to allow for the inclusion of device information. It must be a stringified JSON with only strings values eg. `{\"os\": \"Android\"}`. Can be up to 1024 characters in length. </summary> 
        [JsonProperty("metadata")]
        public object Metadata { get; private set; }

        ///<summary> The URL of this resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private NewFactorResource() {

        }
    }
}

