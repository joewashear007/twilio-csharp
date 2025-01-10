/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Microvisor
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



namespace Twilio.Rest.Microvisor.V1.App
{
    public class AppManifestResource : Resource
    {
    

    

        
        private static Request BuildFetchRequest(FetchAppManifestOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Apps/{AppSid}/Manifest";

            string PathAppSid = options.PathAppSid;
            path = path.Replace("{"+"AppSid"+"}", PathAppSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Microvisor,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Retrieve the Manifest for an App. </summary>
        /// <param name="options"> Fetch AppManifest parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AppManifest </returns>
        public static AppManifestResource Fetch(FetchAppManifestOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Retrieve the Manifest for an App. </summary>
        /// <param name="options"> Fetch AppManifest parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AppManifest </returns>
        public static async System.Threading.Tasks.Task<AppManifestResource> FetchAsync(FetchAppManifestOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Retrieve the Manifest for an App. </summary>
        /// <param name="pathAppSid"> A 34-character string that uniquely identifies this App. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AppManifest </returns>
        public static AppManifestResource Fetch(
                                         string pathAppSid, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchAppManifestOptions(pathAppSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Retrieve the Manifest for an App. </summary>
        /// <param name="pathAppSid"> A 34-character string that uniquely identifies this App. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AppManifest </returns>
        public static async System.Threading.Tasks.Task<AppManifestResource> FetchAsync(string pathAppSid, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            var options = new FetchAppManifestOptions(pathAppSid){  };
            return await FetchAsync(options, client, cancellationToken);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a AppManifestResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AppManifestResource object represented by the provided JSON </returns>
        public static AppManifestResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AppManifestResource>(json);
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

    
        ///<summary> A 34-character string that uniquely identifies this App. </summary> 
        [JsonProperty("app_sid")]
        public string AppSid { get; private set; }

        ///<summary> App manifest hash represented as `hash_algorithm:hash_value`. </summary> 
        [JsonProperty("hash")]
        public string Hash { get; private set; }

        ///<summary> The base-64 encoded manifest </summary> 
        [JsonProperty("encoded_bytes")]
        public string EncodedBytes { get; private set; }

        ///<summary> The absolute URL of this Manifest. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private AppManifestResource() {

        }
    }
}

