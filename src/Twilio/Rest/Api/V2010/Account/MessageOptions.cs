/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
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



namespace Twilio.Rest.Api.V2010.Account
{

    /// <summary> Send a message </summary>
    public class CreateMessageOptions : IOptions<MessageResource>
    {
        
        ///<summary> The recipient's phone number in [E.164](https://www.twilio.com/docs/glossary/what-e164) format (for SMS/MMS) or [channel address](https://www.twilio.com/docs/sms/channels#channel-addresses), e.g. `whatsapp:+15552229999`. </summary> 
        public Types.PhoneNumber To { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) creating the Message resource. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> The URL of the endpoint to which Twilio sends [Message status callback requests](https://www.twilio.com/docs/sms/api/message-resource#twilios-request-to-the-statuscallback-url). URL must contain a valid hostname and underscores are not allowed. If you include this parameter with the `messaging_service_sid`, Twilio uses this URL instead of the Status Callback URL of the [Messaging Service](https://www.twilio.com/docs/sms/services/api).  </summary> 
        public Uri StatusCallback { get; set; }

        ///<summary> The SID of the associated [TwiML Application](https://www.twilio.com/docs/usage/api/applications). If this parameter is provided, the `status_callback` parameter of this request is ignored; [Message status callback requests](https://www.twilio.com/docs/sms/api/message-resource#twilios-request-to-the-statuscallback-url) are sent to the TwiML App's `message_status_callback` URL. </summary> 
        public string ApplicationSid { get; set; }

        ///<summary> The maximum price in US dollars that you are willing to pay for this Message's delivery. The value can have up to four decimal places. When the `max_price` parameter is provided, the cost of a message is checked before it is sent. If the cost exceeds `max_price`, the message is not sent and the Message `status` is `failed`. </summary> 
        public decimal? MaxPrice { get; set; }

        ///<summary> Boolean indicating whether or not you intend to provide delivery confirmation feedback to Twilio (used in conjunction with the [Message Feedback subresource](https://www.twilio.com/docs/sms/api/message-feedback-resource)). Default value is `false`. </summary> 
        public bool? ProvideFeedback { get; set; }

        ///<summary> Total number of attempts made (including this request) to send the message regardless of the provider used </summary> 
        public int? Attempt { get; set; }

        ///<summary> The maximum length in seconds that the Message can remain in Twilio's outgoing message queue. If a queued Message exceeds the `validity_period`, the Message is not sent. Accepted values are integers from `1` to `14400`. Default value is `14400`. A `validity_period` greater than `5` is recommended. [Learn more about the validity period](https://www.twilio.com/blog/take-more-control-of-outbound-messages-using-validity-period-html) </summary> 
        public int? ValidityPeriod { get; set; }

        ///<summary> Reserved </summary> 
        public bool? ForceDelivery { get; set; }

        
        public MessageResource.ContentRetentionEnum ContentRetention { get; set; }

        
        public MessageResource.AddressRetentionEnum AddressRetention { get; set; }

        ///<summary> Whether to detect Unicode characters that have a similar GSM-7 character and replace them. Can be: `true` or `false`. </summary> 
        public bool? SmartEncoded { get; set; }

        ///<summary> Rich actions for non-SMS/MMS channels. Used for [sending location in WhatsApp messages](https://www.twilio.com/docs/whatsapp/message-features#location-messages-with-whatsapp). </summary> 
        public List<string> PersistentAction { get; set; }

        ///<summary> For Messaging Services with [Link Shortening configured](https://www.twilio.com/docs/messaging/features/how-to-configure-link-shortening) only: A Boolean indicating whether or not Twilio should shorten links in the `body` of the Message. Default value is `false`. If `true`, the `messaging_service_sid` parameter must also be provided. </summary> 
        public bool? ShortenUrls { get; set; }

        
        public MessageResource.ScheduleTypeEnum ScheduleType { get; set; }

        ///<summary> The time that Twilio will send the message. Must be in ISO 8601 format. </summary> 
        public DateTime? SendAt { get; set; }

        ///<summary> If set to `true`, Twilio delivers the message as a single MMS message, regardless of the presence of media. </summary> 
        public bool? SendAsMms { get; set; }

        ///<summary> For [Content Editor/API](https://www.twilio.com/docs/content) only: Key-value pairs of [Template variables](https://www.twilio.com/docs/content/using-variables-with-content-api) and their substitution values. `content_sid` parameter must also be provided. If values are not defined in the `content_variables` parameter, the [Template's default placeholder values](https://www.twilio.com/docs/content/content-api-resources#create-templates) are used. </summary> 
        public string ContentVariables { get; set; }

        ///<summary> The sender's Twilio phone number (in [E.164](https://en.wikipedia.org/wiki/E.164) format), [alphanumeric sender ID](https://www.twilio.com/docs/sms/send-messages#use-an-alphanumeric-sender-id), [Wireless SIM](https://www.twilio.com/docs/wireless/tutorials/communications-guides/how-to-send-and-receive-text-messages), [short code](https://www.twilio.com/docs/sms/api/short-code), or [channel address](https://www.twilio.com/docs/sms/channels#channel-addresses) (e.g., `whatsapp:+15554449999`). The value of the `from` parameter must be a sender that is hosted within Twilio and belong to the Account creating the Message. If you are using `messaging_service_sid`, this parameter can be empty (Twilio assigns a `from` value from the Messaging Service's Sender Pool) or you can provide a specific sender from your Sender Pool. </summary> 
        public Types.PhoneNumber From { get; set; }

        ///<summary> The SID of the [Messaging Service](https://www.twilio.com/docs/messaging/services) you want to associate with the Message. When this parameter is provided and the `from` parameter is omitted, Twilio selects the optimal sender from the Messaging Service's Sender Pool. You may also provide a `from` parameter if you want to use a specific Sender from the Sender Pool. </summary> 
        public string MessagingServiceSid { get; set; }

        ///<summary> The text content of the outgoing message. Can be up to 1,600 characters in length. SMS only: If the `body` contains more than 160 [GSM-7](https://www.twilio.com/docs/glossary/what-is-gsm-7-character-encoding) characters (or 70 [UCS-2](https://www.twilio.com/docs/glossary/what-is-ucs-2-character-encoding) characters), the message is segmented and charged accordingly. For long `body` text, consider using the [send_as_mms parameter](https://www.twilio.com/blog/mms-for-long-text-messages). </summary> 
        public string Body { get; set; }

        ///<summary> The URL of media to include in the Message content. `jpeg`, `jpg`, `gif`, and `png` file types are fully supported by Twilio and content is formatted for delivery on destination devices. The media size limit is 5 MB for supported file types (`jpeg`, `jpg`, `png`, `gif`) and 500 KB for [other types](https://www.twilio.com/docs/sms/accepted-mime-types) of accepted media. To send more than one image in the message, provide multiple `media_url` parameters in the POST request. You can include up to ten `media_url` parameters per message. [International](https://support.twilio.com/hc/en-us/articles/223179808-Sending-and-receiving-MMS-messages) and [carrier](https://support.twilio.com/hc/en-us/articles/223133707-Is-MMS-supported-for-all-carriers-in-US-and-Canada-) limits apply. </summary> 
        public List<Uri> MediaUrl { get; set; }

        ///<summary> For [Content Editor/API](https://www.twilio.com/docs/content) only: The SID of the Content Template to be used with the Message, e.g., `HXXXXXXXXXXXXXXXXXXXXXXXXXXXXX`. If this parameter is not provided, a Content Template is not used. Find the SID in the Console on the Content Editor page. For Content API users, the SID is found in Twilio's response when [creating the Template](https://www.twilio.com/docs/content/content-api-resources#create-templates) or by [fetching your Templates](https://www.twilio.com/docs/content/content-api-resources#fetch-all-content-resources). </summary> 
        public string ContentSid { get; set; }


        /// <summary> Construct a new CreateMessageOptions </summary>
        /// <param name="to"> The recipient's phone number in [E.164](https://www.twilio.com/docs/glossary/what-e164) format (for SMS/MMS) or [channel address](https://www.twilio.com/docs/sms/channels#channel-addresses), e.g. `whatsapp:+15552229999`. </param>
        public CreateMessageOptions(Types.PhoneNumber to)
        {
            To = to;
            PersistentAction = new List<string>();
            MediaUrl = new List<Uri>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }
            if (ApplicationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ApplicationSid", ApplicationSid));
            }
            if (MaxPrice != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxPrice", MaxPrice.Value.ToString()));
            }
            if (ProvideFeedback != null)
            {
                p.Add(new KeyValuePair<string, string>("ProvideFeedback", ProvideFeedback.Value.ToString().ToLower()));
            }
            if (Attempt != null)
            {
                p.Add(new KeyValuePair<string, string>("Attempt", Attempt.ToString()));
            }
            if (ValidityPeriod != null)
            {
                p.Add(new KeyValuePair<string, string>("ValidityPeriod", ValidityPeriod.ToString()));
            }
            if (ForceDelivery != null)
            {
                p.Add(new KeyValuePair<string, string>("ForceDelivery", ForceDelivery.Value.ToString().ToLower()));
            }
            if (ContentRetention != null)
            {
                p.Add(new KeyValuePair<string, string>("ContentRetention", ContentRetention.ToString()));
            }
            if (AddressRetention != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressRetention", AddressRetention.ToString()));
            }
            if (SmartEncoded != null)
            {
                p.Add(new KeyValuePair<string, string>("SmartEncoded", SmartEncoded.Value.ToString().ToLower()));
            }
            if (PersistentAction != null)
            {
                p.AddRange(PersistentAction.Select(PersistentAction => new KeyValuePair<string, string>("PersistentAction", PersistentAction)));
            }
            if (ShortenUrls != null)
            {
                p.Add(new KeyValuePair<string, string>("ShortenUrls", ShortenUrls.Value.ToString().ToLower()));
            }
            if (ScheduleType != null)
            {
                p.Add(new KeyValuePair<string, string>("ScheduleType", ScheduleType.ToString()));
            }
            if (SendAt != null)
            {
                p.Add(new KeyValuePair<string, string>("SendAt", Serializers.DateTimeIso8601(SendAt)));
            }
            if (SendAsMms != null)
            {
                p.Add(new KeyValuePair<string, string>("SendAsMms", SendAsMms.Value.ToString().ToLower()));
            }
            if (ContentVariables != null)
            {
                p.Add(new KeyValuePair<string, string>("ContentVariables", ContentVariables));
            }
            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }
            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid));
            }
            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }
            if (MediaUrl != null)
            {
                p.AddRange(MediaUrl.Select(MediaUrl => new KeyValuePair<string, string>("MediaUrl", Serializers.Url(MediaUrl))));
            }
            if (ContentSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ContentSid", ContentSid));
            }
            return p;
        }
        

    }
    /// <summary> Deletes a Message resource from your account </summary>
    public class DeleteMessageOptions : IOptions<MessageResource>
    {
        
        ///<summary> The SID of the Message resource you wish to delete </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) associated with the Message resource </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new DeleteMessageOptions </summary>
        /// <param name="pathSid"> The SID of the Message resource you wish to delete </param>
        public DeleteMessageOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch a specific Message </summary>
    public class FetchMessageOptions : IOptions<MessageResource>
    {
    
        ///<summary> The SID of the Message resource to be fetched </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) associated with the Message resource </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchMessageOptions </summary>
        /// <param name="pathSid"> The SID of the Message resource to be fetched </param>
        public FetchMessageOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of Message resources associated with a Twilio Account </summary>
    public class ReadMessageOptions : ReadOptions<MessageResource>
    {
    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) associated with the Message resources. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> Filter by recipient. For example: Set this `to` parameter to `+15558881111` to retrieve a list of Message resources with `to` properties of `+15558881111` </summary> 
        public Types.PhoneNumber To { get; set; }

        ///<summary> Filter by sender. For example: Set this `from` parameter to `+15552229999` to retrieve a list of Message resources with `from` properties of `+15552229999` </summary> 
        public Types.PhoneNumber From { get; set; }

        ///<summary> Filter by Message `sent_date`. Accepts GMT dates in the following formats: `YYYY-MM-DD` (to find Messages with a specific `sent_date`), `<=YYYY-MM-DD` (to find Messages with `sent_date`s on and before a specific date), and `>=YYYY-MM-DD` (to find Messages with `sent_dates` on and after a specific date). </summary> 
        public DateTime? DateSent { get; set; }

        ///<summary> Filter by Message `sent_date`. Accepts GMT dates in the following formats: `YYYY-MM-DD` (to find Messages with a specific `sent_date`), `<=YYYY-MM-DD` (to find Messages with `sent_date`s on and before a specific date), and `>=YYYY-MM-DD` (to find Messages with `sent_dates` on and after a specific date). </summary> 
        public DateTime? DateSentBefore { get; set; }

        ///<summary> Filter by Message `sent_date`. Accepts GMT dates in the following formats: `YYYY-MM-DD` (to find Messages with a specific `sent_date`), `<=YYYY-MM-DD` (to find Messages with `sent_date`s on and before a specific date), and `>=YYYY-MM-DD` (to find Messages with `sent_dates` on and after a specific date). </summary> 
        public DateTime? DateSentAfter { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }
            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }
            if (DateSent != null)
            {
                p.Add(new KeyValuePair<string, string>("DateSent", Serializers.DateTimeIso8601(DateSent)));
            }
            else
            {
                if (DateSentBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateSent<", Serializers.DateTimeIso8601(DateSentBefore)));
                }
                if (DateSentAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("DateSent>", Serializers.DateTimeIso8601(DateSentAfter)));
                }
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> Update a Message resource (used to redact Message `body` text and to cancel not-yet-sent messages) </summary>
    public class UpdateMessageOptions : IOptions<MessageResource>
    {
    
        ///<summary> The SID of the Message resource to be updated </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Message resources to update. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> The new `body` of the Message resource. To redact the text content of a Message, this parameter's value must be an empty string </summary> 
        public string Body { get; set; }

        
        public MessageResource.UpdateStatusEnum Status { get; set; }



        /// <summary> Construct a new UpdateMessageOptions </summary>
        /// <param name="pathSid"> The SID of the Message resource to be updated </param>
        public UpdateMessageOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            return p;
        }
        

    }


}

