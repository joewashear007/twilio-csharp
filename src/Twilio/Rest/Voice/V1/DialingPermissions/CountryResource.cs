/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// CountryResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Voice.V1.DialingPermissions
{

    public class CountryResource : Resource
    {
        private static Request BuildFetchRequest(FetchCountryOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Voice,
                "/v1/DialingPermissions/Countries/" + options.PathIsoCode + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve voice dialing country permissions identified by the given ISO country code
        /// </summary>
        /// <param name="options"> Fetch Country parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Country </returns>
        public static CountryResource Fetch(FetchCountryOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Retrieve voice dialing country permissions identified by the given ISO country code
        /// </summary>
        /// <param name="options"> Fetch Country parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Country </returns>
        public static async System.Threading.Tasks.Task<CountryResource> FetchAsync(FetchCountryOptions options,
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Retrieve voice dialing country permissions identified by the given ISO country code
        /// </summary>
        /// <param name="pathIsoCode"> The ISO country code </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Country </returns>
        public static CountryResource Fetch(string pathIsoCode, ITwilioRestClient client = null)
        {
            var options = new FetchCountryOptions(pathIsoCode);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve voice dialing country permissions identified by the given ISO country code
        /// </summary>
        /// <param name="pathIsoCode"> The ISO country code </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Country </returns>
        public static async System.Threading.Tasks.Task<CountryResource> FetchAsync(string pathIsoCode,
                                                                                    ITwilioRestClient client = null)
        {
            var options = new FetchCountryOptions(pathIsoCode);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadCountryOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Voice,
                "/v1/DialingPermissions/Countries",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve all voice dialing country permissions for this account
        /// </summary>
        /// <param name="options"> Read Country parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Country </returns>
        public static ResourceSet<CountryResource> Read(ReadCountryOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<CountryResource>.FromJson("content", response.Content);
            return new ResourceSet<CountryResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve all voice dialing country permissions for this account
        /// </summary>
        /// <param name="options"> Read Country parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Country </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CountryResource>> ReadAsync(ReadCountryOptions options,
                                                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<CountryResource>.FromJson("content", response.Content);
            return new ResourceSet<CountryResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve all voice dialing country permissions for this account
        /// </summary>
        /// <param name="isoCode"> Filter to retrieve the country permissions by specifying the ISO country code </param>
        /// <param name="continent"> Filter to retrieve the country permissions by specifying the continent </param>
        /// <param name="countryCode"> Country code filter </param>
        /// <param name="lowRiskNumbersEnabled"> Filter to retrieve the country permissions with dialing to low-risk numbers
        ///                             enabled </param>
        /// <param name="highRiskSpecialNumbersEnabled"> Filter to retrieve the country permissions with dialing to high-risk
        ///                                     special service numbers enabled </param>
        /// <param name="highRiskTollfraudNumbersEnabled"> Filter to retrieve the country permissions with dialing to high-risk
        ///                                       toll fraud numbers enabled </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Country </returns>
        public static ResourceSet<CountryResource> Read(string isoCode = null,
                                                        string continent = null,
                                                        string countryCode = null,
                                                        bool? lowRiskNumbersEnabled = null,
                                                        bool? highRiskSpecialNumbersEnabled = null,
                                                        bool? highRiskTollfraudNumbersEnabled = null,
                                                        int? pageSize = null,
                                                        long? limit = null,
                                                        ITwilioRestClient client = null)
        {
            var options = new ReadCountryOptions(){IsoCode = isoCode, Continent = continent, CountryCode = countryCode, LowRiskNumbersEnabled = lowRiskNumbersEnabled, HighRiskSpecialNumbersEnabled = highRiskSpecialNumbersEnabled, HighRiskTollfraudNumbersEnabled = highRiskTollfraudNumbersEnabled, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve all voice dialing country permissions for this account
        /// </summary>
        /// <param name="isoCode"> Filter to retrieve the country permissions by specifying the ISO country code </param>
        /// <param name="continent"> Filter to retrieve the country permissions by specifying the continent </param>
        /// <param name="countryCode"> Country code filter </param>
        /// <param name="lowRiskNumbersEnabled"> Filter to retrieve the country permissions with dialing to low-risk numbers
        ///                             enabled </param>
        /// <param name="highRiskSpecialNumbersEnabled"> Filter to retrieve the country permissions with dialing to high-risk
        ///                                     special service numbers enabled </param>
        /// <param name="highRiskTollfraudNumbersEnabled"> Filter to retrieve the country permissions with dialing to high-risk
        ///                                       toll fraud numbers enabled </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Country </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CountryResource>> ReadAsync(string isoCode = null,
                                                                                                string continent = null,
                                                                                                string countryCode = null,
                                                                                                bool? lowRiskNumbersEnabled = null,
                                                                                                bool? highRiskSpecialNumbersEnabled = null,
                                                                                                bool? highRiskTollfraudNumbersEnabled = null,
                                                                                                int? pageSize = null,
                                                                                                long? limit = null,
                                                                                                ITwilioRestClient client = null)
        {
            var options = new ReadCountryOptions(){IsoCode = isoCode, Continent = continent, CountryCode = countryCode, LowRiskNumbersEnabled = lowRiskNumbersEnabled, HighRiskSpecialNumbersEnabled = highRiskSpecialNumbersEnabled, HighRiskTollfraudNumbersEnabled = highRiskTollfraudNumbersEnabled, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<CountryResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CountryResource>.FromJson("content", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<CountryResource> NextPage(Page<CountryResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Voice,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<CountryResource>.FromJson("content", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<CountryResource> PreviousPage(Page<CountryResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Voice,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<CountryResource>.FromJson("content", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a CountryResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CountryResource object represented by the provided JSON </returns>
        public static CountryResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<CountryResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The ISO country code
        /// </summary>
        [JsonProperty("iso_code")]
        public string IsoCode { get; private set; }
        /// <summary>
        /// The name of the country
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }
        /// <summary>
        /// The name of the continent in which the country is located
        /// </summary>
        [JsonProperty("continent")]
        public string Continent { get; private set; }
        /// <summary>
        /// The E.164 assigned country codes(s)
        /// </summary>
        [JsonProperty("country_codes")]
        public List<string> CountryCodes { get; private set; }
        /// <summary>
        /// Whether dialing to low-risk numbers is enabled
        /// </summary>
        [JsonProperty("low_risk_numbers_enabled")]
        public bool? LowRiskNumbersEnabled { get; private set; }
        /// <summary>
        /// Whether dialing to high-risk special services numbers is enabled
        /// </summary>
        [JsonProperty("high_risk_special_numbers_enabled")]
        public bool? HighRiskSpecialNumbersEnabled { get; private set; }
        /// <summary>
        /// Whether dialing to high-risk toll fraud numbers is enabled, else `false`
        /// </summary>
        [JsonProperty("high_risk_tollfraud_numbers_enabled")]
        public bool? HighRiskTollfraudNumbersEnabled { get; private set; }
        /// <summary>
        /// The absolute URL of this resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// A list of URLs related to this resource
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private CountryResource()
        {

        }
    }

}