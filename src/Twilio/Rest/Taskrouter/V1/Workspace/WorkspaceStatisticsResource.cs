/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Taskrouter
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



namespace Twilio.Rest.Taskrouter.V1.Workspace
{
    public class WorkspaceStatisticsResource : Resource
    {
    

    

        
        private static Request BuildFetchRequest(FetchWorkspaceStatisticsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Workspaces/{WorkspaceSid}/Statistics";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{"+"WorkspaceSid"+"}", PathWorkspaceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch WorkspaceStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkspaceStatistics </returns>
        public static WorkspaceStatisticsResource Fetch(FetchWorkspaceStatisticsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch WorkspaceStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkspaceStatistics </returns>
        public static async System.Threading.Tasks.Task<WorkspaceStatisticsResource> FetchAsync(FetchWorkspaceStatisticsOptions options, ITwilioRestClient client = null,  System.Threading.CancellationToken cancellationToken = default)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client), cancellationToken);
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace to fetch. </param>
        /// <param name="minutes"> Only calculate statistics since this many minutes in the past. The default 15 minutes. This is helpful for displaying statistics for the last 15 minutes, 240 minutes (4 hours), and 480 minutes (8 hours) to see trends. </param>
        /// <param name="startDate"> Only calculate statistics from this date and time and later, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </param>
        /// <param name="endDate"> Only calculate statistics from this date and time and earlier, specified in GMT as an [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date-time. </param>
        /// <param name="taskChannel"> Only calculate statistics on this TaskChannel. Can be the TaskChannel's SID or its `unique_name`, such as `voice`, `sms`, or `default`. </param>
        /// <param name="splitByWaitTime"> A comma separated list of values that describes the thresholds, in seconds, to calculate statistics on. For each threshold specified, the number of Tasks canceled and reservations accepted above and below the specified thresholds in seconds are computed. For example, `5,30` would show splits of Tasks that were canceled or accepted before and after 5 seconds and before and after 30 seconds. This can be used to show short abandoned Tasks or Tasks that failed to meet an SLA. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkspaceStatistics </returns>
        public static WorkspaceStatisticsResource Fetch(
                                         string pathWorkspaceSid, 
                                         int? minutes = null, 
                                         DateTime? startDate = null, 
                                         DateTime? endDate = null, 
                                         string taskChannel = null, 
                                         string splitByWaitTime = null, 
                                        ITwilioRestClient client = null)
        {
            var options = new FetchWorkspaceStatisticsOptions(pathWorkspaceSid){ Minutes = minutes,StartDate = startDate,EndDate = endDate,TaskChannel = taskChannel,SplitByWaitTime = splitByWaitTime };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace to fetch. </param>
        /// <param name="minutes"> Only calculate statistics since this many minutes in the past. The default 15 minutes. This is helpful for displaying statistics for the last 15 minutes, 240 minutes (4 hours), and 480 minutes (8 hours) to see trends. </param>
        /// <param name="startDate"> Only calculate statistics from this date and time and later, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </param>
        /// <param name="endDate"> Only calculate statistics from this date and time and earlier, specified in GMT as an [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date-time. </param>
        /// <param name="taskChannel"> Only calculate statistics on this TaskChannel. Can be the TaskChannel's SID or its `unique_name`, such as `voice`, `sms`, or `default`. </param>
        /// <param name="splitByWaitTime"> A comma separated list of values that describes the thresholds, in seconds, to calculate statistics on. For each threshold specified, the number of Tasks canceled and reservations accepted above and below the specified thresholds in seconds are computed. For example, `5,30` would show splits of Tasks that were canceled or accepted before and after 5 seconds and before and after 30 seconds. This can be used to show short abandoned Tasks or Tasks that failed to meet an SLA. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkspaceStatistics </returns>
        public static async System.Threading.Tasks.Task<WorkspaceStatisticsResource> FetchAsync(string pathWorkspaceSid, int? minutes = null, DateTime? startDate = null, DateTime? endDate = null, string taskChannel = null, string splitByWaitTime = null, ITwilioRestClient client = null , System.Threading.CancellationToken cancellationToken = default)
        {
            var options = new FetchWorkspaceStatisticsOptions(pathWorkspaceSid){ Minutes = minutes,StartDate = startDate,EndDate = endDate,TaskChannel = taskChannel,SplitByWaitTime = splitByWaitTime };
            return await FetchAsync(options, client, cancellationToken);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a WorkspaceStatisticsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WorkspaceStatisticsResource object represented by the provided JSON </returns>
        public static WorkspaceStatisticsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<WorkspaceStatisticsResource>(json);
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

    
        ///<summary> An object that contains the real-time statistics for the Workspace. </summary> 
        [JsonProperty("realtime")]
        public object Realtime { get; private set; }

        ///<summary> An object that contains the cumulative statistics for the Workspace. </summary> 
        [JsonProperty("cumulative")]
        public object Cumulative { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Workspace resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Workspace. </summary> 
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }

        ///<summary> The absolute URL of the Workspace statistics resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private WorkspaceStatisticsResource() {

        }
    }
}

