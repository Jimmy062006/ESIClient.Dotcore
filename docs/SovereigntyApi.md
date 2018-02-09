# IO.Swagger.Api.SovereigntyApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSovereigntyCampaigns**](SovereigntyApi.md#getsovereigntycampaigns) | **GET** /v1/sovereignty/campaigns/ | List sovereignty campaigns
[**GetSovereigntyMap**](SovereigntyApi.md#getsovereigntymap) | **GET** /v1/sovereignty/map/ | List sovereignty of systems
[**GetSovereigntyStructures**](SovereigntyApi.md#getsovereigntystructures) | **GET** /v1/sovereignty/structures/ | List sovereignty structures


<a name="getsovereigntycampaigns"></a>
# **GetSovereigntyCampaigns**
> List<GetSovereigntyCampaigns200Ok> GetSovereigntyCampaigns (string datasource = null, string userAgent = null, string xUserAgent = null)

List sovereignty campaigns

Shows sovereignty data for campaigns.  - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSovereigntyCampaignsExample
    {
        public void main()
        {
            var apiInstance = new SovereigntyApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // List sovereignty campaigns
                List&lt;GetSovereigntyCampaigns200Ok&gt; result = apiInstance.GetSovereigntyCampaigns(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SovereigntyApi.GetSovereigntyCampaigns: " + e.Message );
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

[**List<GetSovereigntyCampaigns200Ok>**](GetSovereigntyCampaigns200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsovereigntymap"></a>
# **GetSovereigntyMap**
> List<GetSovereigntyMap200Ok> GetSovereigntyMap (string datasource = null, string userAgent = null, string xUserAgent = null)

List sovereignty of systems

Shows sovereignty information for solar systems  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSovereigntyMapExample
    {
        public void main()
        {
            var apiInstance = new SovereigntyApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // List sovereignty of systems
                List&lt;GetSovereigntyMap200Ok&gt; result = apiInstance.GetSovereigntyMap(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SovereigntyApi.GetSovereigntyMap: " + e.Message );
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

[**List<GetSovereigntyMap200Ok>**](GetSovereigntyMap200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsovereigntystructures"></a>
# **GetSovereigntyStructures**
> List<GetSovereigntyStructures200Ok> GetSovereigntyStructures (string datasource = null, string userAgent = null, string xUserAgent = null)

List sovereignty structures

Shows sovereignty data for structures.  - --  This route is cached for up to 120 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSovereigntyStructuresExample
    {
        public void main()
        {
            var apiInstance = new SovereigntyApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // List sovereignty structures
                List&lt;GetSovereigntyStructures200Ok&gt; result = apiInstance.GetSovereigntyStructures(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SovereigntyApi.GetSovereigntyStructures: " + e.Message );
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

[**List<GetSovereigntyStructures200Ok>**](GetSovereigntyStructures200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

