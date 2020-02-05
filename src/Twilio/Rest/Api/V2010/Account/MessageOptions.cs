/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account
{

    /// <summary>
    /// Send a message from the account used to make the request
    /// </summary>
    public class CreateMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The SID of the Account that will create the resource
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The destination phone number
        /// </summary>
        public Types.PhoneNumber To { get; }
        /// <summary>
        /// The phone number that initiated the message
        /// </summary>
        public Types.PhoneNumber From { get; set; }
        /// <summary>
        /// The SID of the Messaging Service you want to associate with the message.
        /// </summary>
        public string MessagingServiceSid { get; set; }
        /// <summary>
        /// The text of the message you want to send. Can be up to 1,600 characters in length.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The URL of the media to send with the message
        /// </summary>
        public List<Uri> MediaUrl { get; set; }
        /// <summary>
        /// The URL we should call to send status information to your application
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// The application to use for callbacks
        /// </summary>
        public string ApplicationSid { get; set; }
        /// <summary>
        /// The total maximum price up to 4 decimal places in US dollars acceptable for the message to be delivered.
        /// </summary>
        public decimal? MaxPrice { get; set; }
        /// <summary>
        /// Whether to confirm delivery of the message
        /// </summary>
        public bool? ProvideFeedback { get; set; }
        /// <summary>
        /// The number of seconds that the message can remain in our outgoing queue.
        /// </summary>
        public int? ValidityPeriod { get; set; }
        /// <summary>
        /// Reserved
        /// </summary>
        public bool? ForceDelivery { get; set; }
        /// <summary>
        /// Determines if the message content can be stored or redacted based on privacy settings
        /// </summary>
        public MessageResource.ContentRetentionEnum ContentRetention { get; set; }
        /// <summary>
        /// Determines if the address can be stored or obfuscated based on privacy settings
        /// </summary>
        public MessageResource.AddressRetentionEnum AddressRetention { get; set; }
        /// <summary>
        /// Whether to detect Unicode characters that have a similar GSM-7 character and replace them
        /// </summary>
        public bool? SmartEncoded { get; set; }
        /// <summary>
        /// Rich actions for Channels Messages.
        /// </summary>
        public List<string> PersistentAction { get; set; }

        /// <summary>
        /// Construct a new CreateMessageOptions
        /// </summary>
        /// <param name="to"> The destination phone number </param>
        public CreateMessageOptions(Types.PhoneNumber to)
        {
            To = to;
            MediaUrl = new List<Uri>();
            PersistentAction = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
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

            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid.ToString()));
            }

            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }

            if (MediaUrl != null)
            {
                p.AddRange(MediaUrl.Select(prop => new KeyValuePair<string, string>("MediaUrl", Serializers.Url(prop))));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }

            if (ApplicationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ApplicationSid", ApplicationSid.ToString()));
            }

            if (MaxPrice != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxPrice", MaxPrice.Value.ToString()));
            }

            if (ProvideFeedback != null)
            {
                p.Add(new KeyValuePair<string, string>("ProvideFeedback", ProvideFeedback.Value.ToString().ToLower()));
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
                p.AddRange(PersistentAction.Select(prop => new KeyValuePair<string, string>("PersistentAction", prop)));
            }

            return p;
        }
    }

    /// <summary>
    /// Deletes a message record from your account
    /// </summary>
    public class DeleteMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The SID of the Account that created the resources to delete
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteMessageOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public DeleteMessageOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Fetch a message belonging to the account used to make the request
    /// </summary>
    public class FetchMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The SID of the Account that created the resource to fetch
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchMessageOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchMessageOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Retrieve a list of messages belonging to the account used to make the request
    /// </summary>
    public class ReadMessageOptions : ReadOptions<MessageResource>
    {
        /// <summary>
        /// The SID of the Account that created the resources to read
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Filter by messages sent to this number
        /// </summary>
        public Types.PhoneNumber To { get; set; }
        /// <summary>
        /// Filter by from number
        /// </summary>
        public Types.PhoneNumber From { get; set; }
        /// <summary>
        /// Filter by date sent
        /// </summary>
        public DateTime? DateSentBefore { get; set; }
        /// <summary>
        /// Filter by date sent
        /// </summary>
        public DateTime? DateSent { get; set; }
        /// <summary>
        /// Filter by date sent
        /// </summary>
        public DateTime? DateSentAfter { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
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

    /// <summary>
    /// To redact a message-body from a post-flight message record, post to the message instance resource with an empty body
    /// </summary>
    public class UpdateMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The SID of the Account that created the resources to update
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The text of the message you want to send
        /// </summary>
        public string Body { get; }

        /// <summary>
        /// Construct a new UpdateMessageOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="body"> The text of the message you want to send </param>
        public UpdateMessageOptions(string pathSid, string body)
        {
            PathSid = pathSid;
            Body = body;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }

            return p;
        }
    }

}