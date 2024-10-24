/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Proxy
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


namespace Twilio.Rest.Proxy.V1.Service.Session
{
    public class InteractionResource : Resource
    {
    

    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class TypeEnum : StringEnum
        {
            private TypeEnum(string value) : base(value) {}
            public TypeEnum() {}
            public static implicit operator TypeEnum(string value)
            {
                return new TypeEnum(value);
            }
            public static readonly TypeEnum Message = new TypeEnum("message");
            public static readonly TypeEnum Voice = new TypeEnum("voice");
            public static readonly TypeEnum Unknown = new TypeEnum("unknown");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class ResourceStatusEnum : StringEnum
        {
            private ResourceStatusEnum(string value) : base(value) {}
            public ResourceStatusEnum() {}
            public static implicit operator ResourceStatusEnum(string value)
            {
                return new ResourceStatusEnum(value);
            }
            public static readonly ResourceStatusEnum Accepted = new ResourceStatusEnum("accepted");
            public static readonly ResourceStatusEnum Answered = new ResourceStatusEnum("answered");
            public static readonly ResourceStatusEnum Busy = new ResourceStatusEnum("busy");
            public static readonly ResourceStatusEnum Canceled = new ResourceStatusEnum("canceled");
            public static readonly ResourceStatusEnum Completed = new ResourceStatusEnum("completed");
            public static readonly ResourceStatusEnum Deleted = new ResourceStatusEnum("deleted");
            public static readonly ResourceStatusEnum Delivered = new ResourceStatusEnum("delivered");
            public static readonly ResourceStatusEnum DeliveryUnknown = new ResourceStatusEnum("delivery-unknown");
            public static readonly ResourceStatusEnum Failed = new ResourceStatusEnum("failed");
            public static readonly ResourceStatusEnum InProgress = new ResourceStatusEnum("in-progress");
            public static readonly ResourceStatusEnum Initiated = new ResourceStatusEnum("initiated");
            public static readonly ResourceStatusEnum NoAnswer = new ResourceStatusEnum("no-answer");
            public static readonly ResourceStatusEnum Queued = new ResourceStatusEnum("queued");
            public static readonly ResourceStatusEnum Received = new ResourceStatusEnum("received");
            public static readonly ResourceStatusEnum Receiving = new ResourceStatusEnum("receiving");
            public static readonly ResourceStatusEnum Ringing = new ResourceStatusEnum("ringing");
            public static readonly ResourceStatusEnum Scheduled = new ResourceStatusEnum("scheduled");
            public static readonly ResourceStatusEnum Sending = new ResourceStatusEnum("sending");
            public static readonly ResourceStatusEnum Sent = new ResourceStatusEnum("sent");
            public static readonly ResourceStatusEnum Undelivered = new ResourceStatusEnum("undelivered");
            public static readonly ResourceStatusEnum Unknown = new ResourceStatusEnum("unknown");

        }

        
        /// <summary> Delete a specific Interaction. </summary>
        /// <param name="options"> Delete Interaction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Interaction </returns>
        private static Request BuildDeleteRequest(DeleteInteractionOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Sessions/{SessionSid}/Interactions/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathSessionSid = options.PathSessionSid;
            path = path.Replace("{"+"SessionSid"+"}", PathSessionSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Proxy,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific Interaction. </summary>
        /// <param name="options"> Delete Interaction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Interaction </returns>
        public static bool Delete(DeleteInteractionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a specific Interaction. </summary>
        /// <param name="options"> Delete Interaction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Interaction </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteInteractionOptions options,
                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a specific Interaction. </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the resource to delete. </param>
        /// <param name="pathSessionSid"> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) of the resource to delete. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Interaction resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Interaction </returns>
        public static bool Delete(string pathServiceSid, string pathSessionSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteInteractionOptions(pathServiceSid, pathSessionSid, pathSid)           ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a specific Interaction. </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the resource to delete. </param>
        /// <param name="pathSessionSid"> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) of the resource to delete. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Interaction resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Interaction </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathSessionSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteInteractionOptions(pathServiceSid, pathSessionSid, pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchInteractionOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Sessions/{SessionSid}/Interactions/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathSessionSid = options.PathSessionSid;
            path = path.Replace("{"+"SessionSid"+"}", PathSessionSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Proxy,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Retrieve a list of Interactions for a given [Session](https://www.twilio.com/docs/proxy/api/session). </summary>
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
        /// <summary> Retrieve a list of Interactions for a given [Session](https://www.twilio.com/docs/proxy/api/session). </summary>
        /// <param name="options"> Fetch Interaction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Interaction </returns>
        public static async System.Threading.Tasks.Task<InteractionResource> FetchAsync(FetchInteractionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Retrieve a list of Interactions for a given [Session](https://www.twilio.com/docs/proxy/api/session). </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the resource to fetch. </param>
        /// <param name="pathSessionSid"> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) of the resource to fetch. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Interaction resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Interaction </returns>
        public static InteractionResource Fetch(
                                         string pathServiceSid, 
                                         string pathSessionSid, 
                                         string pathSid, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchInteractionOptions(pathServiceSid, pathSessionSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Interactions for a given [Session](https://www.twilio.com/docs/proxy/api/session). </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the resource to fetch. </param>
        /// <param name="pathSessionSid"> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) of the resource to fetch. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Interaction resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Interaction </returns>
        public static async System.Threading.Tasks.Task<InteractionResource> FetchAsync(string pathServiceSid, string pathSessionSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchInteractionOptions(pathServiceSid, pathSessionSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadInteractionOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Sessions/{SessionSid}/Interactions";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathSessionSid = options.PathSessionSid;
            path = path.Replace("{"+"SessionSid"+"}", PathSessionSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Proxy,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Interactions for a Session. A maximum of 100 records will be returned per page. </summary>
        /// <param name="options"> Read Interaction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Interaction </returns>
        public static ResourceSet<InteractionResource> Read(ReadInteractionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<InteractionResource>.FromJson("interactions", response.Content);
            return new ResourceSet<InteractionResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Interactions for a Session. A maximum of 100 records will be returned per page. </summary>
        /// <param name="options"> Read Interaction parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Interaction </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InteractionResource>> ReadAsync(ReadInteractionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<InteractionResource>.FromJson("interactions", response.Content);
            return new ResourceSet<InteractionResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Interactions for a Session. A maximum of 100 records will be returned per page. </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) to read the resources from. </param>
        /// <param name="pathSessionSid"> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) to read the resources from. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Interaction </returns>
        public static ResourceSet<InteractionResource> Read(
                                                     string pathServiceSid,
                                                     string pathSessionSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadInteractionOptions(pathServiceSid, pathSessionSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Interactions for a Session. A maximum of 100 records will be returned per page. </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) to read the resources from. </param>
        /// <param name="pathSessionSid"> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) to read the resources from. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Interaction </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InteractionResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             string pathSessionSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadInteractionOptions(pathServiceSid, pathSessionSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<InteractionResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<InteractionResource>.FromJson("interactions", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<InteractionResource> NextPage(Page<InteractionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<InteractionResource>.FromJson("interactions", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<InteractionResource> PreviousPage(Page<InteractionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<InteractionResource>.FromJson("interactions", response.Content);
        }

    
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

    
        ///<summary> The unique string that we created to identify the Interaction resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) resource. </summary> 
        [JsonProperty("session_sid")]
        public string SessionSid { get; private set; }

        ///<summary> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) resource. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Interaction resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> A JSON string that includes the message body of message interactions (e.g. `{\"body\": \"hello\"}`) or the call duration (when available) of a call (e.g. `{\"duration\": \"5\"}`). </summary> 
        [JsonProperty("data")]
        public string Data { get; private set; }

        
        [JsonProperty("type")]
        public InteractionResource.TypeEnum Type { get; private set; }

        ///<summary> The SID of the inbound [Participant](https://www.twilio.com/docs/proxy/api/participant) resource. </summary> 
        [JsonProperty("inbound_participant_sid")]
        public string InboundParticipantSid { get; private set; }

        ///<summary> The SID of the inbound resource; either the [Call](https://www.twilio.com/docs/voice/api/call-resource) or [Message](https://www.twilio.com/docs/sms/api/message-resource). </summary> 
        [JsonProperty("inbound_resource_sid")]
        public string InboundResourceSid { get; private set; }

        
        [JsonProperty("inbound_resource_status")]
        public InteractionResource.ResourceStatusEnum InboundResourceStatus { get; private set; }

        ///<summary> The inbound resource type. Can be [Call](https://www.twilio.com/docs/voice/api/call-resource) or [Message](https://www.twilio.com/docs/sms/api/message-resource). </summary> 
        [JsonProperty("inbound_resource_type")]
        public string InboundResourceType { get; private set; }

        ///<summary> The URL of the Twilio inbound resource </summary> 
        [JsonProperty("inbound_resource_url")]
        public Uri InboundResourceUrl { get; private set; }

        ///<summary> The SID of the outbound [Participant](https://www.twilio.com/docs/proxy/api/participant)). </summary> 
        [JsonProperty("outbound_participant_sid")]
        public string OutboundParticipantSid { get; private set; }

        ///<summary> The SID of the outbound resource; either the [Call](https://www.twilio.com/docs/voice/api/call-resource) or [Message](https://www.twilio.com/docs/sms/api/message-resource). </summary> 
        [JsonProperty("outbound_resource_sid")]
        public string OutboundResourceSid { get; private set; }

        
        [JsonProperty("outbound_resource_status")]
        public InteractionResource.ResourceStatusEnum OutboundResourceStatus { get; private set; }

        ///<summary> The outbound resource type. Can be: [Call](https://www.twilio.com/docs/voice/api/call-resource) or [Message](https://www.twilio.com/docs/sms/api/message-resource). </summary> 
        [JsonProperty("outbound_resource_type")]
        public string OutboundResourceType { get; private set; }

        ///<summary> The URL of the Twilio outbound resource. </summary> 
        [JsonProperty("outbound_resource_url")]
        public Uri OutboundResourceUrl { get; private set; }

        ///<summary> The [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date and time in GMT when the Interaction was created. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date and time in GMT when the resource was last updated. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the Interaction resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private InteractionResource() {

        }
    }
}

