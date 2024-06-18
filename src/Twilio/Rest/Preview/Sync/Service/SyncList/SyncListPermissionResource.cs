/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Preview
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



namespace Twilio.Rest.Preview.Sync.Service.SyncList
{
    public class SyncListPermissionResource : Resource
    {
    

    

        
        /// <summary> Delete a specific Sync List Permission. </summary>
        /// <param name="options"> Delete SyncListPermission parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncListPermission </returns>
        private static Request BuildDeleteRequest(DeleteSyncListPermissionOptions options, ITwilioRestClient client)
        {
            
            string path = "/Sync/Services/{ServiceSid}/Lists/{ListSid}/Permissions/{Identity}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathListSid = options.PathListSid;
            path = path.Replace("{"+"ListSid"+"}", PathListSid);
            string PathIdentity = options.PathIdentity;
            path = path.Replace("{"+"Identity"+"}", PathIdentity);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific Sync List Permission. </summary>
        /// <param name="options"> Delete SyncListPermission parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncListPermission </returns>
        public static bool Delete(DeleteSyncListPermissionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete a specific Sync List Permission. </summary>
        /// <param name="options"> Delete SyncListPermission parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncListPermission </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSyncListPermissionOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete a specific Sync List Permission. </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathListSid"> Identifier of the Sync List. Either a SID or a unique name. </param>
        /// <param name="pathIdentity"> Arbitrary string identifier representing a user associated with an FPA token, assigned by the developer. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncListPermission </returns>
        public static bool Delete(string pathServiceSid, string pathListSid, string pathIdentity, ITwilioRestClient client = null)
        {
            var options = new DeleteSyncListPermissionOptions(pathServiceSid, pathListSid, pathIdentity)           ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete a specific Sync List Permission. </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathListSid"> Identifier of the Sync List. Either a SID or a unique name. </param>
        /// <param name="pathIdentity"> Arbitrary string identifier representing a user associated with an FPA token, assigned by the developer. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncListPermission </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathListSid, string pathIdentity, ITwilioRestClient client = null)
        {
            var options = new DeleteSyncListPermissionOptions(pathServiceSid, pathListSid, pathIdentity) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchSyncListPermissionOptions options, ITwilioRestClient client)
        {
            
            string path = "/Sync/Services/{ServiceSid}/Lists/{ListSid}/Permissions/{Identity}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathListSid = options.PathListSid;
            path = path.Replace("{"+"ListSid"+"}", PathListSid);
            string PathIdentity = options.PathIdentity;
            path = path.Replace("{"+"Identity"+"}", PathIdentity);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific Sync List Permission. </summary>
        /// <param name="options"> Fetch SyncListPermission parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncListPermission </returns>
        public static SyncListPermissionResource Fetch(FetchSyncListPermissionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a specific Sync List Permission. </summary>
        /// <param name="options"> Fetch SyncListPermission parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncListPermission </returns>
        public static async System.Threading.Tasks.Task<SyncListPermissionResource> FetchAsync(FetchSyncListPermissionOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a specific Sync List Permission. </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathListSid"> Identifier of the Sync List. Either a SID or a unique name. </param>
        /// <param name="pathIdentity"> Arbitrary string identifier representing a user associated with an FPA token, assigned by the developer. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncListPermission </returns>
        public static SyncListPermissionResource Fetch(
                                         string pathServiceSid, 
                                         string pathListSid, 
                                         string pathIdentity, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchSyncListPermissionOptions(pathServiceSid, pathListSid, pathIdentity){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a specific Sync List Permission. </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathListSid"> Identifier of the Sync List. Either a SID or a unique name. </param>
        /// <param name="pathIdentity"> Arbitrary string identifier representing a user associated with an FPA token, assigned by the developer. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncListPermission </returns>
        public static async System.Threading.Tasks.Task<SyncListPermissionResource> FetchAsync(string pathServiceSid, string pathListSid, string pathIdentity, ITwilioRestClient client = null)
        {
            var options = new FetchSyncListPermissionOptions(pathServiceSid, pathListSid, pathIdentity){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadSyncListPermissionOptions options, ITwilioRestClient client)
        {
            
            string path = "/Sync/Services/{ServiceSid}/Lists/{ListSid}/Permissions";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathListSid = options.PathListSid;
            path = path.Replace("{"+"ListSid"+"}", PathListSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Permissions applying to a Sync List. </summary>
        /// <param name="options"> Read SyncListPermission parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncListPermission </returns>
        public static ResourceSet<SyncListPermissionResource> Read(ReadSyncListPermissionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<SyncListPermissionResource>.FromJson("permissions", response.Content);
            return new ResourceSet<SyncListPermissionResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Permissions applying to a Sync List. </summary>
        /// <param name="options"> Read SyncListPermission parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncListPermission </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SyncListPermissionResource>> ReadAsync(ReadSyncListPermissionOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SyncListPermissionResource>.FromJson("permissions", response.Content);
            return new ResourceSet<SyncListPermissionResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Permissions applying to a Sync List. </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathListSid"> Identifier of the Sync List. Either a SID or a unique name. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncListPermission </returns>
        public static ResourceSet<SyncListPermissionResource> Read(
                                                     string pathServiceSid,
                                                     string pathListSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadSyncListPermissionOptions(pathServiceSid, pathListSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Permissions applying to a Sync List. </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathListSid"> Identifier of the Sync List. Either a SID or a unique name. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncListPermission </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SyncListPermissionResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             string pathListSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadSyncListPermissionOptions(pathServiceSid, pathListSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SyncListPermissionResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SyncListPermissionResource>.FromJson("permissions", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SyncListPermissionResource> NextPage(Page<SyncListPermissionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SyncListPermissionResource>.FromJson("permissions", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SyncListPermissionResource> PreviousPage(Page<SyncListPermissionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SyncListPermissionResource>.FromJson("permissions", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateSyncListPermissionOptions options, ITwilioRestClient client)
        {
            
            string path = "/Sync/Services/{ServiceSid}/Lists/{ListSid}/Permissions/{Identity}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathListSid = options.PathListSid;
            path = path.Replace("{"+"ListSid"+"}", PathListSid);
            string PathIdentity = options.PathIdentity;
            path = path.Replace("{"+"Identity"+"}", PathIdentity);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                path,
                contentType: EnumConstants.ContentTypeEnum.FORM_URLENCODED,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update an identity's access to a specific Sync List. </summary>
        /// <param name="options"> Update SyncListPermission parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncListPermission </returns>
        public static SyncListPermissionResource Update(UpdateSyncListPermissionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update an identity's access to a specific Sync List. </summary>
        /// <param name="options"> Update SyncListPermission parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncListPermission </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<SyncListPermissionResource> UpdateAsync(UpdateSyncListPermissionOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Update an identity's access to a specific Sync List. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Sync Service Instance. </param>
        /// <param name="pathListSid"> Identifier of the Sync List. Either a SID or a unique name. </param>
        /// <param name="pathIdentity"> Arbitrary string identifier representing a human user associated with an FPA token, assigned by the developer. </param>
        /// <param name="read"> Boolean flag specifying whether the identity can read the Sync List. </param>
        /// <param name="write"> Boolean flag specifying whether the identity can create, update and delete Items of the Sync List. </param>
        /// <param name="manage"> Boolean flag specifying whether the identity can delete the Sync List. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncListPermission </returns>
        public static SyncListPermissionResource Update(
                                          string pathServiceSid,
                                          string pathListSid,
                                          string pathIdentity,
                                          bool? read,
                                          bool? write,
                                          bool? manage,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateSyncListPermissionOptions(pathServiceSid, pathListSid, pathIdentity, read, write, manage){  };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Update an identity's access to a specific Sync List. </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Sync Service Instance. </param>
        /// <param name="pathListSid"> Identifier of the Sync List. Either a SID or a unique name. </param>
        /// <param name="pathIdentity"> Arbitrary string identifier representing a human user associated with an FPA token, assigned by the developer. </param>
        /// <param name="read"> Boolean flag specifying whether the identity can read the Sync List. </param>
        /// <param name="write"> Boolean flag specifying whether the identity can create, update and delete Items of the Sync List. </param>
        /// <param name="manage"> Boolean flag specifying whether the identity can delete the Sync List. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncListPermission </returns>
        public static async System.Threading.Tasks.Task<SyncListPermissionResource> UpdateAsync(
                                                                              string pathServiceSid,
                                                                              string pathListSid,
                                                                              string pathIdentity,
                                                                              bool? read,
                                                                              bool? write,
                                                                              bool? manage,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateSyncListPermissionOptions(pathServiceSid, pathListSid, pathIdentity, read, write, manage){  };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a SyncListPermissionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SyncListPermissionResource object represented by the provided JSON </returns>
        public static SyncListPermissionResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SyncListPermissionResource>(json);
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

    
        ///<summary> The unique SID identifier of the Twilio Account. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique SID identifier of the Sync Service Instance. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The unique SID identifier of the Sync List to which the Permission applies. </summary> 
        [JsonProperty("list_sid")]
        public string ListSid { get; private set; }

        ///<summary> Arbitrary string identifier representing a human user associated with an FPA token, assigned by the developer. </summary> 
        [JsonProperty("identity")]
        public string Identity { get; private set; }

        ///<summary> Boolean flag specifying whether the identity can read the Sync List and its Items. </summary> 
        [JsonProperty("read")]
        public bool? _Read { get; private set; }

        ///<summary> Boolean flag specifying whether the identity can create, update and delete Items of the Sync List. </summary> 
        [JsonProperty("write")]
        public bool? Write { get; private set; }

        ///<summary> Boolean flag specifying whether the identity can delete the Sync List. </summary> 
        [JsonProperty("manage")]
        public bool? Manage { get; private set; }

        ///<summary> Contains an absolute URL for this Sync List Permission. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private SyncListPermissionResource() {

        }
    }
}

