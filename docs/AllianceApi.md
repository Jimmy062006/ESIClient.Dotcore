# IO.Swagger.Api.AllianceApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAlliances**](AllianceApi.md#getalliances) | **GET** /v1/alliances/ | List all alliances
[**GetAlliancesAllianceId**](AllianceApi.md#getalliancesallianceid) | **GET** /v3/alliances/{alliance_id}/ | Get alliance information
[**GetAlliancesAllianceIdCorporations**](AllianceApi.md#getalliancesallianceidcorporations) | **GET** /v1/alliances/{alliance_id}/corporations/ | List alliance&#39;s corporations
[**GetAlliancesAllianceIdIcons**](AllianceApi.md#getalliancesallianceidicons) | **GET** /v1/alliances/{alliance_id}/icons/ | Get alliance icon
[**GetAlliancesNames**](AllianceApi.md#getalliancesnames) | **GET** /v2/alliances/names/ | Get alliance names


<a name="getalliances"></a>
# **GetAlliances**
> List<int?> GetAlliances (string datasource = null, string userAgent = null, string xUserAgent = null)

List all alliances

List all active player alliances  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAlliancesExample
    {
        public void main()
        {
            var apiInstance = new AllianceApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // List all alliances
                List&lt;int?&gt; result = apiInstance.GetAlliances(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AllianceApi.GetAlliances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalliancesallianceid"></a>
# **GetAlliancesAllianceId**
> GetAlliancesAllianceIdOk GetAlliancesAllianceId (int? allianceId, string datasource = null, string userAgent = null, string xUserAgent = null)

Get alliance information

Public information about an alliance  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAlliancesAllianceIdExample
    {
        public void main()
        {
            var apiInstance = new AllianceApi();
            var allianceId = 56;  // int? | An EVE alliance ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get alliance information
                GetAlliancesAllianceIdOk result = apiInstance.GetAlliancesAllianceId(allianceId, datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AllianceApi.GetAlliancesAllianceId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **allianceId** | **int?**| An EVE alliance ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetAlliancesAllianceIdOk**](GetAlliancesAllianceIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalliancesallianceidcorporations"></a>
# **GetAlliancesAllianceIdCorporations**
> List<int?> GetAlliancesAllianceIdCorporations (int? allianceId, string datasource = null, string userAgent = null, string xUserAgent = null)

List alliance's corporations

List all current member corporations of an alliance  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAlliancesAllianceIdCorporationsExample
    {
        public void main()
        {
            var apiInstance = new AllianceApi();
            var allianceId = 56;  // int? | An EVE alliance ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // List alliance's corporations
                List&lt;int?&gt; result = apiInstance.GetAlliancesAllianceIdCorporations(allianceId, datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AllianceApi.GetAlliancesAllianceIdCorporations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **allianceId** | **int?**| An EVE alliance ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalliancesallianceidicons"></a>
# **GetAlliancesAllianceIdIcons**
> GetAlliancesAllianceIdIconsOk GetAlliancesAllianceIdIcons (int? allianceId, string datasource = null, string userAgent = null, string xUserAgent = null)

Get alliance icon

Get the icon urls for a alliance  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAlliancesAllianceIdIconsExample
    {
        public void main()
        {
            var apiInstance = new AllianceApi();
            var allianceId = 56;  // int? | An EVE alliance ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get alliance icon
                GetAlliancesAllianceIdIconsOk result = apiInstance.GetAlliancesAllianceIdIcons(allianceId, datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AllianceApi.GetAlliancesAllianceIdIcons: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **allianceId** | **int?**| An EVE alliance ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetAlliancesAllianceIdIconsOk**](GetAlliancesAllianceIdIconsOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalliancesnames"></a>
# **GetAlliancesNames**
> List<GetAlliancesNames200Ok> GetAlliancesNames (List<int?> allianceIds, string datasource = null, string userAgent = null, string xUserAgent = null)

Get alliance names

Resolve a set of alliance IDs to alliance names  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAlliancesNamesExample
    {
        public void main()
        {
            var apiInstance = new AllianceApi();
            var allianceIds = new List<int?>(); // List<int?> | A comma separated list of alliance IDs
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get alliance names
                List&lt;GetAlliancesNames200Ok&gt; result = apiInstance.GetAlliancesNames(allianceIds, datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AllianceApi.GetAlliancesNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **allianceIds** | [**List&lt;int?&gt;**](int?.md)| A comma separated list of alliance IDs | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetAlliancesNames200Ok>**](GetAlliancesNames200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

