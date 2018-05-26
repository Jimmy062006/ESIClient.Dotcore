# ESIClient.Dotcore.Api.OpportunitiesApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdOpportunities**](OpportunitiesApi.md#getcharacterscharacteridopportunities) | **GET** /v1/characters/{character_id}/opportunities/ | Get a character&#39;s completed tasks
[**GetOpportunitiesGroups**](OpportunitiesApi.md#getopportunitiesgroups) | **GET** /v1/opportunities/groups/ | Get opportunities groups
[**GetOpportunitiesGroupsGroupId**](OpportunitiesApi.md#getopportunitiesgroupsgroupid) | **GET** /v1/opportunities/groups/{group_id}/ | Get opportunities group
[**GetOpportunitiesTasks**](OpportunitiesApi.md#getopportunitiestasks) | **GET** /v1/opportunities/tasks/ | Get opportunities tasks
[**GetOpportunitiesTasksTaskId**](OpportunitiesApi.md#getopportunitiestaskstaskid) | **GET** /v1/opportunities/tasks/{task_id}/ | Get opportunities task


<a name="getcharacterscharacteridopportunities"></a>
# **GetCharactersCharacterIdOpportunities**
> List<GetCharactersCharacterIdOpportunities200Ok> GetCharactersCharacterIdOpportunities (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Get a character's completed tasks

Return a list of tasks finished by a character  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdOpportunitiesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OpportunitiesApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get a character's completed tasks
                List&lt;GetCharactersCharacterIdOpportunities200Ok&gt; result = apiInstance.GetCharactersCharacterIdOpportunities(characterId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunitiesApi.GetCharactersCharacterIdOpportunities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**List<GetCharactersCharacterIdOpportunities200Ok>**](GetCharactersCharacterIdOpportunities200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getopportunitiesgroups"></a>
# **GetOpportunitiesGroups**
> List<int?> GetOpportunitiesGroups (string datasource = null, string ifNoneMatch = null)

Get opportunities groups

Return a list of opportunities groups  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetOpportunitiesGroupsExample
    {
        public void main()
        {
            var apiInstance = new OpportunitiesApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Get opportunities groups
                List&lt;int?&gt; result = apiInstance.GetOpportunitiesGroups(datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunitiesApi.GetOpportunitiesGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getopportunitiesgroupsgroupid"></a>
# **GetOpportunitiesGroupsGroupId**
> GetOpportunitiesGroupsGroupIdOk GetOpportunitiesGroupsGroupId (int? groupId, string acceptLanguage = null, string datasource = null, string ifNoneMatch = null, string language = null)

Get opportunities group

Return information of an opportunities group  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetOpportunitiesGroupsGroupIdExample
    {
        public void main()
        {
            var apiInstance = new OpportunitiesApi();
            var groupId = 56;  // int? | ID of an opportunities group
            var acceptLanguage = acceptLanguage_example;  // string | Language to use in the response (optional)  (default to en-us)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var language = language_example;  // string | Language to use in the response, takes precedence over Accept-Language (optional)  (default to en-us)

            try
            {
                // Get opportunities group
                GetOpportunitiesGroupsGroupIdOk result = apiInstance.GetOpportunitiesGroupsGroupId(groupId, acceptLanguage, datasource, ifNoneMatch, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunitiesApi.GetOpportunitiesGroupsGroupId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **int?**| ID of an opportunities group | 
 **acceptLanguage** | **string**| Language to use in the response | [optional] [default to en-us]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **language** | **string**| Language to use in the response, takes precedence over Accept-Language | [optional] [default to en-us]

### Return type

[**GetOpportunitiesGroupsGroupIdOk**](GetOpportunitiesGroupsGroupIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getopportunitiestasks"></a>
# **GetOpportunitiesTasks**
> List<int?> GetOpportunitiesTasks (string datasource = null, string ifNoneMatch = null)

Get opportunities tasks

Return a list of opportunities tasks  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetOpportunitiesTasksExample
    {
        public void main()
        {
            var apiInstance = new OpportunitiesApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Get opportunities tasks
                List&lt;int?&gt; result = apiInstance.GetOpportunitiesTasks(datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunitiesApi.GetOpportunitiesTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getopportunitiestaskstaskid"></a>
# **GetOpportunitiesTasksTaskId**
> GetOpportunitiesTasksTaskIdOk GetOpportunitiesTasksTaskId (int? taskId, string datasource = null, string ifNoneMatch = null)

Get opportunities task

Return information of an opportunities task  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetOpportunitiesTasksTaskIdExample
    {
        public void main()
        {
            var apiInstance = new OpportunitiesApi();
            var taskId = 56;  // int? | ID of an opportunities task
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Get opportunities task
                GetOpportunitiesTasksTaskIdOk result = apiInstance.GetOpportunitiesTasksTaskId(taskId, datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunitiesApi.GetOpportunitiesTasksTaskId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **int?**| ID of an opportunities task | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 

### Return type

[**GetOpportunitiesTasksTaskIdOk**](GetOpportunitiesTasksTaskIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

