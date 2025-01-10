/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Events
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



namespace Twilio.Rest.Events.V1.Sink
{
    public class SinkTestResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateSinkTestOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Sinks/{Sid}/Test";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Events,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Sink Test Event for the given Sink. </summary>
        /// <param name="options"> Create SinkTest parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SinkTest </returns>
        public static SinkTestResource Create(CreateSinkTestOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Sink Test Event for the given Sink. </summary>
        /// <param name="options"> Create SinkTest parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SinkTest </returns>
        public static async System.Threading.Tasks.Task<SinkTestResource> CreateAsync(CreateSinkTestOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Sink Test Event for the given Sink. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the Sink to be Tested. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SinkTest </returns>
        public static SinkTestResource Create(
                                          string pathSid,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateSinkTestOptions(pathSid){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Sink Test Event for the given Sink. </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the Sink to be Tested. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SinkTest </returns>
        public static async System.Threading.Tasks.Task<SinkTestResource> CreateAsync(
                                                                                  string pathSid,
                                                                                    ITwilioRestClient client = null)
        {
        var options = new CreateSinkTestOptions(pathSid){  };
            return await CreateAsync(options, client, cancellationToken);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a SinkTestResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SinkTestResource object represented by the provided JSON </returns>
        public static SinkTestResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SinkTestResource>(json);
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

    
        ///<summary> Feedback indicating whether the test event was generated. </summary> 
        [JsonProperty("result")]
        public string Result { get; private set; }



        private SinkTestResource() {

        }
    }
}

