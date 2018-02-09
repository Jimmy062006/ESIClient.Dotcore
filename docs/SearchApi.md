# IO.Swagger.Api.SearchApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdSearch**](SearchApi.md#getcharacterscharacteridsearch) | **GET** /v3/characters/{character_id}/search/ | Search on a string
[**GetSearch**](SearchApi.md#getsearch) | **GET** /v2/search/ | Search on a string


<a name="getcharacterscharacteridsearch"></a>
# **GetCharactersCharacterIdSearch**
> GetCharactersCharacterIdSearchOk GetCharactersCharacterIdSearch (List<string> categories, int? characterId, string search, string datasource = null, string language = null, bool? strict = null, string token = null, string userAgent = null, string xUserAgent = null)

Search on a string

Search for entities that match a given sub-string.  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdSearchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var categories = categories_example;  // List<string> | Type of entities to search for
            var characterId = 56;  // int? | An EVE character ID
            var search = search_example;  // string | The string to search on
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var strict = true;  // bool? | Whether the search should be a strict match (optional)  (default to false)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Search on a string
                GetCharactersCharacterIdSearchOk result = apiInstance.GetCharactersCharacterIdSearch(categories, characterId, search, datasource, language, strict, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetCharactersCharacterIdSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categories** | **List&lt;string&gt;**| Type of entities to search for | 
 **characterId** | **int?**| An EVE character ID | 
 **search** | **string**| The string to search on | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **strict** | **bool?**| Whether the search should be a strict match | [optional] [default to false]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetCharactersCharacterIdSearchOk**](GetCharactersCharacterIdSearchOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsearch"></a>
# **GetSearch**
> GetSearchOk GetSearch (List<string> categories, string search, string datasource = null, string language = null, bool? strict = null, string userAgent = null, string xUserAgent = null)

Search on a string

Search for entities that match a given sub-string.  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSearchExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var categories = categories_example;  // List<string> | Type of entities to search for
            var search = search_example;  // string | The string to search on
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var strict = true;  // bool? | Whether the search should be a strict match (optional)  (default to false)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Search on a string
                GetSearchOk result = apiInstance.GetSearch(categories, search, datasource, language, strict, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.GetSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categories** | **List&lt;string&gt;**| Type of entities to search for | 
 **search** | **string**| The string to search on | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **strict** | **bool?**| Whether the search should be a strict match | [optional] [default to false]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetSearchOk**](GetSearchOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

