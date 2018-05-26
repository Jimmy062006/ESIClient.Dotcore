# ESIClient.Dotcore.Api.UserInterfaceApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostUiAutopilotWaypoint**](UserInterfaceApi.md#postuiautopilotwaypoint) | **POST** /v2/ui/autopilot/waypoint/ | Set Autopilot Waypoint
[**PostUiOpenwindowContract**](UserInterfaceApi.md#postuiopenwindowcontract) | **POST** /v1/ui/openwindow/contract/ | Open Contract Window
[**PostUiOpenwindowInformation**](UserInterfaceApi.md#postuiopenwindowinformation) | **POST** /v1/ui/openwindow/information/ | Open Information Window
[**PostUiOpenwindowMarketdetails**](UserInterfaceApi.md#postuiopenwindowmarketdetails) | **POST** /v1/ui/openwindow/marketdetails/ | Open Market Details
[**PostUiOpenwindowNewmail**](UserInterfaceApi.md#postuiopenwindownewmail) | **POST** /v1/ui/openwindow/newmail/ | Open New Mail Window


<a name="postuiautopilotwaypoint"></a>
# **PostUiAutopilotWaypoint**
> void PostUiAutopilotWaypoint (bool? addToBeginning, bool? clearOtherWaypoints, long? destinationId, string datasource = null, string token = null)

Set Autopilot Waypoint

Set a solar system as autopilot waypoint  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class PostUiAutopilotWaypointExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserInterfaceApi();
            var addToBeginning = true;  // bool? | Whether this solar system should be added to the beginning of all waypoints (default to false)
            var clearOtherWaypoints = true;  // bool? | Whether clean other waypoints beforing adding this one (default to false)
            var destinationId = 789;  // long? | The destination to travel to, can be solar system, station or structure's id
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Set Autopilot Waypoint
                apiInstance.PostUiAutopilotWaypoint(addToBeginning, clearOtherWaypoints, destinationId, datasource, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserInterfaceApi.PostUiAutopilotWaypoint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **addToBeginning** | **bool?**| Whether this solar system should be added to the beginning of all waypoints | [default to false]
 **clearOtherWaypoints** | **bool?**| Whether clean other waypoints beforing adding this one | [default to false]
 **destinationId** | **long?**| The destination to travel to, can be solar system, station or structure&#39;s id | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postuiopenwindowcontract"></a>
# **PostUiOpenwindowContract**
> void PostUiOpenwindowContract (int? contractId, string datasource = null, string token = null)

Open Contract Window

Open the contract window inside the client  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class PostUiOpenwindowContractExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserInterfaceApi();
            var contractId = 56;  // int? | The contract to open
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Open Contract Window
                apiInstance.PostUiOpenwindowContract(contractId, datasource, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserInterfaceApi.PostUiOpenwindowContract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **int?**| The contract to open | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postuiopenwindowinformation"></a>
# **PostUiOpenwindowInformation**
> void PostUiOpenwindowInformation (int? targetId, string datasource = null, string token = null)

Open Information Window

Open the information window for a character, corporation or alliance inside the client  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class PostUiOpenwindowInformationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserInterfaceApi();
            var targetId = 56;  // int? | The target to open
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Open Information Window
                apiInstance.PostUiOpenwindowInformation(targetId, datasource, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserInterfaceApi.PostUiOpenwindowInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **targetId** | **int?**| The target to open | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postuiopenwindowmarketdetails"></a>
# **PostUiOpenwindowMarketdetails**
> void PostUiOpenwindowMarketdetails (int? typeId, string datasource = null, string token = null)

Open Market Details

Open the market details window for a specific typeID inside the client  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class PostUiOpenwindowMarketdetailsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserInterfaceApi();
            var typeId = 56;  // int? | The item type to open in market window
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Open Market Details
                apiInstance.PostUiOpenwindowMarketdetails(typeId, datasource, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserInterfaceApi.PostUiOpenwindowMarketdetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **typeId** | **int?**| The item type to open in market window | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postuiopenwindownewmail"></a>
# **PostUiOpenwindowNewmail**
> void PostUiOpenwindowNewmail (PostUiOpenwindowNewmailNewMail newMail, string datasource = null, string token = null)

Open New Mail Window

Open the New Mail window, according to settings from the request if applicable  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class PostUiOpenwindowNewmailExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserInterfaceApi();
            var newMail = new PostUiOpenwindowNewmailNewMail(); // PostUiOpenwindowNewmailNewMail | The details of mail to create
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Open New Mail Window
                apiInstance.PostUiOpenwindowNewmail(newMail, datasource, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserInterfaceApi.PostUiOpenwindowNewmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newMail** | [**PostUiOpenwindowNewmailNewMail**](PostUiOpenwindowNewmailNewMail.md)| The details of mail to create | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

