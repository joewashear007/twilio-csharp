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


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Constant;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Twilio.Rest.Api.V2010.Account
{
    public class SigningKeyResource : Resource
    {
    

    

        
        /// <summary> delete </summary>
        /// <param name="options"> Delete SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns>
        private static Request BuildDeleteRequest(DeleteSigningKeyOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SigningKeys/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns>
        public static bool Delete(DeleteSigningKeyOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSigningKeyOptions options, 
                                                                        ITwilioRestClient client = null,
                                                                        CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client), cancellationToken);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathSid">  </param>
        /// <param name="pathAccountSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns>
        public static bool Delete(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteSigningKeyOptions(pathSid)      { PathAccountSid = pathAccountSid }   ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathSid">  </param>
        /// <param name="pathAccountSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteSigningKeyOptions(pathSid)  { PathAccountSid = pathAccountSid };
            return await DeleteAsync(options, client, cancellationToken);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchSigningKeyOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SigningKeys/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns>
        public static SigningKeyResource Fetch(FetchSigningKeyOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns>
        public static async System.Threading.Tasks.Task<SigningKeyResource> FetchAsync(FetchSigningKeyOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathSid">  </param>
        /// <param name="pathAccountSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns>
        public static SigningKeyResource Fetch(
                                         string pathSid, 
                                         string pathAccountSid = null, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchSigningKeyOptions(pathSid){ PathAccountSid = pathAccountSid };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathSid">  </param>
        /// <param name="pathAccountSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns>
        public static async System.Threading.Tasks.Task<SigningKeyResource> FetchAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchSigningKeyOptions(pathSid){ PathAccountSid = pathAccountSid };
            return await FetchAsync(options, client, cancellationToken);
        }
        #endif
        
        private static Request BuildReadRequest(ReadSigningKeyOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SigningKeys.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns>
        public static ResourceSet<SigningKeyResource> Read(ReadSigningKeyOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<SigningKeyResource>.FromJson("signing_keys", response.Content);
            return new ResourceSet<SigningKeyResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SigningKeyResource>> ReadAsync(ReadSigningKeyOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client), cancellationToken);

            var page = Page<SigningKeyResource>.FromJson("signing_keys", response.Content);
            return new ResourceSet<SigningKeyResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pathAccountSid">  </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns>
        public static ResourceSet<SigningKeyResource> Read(
                                                     string pathAccountSid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadSigningKeyOptions(){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pathAccountSid">  </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SigningKeyResource>> ReadAsync(
                                                                                             string pathAccountSid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadSigningKeyOptions(){ PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client, cancellationToken);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SigningKeyResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SigningKeyResource>.FromJson("signing_keys", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SigningKeyResource> NextPage(Page<SigningKeyResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SigningKeyResource>.FromJson("signing_keys", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SigningKeyResource> PreviousPage(Page<SigningKeyResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SigningKeyResource>.FromJson("signing_keys", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateSigningKeyOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/SigningKeys/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns>
        public static SigningKeyResource Update(UpdateSigningKeyOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update SigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<SigningKeyResource> UpdateAsync(UpdateSigningKeyOptions options, 
                                                                                                    ITwilioRestClient client = null,
                                                                                                    CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathSid">  </param>
        /// <param name="pathAccountSid">  </param>
        /// <param name="friendlyName">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SigningKey </returns>
        public static SigningKeyResource Update(
                                          string pathSid,
                                          string pathAccountSid = null,
                                          string friendlyName = null,
                                            ITwilioRestClient client = null)
        {
            var options = new UpdateSigningKeyOptions(pathSid){ PathAccountSid = pathAccountSid, FriendlyName = friendlyName };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathSid">  </param>
        /// <param name="pathAccountSid">  </param>
        /// <param name="friendlyName">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SigningKey </returns>
        public static async System.Threading.Tasks.Task<SigningKeyResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string pathAccountSid = null,
                                                                              string friendlyName = null,
                                                                                ITwilioRestClient client = null)
        {
            var options = new UpdateSigningKeyOptions(pathSid){ PathAccountSid = pathAccountSid, FriendlyName = friendlyName };
            return await UpdateAsync(options, client, cancellationToken);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a SigningKeyResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SigningKeyResource object represented by the provided JSON </returns>
        public static SigningKeyResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SigningKeyResource>(json);
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

    
        ///<summary> The sid </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The friendly_name </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The date_created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date_updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }



        private SigningKeyResource() {

        }
    }
}

