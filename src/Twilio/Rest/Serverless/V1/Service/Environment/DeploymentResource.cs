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



namespace Twilio.Rest.Serverless.V1.Service.Environment
{
    public class DeploymentResource : Resource
    {
    

    

        
        private static Request BuildCreateRequest(CreateDeploymentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Environments/{EnvironmentSid}/Deployments";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathEnvironmentSid = options.PathEnvironmentSid;
            path = path.Replace("{"+"EnvironmentSid"+"}", PathEnvironmentSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Serverless,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Deployment. </summary>
        /// <param name="options"> Create Deployment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Deployment </returns>
        public static DeploymentResource Create(CreateDeploymentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Deployment. </summary>
        /// <param name="options"> Create Deployment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Deployment </returns>
        public static async System.Threading.Tasks.Task<DeploymentResource> CreateAsync(CreateDeploymentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Deployment. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the Deployment resource under. </param>
        /// <param name="pathEnvironmentSid"> The SID of the Environment for the Deployment. </param>
        /// <param name="buildSid"> The SID of the Build for the Deployment. </param>
        /// <param name="isPlugin"> Whether the Deployment is a plugin. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Deployment </returns>
        public static DeploymentResource Create(
                                          string pathServiceSid,
                                          string pathEnvironmentSid,
                                          string buildSid = null,
                                          bool? isPlugin = null,
                                            ITwilioRestClient client = null)
        {
            var options = new CreateDeploymentOptions(pathServiceSid, pathEnvironmentSid){  BuildSid = buildSid, IsPlugin = isPlugin };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Deployment. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the Deployment resource under. </param>
        /// <param name="pathEnvironmentSid"> The SID of the Environment for the Deployment. </param>
        /// <param name="buildSid"> The SID of the Build for the Deployment. </param>
        /// <param name="isPlugin"> Whether the Deployment is a plugin. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Deployment </returns>
        public static async System.Threading.Tasks.Task<DeploymentResource> CreateAsync(
                                                                                  string pathServiceSid,
                                                                                  string pathEnvironmentSid,
                                                                                  string buildSid = null,
                                                                                  bool? isPlugin = null,
                                                                                    ITwilioRestClient client = null)
        {
        var options = new CreateDeploymentOptions(pathServiceSid, pathEnvironmentSid){  BuildSid = buildSid, IsPlugin = isPlugin };
            return await CreateAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchDeploymentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Environments/{EnvironmentSid}/Deployments/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathEnvironmentSid = options.PathEnvironmentSid;
            path = path.Replace("{"+"EnvironmentSid"+"}", PathEnvironmentSid);
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

        /// <summary> Retrieve a specific Deployment. </summary>
        /// <param name="options"> Fetch Deployment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Deployment </returns>
        public static DeploymentResource Fetch(FetchDeploymentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Retrieve a specific Deployment. </summary>
        /// <param name="options"> Fetch Deployment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Deployment </returns>
        public static async System.Threading.Tasks.Task<DeploymentResource> FetchAsync(FetchDeploymentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Retrieve a specific Deployment. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Deployment resource from. </param>
        /// <param name="pathEnvironmentSid"> The SID of the Environment used by the Deployment to fetch. </param>
        /// <param name="pathSid"> The SID that identifies the Deployment resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Deployment </returns>
        public static DeploymentResource Fetch(
                                         string pathServiceSid, 
                                         string pathEnvironmentSid, 
                                         string pathSid, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchDeploymentOptions(pathServiceSid, pathEnvironmentSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a specific Deployment. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Deployment resource from. </param>
        /// <param name="pathEnvironmentSid"> The SID of the Environment used by the Deployment to fetch. </param>
        /// <param name="pathSid"> The SID that identifies the Deployment resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Deployment </returns>
        public static async System.Threading.Tasks.Task<DeploymentResource> FetchAsync(string pathServiceSid, string pathEnvironmentSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchDeploymentOptions(pathServiceSid, pathEnvironmentSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadDeploymentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Environments/{EnvironmentSid}/Deployments";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathEnvironmentSid = options.PathEnvironmentSid;
            path = path.Replace("{"+"EnvironmentSid"+"}", PathEnvironmentSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Deployments. </summary>
        /// <param name="options"> Read Deployment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Deployment </returns>
        public static ResourceSet<DeploymentResource> Read(ReadDeploymentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<DeploymentResource>.FromJson("deployments", response.Content);
            return new ResourceSet<DeploymentResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Deployments. </summary>
        /// <param name="options"> Read Deployment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Deployment </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DeploymentResource>> ReadAsync(ReadDeploymentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<DeploymentResource>.FromJson("deployments", response.Content);
            return new ResourceSet<DeploymentResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Deployments. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the Deployment resources from. </param>
        /// <param name="pathEnvironmentSid"> The SID of the Environment used by the Deployment resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Deployment </returns>
        public static ResourceSet<DeploymentResource> Read(
                                                     string pathServiceSid,
                                                     string pathEnvironmentSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadDeploymentOptions(pathServiceSid, pathEnvironmentSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Deployments. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the Deployment resources from. </param>
        /// <param name="pathEnvironmentSid"> The SID of the Environment used by the Deployment resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Deployment </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DeploymentResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             string pathEnvironmentSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadDeploymentOptions(pathServiceSid, pathEnvironmentSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<DeploymentResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<DeploymentResource>.FromJson("deployments", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<DeploymentResource> NextPage(Page<DeploymentResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<DeploymentResource>.FromJson("deployments", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<DeploymentResource> PreviousPage(Page<DeploymentResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<DeploymentResource>.FromJson("deployments", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a DeploymentResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DeploymentResource object represented by the provided JSON </returns>
        public static DeploymentResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<DeploymentResource>(json);
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

    
        ///<summary> The unique string that we created to identify the Deployment resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Deployment resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Service that the Deployment resource is associated with. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The SID of the Environment for the Deployment. </summary> 
        [JsonProperty("environment_sid")]
        public string EnvironmentSid { get; private set; }

        ///<summary> The SID of the Build for the deployment. </summary> 
        [JsonProperty("build_sid")]
        public string BuildSid { get; private set; }

        ///<summary> The date and time in GMT when the Deployment resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the Deployment resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the Deployment resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private DeploymentResource() {

        }
    }
}

