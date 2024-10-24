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


namespace Twilio.Rest.Video.V1.Room.Participant
{
    public class AnonymizeResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum Connected = new StatusEnum("connected");
            public static readonly StatusEnum Disconnected = new StatusEnum("disconnected");

        }

        
        private static Request BuildUpdateRequest(UpdateAnonymizeOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Rooms/{RoomSid}/Participants/{Sid}/Anonymize";

            string PathRoomSid = options.PathRoomSid;
            path = path.Replace("{"+"RoomSid"+"}", PathRoomSid);
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
        /// <param name="options"> Update Anonymize parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Anonymize </returns>
        public static AnonymizeResource Update(UpdateAnonymizeOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Anonymize parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Anonymize </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<AnonymizeResource> UpdateAsync(UpdateAnonymizeOptions options,
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathRoomSid"> The SID of the room with the participant to update. </param>
        /// <param name="pathSid"> The SID of the RoomParticipant resource to update. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Anonymize </returns>
        public static AnonymizeResource Update(
                                          string pathRoomSid,
                                          string pathSid,
                                            ITwilioRestClient client = null)
        {
            var options = new UpdateAnonymizeOptions(pathRoomSid, pathSid){  };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathRoomSid"> The SID of the room with the participant to update. </param>
        /// <param name="pathSid"> The SID of the RoomParticipant resource to update. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Anonymize </returns>
        public static async System.Threading.Tasks.Task<AnonymizeResource> UpdateAsync(
                                                                              string pathRoomSid,
                                                                              string pathSid,
                                                                                ITwilioRestClient client = null)
        {
            var options = new UpdateAnonymizeOptions(pathRoomSid, pathSid){  };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a AnonymizeResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AnonymizeResource object represented by the provided JSON </returns>
        public static AnonymizeResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AnonymizeResource>(json);
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

    
        ///<summary> The unique string that we created to identify the RoomParticipant resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the participant's room. </summary> 
        [JsonProperty("room_sid")]
        public string RoomSid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the RoomParticipant resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        
        [JsonProperty("status")]
        public AnonymizeResource.StatusEnum Status { get; private set; }

        ///<summary> The SID of the participant. </summary> 
        [JsonProperty("identity")]
        public string Identity { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The time of participant connected to the room in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601#UTC) format. </summary> 
        [JsonProperty("start_time")]
        public DateTime? StartTime { get; private set; }

        ///<summary> The time when the participant disconnected from the room in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601#UTC) format. </summary> 
        [JsonProperty("end_time")]
        public DateTime? EndTime { get; private set; }

        ///<summary> The duration in seconds that the participant was `connected`. Populated only after the participant is `disconnected`. </summary> 
        [JsonProperty("duration")]
        public int? Duration { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private AnonymizeResource() {

        }
    }
}

