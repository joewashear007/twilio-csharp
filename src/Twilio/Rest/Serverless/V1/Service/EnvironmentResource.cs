/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Serverless
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



namespace Twilio.Rest.Serverless.V1.Service
{
    public class EnvironmentResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateEnvironmentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Environments";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Serverless,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new environment. </summary>
        /// <param name="options"> Create Environment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Environment </returns>
        public static EnvironmentResource Create(CreateEnvironmentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new environment. </summary>
        /// <param name="options"> Create Environment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Environment </returns>
        public static async System.Threading.Tasks.Task<EnvironmentResource> CreateAsync(CreateEnvironmentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new environment. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the Environment resource under. </param>
        /// <param name="uniqueName"> A user-defined string that uniquely identifies the Environment resource. It can be a maximum of 100 characters. </param>
        /// <param name="domainSuffix"> A URL-friendly name that represents the environment and forms part of the domain name. It can be a maximum of 16 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Environment </returns>
        public static EnvironmentResource Create(
                                          string pathServiceSid,
                                          string uniqueName,
                                          string domainSuffix = null,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateEnvironmentOptions(pathServiceSid, uniqueName){  DomainSuffix = domainSuffix };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new environment. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the Environment resource under. </param>
        /// <param name="uniqueName"> A user-defined string that uniquely identifies the Environment resource. It can be a maximum of 100 characters. </param>
        /// <param name="domainSuffix"> A URL-friendly name that represents the environment and forms part of the domain name. It can be a maximum of 16 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Environment </returns>
        public static async System.Threading.Tasks.Task<EnvironmentResource> CreateAsync(
                                                                                  string pathServiceSid,
                                                                                  string uniqueName,
                                                                                  string domainSuffix = null,
                                                                                    ITwilioRestClient client = null)
        {
        var options = new CreateEnvironmentOptions(pathServiceSid, uniqueName){  DomainSuffix = domainSuffix };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete a specific environment. </summary>
        /// <param name="options"> Delete Environment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Environment </returns>
        private static Request BuildDeleteRequest(DeleteEnvironmentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Environments/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Serverless,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific environment. </summary>
        /// <param name="options"> Delete Environment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Environment </returns>
        public static bool Delete(DeleteEnvironmentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a specific environment. </summary>
        /// <param name="options"> Delete Environment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Environment </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteEnvironmentOptions options,
                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a specific environment. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to delete the Environment resource from. </param>
        /// <param name="pathSid"> The SID of the Environment resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Environment </returns>
        public static bool Delete(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteEnvironmentOptions(pathServiceSid, pathSid)        ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a specific environment. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to delete the Environment resource from. </param>
        /// <param name="pathSid"> The SID of the Environment resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Environment </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteEnvironmentOptions(pathServiceSid, pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchEnvironmentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Environments/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Retrieve a specific environment. </summary>
        /// <param name="options"> Fetch Environment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Environment </returns>
        public static EnvironmentResource Fetch(FetchEnvironmentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Retrieve a specific environment. </summary>
        /// <param name="options"> Fetch Environment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Environment </returns>
        public static async System.Threading.Tasks.Task<EnvironmentResource> FetchAsync(FetchEnvironmentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Retrieve a specific environment. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Environment resource from. </param>
        /// <param name="pathSid"> The SID of the Environment resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Environment </returns>
        public static EnvironmentResource Fetch(
                                         string pathServiceSid, 
                                         string pathSid, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchEnvironmentOptions(pathServiceSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a specific environment. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Environment resource from. </param>
        /// <param name="pathSid"> The SID of the Environment resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Environment </returns>
        public static async System.Threading.Tasks.Task<EnvironmentResource> FetchAsync(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchEnvironmentOptions(pathServiceSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadEnvironmentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Environments";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all environments. </summary>
        /// <param name="options"> Read Environment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Environment </returns>
        public static ResourceSet<EnvironmentResource> Read(ReadEnvironmentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<EnvironmentResource>.FromJson("environments", response.Content);
            return new ResourceSet<EnvironmentResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all environments. </summary>
        /// <param name="options"> Read Environment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Environment </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EnvironmentResource>> ReadAsync(ReadEnvironmentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<EnvironmentResource>.FromJson("environments", response.Content);
            return new ResourceSet<EnvironmentResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all environments. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the Environment resources from. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Environment </returns>
        public static ResourceSet<EnvironmentResource> Read(
                                                     string pathServiceSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadEnvironmentOptions(pathServiceSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all environments. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the Environment resources from. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Environment </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EnvironmentResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadEnvironmentOptions(pathServiceSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<EnvironmentResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<EnvironmentResource>.FromJson("environments", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<EnvironmentResource> NextPage(Page<EnvironmentResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<EnvironmentResource>.FromJson("environments", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<EnvironmentResource> PreviousPage(Page<EnvironmentResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<EnvironmentResource>.FromJson("environments", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a EnvironmentResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> EnvironmentResource object represented by the provided JSON </returns>
        public static EnvironmentResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<EnvironmentResource>(json);
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

    
        ///<summary> The unique string that we created to identify the Environment resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Environment resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Service that the Environment resource is associated with. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The SID of the build deployed in the environment. </summary> 
        [JsonProperty("build_sid")]
        public string BuildSid { get; private set; }

        ///<summary> A user-defined string that uniquely identifies the Environment resource. </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> A URL-friendly name that represents the environment and forms part of the domain name. </summary> 
        [JsonProperty("domain_suffix")]
        public string DomainSuffix { get; private set; }

        ///<summary> The domain name for all Functions and Assets deployed in the Environment, using the Service unique name, a randomly-generated Service suffix, and an optional Environment domain suffix. </summary> 
        [JsonProperty("domain_name")]
        public string DomainName { get; private set; }

        ///<summary> The date and time in GMT when the Environment resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the Environment resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the Environment resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The URLs of the Environment resource's nested resources. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private EnvironmentResource() {

        }
    }
}

