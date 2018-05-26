# ESIClient.Dotcore.Api.SearchApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdSearch**](SearchApi.md#getcharacterscharacteridsearch) | **GET** /v3/characters/{character_id}/search/ | Search on a string
[**GetSearch**](SearchApi.md#getsearch) | **GET** /v2/search/ | Search on a string


<a name="getcharacterscharacteridsearch"></a>
# **GetCharactersCharacterIdSearch**
> GetCharactersCharacterIdSearchOk GetCharactersCharacterIdSearch (List<string> categories, int? characterId, string search, string acceptLanguage = null, string datasource = null, string ifNoneMatch = null, string language = null, bool? strict = null, string token = null)

Search on a string

Search for entities that match a given sub-string.  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var acceptLanguage = acceptLanguage_example;  // string | Language to use in the response (optional)  (default to en-us)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var language = language_example;  // string | Language to use in the response, takes precedence over Accept-Language (optional)  (default to en-us)
            var strict = true;  // bool? | Whether the search should be a strict match (optional)  (default to false)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Search on a string
                GetCharactersCharacterIdSearchOk result = apiInstance.GetCharactersCharacterIdSearch(categories, characterId, search, acceptLanguage, datasource, ifNoneMatch, language, strict, token);
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
 **acceptLanguage** | **string**| Language to use in the response | [optional] [default to en-us]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **language** | **string**| Language to use in the response, takes precedence over Accept-Language | [optional] [default to en-us]
 **strict** | **bool?**| Whether the search should be a strict match | [optional] [default to false]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**GetCharactersCharacterIdSearchOk**](GetCharactersCharacterIdSearchOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsearch"></a>
# **GetSearch**
> GetSearchOk GetSearch (List<string> categories, string search, string acceptLanguage = null, string datasource = null, string ifNoneMatch = null, string language = null, bool? strict = null)

Search on a string

Search for entities that match a given sub-string.  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetSearchExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var categories = categories_example;  // List<string> | Type of entities to search for
            var search = search_example;  // string | The string to search on
            var acceptLanguage = acceptLanguage_example;  // string | Language to use in the response (optional)  (default to en-us)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var language = language_example;  // string | Language to use in the response, takes precedence over Accept-Language (optional)  (default to en-us)
            var strict = true;  // bool? | Whether the search should be a strict match (optional)  (default to false)

            try
            {
                // Search on a string
                GetSearchOk result = apiInstance.GetSearch(categories, search, acceptLanguage, datasource, ifNoneMatch, language, strict);
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
 **acceptLanguage** | **string**| Language to use in the response | [optional] [default to en-us]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **language** | **string**| Language to use in the response, takes precedence over Accept-Language | [optional] [default to en-us]
 **strict** | **bool?**| Whether the search should be a strict match | [optional] [default to false]

### Return type

[**GetSearchOk**](GetSearchOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

