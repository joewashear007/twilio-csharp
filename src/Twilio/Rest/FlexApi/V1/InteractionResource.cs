/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
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



namespace Twilio.Rest.FlexApi.V1
{
    public class InteractionResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateInteractionOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Interactions";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Interaction. </summary>
        /// <param name="options"> Create Interaction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Interaction </returns>
        public static InteractionResource Create(CreateInteractionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Interaction. </summary>
        /// <param name="options"> Create Interaction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Interaction </returns>
        public static async System.Threading.Tasks.Task<InteractionResource> CreateAsync(CreateInteractionOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Interaction. </summary>
        /// <param name="channel"> The Interaction's channel. </param>
        /// <param name="routing"> The Interaction's routing logic. </param>
        /// <param name="interactionContextSid"> The Interaction context sid is used for adding a context lookup sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Interaction </returns>
        public static InteractionResource Create(
                                          object channel,
                                          object routing = null,
                                          string interactionContextSid = null,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateInteractionOptions(channel){  Routing = routing, InteractionContextSid = interactionContextSid };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Interaction. </summary>
        /// <param name="channel"> The Interaction's channel. </param>
        /// <param name="routing"> The Interaction's routing logic. </param>
        /// <param name="interactionContextSid"> The Interaction context sid is used for adding a context lookup sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Interaction </returns>
        public static async System.Threading.Tasks.Task<InteractionResource> CreateAsync(
                                                                                  object channel,
                                                                                  object routing = null,
                                                                                  string interactionContextSid = null,
                                                                                    ITwilioRestClient client = null)
        {
        var options = new CreateInteractionOptions(channel){  Routing = routing, InteractionContextSid = interactionContextSid };
            return await CreateAsync(options, client, cancellationToken);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchInteractionOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Interactions/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Interaction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Interaction </returns>
        public static InteractionResource Fetch(FetchInteractionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Interaction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Interaction </returns>
        public static async System.Threading.Tasks.Task<InteractionResource> FetchAsync(FetchInteractionOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The SID of the Interaction resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Interaction </returns>
        public static InteractionResource Fetch(
                                         string pathSid, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchInteractionOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The SID of the Interaction resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Interaction </returns>
        public static async System.Threading.Tasks.Task<InteractionResource> FetchAsync(string pathSid, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            var options = new FetchInteractionOptions(pathSid){  };
            return await FetchAsync(options, client, cancellationToken);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a InteractionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> InteractionResource object represented by the provided JSON </returns>
        public static InteractionResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<InteractionResource>(json);
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

    
        ///<summary> The unique string created by Twilio to identify an Interaction resource, prefixed with KD. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> A JSON object that defines the Interaction’s communication channel and includes details about the channel. See the [Outbound SMS](https://www.twilio.com/docs/flex/developer/conversations/interactions-api/interactions#agent-initiated-outbound-interactions) and [inbound (API-initiated)](https://www.twilio.com/docs/flex/developer/conversations/interactions-api/interactions#api-initiated-contact) Channel object examples. </summary> 
        [JsonProperty("channel")]
        public object Channel { get; private set; }

        ///<summary> A JSON Object representing the routing rules for the Interaction Channel. See [Outbound SMS Example](https://www.twilio.com/docs/flex/developer/conversations/interactions-api/interactions#agent-initiated-outbound-interactions) for an example Routing object. The Interactions resource uses TaskRouter for all routing functionality.   All attributes in the Routing object on your Interaction request body are added “as is” to the task. For a list of known attributes consumed by the Flex UI and/or Flex Insights, see [Known Task Attributes](https://www.twilio.com/docs/flex/developer/conversations/interactions-api#task-attributes). </summary> 
        [JsonProperty("routing")]
        public object Routing { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The links </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        ///<summary> The interaction_context_sid </summary> 
        [JsonProperty("interaction_context_sid")]
        public string InteractionContextSid { get; private set; }



        private InteractionResource() {

        }
    }
}

