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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;
using System.Linq;



namespace Twilio.Rest.Conversations.V1
{

    /// <summary> Create a new conversation with the list of participants in your account's default service </summary>
    public class CreateConversationWithParticipantsOptions : IOptions<ConversationWithParticipantsResource>
    {
        
        ///<summary> The X-Twilio-Webhook-Enabled HTTP request header </summary> 
        public ConversationWithParticipantsResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }

        ///<summary> The human-readable name of this conversation, limited to 256 characters. Optional. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used to address the resource in place of the resource's `sid` in the URL. </summary> 
        public string UniqueName { get; set; }

        ///<summary> The date that this resource was created. </summary> 
        public DateTime? DateCreated { get; set; }

        ///<summary> The date that this resource was last updated. </summary> 
        public DateTime? DateUpdated { get; set; }

        ///<summary> The unique ID of the [Messaging Service](https://www.twilio.com/docs/messaging/api/service-resource) this conversation belongs to. </summary> 
        public string MessagingServiceSid { get; set; }

        ///<summary> An optional string metadata field you can use to store any data you wish. The string value must contain structurally valid JSON if specified.  **Note** that if the attributes are not set \\\"{}\\\" will be returned. </summary> 
        public string Attributes { get; set; }

        
        public ConversationWithParticipantsResource.StateEnum State { get; set; }

        ///<summary> ISO8601 duration when conversation will be switched to `inactive` state. Minimum value for this timer is 1 minute. </summary> 
        public string TimersInactive { get; set; }

        ///<summary> ISO8601 duration when conversation will be switched to `closed` state. Minimum value for this timer is 10 minutes. </summary> 
        public string TimersClosed { get; set; }

        ///<summary> The default email address that will be used when sending outbound emails in this conversation. </summary> 
        public string BindingsEmailAddress { get; set; }

        ///<summary> The default name that will be used when sending outbound emails in this conversation. </summary> 
        public string BindingsEmailName { get; set; }

        ///<summary> The participant to be added to the conversation in JSON format. The parameters are as in [Participant Resource](https://www.twilio.com/docs/conversations/api/conversation-participant-resource). The maximum number of participants that can be added in a single request is 10. </summary> 
        public List<string> Participant { get; set; }



        
        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }
            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }
            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid));
            }
            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }
            if (State != null)
            {
                p.Add(new KeyValuePair<string, string>("State", State.ToString()));
            }
            if (TimersInactive != null)
            {
                p.Add(new KeyValuePair<string, string>("Timers.Inactive", TimersInactive));
            }
            if (TimersClosed != null)
            {
                p.Add(new KeyValuePair<string, string>("Timers.Closed", TimersClosed));
            }
            if (BindingsEmailAddress != null)
            {
                p.Add(new KeyValuePair<string, string>("Bindings.Email.Address", BindingsEmailAddress));
            }
            if (BindingsEmailName != null)
            {
                p.Add(new KeyValuePair<string, string>("Bindings.Email.Name", BindingsEmailName));
            }
            if (Participant != null)
            {
                p.AddRange(Participant.Select(Participant => new KeyValuePair<string, string>("Participant", Participant)));
            }
            return p;
        }

        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (XTwilioWebhookEnabled != null)
        {
            p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
        }
        return p;
    }

    }
}

