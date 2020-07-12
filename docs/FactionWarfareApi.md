# ESIClient.Dotcore.Api.FactionWarfareApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdFwStats**](FactionWarfareApi.md#getcharacterscharacteridfwstats) | **GET** /v1/characters/{character_id}/fw/stats/ | Overview of a character involved in faction warfare
[**GetCorporationsCorporationIdFwStats**](FactionWarfareApi.md#getcorporationscorporationidfwstats) | **GET** /v1/corporations/{corporation_id}/fw/stats/ | Overview of a corporation involved in faction warfare
[**GetFwLeaderboards**](FactionWarfareApi.md#getfwleaderboards) | **GET** /v1/fw/leaderboards/ | List of the top factions in faction warfare
[**GetFwLeaderboardsCharacters**](FactionWarfareApi.md#getfwleaderboardscharacters) | **GET** /v1/fw/leaderboards/characters/ | List of the top pilots in faction warfare
[**GetFwLeaderboardsCorporations**](FactionWarfareApi.md#getfwleaderboardscorporations) | **GET** /v1/fw/leaderboards/corporations/ | List of the top corporations in faction warfare
[**GetFwStats**](FactionWarfareApi.md#getfwstats) | **GET** /v1/fw/stats/ | An overview of statistics about factions involved in faction warfare
[**GetFwSystems**](FactionWarfareApi.md#getfwsystems) | **GET** /v2/fw/systems/ | Ownership of faction warfare systems
[**GetFwWars**](FactionWarfareApi.md#getfwwars) | **GET** /v1/fw/wars/ | Data about which NPC factions are at war


<a name="getcharacterscharacteridfwstats"></a>
# **GetCharactersCharacterIdFwStats**
> GetCharactersCharacterIdFwStatsOk GetCharactersCharacterIdFwStats (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Overview of a character involved in faction warfare

Statistical overview of a character involved in faction warfare  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Overview of a character involved in faction warfare
                GetCharactersCharacterIdFwStatsOk result = apiInstance.GetCharactersCharacterIdFwStats(characterId, datasource, ifNoneMatch, token);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**GetCharactersCharacterIdFwStatsOk**](GetCharactersCharacterIdFwStatsOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidfwstats"></a>
# **GetCorporationsCorporationIdFwStats**
> GetCorporationsCorporationIdFwStatsOk GetCorporationsCorporationIdFwStats (int? corporationId, string datasource = null, string ifNoneMatch = null, string token = null)

Overview of a corporation involved in faction warfare

Statistics about a corporation involved in faction warfare  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Overview of a corporation involved in faction warfare
                GetCorporationsCorporationIdFwStatsOk result = apiInstance.GetCorporationsCorporationIdFwStats(corporationId, datasource, ifNoneMatch, token);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**GetCorporationsCorporationIdFwStatsOk**](GetCorporationsCorporationIdFwStatsOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfwleaderboards"></a>
# **GetFwLeaderboards**
> GetFwLeaderboardsOk GetFwLeaderboards (string datasource = null, string ifNoneMatch = null)

List of the top factions in faction warfare

Top 4 leaderboard of factions for kills and victory points separated by total, last week and yesterday  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetFwLeaderboardsExample
    {
        public void main()
        {
            var apiInstance = new FactionWarfareApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // List of the top factions in faction warfare
                GetFwLeaderboardsOk result = apiInstance.GetFwLeaderboards(datasource, ifNoneMatch);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 

### Return type

[**GetFwLeaderboardsOk**](GetFwLeaderboardsOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfwleaderboardscharacters"></a>
# **GetFwLeaderboardsCharacters**
> GetFwLeaderboardsCharactersOk GetFwLeaderboardsCharacters (string datasource = null, string ifNoneMatch = null)

List of the top pilots in faction warfare

Top 100 leaderboard of pilots for kills and victory points separated by total, last week and yesterday  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetFwLeaderboardsCharactersExample
    {
        public void main()
        {
            var apiInstance = new FactionWarfareApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // List of the top pilots in faction warfare
                GetFwLeaderboardsCharactersOk result = apiInstance.GetFwLeaderboardsCharacters(datasource, ifNoneMatch);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 

### Return type

[**GetFwLeaderboardsCharactersOk**](GetFwLeaderboardsCharactersOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfwleaderboardscorporations"></a>
# **GetFwLeaderboardsCorporations**
> GetFwLeaderboardsCorporationsOk GetFwLeaderboardsCorporations (string datasource = null, string ifNoneMatch = null)

List of the top corporations in faction warfare

Top 10 leaderboard of corporations for kills and victory points separated by total, last week and yesterday  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetFwLeaderboardsCorporationsExample
    {
        public void main()
        {
            var apiInstance = new FactionWarfareApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // List of the top corporations in faction warfare
                GetFwLeaderboardsCorporationsOk result = apiInstance.GetFwLeaderboardsCorporations(datasource, ifNoneMatch);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 

### Return type

[**GetFwLeaderboardsCorporationsOk**](GetFwLeaderboardsCorporationsOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfwstats"></a>
# **GetFwStats**
> List<Object> GetFwStats (string datasource = null, string ifNoneMatch = null)

An overview of statistics about factions involved in faction warfare

Statistical overviews of factions involved in faction warfare  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetFwStatsExample
    {
        public void main()
        {
            var apiInstance = new FactionWarfareApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // An overview of statistics about factions involved in faction warfare
                List&lt;Object&gt; result = apiInstance.GetFwStats(datasource, ifNoneMatch);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfwsystems"></a>
# **GetFwSystems**
> List<Object> GetFwSystems (string datasource = null, string ifNoneMatch = null)

Ownership of faction warfare systems

An overview of the current ownership of faction warfare solar systems  - --  This route is cached for up to 1800 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetFwSystemsExample
    {
        public void main()
        {
            var apiInstance = new FactionWarfareApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Ownership of faction warfare systems
                List&lt;Object&gt; result = apiInstance.GetFwSystems(datasource, ifNoneMatch);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfwwars"></a>
# **GetFwWars**
> List<Object> GetFwWars (string datasource = null, string ifNoneMatch = null)

Data about which NPC factions are at war

Data about which NPC factions are at war  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetFwWarsExample
    {
        public void main()
        {
            var apiInstance = new FactionWarfareApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Data about which NPC factions are at war
                List&lt;Object&gt; result = apiInstance.GetFwWars(datasource, ifNoneMatch);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

