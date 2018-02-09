# IO.Swagger.Api.LocationApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdLocation**](LocationApi.md#getcharacterscharacteridlocation) | **GET** /v1/characters/{character_id}/location/ | Get character location
[**GetCharactersCharacterIdOnline**](LocationApi.md#getcharacterscharacteridonline) | **GET** /v2/characters/{character_id}/online/ | Get character online
[**GetCharactersCharacterIdShip**](LocationApi.md#getcharacterscharacteridship) | **GET** /v1/characters/{character_id}/ship/ | Get current ship


<a name="getcharacterscharacteridlocation"></a>
# **GetCharactersCharacterIdLocation**
> GetCharactersCharacterIdLocationOk GetCharactersCharacterIdLocation (int? characterId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get character location

Information about the characters current location. Returns the current solar system id, and also the current station or structure ID if applicable.  - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdLocationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get character location
                GetCharactersCharacterIdLocationOk result = apiInstance.GetCharactersCharacterIdLocation(characterId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.GetCharactersCharacterIdLocation: " + e.Message );
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
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetCharactersCharacterIdLocationOk**](GetCharactersCharacterIdLocationOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridonline"></a>
# **GetCharactersCharacterIdOnline**
> GetCharactersCharacterIdOnlineOk GetCharactersCharacterIdOnline (int? characterId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get character online

Checks if the character is currently online  - --  This route is cached for up to 60 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdOnlineExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get character online
                GetCharactersCharacterIdOnlineOk result = apiInstance.GetCharactersCharacterIdOnline(characterId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.GetCharactersCharacterIdOnline: " + e.Message );
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
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetCharactersCharacterIdOnlineOk**](GetCharactersCharacterIdOnlineOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridship"></a>
# **GetCharactersCharacterIdShip**
> GetCharactersCharacterIdShipOk GetCharactersCharacterIdShip (int? characterId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get current ship

Get the current ship type, name and id  - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdShipExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get current ship
                GetCharactersCharacterIdShipOk result = apiInstance.GetCharactersCharacterIdShip(characterId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.GetCharactersCharacterIdShip: " + e.Message );
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
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetCharactersCharacterIdShipOk**](GetCharactersCharacterIdShipOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

