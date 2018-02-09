# IO.Swagger.Api.RoutesApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRouteOriginDestination**](RoutesApi.md#getrouteorigindestination) | **GET** /v1/route/{origin}/{destination}/ | Get route


<a name="getrouteorigindestination"></a>
# **GetRouteOriginDestination**
> List<int?> GetRouteOriginDestination (int? destination, int? origin, List<int?> avoid = null, List<List<int?>> connections = null, string datasource = null, string flag = null, string userAgent = null, string xUserAgent = null)

Get route

Get the systems between origin and destination  - --  This route is cached for up to 86400 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRouteOriginDestinationExample
    {
        public void main()
        {
            var apiInstance = new RoutesApi();
            var destination = 56;  // int? | destination solar system ID
            var origin = 56;  // int? | origin solar system ID
            var avoid = new List<int?>(); // List<int?> | avoid solar system ID(s) (optional) 
            var connections = new List<List<int?>>(); // List<List<int?>> | connected solar system pairs (optional) 
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var flag = flag_example;  // string | route security preference (optional)  (default to shortest)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get route
                List&lt;int?&gt; result = apiInstance.GetRouteOriginDestination(destination, origin, avoid, connections, datasource, flag, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutesApi.GetRouteOriginDestination: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destination** | **int?**| destination solar system ID | 
 **origin** | **int?**| origin solar system ID | 
 **avoid** | [**List&lt;int?&gt;**](int?.md)| avoid solar system ID(s) | [optional] 
 **connections** | [**List&lt;List&lt;int?&gt;&gt;**](List&lt;int?&gt;.md)| connected solar system pairs | [optional] 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **flag** | **string**| route security preference | [optional] [default to shortest]
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

