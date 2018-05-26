# ESIClient.Dotcore.Api.WarsApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWars**](WarsApi.md#getwars) | **GET** /v1/wars/ | List wars
[**GetWarsWarId**](WarsApi.md#getwarswarid) | **GET** /v1/wars/{war_id}/ | Get war information
[**GetWarsWarIdKillmails**](WarsApi.md#getwarswaridkillmails) | **GET** /v1/wars/{war_id}/killmails/ | List kills for a war


<a name="getwars"></a>
# **GetWars**
> List<int?> GetWars (string datasource = null, string ifNoneMatch = null, int? maxWarId = null)

List wars

Return a list of wars  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetWarsExample
    {
        public void main()
        {
            var apiInstance = new WarsApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var maxWarId = 56;  // int? | Only return wars with ID smaller than this. (optional) 

            try
            {
                // List wars
                List&lt;int?&gt; result = apiInstance.GetWars(datasource, ifNoneMatch, maxWarId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarsApi.GetWars: " + e.Message );
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
 **maxWarId** | **int?**| Only return wars with ID smaller than this. | [optional] 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarswarid"></a>
# **GetWarsWarId**
> GetWarsWarIdOk GetWarsWarId (int? warId, string datasource = null, string ifNoneMatch = null)

Get war information

Return details about a war  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetWarsWarIdExample
    {
        public void main()
        {
            var apiInstance = new WarsApi();
            var warId = 56;  // int? | ID for a war
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Get war information
                GetWarsWarIdOk result = apiInstance.GetWarsWarId(warId, datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarsApi.GetWarsWarId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warId** | **int?**| ID for a war | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 

### Return type

[**GetWarsWarIdOk**](GetWarsWarIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwarswaridkillmails"></a>
# **GetWarsWarIdKillmails**
> List<GetWarsWarIdKillmails200Ok> GetWarsWarIdKillmails (int? warId, string datasource = null, string ifNoneMatch = null, int? page = null)

List kills for a war

Return a list of kills related to a war  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetWarsWarIdKillmailsExample
    {
        public void main()
        {
            var apiInstance = new WarsApi();
            var warId = 56;  // int? | A valid war ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)

            try
            {
                // List kills for a war
                List&lt;GetWarsWarIdKillmails200Ok&gt; result = apiInstance.GetWarsWarIdKillmails(warId, datasource, ifNoneMatch, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarsApi.GetWarsWarIdKillmails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warId** | **int?**| A valid war ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **page** | **int?**| Which page of results to return | [optional] [default to 1]

### Return type

[**List<GetWarsWarIdKillmails200Ok>**](GetWarsWarIdKillmails200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

