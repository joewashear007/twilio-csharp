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
using Twilio.Types;


namespace Twilio.Rest.Video.V1
{
    public class RoomResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class VideoCodecEnum : StringEnum
        {
            private VideoCodecEnum(string value) : base(value) {}
            public VideoCodecEnum() {}
            public static implicit operator VideoCodecEnum(string value)
            {
                return new VideoCodecEnum(value);
            }

            public static readonly VideoCodecEnum Vp8 = new VideoCodecEnum("VP8");
            public static readonly VideoCodecEnum H264 = new VideoCodecEnum("H264");
        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class RoomTypeEnum : StringEnum
        {
            private RoomTypeEnum(string value) : base(value) {}
            public RoomTypeEnum() {}
            public static implicit operator RoomTypeEnum(string value)
            {
                return new RoomTypeEnum(value);
            }
            public static readonly RoomTypeEnum Go = new RoomTypeEnum("go");
            public static readonly RoomTypeEnum PeerToPeer = new RoomTypeEnum("peer-to-peer");
            public static readonly RoomTypeEnum Group = new RoomTypeEnum("group");
            public static readonly RoomTypeEnum GroupSmall = new RoomTypeEnum("group-small");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class RoomStatusEnum : StringEnum
        {
            private RoomStatusEnum(string value) : base(value) {}
            public RoomStatusEnum() {}
            public static implicit operator RoomStatusEnum(string value)
            {
                return new RoomStatusEnum(value);
            }
            public static readonly RoomStatusEnum InProgress = new RoomStatusEnum("in-progress");
            public static readonly RoomStatusEnum Completed = new RoomStatusEnum("completed");
            public static readonly RoomStatusEnum Failed = new RoomStatusEnum("failed");

        }

        
        private static Request BuildCreateRequest(CreateRoomOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Rooms";


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
        /// <param name="options"> Create Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns>
        public static RoomResource Create(CreateRoomOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns>
        public static async System.Threading.Tasks.Task<RoomResource> CreateAsync(CreateRoomOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="enableTurn"> Deprecated, now always considered to be true. </param>
        /// <param name="type">  </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. It can be used as a `room_sid` in place of the resource's `sid` in the URL to address the resource, assuming it does not contain any [reserved characters](https://tools.ietf.org/html/rfc3986#section-2.2) that would need to be URL encoded. This value is unique for `in-progress` rooms. SDK clients can use this name to connect to the room. REST API clients can use this name in place of the Room SID to interact with the room as long as the room is `in-progress`. </param>
        /// <param name="statusCallback"> The URL we should call using the `status_callback_method` to send status information to your application on every room event. See [Status Callbacks](https://www.twilio.com/docs/video/api/status-callbacks) for more info. </param>
        /// <param name="statusCallbackMethod"> The HTTP method we should use to call `status_callback`. Can be `POST` or `GET`. </param>
        /// <param name="maxParticipants"> The maximum number of concurrent Participants allowed in the room. Peer-to-peer rooms can have up to 10 Participants. Small Group rooms can have up to 4 Participants. Group rooms can have up to 50 Participants. </param>
        /// <param name="recordParticipantsOnConnect"> Whether to start recording when Participants connect. ***This feature is not available in `peer-to-peer` rooms.*** </param>
        /// <param name="videoCodecs"> An array of the video codecs that are supported when publishing a track in the room.  Can be: `VP8` and `H264`.  ***This feature is not available in `peer-to-peer` rooms*** </param>
        /// <param name="mediaRegion"> The region for the media server in Group Rooms.  Can be: one of the [available Media Regions](https://www.twilio.com/docs/video/ip-addresses#group-rooms-media-servers). ***This feature is not available in `peer-to-peer` rooms.*** </param>
        /// <param name="recordingRules"> A collection of Recording Rules that describe how to include or exclude matching tracks for recording </param>
        /// <param name="audioOnly"> When set to true, indicates that the participants in the room will only publish audio. No video tracks will be allowed. Group rooms only. </param>
        /// <param name="maxParticipantDuration"> The maximum number of seconds a Participant can be connected to the room. The maximum possible value is 86400 seconds (24 hours). The default is 14400 seconds (4 hours). </param>
        /// <param name="emptyRoomTimeout"> Configures how long (in minutes) a room will remain active after last participant leaves. Valid values range from 1 to 60 minutes (no fractions). </param>
        /// <param name="unusedRoomTimeout"> Configures how long (in minutes) a room will remain active if no one joins. Valid values range from 1 to 60 minutes (no fractions). </param>
        /// <param name="largeRoom"> When set to true, indicated that this is the large room. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns>
        public static RoomResource Create(
                                          bool? enableTurn = null,
                                          RoomResource.RoomTypeEnum type = null,
                                          string uniqueName = null,
                                          Uri statusCallback = null,
                                          Twilio.Http.HttpMethod statusCallbackMethod = null,
                                          int? maxParticipants = null,
                                          bool? recordParticipantsOnConnect = null,
                                          List<RoomResource.VideoCodecEnum> videoCodecs = null,
                                          string mediaRegion = null,
                                          object recordingRules = null,
                                          bool? audioOnly = null,
                                          int? maxParticipantDuration = null,
                                          int? emptyRoomTimeout = null,
                                          int? unusedRoomTimeout = null,
                                          bool? largeRoom = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateRoomOptions(){  EnableTurn = enableTurn, Type = type, UniqueName = uniqueName, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, MaxParticipants = maxParticipants, RecordParticipantsOnConnect = recordParticipantsOnConnect, VideoCodecs = videoCodecs, MediaRegion = mediaRegion, RecordingRules = recordingRules, AudioOnly = audioOnly, MaxParticipantDuration = maxParticipantDuration, EmptyRoomTimeout = emptyRoomTimeout, UnusedRoomTimeout = unusedRoomTimeout, LargeRoom = largeRoom };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="enableTurn"> Deprecated, now always considered to be true. </param>
        /// <param name="type">  </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. It can be used as a `room_sid` in place of the resource's `sid` in the URL to address the resource, assuming it does not contain any [reserved characters](https://tools.ietf.org/html/rfc3986#section-2.2) that would need to be URL encoded. This value is unique for `in-progress` rooms. SDK clients can use this name to connect to the room. REST API clients can use this name in place of the Room SID to interact with the room as long as the room is `in-progress`. </param>
        /// <param name="statusCallback"> The URL we should call using the `status_callback_method` to send status information to your application on every room event. See [Status Callbacks](https://www.twilio.com/docs/video/api/status-callbacks) for more info. </param>
        /// <param name="statusCallbackMethod"> The HTTP method we should use to call `status_callback`. Can be `POST` or `GET`. </param>
        /// <param name="maxParticipants"> The maximum number of concurrent Participants allowed in the room. Peer-to-peer rooms can have up to 10 Participants. Small Group rooms can have up to 4 Participants. Group rooms can have up to 50 Participants. </param>
        /// <param name="recordParticipantsOnConnect"> Whether to start recording when Participants connect. ***This feature is not available in `peer-to-peer` rooms.*** </param>
        /// <param name="videoCodecs"> An array of the video codecs that are supported when publishing a track in the room.  Can be: `VP8` and `H264`.  ***This feature is not available in `peer-to-peer` rooms*** </param>
        /// <param name="mediaRegion"> The region for the media server in Group Rooms.  Can be: one of the [available Media Regions](https://www.twilio.com/docs/video/ip-addresses#group-rooms-media-servers). ***This feature is not available in `peer-to-peer` rooms.*** </param>
        /// <param name="recordingRules"> A collection of Recording Rules that describe how to include or exclude matching tracks for recording </param>
        /// <param name="audioOnly"> When set to true, indicates that the participants in the room will only publish audio. No video tracks will be allowed. Group rooms only. </param>
        /// <param name="maxParticipantDuration"> The maximum number of seconds a Participant can be connected to the room. The maximum possible value is 86400 seconds (24 hours). The default is 14400 seconds (4 hours). </param>
        /// <param name="emptyRoomTimeout"> Configures how long (in minutes) a room will remain active after last participant leaves. Valid values range from 1 to 60 minutes (no fractions). </param>
        /// <param name="unusedRoomTimeout"> Configures how long (in minutes) a room will remain active if no one joins. Valid values range from 1 to 60 minutes (no fractions). </param>
        /// <param name="largeRoom"> When set to true, indicated that this is the large room. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns>
        public static async System.Threading.Tasks.Task<RoomResource> CreateAsync(
                                                                                  bool? enableTurn = null,
                                                                                  RoomResource.RoomTypeEnum type = null,
                                                                                  string uniqueName = null,
                                                                                  Uri statusCallback = null,
                                                                                  Twilio.Http.HttpMethod statusCallbackMethod = null,
                                                                                  int? maxParticipants = null,
                                                                                  bool? recordParticipantsOnConnect = null,
                                                                                  List<RoomResource.VideoCodecEnum> videoCodecs = null,
                                                                                  string mediaRegion = null,
                                                                                  object recordingRules = null,
                                                                                  bool? audioOnly = null,
                                                                                  int? maxParticipantDuration = null,
                                                                                  int? emptyRoomTimeout = null,
                                                                                  int? unusedRoomTimeout = null,
                                                                                  bool? largeRoom = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateRoomOptions(){  EnableTurn = enableTurn, Type = type, UniqueName = uniqueName, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, MaxParticipants = maxParticipants, RecordParticipantsOnConnect = recordParticipantsOnConnect, VideoCodecs = videoCodecs, MediaRegion = mediaRegion, RecordingRules = recordingRules, AudioOnly = audioOnly, MaxParticipantDuration = maxParticipantDuration, EmptyRoomTimeout = emptyRoomTimeout, UnusedRoomTimeout = unusedRoomTimeout, LargeRoom = largeRoom };
            return await CreateAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchRoomOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Rooms/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns>
        public static RoomResource Fetch(FetchRoomOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns>
        public static async System.Threading.Tasks.Task<RoomResource> FetchAsync(FetchRoomOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The SID of the Room resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns>
        public static RoomResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchRoomOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The SID of the Room resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns>
        public static async System.Threading.Tasks.Task<RoomResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchRoomOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadRoomOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Rooms";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns>
        public static ResourceSet<RoomResource> Read(ReadRoomOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<RoomResource>.FromJson("rooms", response.Content);
            return new ResourceSet<RoomResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<RoomResource>> ReadAsync(ReadRoomOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<RoomResource>.FromJson("rooms", response.Content);
            return new ResourceSet<RoomResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="status"> Read only the rooms with this status. Can be: `in-progress` (default) or `completed` </param>
        /// <param name="uniqueName"> Read only rooms with the this `unique_name`. </param>
        /// <param name="dateCreatedAfter"> Read only rooms that started on or after this date, given as `YYYY-MM-DD`. </param>
        /// <param name="dateCreatedBefore"> Read only rooms that started before this date, given as `YYYY-MM-DD`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns>
        public static ResourceSet<RoomResource> Read(
                                                     RoomResource.RoomStatusEnum status = null,
                                                     string uniqueName = null,
                                                     DateTime? dateCreatedAfter = null,
                                                     DateTime? dateCreatedBefore = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadRoomOptions(){ Status = status, UniqueName = uniqueName, DateCreatedAfter = dateCreatedAfter, DateCreatedBefore = dateCreatedBefore, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="status"> Read only the rooms with this status. Can be: `in-progress` (default) or `completed` </param>
        /// <param name="uniqueName"> Read only rooms with the this `unique_name`. </param>
        /// <param name="dateCreatedAfter"> Read only rooms that started on or after this date, given as `YYYY-MM-DD`. </param>
        /// <param name="dateCreatedBefore"> Read only rooms that started before this date, given as `YYYY-MM-DD`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<RoomResource>> ReadAsync(
                                                                                             RoomResource.RoomStatusEnum status = null,
                                                                                             string uniqueName = null,
                                                                                             DateTime? dateCreatedAfter = null,
                                                                                             DateTime? dateCreatedBefore = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadRoomOptions(){ Status = status, UniqueName = uniqueName, DateCreatedAfter = dateCreatedAfter, DateCreatedBefore = dateCreatedBefore, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<RoomResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<RoomResource>.FromJson("rooms", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<RoomResource> NextPage(Page<RoomResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<RoomResource>.FromJson("rooms", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<RoomResource> PreviousPage(Page<RoomResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<RoomResource>.FromJson("rooms", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateRoomOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Rooms/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Video,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns>
        public static RoomResource Update(UpdateRoomOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<RoomResource> UpdateAsync(UpdateRoomOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathSid"> The SID of the Room resource to update. </param>
        /// <param name="status">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns>
        public static RoomResource Update(
                                          string pathSid,
                                          RoomResource.RoomStatusEnum status,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateRoomOptions(pathSid, status){  };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathSid"> The SID of the Room resource to update. </param>
        /// <param name="status">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns>
        public static async System.Threading.Tasks.Task<RoomResource> UpdateAsync(
                                                                              string pathSid,
                                                                              RoomResource.RoomStatusEnum status,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateRoomOptions(pathSid, status){  };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a RoomResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> RoomResource object represented by the provided JSON </returns>
        public static RoomResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<RoomResource>(json);
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

    
        ///<summary> The unique string that we created to identify the Room resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        
        [JsonProperty("status")]
        public RoomResource.RoomStatusEnum Status { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Room resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> Deprecated, now always considered to be true. </summary> 
        [JsonProperty("enable_turn")]
        public bool? EnableTurn { get; private set; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used as a `room_sid` in place of the resource's `sid` in the URL to address the resource, assuming it does not contain any [reserved characters](https://tools.ietf.org/html/rfc3986#section-2.2) that would need to be URL encoded. This value is unique for `in-progress` rooms. SDK clients can use this name to connect to the room. REST API clients can use this name in place of the Room SID to interact with the room as long as the room is `in-progress`. </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> The URL we call using the `status_callback_method` to send status information to your application on every room event. See [Status Callbacks](https://www.twilio.com/docs/video/api/status-callbacks) for more info. </summary> 
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }

        ///<summary> The HTTP method we use to call `status_callback`. Can be `POST` or `GET` and defaults to `POST`. </summary> 
        [JsonProperty("status_callback_method")]
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; private set; }

        ///<summary> The UTC end time of the room in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601#UTC) format. </summary> 
        [JsonProperty("end_time")]
        public DateTime? EndTime { get; private set; }

        ///<summary> The duration of the room in seconds. </summary> 
        [JsonProperty("duration")]
        public int? Duration { get; private set; }

        
        [JsonProperty("type")]
        public RoomResource.RoomTypeEnum Type { get; private set; }

        ///<summary> The maximum number of concurrent Participants allowed in the room.  </summary> 
        [JsonProperty("max_participants")]
        public int? MaxParticipants { get; private set; }

        ///<summary> The maximum number of seconds a Participant can be connected to the room. The maximum possible value is 86400 seconds (24 hours). The default is 14400 seconds (4 hours). </summary> 
        [JsonProperty("max_participant_duration")]
        public int? MaxParticipantDuration { get; private set; }

        ///<summary> The maximum number of published audio, video, and data tracks all participants combined are allowed to publish in the room at the same time. Check [Programmable Video Limits](https://www.twilio.com/docs/video/programmable-video-limits) for more details. If it is set to 0 it means unconstrained. </summary> 
        [JsonProperty("max_concurrent_published_tracks")]
        public int? MaxConcurrentPublishedTracks { get; private set; }

        ///<summary> Whether to start recording when Participants connect. ***This feature is not available in `peer-to-peer` rooms.*** </summary> 
        [JsonProperty("record_participants_on_connect")]
        public bool? RecordParticipantsOnConnect { get; private set; }

        ///<summary> An array of the video codecs that are supported when publishing a track in the room.  Can be: `VP8` and `H264`.  ***This feature is not available in `peer-to-peer` rooms*** </summary> 
        [JsonProperty("video_codecs")]
        public List<RoomResource.VideoCodecEnum> VideoCodecs { get; private set; }

        ///<summary> The region for the media server in Group Rooms.  Can be: one of the [available Media Regions](https://www.twilio.com/docs/video/ip-addresses#media-servers). ***This feature is not available in `peer-to-peer` rooms.*** </summary> 
        [JsonProperty("media_region")]
        public string MediaRegion { get; private set; }

        ///<summary> When set to true, indicates that the participants in the room will only publish audio. No video tracks will be allowed. Group rooms only. </summary> 
        [JsonProperty("audio_only")]
        public bool? AudioOnly { get; private set; }

        ///<summary> Specifies how long (in minutes) a room will remain active after last participant leaves. Can be configured when creating a room via REST API. For Ad-Hoc rooms this value cannot be changed. </summary> 
        [JsonProperty("empty_room_timeout")]
        public int? EmptyRoomTimeout { get; private set; }

        ///<summary> Specifies how long (in minutes) a room will remain active if no one joins. Can be configured when creating a room via REST API. For Ad-Hoc rooms this value cannot be changed. </summary> 
        [JsonProperty("unused_room_timeout")]
        public int? UnusedRoomTimeout { get; private set; }

        ///<summary> Indicates if this is a large room. </summary> 
        [JsonProperty("large_room")]
        public bool? LargeRoom { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The URLs of related resources. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private RoomResource() {

        }
    }
}

