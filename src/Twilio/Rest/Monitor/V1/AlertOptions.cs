/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Monitor.V1
{

    /// <summary>
    /// FetchAlertOptions
    /// </summary>
    public class FetchAlertOptions : IOptions<AlertResource>
    {
        /// <summary>
        /// The SID that identifies the resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchAlertOptions
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        public FetchAlertOptions(string pathSid)
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
    /// ReadAlertOptions
    /// </summary>
    public class ReadAlertOptions : ReadOptions<AlertResource>
    {
        /// <summary>
        /// Only show alerts for this log-level
        /// </summary>
        public string LogLevel { get; set; }
        /// <summary>
        /// Only include alerts that occurred on or after this date and time
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Only include alerts that occurred on or before this date and time
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (LogLevel != null)
            {
                p.Add(new KeyValuePair<string, string>("LogLevel", LogLevel));
            }

            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", StartDate.Value.ToString("yyyy-MM-dd")));
            }

            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", EndDate.Value.ToString("yyyy-MM-dd")));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}