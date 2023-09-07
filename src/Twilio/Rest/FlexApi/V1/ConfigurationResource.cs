/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
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
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;


namespace Twilio.Rest.FlexApi.V1
{
    public class ConfigurationResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum Ok = new StatusEnum("ok");
            public static readonly StatusEnum Inprogress = new StatusEnum("inprogress");
            public static readonly StatusEnum Notstarted = new StatusEnum("notstarted");

        }

        
        private static Request BuildFetchRequest(FetchConfigurationOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Configuration";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Configuration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Configuration </returns>
        public static ConfigurationResource Fetch(FetchConfigurationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Configuration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Configuration </returns>
        public static async System.Threading.Tasks.Task<ConfigurationResource> FetchAsync(FetchConfigurationOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="uiVersion"> The Pinned UI version of the Configuration resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Configuration </returns>
        public static ConfigurationResource Fetch(
                                         string uiVersion = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchConfigurationOptions(){ UiVersion = uiVersion };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="uiVersion"> The Pinned UI version of the Configuration resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Configuration </returns>
        public static async System.Threading.Tasks.Task<ConfigurationResource> FetchAsync(string uiVersion = null, ITwilioRestClient client = null)
        {
            var options = new FetchConfigurationOptions(){ UiVersion = uiVersion };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a ConfigurationResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ConfigurationResource object represented by the provided JSON </returns>
        public static ConfigurationResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ConfigurationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Configuration resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The date and time in GMT when the Configuration resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the Configuration resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> An object that contains application-specific data. </summary> 
        [JsonProperty("attributes")]
        public object Attributes { get; private set; }

        
        [JsonProperty("status")]
        public ConfigurationResource.StatusEnum Status { get; private set; }

        ///<summary> The SID of the TaskRouter Workspace. </summary> 
        [JsonProperty("taskrouter_workspace_sid")]
        public string TaskrouterWorkspaceSid { get; private set; }

        ///<summary> The SID of the TaskRouter target Workflow. </summary> 
        [JsonProperty("taskrouter_target_workflow_sid")]
        public string TaskrouterTargetWorkflowSid { get; private set; }

        ///<summary> The SID of the TaskRouter Target TaskQueue. </summary> 
        [JsonProperty("taskrouter_target_taskqueue_sid")]
        public string TaskrouterTargetTaskqueueSid { get; private set; }

        ///<summary> The list of TaskRouter TaskQueues. </summary> 
        [JsonProperty("taskrouter_taskqueues")]
        public List<object> TaskrouterTaskqueues { get; private set; }

        ///<summary> The Skill description for TaskRouter workers. </summary> 
        [JsonProperty("taskrouter_skills")]
        public List<object> TaskrouterSkills { get; private set; }

        ///<summary> The TaskRouter default channel capacities and availability for workers. </summary> 
        [JsonProperty("taskrouter_worker_channels")]
        public object TaskrouterWorkerChannels { get; private set; }

        ///<summary> The TaskRouter Worker attributes. </summary> 
        [JsonProperty("taskrouter_worker_attributes")]
        public object TaskrouterWorkerAttributes { get; private set; }

        ///<summary> The TaskRouter SID of the offline activity. </summary> 
        [JsonProperty("taskrouter_offline_activity_sid")]
        public string TaskrouterOfflineActivitySid { get; private set; }

        ///<summary> The URL where the Flex instance is hosted. </summary> 
        [JsonProperty("runtime_domain")]
        public Uri RuntimeDomain { get; private set; }

        ///<summary> The SID of the Messaging service instance. </summary> 
        [JsonProperty("messaging_service_instance_sid")]
        public string MessagingServiceInstanceSid { get; private set; }

        ///<summary> The SID of the chat service this user belongs to. </summary> 
        [JsonProperty("chat_service_instance_sid")]
        public string ChatServiceInstanceSid { get; private set; }

        ///<summary> The SID of the Flex service instance. </summary> 
        [JsonProperty("flex_service_instance_sid")]
        public string FlexServiceInstanceSid { get; private set; }

        ///<summary> The primary language of the Flex UI. </summary> 
        [JsonProperty("ui_language")]
        public string UiLanguage { get; private set; }

        ///<summary> The object that describes Flex UI characteristics and settings. </summary> 
        [JsonProperty("ui_attributes")]
        public object UiAttributes { get; private set; }

        ///<summary> The object that defines the NPM packages and versions to be used in Hosted Flex. </summary> 
        [JsonProperty("ui_dependencies")]
        public object UiDependencies { get; private set; }

        ///<summary> The Pinned UI version. </summary> 
        [JsonProperty("ui_version")]
        public string UiVersion { get; private set; }

        ///<summary> The Flex Service version. </summary> 
        [JsonProperty("service_version")]
        public string ServiceVersion { get; private set; }

        ///<summary> Whether call recording is enabled. </summary> 
        [JsonProperty("call_recording_enabled")]
        public bool? CallRecordingEnabled { get; private set; }

        ///<summary> The call recording webhook URL. </summary> 
        [JsonProperty("call_recording_webhook_url")]
        public Uri CallRecordingWebhookUrl { get; private set; }

        ///<summary> Whether CRM is present for Flex. </summary> 
        [JsonProperty("crm_enabled")]
        public bool? CrmEnabled { get; private set; }

        ///<summary> The CRM type. </summary> 
        [JsonProperty("crm_type")]
        public string CrmType { get; private set; }

        ///<summary> The CRM Callback URL. </summary> 
        [JsonProperty("crm_callback_url")]
        public Uri CrmCallbackUrl { get; private set; }

        ///<summary> The CRM Fallback URL. </summary> 
        [JsonProperty("crm_fallback_url")]
        public Uri CrmFallbackUrl { get; private set; }

        ///<summary> An object that contains the CRM attributes. </summary> 
        [JsonProperty("crm_attributes")]
        public object CrmAttributes { get; private set; }

        ///<summary> The list of public attributes, which are visible to unauthenticated clients. </summary> 
        [JsonProperty("public_attributes")]
        public object PublicAttributes { get; private set; }

        ///<summary> Whether the plugin service enabled. </summary> 
        [JsonProperty("plugin_service_enabled")]
        public bool? PluginServiceEnabled { get; private set; }

        ///<summary> The plugin service attributes. </summary> 
        [JsonProperty("plugin_service_attributes")]
        public object PluginServiceAttributes { get; private set; }

        ///<summary> A list of objects that contain the configurations for the Integrations supported in this configuration. </summary> 
        [JsonProperty("integrations")]
        public List<object> Integrations { get; private set; }

        ///<summary> The list of outbound call flows. </summary> 
        [JsonProperty("outbound_call_flows")]
        public object OutboundCallFlows { get; private set; }

        ///<summary> The list of serverless service SIDs. </summary> 
        [JsonProperty("serverless_service_sids")]
        public List<string> ServerlessServiceSids { get; private set; }

        ///<summary> Configurable parameters for Queues Statistics. </summary> 
        [JsonProperty("queue_stats_configuration")]
        public object QueueStatsConfiguration { get; private set; }

        ///<summary> Configurable parameters for Notifications. </summary> 
        [JsonProperty("notifications")]
        public object Notifications { get; private set; }

        ///<summary> Configurable parameters for Markdown. </summary> 
        [JsonProperty("markdown")]
        public object Markdown { get; private set; }

        ///<summary> The absolute URL of the Configuration resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> Object with enabled/disabled flag with list of workspaces. </summary> 
        [JsonProperty("flex_insights_hr")]
        public object FlexInsightsHr { get; private set; }

        ///<summary> Setting this to true will redirect Flex UI to the URL set in flex_url </summary> 
        [JsonProperty("flex_insights_drilldown")]
        public bool? FlexInsightsDrilldown { get; private set; }

        ///<summary> URL to redirect to in case drilldown is enabled. </summary> 
        [JsonProperty("flex_url")]
        public Uri FlexUrl { get; private set; }

        ///<summary> Settings for different limits for Flex Conversations channels attachments. </summary> 
        [JsonProperty("channel_configs")]
        public List<object> ChannelConfigs { get; private set; }

        ///<summary> Configurable parameters for Debugger Integration. </summary> 
        [JsonProperty("debugger_integration")]
        public object DebuggerIntegration { get; private set; }

        ///<summary> Configurable parameters for Flex UI Status report. </summary> 
        [JsonProperty("flex_ui_status_report")]
        public object FlexUiStatusReport { get; private set; }

        ///<summary> Agent conversation end methods. </summary> 
        [JsonProperty("agent_conv_end_methods")]
        public object AgentConvEndMethods { get; private set; }



        private ConfigurationResource() {

        }
    }
}

