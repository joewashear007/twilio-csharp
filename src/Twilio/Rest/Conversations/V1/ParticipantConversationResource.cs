/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Conversations
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


namespace Twilio.Rest.Conversations.V1
{
    public class ParticipantConversationResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StateEnum : StringEnum
        {
            private StateEnum(string value) : base(value) {}
            public StateEnum() {}
            public static implicit operator StateEnum(string value)
            {
                return new StateEnum(value);
            }
            public static readonly StateEnum Inactive = new StateEnum("inactive");
            public static readonly StateEnum Active = new StateEnum("active");
            public static readonly StateEnum Closed = new StateEnum("closed");

        }

        
        private static Request BuildReadRequest(ReadParticipantConversationOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/ParticipantConversations";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Conversations,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Conversations that this Participant belongs to by identity or by address. Only one parameter should be specified. </summary>
        /// <param name="options"> Read ParticipantConversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ParticipantConversation </returns>
        public static ResourceSet<ParticipantConversationResource> Read(ReadParticipantConversationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<ParticipantConversationResource>.FromJson("conversations", response.Content);
            return new ResourceSet<ParticipantConversationResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Conversations that this Participant belongs to by identity or by address. Only one parameter should be specified. </summary>
        /// <param name="options"> Read ParticipantConversation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ParticipantConversation </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ParticipantConversationResource>> ReadAsync(ReadParticipantConversationOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client), cancellationToken);

            var page = Page<ParticipantConversationResource>.FromJson("conversations", response.Content);
            return new ResourceSet<ParticipantConversationResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Conversations that this Participant belongs to by identity or by address. Only one parameter should be specified. </summary>
        /// <param name="identity"> A unique string identifier for the conversation participant as [Conversation User](https://www.twilio.com/docs/conversations/api/user-resource). This parameter is non-null if (and only if) the participant is using the Conversations SDK to communicate. Limited to 256 characters. </param>
        /// <param name="address"> A unique string identifier for the conversation participant who's not a Conversation User. This parameter could be found in messaging_binding.address field of Participant resource. It should be url-encoded. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ParticipantConversation </returns>
        public static ResourceSet<ParticipantConversationResource> Read(
                                                     string identity = null,
                                                     string address = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadParticipantConversationOptions(){ Identity = identity, Address = address, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Conversations that this Participant belongs to by identity or by address. Only one parameter should be specified. </summary>
        /// <param name="identity"> A unique string identifier for the conversation participant as [Conversation User](https://www.twilio.com/docs/conversations/api/user-resource). This parameter is non-null if (and only if) the participant is using the Conversations SDK to communicate. Limited to 256 characters. </param>
        /// <param name="address"> A unique string identifier for the conversation participant who's not a Conversation User. This parameter could be found in messaging_binding.address field of Participant resource. It should be url-encoded. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ParticipantConversation </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ParticipantConversationResource>> ReadAsync(
                                                                                             string identity = null,
                                                                                             string address = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadParticipantConversationOptions(){ Identity = identity, Address = address, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client, cancellationToken);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<ParticipantConversationResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ParticipantConversationResource>.FromJson("conversations", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<ParticipantConversationResource> NextPage(Page<ParticipantConversationResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ParticipantConversationResource>.FromJson("conversations", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<ParticipantConversationResource> PreviousPage(Page<ParticipantConversationResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ParticipantConversationResource>.FromJson("conversations", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a ParticipantConversationResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ParticipantConversationResource object represented by the provided JSON </returns>
        public static ParticipantConversationResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ParticipantConversationResource>(json);
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

    
        ///<summary> The unique ID of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this conversation. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique ID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) this conversation belongs to. </summary> 
        [JsonProperty("chat_service_sid")]
        public string ChatServiceSid { get; private set; }

        ///<summary> The unique ID of the [Participant](https://www.twilio.com/docs/conversations/api/conversation-participant-resource). </summary> 
        [JsonProperty("participant_sid")]
        public string ParticipantSid { get; private set; }

        ///<summary> The unique string that identifies the conversation participant as [Conversation User](https://www.twilio.com/docs/conversations/api/user-resource). </summary> 
        [JsonProperty("participant_user_sid")]
        public string ParticipantUserSid { get; private set; }

        ///<summary> A unique string identifier for the conversation participant as [Conversation User](https://www.twilio.com/docs/conversations/api/user-resource). This parameter is non-null if (and only if) the participant is using the Conversations SDK to communicate. Limited to 256 characters. </summary> 
        [JsonProperty("participant_identity")]
        public string ParticipantIdentity { get; private set; }

        ///<summary> Information about how this participant exchanges messages with the conversation. A JSON parameter consisting of type and address fields of the participant. </summary> 
        [JsonProperty("participant_messaging_binding")]
        public object ParticipantMessagingBinding { get; private set; }

        ///<summary> The unique ID of the [Conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) this Participant belongs to. </summary> 
        [JsonProperty("conversation_sid")]
        public string ConversationSid { get; private set; }

        ///<summary> An application-defined string that uniquely identifies the Conversation resource. </summary> 
        [JsonProperty("conversation_unique_name")]
        public string ConversationUniqueName { get; private set; }

        ///<summary> The human-readable name of this conversation, limited to 256 characters. Optional. </summary> 
        [JsonProperty("conversation_friendly_name")]
        public string ConversationFriendlyName { get; private set; }

        ///<summary> An optional string metadata field you can use to store any data you wish. The string value must contain structurally valid JSON if specified.  **Note** that if the attributes are not set \"{}\" will be returned. </summary> 
        [JsonProperty("conversation_attributes")]
        public string ConversationAttributes { get; private set; }

        ///<summary> The date that this conversation was created, given in ISO 8601 format. </summary> 
        [JsonProperty("conversation_date_created")]
        public DateTime? ConversationDateCreated { get; private set; }

        ///<summary> The date that this conversation was last updated, given in ISO 8601 format. </summary> 
        [JsonProperty("conversation_date_updated")]
        public DateTime? ConversationDateUpdated { get; private set; }

        ///<summary> Identity of the creator of this Conversation. </summary> 
        [JsonProperty("conversation_created_by")]
        public string ConversationCreatedBy { get; private set; }

        
        [JsonProperty("conversation_state")]
        public ParticipantConversationResource.StateEnum ConversationState { get; private set; }

        ///<summary> Timer date values representing state update for this conversation. </summary> 
        [JsonProperty("conversation_timers")]
        public object ConversationTimers { get; private set; }

        ///<summary> Contains absolute URLs to access the [participant](https://www.twilio.com/docs/conversations/api/conversation-participant-resource) and [conversation](https://www.twilio.com/docs/conversations/api/conversation-resource) of this conversation. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private ParticipantConversationResource() {

        }
    }
}

