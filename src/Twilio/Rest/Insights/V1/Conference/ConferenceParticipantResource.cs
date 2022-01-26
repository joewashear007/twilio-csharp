/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// ConferenceParticipantResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Insights.V1.Conference
{

    public class ConferenceParticipantResource : Resource
    {
        public sealed class CallDirectionEnum : StringEnum
        {
            private CallDirectionEnum(string value) : base(value) {}
            public CallDirectionEnum() {}
            public static implicit operator CallDirectionEnum(string value)
            {
                return new CallDirectionEnum(value);
            }

            public static readonly CallDirectionEnum Inbound = new CallDirectionEnum("inbound");
            public static readonly CallDirectionEnum Outbound = new CallDirectionEnum("outbound");
        }

        public sealed class CallStateEnum : StringEnum
        {
            private CallStateEnum(string value) : base(value) {}
            public CallStateEnum() {}
            public static implicit operator CallStateEnum(string value)
            {
                return new CallStateEnum(value);
            }

            public static readonly CallStateEnum Answered = new CallStateEnum("answered");
            public static readonly CallStateEnum Completed = new CallStateEnum("completed");
            public static readonly CallStateEnum Busy = new CallStateEnum("busy");
            public static readonly CallStateEnum Fail = new CallStateEnum("fail");
            public static readonly CallStateEnum Noanswer = new CallStateEnum("noanswer");
            public static readonly CallStateEnum Ringing = new CallStateEnum("ringing");
            public static readonly CallStateEnum Canceled = new CallStateEnum("canceled");
        }

        public sealed class JitterBufferSizeEnum : StringEnum
        {
            private JitterBufferSizeEnum(string value) : base(value) {}
            public JitterBufferSizeEnum() {}
            public static implicit operator JitterBufferSizeEnum(string value)
            {
                return new JitterBufferSizeEnum(value);
            }

            public static readonly JitterBufferSizeEnum Large = new JitterBufferSizeEnum("large");
            public static readonly JitterBufferSizeEnum Small = new JitterBufferSizeEnum("small");
            public static readonly JitterBufferSizeEnum Medium = new JitterBufferSizeEnum("medium");
            public static readonly JitterBufferSizeEnum Off = new JitterBufferSizeEnum("off");
        }

        public sealed class RegionEnum : StringEnum
        {
            private RegionEnum(string value) : base(value) {}
            public RegionEnum() {}
            public static implicit operator RegionEnum(string value)
            {
                return new RegionEnum(value);
            }

            public static readonly RegionEnum Us1 = new RegionEnum("us1");
            public static readonly RegionEnum Us2 = new RegionEnum("us2");
            public static readonly RegionEnum Au1 = new RegionEnum("au1");
            public static readonly RegionEnum Br1 = new RegionEnum("br1");
            public static readonly RegionEnum Ie1 = new RegionEnum("ie1");
            public static readonly RegionEnum Jp1 = new RegionEnum("jp1");
            public static readonly RegionEnum Sg1 = new RegionEnum("sg1");
            public static readonly RegionEnum De1 = new RegionEnum("de1");
        }

        public sealed class CallTypeEnum : StringEnum
        {
            private CallTypeEnum(string value) : base(value) {}
            public CallTypeEnum() {}
            public static implicit operator CallTypeEnum(string value)
            {
                return new CallTypeEnum(value);
            }

            public static readonly CallTypeEnum Carrier = new CallTypeEnum("carrier");
            public static readonly CallTypeEnum Client = new CallTypeEnum("client");
            public static readonly CallTypeEnum Sip = new CallTypeEnum("sip");
        }

        private static Request BuildFetchRequest(FetchConferenceParticipantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Insights,
                "/v1/Conferences/" + options.PathConferenceSid + "/Participants/" + options.PathParticipantSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch ConferenceParticipant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConferenceParticipant </returns>
        public static ConferenceParticipantResource Fetch(FetchConferenceParticipantOptions options,
                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch ConferenceParticipant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConferenceParticipant </returns>
        public static async System.Threading.Tasks.Task<ConferenceParticipantResource> FetchAsync(FetchConferenceParticipantOptions options,
                                                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathConferenceSid"> The conference_sid </param>
        /// <param name="pathParticipantSid"> The participant_sid </param>
        /// <param name="events"> The events </param>
        /// <param name="metrics"> The metrics </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConferenceParticipant </returns>
        public static ConferenceParticipantResource Fetch(string pathConferenceSid,
                                                          string pathParticipantSid,
                                                          string events = null,
                                                          string metrics = null,
                                                          ITwilioRestClient client = null)
        {
            var options = new FetchConferenceParticipantOptions(pathConferenceSid, pathParticipantSid){Events = events, Metrics = metrics};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathConferenceSid"> The conference_sid </param>
        /// <param name="pathParticipantSid"> The participant_sid </param>
        /// <param name="events"> The events </param>
        /// <param name="metrics"> The metrics </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConferenceParticipant </returns>
        public static async System.Threading.Tasks.Task<ConferenceParticipantResource> FetchAsync(string pathConferenceSid,
                                                                                                  string pathParticipantSid,
                                                                                                  string events = null,
                                                                                                  string metrics = null,
                                                                                                  ITwilioRestClient client = null)
        {
            var options = new FetchConferenceParticipantOptions(pathConferenceSid, pathParticipantSid){Events = events, Metrics = metrics};
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadConferenceParticipantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Insights,
                "/v1/Conferences/" + options.PathConferenceSid + "/Participants",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read ConferenceParticipant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConferenceParticipant </returns>
        public static ResourceSet<ConferenceParticipantResource> Read(ReadConferenceParticipantOptions options,
                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<ConferenceParticipantResource>.FromJson("participants", response.Content);
            return new ResourceSet<ConferenceParticipantResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read ConferenceParticipant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConferenceParticipant </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ConferenceParticipantResource>> ReadAsync(ReadConferenceParticipantOptions options,
                                                                                                              ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ConferenceParticipantResource>.FromJson("participants", response.Content);
            return new ResourceSet<ConferenceParticipantResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathConferenceSid"> The conference_sid </param>
        /// <param name="participantSid"> The participant_sid </param>
        /// <param name="label"> The label </param>
        /// <param name="events"> The events </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ConferenceParticipant </returns>
        public static ResourceSet<ConferenceParticipantResource> Read(string pathConferenceSid,
                                                                      string participantSid = null,
                                                                      string label = null,
                                                                      string events = null,
                                                                      int? pageSize = null,
                                                                      long? limit = null,
                                                                      ITwilioRestClient client = null)
        {
            var options = new ReadConferenceParticipantOptions(pathConferenceSid){ParticipantSid = participantSid, Label = label, Events = events, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathConferenceSid"> The conference_sid </param>
        /// <param name="participantSid"> The participant_sid </param>
        /// <param name="label"> The label </param>
        /// <param name="events"> The events </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ConferenceParticipant </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ConferenceParticipantResource>> ReadAsync(string pathConferenceSid,
                                                                                                              string participantSid = null,
                                                                                                              string label = null,
                                                                                                              string events = null,
                                                                                                              int? pageSize = null,
                                                                                                              long? limit = null,
                                                                                                              ITwilioRestClient client = null)
        {
            var options = new ReadConferenceParticipantOptions(pathConferenceSid){ParticipantSid = participantSid, Label = label, Events = events, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<ConferenceParticipantResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ConferenceParticipantResource>.FromJson("participants", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<ConferenceParticipantResource> NextPage(Page<ConferenceParticipantResource> page,
                                                                   ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Insights)
            );

            var response = client.Request(request);
            return Page<ConferenceParticipantResource>.FromJson("participants", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<ConferenceParticipantResource> PreviousPage(Page<ConferenceParticipantResource> page,
                                                                       ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Insights)
            );

            var response = client.Request(request);
            return Page<ConferenceParticipantResource>.FromJson("participants", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a ConferenceParticipantResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ConferenceParticipantResource object represented by the provided JSON </returns>
        public static ConferenceParticipantResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ConferenceParticipantResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The participant_sid
        /// </summary>
        [JsonProperty("participant_sid")]
        public string ParticipantSid { get; private set; }
        /// <summary>
        /// The label
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; private set; }
        /// <summary>
        /// The conference_sid
        /// </summary>
        [JsonProperty("conference_sid")]
        public string ConferenceSid { get; private set; }
        /// <summary>
        /// The call_sid
        /// </summary>
        [JsonProperty("call_sid")]
        public string CallSid { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The call_direction
        /// </summary>
        [JsonProperty("call_direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConferenceParticipantResource.CallDirectionEnum CallDirection { get; private set; }
        /// <summary>
        /// The from
        /// </summary>
        [JsonProperty("from")]
        public string From { get; private set; }
        /// <summary>
        /// The to
        /// </summary>
        [JsonProperty("to")]
        public string To { get; private set; }
        /// <summary>
        /// The call_state
        /// </summary>
        [JsonProperty("call_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConferenceParticipantResource.CallStateEnum CallState { get; private set; }
        /// <summary>
        /// The country_code
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; private set; }
        /// <summary>
        /// The is_moderator
        /// </summary>
        [JsonProperty("is_moderator")]
        public bool? IsModerator { get; private set; }
        /// <summary>
        /// The join_time
        /// </summary>
        [JsonProperty("join_time")]
        public DateTime? JoinTime { get; private set; }
        /// <summary>
        /// The leave_time
        /// </summary>
        [JsonProperty("leave_time")]
        public DateTime? LeaveTime { get; private set; }
        /// <summary>
        /// The duration_seconds
        /// </summary>
        [JsonProperty("duration_seconds")]
        public int? DurationSeconds { get; private set; }
        /// <summary>
        /// The whisper
        /// </summary>
        [JsonProperty("whisper")]
        public string Whisper { get; private set; }
        /// <summary>
        /// The agent_audio
        /// </summary>
        [JsonProperty("agent_audio")]
        public bool? AgentAudio { get; private set; }
        /// <summary>
        /// The outbound_queue_length
        /// </summary>
        [JsonProperty("outbound_queue_length")]
        public int? OutboundQueueLength { get; private set; }
        /// <summary>
        /// The outbound_time_in_queue
        /// </summary>
        [JsonProperty("outbound_time_in_queue")]
        public int? OutboundTimeInQueue { get; private set; }
        /// <summary>
        /// The jitter_buffer_size
        /// </summary>
        [JsonProperty("jitter_buffer_size")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConferenceParticipantResource.JitterBufferSizeEnum JitterBufferSize { get; private set; }
        /// <summary>
        /// The is_coach
        /// </summary>
        [JsonProperty("is_coach")]
        public bool? IsCoach { get; private set; }
        /// <summary>
        /// The coached_participants
        /// </summary>
        [JsonProperty("coached_participants")]
        public List<string> CoachedParticipants { get; private set; }
        /// <summary>
        /// The participant_region
        /// </summary>
        [JsonProperty("participant_region")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConferenceParticipantResource.RegionEnum ParticipantRegion { get; private set; }
        /// <summary>
        /// The conference_region
        /// </summary>
        [JsonProperty("conference_region")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConferenceParticipantResource.RegionEnum ConferenceRegion { get; private set; }
        /// <summary>
        /// The call_type
        /// </summary>
        [JsonProperty("call_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConferenceParticipantResource.CallTypeEnum CallType { get; private set; }
        /// <summary>
        /// The quality_issues
        /// </summary>
        [JsonProperty("quality_issues")]
        public int? QualityIssues { get; private set; }
        /// <summary>
        /// The properties
        /// </summary>
        [JsonProperty("properties")]
        public object Properties { get; private set; }
        /// <summary>
        /// The events
        /// </summary>
        [JsonProperty("events")]
        public object Events { get; private set; }
        /// <summary>
        /// The metrics
        /// </summary>
        [JsonProperty("metrics")]
        public object Metrics { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private ConferenceParticipantResource()
        {

        }
    }

}