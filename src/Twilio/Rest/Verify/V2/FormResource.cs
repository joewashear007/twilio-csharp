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


namespace Twilio.Rest.Verify.V2
{
    public class FormResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class FormTypesEnum : StringEnum
        {
            private FormTypesEnum(string value) : base(value) {}
            public FormTypesEnum() {}
            public static implicit operator FormTypesEnum(string value)
            {
                return new FormTypesEnum(value);
            }
            public static readonly FormTypesEnum FormPush = new FormTypesEnum("form-push");

        }

        
        private static Request BuildFetchRequest(FetchFormOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Forms/{FormType}";

            string PathFormType = options.PathFormType.ToString();
            path = path.Replace("{"+"FormType"+"}", PathFormType);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Verify,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch the forms for a specific Form Type. </summary>
        /// <param name="options"> Fetch Form parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Form </returns>
        public static FormResource Fetch(FetchFormOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch the forms for a specific Form Type. </summary>
        /// <param name="options"> Fetch Form parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Form </returns>
        public static async System.Threading.Tasks.Task<FormResource> FetchAsync(FetchFormOptions options, ITwilioRestClient client = null,  System.Threading.CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch the forms for a specific Form Type. </summary>
        /// <param name="pathFormType"> The Type of this Form. Currently only `form-push` is supported. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Form </returns>
        public static FormResource Fetch(
                                         FormResource.FormTypesEnum pathFormType, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchFormOptions(pathFormType){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch the forms for a specific Form Type. </summary>
        /// <param name="pathFormType"> The Type of this Form. Currently only `form-push` is supported. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Form </returns>
        public static async System.Threading.Tasks.Task<FormResource> FetchAsync(FormResource.FormTypesEnum pathFormType, ITwilioRestClient client = null , System.Threading.CancellationToken cancellationToken = default)
        {
            var options = new FetchFormOptions(pathFormType){  };
            return await FetchAsync(options, client, cancellationToken);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a FormResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FormResource object represented by the provided JSON </returns>
        public static FormResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<FormResource>(json);
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

    
        
        [JsonProperty("form_type")]
        public FormResource.FormTypesEnum FormType { get; private set; }

        ///<summary> Object that contains the available forms for this type. This available forms are given in the standard [JSON Schema](https://json-schema.org/) format </summary> 
        [JsonProperty("forms")]
        public object Forms { get; private set; }

        ///<summary> Additional information for the available forms for this type. E.g. The separator string used for `binding` in a Factor push. </summary> 
        [JsonProperty("form_meta")]
        public object FormMeta { get; private set; }

        ///<summary> The URL to access the forms for this type. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private FormResource() {

        }
    }
}

