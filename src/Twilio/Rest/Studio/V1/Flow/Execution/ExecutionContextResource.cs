/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Studio
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



namespace Twilio.Rest.Studio.V1.Flow.Execution
{
    public class ExecutionContextResource : Resource
    {
    

    

        
        private static Request BuildFetchRequest(FetchExecutionContextOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Flows/{FlowSid}/Executions/{ExecutionSid}/Context";

            string PathFlowSid = options.PathFlowSid;
            path = path.Replace("{"+"FlowSid"+"}", PathFlowSid);
            string PathExecutionSid = options.PathExecutionSid;
            path = path.Replace("{"+"ExecutionSid"+"}", PathExecutionSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Retrieve the most recent context for an Execution. </summary>
        /// <param name="options"> Fetch ExecutionContext parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ExecutionContext </returns>
        public static ExecutionContextResource Fetch(FetchExecutionContextOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Retrieve the most recent context for an Execution. </summary>
        /// <param name="options"> Fetch ExecutionContext parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ExecutionContext </returns>
        public static async System.Threading.Tasks.Task<ExecutionContextResource> FetchAsync(FetchExecutionContextOptions options, ITwilioRestClient client = null,  CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Retrieve the most recent context for an Execution. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Execution context to fetch. </param>
        /// <param name="pathExecutionSid"> The SID of the Execution context to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ExecutionContext </returns>
        public static ExecutionContextResource Fetch(
                                         string pathFlowSid, 
                                         string pathExecutionSid, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchExecutionContextOptions(pathFlowSid, pathExecutionSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Retrieve the most recent context for an Execution. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Execution context to fetch. </param>
        /// <param name="pathExecutionSid"> The SID of the Execution context to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ExecutionContext </returns>
        public static async System.Threading.Tasks.Task<ExecutionContextResource> FetchAsync(string pathFlowSid, string pathExecutionSid, ITwilioRestClient client = null)
        {
            var options = new FetchExecutionContextOptions(pathFlowSid, pathExecutionSid){  };
            return await FetchAsync(options, client, cancellationToken);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a ExecutionContextResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ExecutionContextResource object represented by the provided JSON </returns>
        public static ExecutionContextResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ExecutionContextResource>(json);
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

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the ExecutionContext resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The current state of the Flow's Execution. As a flow executes, we save its state in this context. We save data that your widgets can access as variables in configuration fields or in text areas as variable substitution. </summary> 
        [JsonProperty("context")]
        public object Context { get; private set; }

        ///<summary> The SID of the Flow. </summary> 
        [JsonProperty("flow_sid")]
        public string FlowSid { get; private set; }

        ///<summary> The SID of the context's Execution resource. </summary> 
        [JsonProperty("execution_sid")]
        public string ExecutionSid { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private ExecutionContextResource() {

        }
    }
}

