# IO.Swagger.Api.FactionWarfareApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdFwStats**](FactionWarfareApi.md#getcharacterscharacteridfwstats) | **GET** /v1/characters/{character_id}/fw/stats/ | Overview of a character involved in faction warfare
[**GetCorporationsCorporationIdFwStats**](FactionWarfareApi.md#getcorporationscorporationidfwstats) | **GET** /v1/corporations/{corporation_id}/fw/stats/ | Overview of a corporation involved in faction warfare
[**GetFwLeaderboards**](FactionWarfareApi.md#getfwleaderboards) | **GET** /v1/fw/leaderboards/ | List of the top factions in faction warfare
[**GetFwLeaderboardsCharacters**](FactionWarfareApi.md#getfwleaderboardscharacters) | **GET** /v1/fw/leaderboards/characters/ | List of the top pilots in faction warfare
[**GetFwLeaderboardsCorporations**](FactionWarfareApi.md#getfwleaderboardscorporations) | **GET** /v1/fw/leaderboards/corporations/ | List of the top corporations in faction warfare
[**GetFwStats**](FactionWarfareApi.md#getfwstats) | **GET** /v1/fw/stats/ | An overview of statistics about factions involved in faction warfare
[**GetFwSystems**](FactionWarfareApi.md#getfwsystems) | **GET** /v1/fw/systems/ | Ownership of faction warfare systems
[**GetFwWars**](FactionWarfareApi.md#getfwwars) | **GET** /v1/fw/wars/ | Data about which NPC factions are at war


<a name="getcharacterscharacteridfwstats"></a>
# **GetCharactersCharacterIdFwStats**
> GetCharactersCharacterIdFwStatsOk GetCharactersCharacterIdFwStats (int? characterId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Overview of a character involved in faction warfare

Statistical overview of a character involved in faction warfare  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdFwStatsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FactionWarfareApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Overview of a character involved in faction warfare
                GetCharactersCharacterIdFwStatsOk result = apiInstance.GetCharactersCharacterIdFwStats(characterId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FactionWarfareApi.GetCharactersCharacterIdFwStats: " + e.Message );
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

[**GetCharactersCharacterIdFwStatsOk**](GetCharactersCharacterIdFwStatsOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidfwstats"></a>
# **GetCorporationsCorporationIdFwStats**
> GetCorporationsCorporationIdFwStatsOk GetCorporationsCorporationIdFwStats (int? corporationId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Overview of a corporation involved in faction warfare

Statistics about a corporation involved in faction warfare  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCorporationsCorporationIdFwStatsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FactionWarfareApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Overview of a corporation involved in faction warfare
                GetCorporationsCorporationIdFwStatsOk result = apiInstance.GetCorporationsCorporationIdFwStats(corporationId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FactionWarfareApi.GetCorporationsCorporationIdFwStats: " + e.Message );
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
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetCorporationsCorporationIdFwStatsOk**](GetCorporationsCorporationIdFwStatsOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfwleaderboards"></a>
# **GetFwLeaderboards**
> GetFwLeaderboardsOk GetFwLeaderboards (string datasource = null, string userAgent = null, string xUserAgent = null)

List of the top factions in faction warfare

Top 4 leaderboard of factions for kills and victory points separated by total, last week and yesterday.  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFwLeaderboardsExample
    {
        public void main()
        {
            var apiInstance = new FactionWarfareApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // List of the top factions in faction warfare
                GetFwLeaderboardsOk result = apiInstance.GetFwLeaderboards(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FactionWarfareApi.GetFwLeaderboards: " + e.Message );
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

[**GetFwLeaderboardsOk**](GetFwLeaderboardsOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfwleaderboardscharacters"></a>
# **GetFwLeaderboardsCharacters**
> GetFwLeaderboardsCharactersOk GetFwLeaderboardsCharacters (string datasource = null, string userAgent = null, string xUserAgent = null)

List of the top pilots in faction warfare

Top 100 leaderboard of pilots for kills and victory points separated by total, last week and yesterday.  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFwLeaderboardsCharactersExample
    {
        public void main()
        {
            var apiInstance = new FactionWarfareApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // List of the top pilots in faction warfare
                GetFwLeaderboardsCharactersOk result = apiInstance.GetFwLeaderboardsCharacters(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FactionWarfareApi.GetFwLeaderboardsCharacters: " + e.Message );
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

[**GetFwLeaderboardsCharactersOk**](GetFwLeaderboardsCharactersOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfwleaderboardscorporations"></a>
# **GetFwLeaderboardsCorporations**
> GetFwLeaderboardsCorporationsOk GetFwLeaderboardsCorporations (string datasource = null, string userAgent = null, string xUserAgent = null)

List of the top corporations in faction warfare

Top 10 leaderboard of corporations for kills and victory points separated by total, last week and yesterday.  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFwLeaderboardsCorporationsExample
    {
        public void main()
        {
            var apiInstance = new FactionWarfareApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // List of the top corporations in faction warfare
                GetFwLeaderboardsCorporationsOk result = apiInstance.GetFwLeaderboardsCorporations(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FactionWarfareApi.GetFwLeaderboardsCorporations: " + e.Message );
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

[**GetFwLeaderboardsCorporationsOk**](GetFwLeaderboardsCorporationsOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfwstats"></a>
# **GetFwStats**
> List<GetFwStats200Ok> GetFwStats (string datasource = null, string userAgent = null, string xUserAgent = null)

An overview of statistics about factions involved in faction warfare

Statistical overviews of factions involved in faction warfare  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFwStatsExample
    {
        public void main()
        {
            var apiInstance = new FactionWarfareApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // An overview of statistics about factions involved in faction warfare
                List&lt;GetFwStats200Ok&gt; result = apiInstance.GetFwStats(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FactionWarfareApi.GetFwStats: " + e.Message );
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

[**List<GetFwStats200Ok>**](GetFwStats200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfwsystems"></a>
# **GetFwSystems**
> List<GetFwSystems200Ok> GetFwSystems (string datasource = null, string userAgent = null, string xUserAgent = null)

Ownership of faction warfare systems

An overview of the current ownership of faction warfare solar systems  - --  This route is cached for up to 1800 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFwSystemsExample
    {
        public void main()
        {
            var apiInstance = new FactionWarfareApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Ownership of faction warfare systems
                List&lt;GetFwSystems200Ok&gt; result = apiInstance.GetFwSystems(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FactionWarfareApi.GetFwSystems: " + e.Message );
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

[**List<GetFwSystems200Ok>**](GetFwSystems200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfwwars"></a>
# **GetFwWars**
> List<GetFwWars200Ok> GetFwWars (string datasource = null, string userAgent = null, string xUserAgent = null)

Data about which NPC factions are at war

Data about which NPC factions are at war  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFwWarsExample
    {
        public void main()
        {
            var apiInstance = new FactionWarfareApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Data about which NPC factions are at war
                List&lt;GetFwWars200Ok&gt; result = apiInstance.GetFwWars(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FactionWarfareApi.GetFwWars: " + e.Message );
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

[**List<GetFwWars200Ok>**](GetFwWars200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

