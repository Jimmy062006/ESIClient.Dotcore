# IO.Swagger.Api.FittingsApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCharactersCharacterIdFittingsFittingId**](FittingsApi.md#deletecharacterscharacteridfittingsfittingid) | **DELETE** /v1/characters/{character_id}/fittings/{fitting_id}/ | Delete fitting
[**GetCharactersCharacterIdFittings**](FittingsApi.md#getcharacterscharacteridfittings) | **GET** /v1/characters/{character_id}/fittings/ | Get fittings
[**PostCharactersCharacterIdFittings**](FittingsApi.md#postcharacterscharacteridfittings) | **POST** /v1/characters/{character_id}/fittings/ | Create fitting


<a name="deletecharacterscharacteridfittingsfittingid"></a>
# **DeleteCharactersCharacterIdFittingsFittingId**
> void DeleteCharactersCharacterIdFittingsFittingId (int? characterId, int? fittingId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Delete fitting

Delete a fitting from a character  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCharactersCharacterIdFittingsFittingIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FittingsApi();
            var characterId = 56;  // int? | An EVE character ID
            var fittingId = 56;  // int? | ID for a fitting of this character
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Delete fitting
                apiInstance.DeleteCharactersCharacterIdFittingsFittingId(characterId, fittingId, datasource, token, userAgent, xUserAgent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FittingsApi.DeleteCharactersCharacterIdFittingsFittingId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **fittingId** | **int?**| ID for a fitting of this character | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridfittings"></a>
# **GetCharactersCharacterIdFittings**
> List<GetCharactersCharacterIdFittings200Ok> GetCharactersCharacterIdFittings (int? characterId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get fittings

Return fittings of a character  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdFittingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FittingsApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get fittings
                List&lt;GetCharactersCharacterIdFittings200Ok&gt; result = apiInstance.GetCharactersCharacterIdFittings(characterId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FittingsApi.GetCharactersCharacterIdFittings: " + e.Message );
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

[**List<GetCharactersCharacterIdFittings200Ok>**](GetCharactersCharacterIdFittings200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcharacterscharacteridfittings"></a>
# **PostCharactersCharacterIdFittings**
> PostCharactersCharacterIdFittingsCreated PostCharactersCharacterIdFittings (int? characterId, string datasource = null, PostCharactersCharacterIdFittingsFitting fitting = null, string token = null, string userAgent = null, string xUserAgent = null)

Create fitting

Save a new fitting for a character  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostCharactersCharacterIdFittingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FittingsApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var fitting = new PostCharactersCharacterIdFittingsFitting(); // PostCharactersCharacterIdFittingsFitting | Details about the new fitting (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Create fitting
                PostCharactersCharacterIdFittingsCreated result = apiInstance.PostCharactersCharacterIdFittings(characterId, datasource, fitting, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FittingsApi.PostCharactersCharacterIdFittings: " + e.Message );
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
 **fitting** | [**PostCharactersCharacterIdFittingsFitting**](PostCharactersCharacterIdFittingsFitting.md)| Details about the new fitting | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**PostCharactersCharacterIdFittingsCreated**](PostCharactersCharacterIdFittingsCreated.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

