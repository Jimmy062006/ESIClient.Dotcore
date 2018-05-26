# ESIClient.Dotcore.Api.FittingsApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCharactersCharacterIdFittingsFittingId**](FittingsApi.md#deletecharacterscharacteridfittingsfittingid) | **DELETE** /v1/characters/{character_id}/fittings/{fitting_id}/ | Delete fitting
[**GetCharactersCharacterIdFittings**](FittingsApi.md#getcharacterscharacteridfittings) | **GET** /v1/characters/{character_id}/fittings/ | Get fittings
[**PostCharactersCharacterIdFittings**](FittingsApi.md#postcharacterscharacteridfittings) | **POST** /v1/characters/{character_id}/fittings/ | Create fitting


<a name="deletecharacterscharacteridfittingsfittingid"></a>
# **DeleteCharactersCharacterIdFittingsFittingId**
> void DeleteCharactersCharacterIdFittingsFittingId (int? characterId, int? fittingId, string datasource = null, string token = null)

Delete fitting

Delete a fitting from a character  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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

            try
            {
                // Delete fitting
                apiInstance.DeleteCharactersCharacterIdFittingsFittingId(characterId, fittingId, datasource, token);
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

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridfittings"></a>
# **GetCharactersCharacterIdFittings**
> List<GetCharactersCharacterIdFittings200Ok> GetCharactersCharacterIdFittings (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Get fittings

Return fittings of a character  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get fittings
                List&lt;GetCharactersCharacterIdFittings200Ok&gt; result = apiInstance.GetCharactersCharacterIdFittings(characterId, datasource, ifNoneMatch, token);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**List<GetCharactersCharacterIdFittings200Ok>**](GetCharactersCharacterIdFittings200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcharacterscharacteridfittings"></a>
# **PostCharactersCharacterIdFittings**
> PostCharactersCharacterIdFittingsCreated PostCharactersCharacterIdFittings (int? characterId, PostCharactersCharacterIdFittingsFitting fitting, string datasource = null, string token = null)

Create fitting

Save a new fitting for a character  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var fitting = new PostCharactersCharacterIdFittingsFitting(); // PostCharactersCharacterIdFittingsFitting | Details about the new fitting
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Create fitting
                PostCharactersCharacterIdFittingsCreated result = apiInstance.PostCharactersCharacterIdFittings(characterId, fitting, datasource, token);
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
 **fitting** | [**PostCharactersCharacterIdFittingsFitting**](PostCharactersCharacterIdFittingsFitting.md)| Details about the new fitting | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**PostCharactersCharacterIdFittingsCreated**](PostCharactersCharacterIdFittingsCreated.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

