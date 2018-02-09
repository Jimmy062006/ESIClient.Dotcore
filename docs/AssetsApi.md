# IO.Swagger.Api.AssetsApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdAssets**](AssetsApi.md#getcharacterscharacteridassets) | **GET** /v3/characters/{character_id}/assets/ | Get character assets
[**GetCorporationsCorporationIdAssets**](AssetsApi.md#getcorporationscorporationidassets) | **GET** /v2/corporations/{corporation_id}/assets/ | Get corporation assets
[**PostCharactersCharacterIdAssetsLocations**](AssetsApi.md#postcharacterscharacteridassetslocations) | **POST** /v2/characters/{character_id}/assets/locations/ | Get character asset locations
[**PostCharactersCharacterIdAssetsNames**](AssetsApi.md#postcharacterscharacteridassetsnames) | **POST** /v1/characters/{character_id}/assets/names/ | Get character asset names
[**PostCorporationsCorporationIdAssetsLocations**](AssetsApi.md#postcorporationscorporationidassetslocations) | **POST** /v2/corporations/{corporation_id}/assets/locations/ | Get corporation asset locations
[**PostCorporationsCorporationIdAssetsNames**](AssetsApi.md#postcorporationscorporationidassetsnames) | **POST** /v1/corporations/{corporation_id}/assets/names/ | Get coporation asset names


<a name="getcharacterscharacteridassets"></a>
# **GetCharactersCharacterIdAssets**
> List<GetCharactersCharacterIdAssets200Ok> GetCharactersCharacterIdAssets (int? characterId, string datasource = null, int? page = null, string token = null, string userAgent = null, string xUserAgent = null)

Get character assets

Return a list of the characters assets  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdAssetsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get character assets
                List&lt;GetCharactersCharacterIdAssets200Ok&gt; result = apiInstance.GetCharactersCharacterIdAssets(characterId, datasource, page, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.GetCharactersCharacterIdAssets: " + e.Message );
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
 **page** | **int?**| Which page of results to return | [optional] [default to 1]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetCharactersCharacterIdAssets200Ok>**](GetCharactersCharacterIdAssets200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidassets"></a>
# **GetCorporationsCorporationIdAssets**
> List<GetCorporationsCorporationIdAssets200Ok> GetCorporationsCorporationIdAssets (int? corporationId, string datasource = null, int? page = null, string token = null, string userAgent = null, string xUserAgent = null)

Get corporation assets

Return a list of the corporation assets  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCorporationsCorporationIdAssetsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get corporation assets
                List&lt;GetCorporationsCorporationIdAssets200Ok&gt; result = apiInstance.GetCorporationsCorporationIdAssets(corporationId, datasource, page, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.GetCorporationsCorporationIdAssets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationId** | **int?**| An EVE corporation ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **page** | **int?**| Which page of results to return | [optional] [default to 1]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetCorporationsCorporationIdAssets200Ok>**](GetCorporationsCorporationIdAssets200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcharacterscharacteridassetslocations"></a>
# **PostCharactersCharacterIdAssetsLocations**
> List<PostCharactersCharacterIdAssetsLocations200Ok> PostCharactersCharacterIdAssetsLocations (int? characterId, List<long?> itemIds, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get character asset locations

Return locations for a set of item ids, which you can get from character assets endpoint. Coordinates for items in hangars or stations are set to (0,0,0)  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostCharactersCharacterIdAssetsLocationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi();
            var characterId = 56;  // int? | An EVE character ID
            var itemIds = ;  // List<long?> | A list of item ids
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get character asset locations
                List&lt;PostCharactersCharacterIdAssetsLocations200Ok&gt; result = apiInstance.PostCharactersCharacterIdAssetsLocations(characterId, itemIds, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.PostCharactersCharacterIdAssetsLocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **itemIds** | **List&lt;long?&gt;**| A list of item ids | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<PostCharactersCharacterIdAssetsLocations200Ok>**](PostCharactersCharacterIdAssetsLocations200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcharacterscharacteridassetsnames"></a>
# **PostCharactersCharacterIdAssetsNames**
> List<PostCharactersCharacterIdAssetsNames200Ok> PostCharactersCharacterIdAssetsNames (int? characterId, List<long?> itemIds, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get character asset names

Return names for a set of item ids, which you can get from character assets endpoint. Typically used for items that can customize names, like containers or ships.  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostCharactersCharacterIdAssetsNamesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi();
            var characterId = 56;  // int? | An EVE character ID
            var itemIds = ;  // List<long?> | A list of item ids
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get character asset names
                List&lt;PostCharactersCharacterIdAssetsNames200Ok&gt; result = apiInstance.PostCharactersCharacterIdAssetsNames(characterId, itemIds, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.PostCharactersCharacterIdAssetsNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **itemIds** | **List&lt;long?&gt;**| A list of item ids | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<PostCharactersCharacterIdAssetsNames200Ok>**](PostCharactersCharacterIdAssetsNames200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcorporationscorporationidassetslocations"></a>
# **PostCorporationsCorporationIdAssetsLocations**
> List<PostCorporationsCorporationIdAssetsLocations200Ok> PostCorporationsCorporationIdAssetsLocations (int? corporationId, List<long?> itemIds, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get corporation asset locations

Return locations for a set of item ids, which you can get from corporation assets endpoint. Coordinates for items in hangars or stations are set to (0,0,0)  - --  Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostCorporationsCorporationIdAssetsLocationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var itemIds = ;  // List<long?> | A list of item ids
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get corporation asset locations
                List&lt;PostCorporationsCorporationIdAssetsLocations200Ok&gt; result = apiInstance.PostCorporationsCorporationIdAssetsLocations(corporationId, itemIds, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.PostCorporationsCorporationIdAssetsLocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationId** | **int?**| An EVE corporation ID | 
 **itemIds** | **List&lt;long?&gt;**| A list of item ids | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<PostCorporationsCorporationIdAssetsLocations200Ok>**](PostCorporationsCorporationIdAssetsLocations200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcorporationscorporationidassetsnames"></a>
# **PostCorporationsCorporationIdAssetsNames**
> List<PostCorporationsCorporationIdAssetsNames200Ok> PostCorporationsCorporationIdAssetsNames (int? corporationId, List<long?> itemIds, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get coporation asset names

Return names for a set of item ids, which you can get from corporation assets endpoint. Only valid for items that can customize names, like containers or ships.  - --  Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostCorporationsCorporationIdAssetsNamesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssetsApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var itemIds = ;  // List<long?> | A list of item ids
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get coporation asset names
                List&lt;PostCorporationsCorporationIdAssetsNames200Ok&gt; result = apiInstance.PostCorporationsCorporationIdAssetsNames(corporationId, itemIds, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssetsApi.PostCorporationsCorporationIdAssetsNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationId** | **int?**| An EVE corporation ID | 
 **itemIds** | **List&lt;long?&gt;**| A list of item ids | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<PostCorporationsCorporationIdAssetsNames200Ok>**](PostCorporationsCorporationIdAssetsNames200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

