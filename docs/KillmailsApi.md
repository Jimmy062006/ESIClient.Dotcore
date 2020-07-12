# ESIClient.Dotcore.Api.KillmailsApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdKillmailsRecent**](KillmailsApi.md#getcharacterscharacteridkillmailsrecent) | **GET** /v1/characters/{character_id}/killmails/recent/ | Get a character&#39;s recent kills and losses
[**GetCorporationsCorporationIdKillmailsRecent**](KillmailsApi.md#getcorporationscorporationidkillmailsrecent) | **GET** /v1/corporations/{corporation_id}/killmails/recent/ | Get a corporation&#39;s recent kills and losses
[**GetKillmailsKillmailIdKillmailHash**](KillmailsApi.md#getkillmailskillmailidkillmailhash) | **GET** /v1/killmails/{killmail_id}/{killmail_hash}/ | Get a single killmail


<a name="getcharacterscharacteridkillmailsrecent"></a>
# **GetCharactersCharacterIdKillmailsRecent**
> List<Object> GetCharactersCharacterIdKillmailsRecent (int? characterId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get a character's recent kills and losses

Return a list of a character's kills and losses going back 90 days  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdKillmailsRecentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KillmailsApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get a character's recent kills and losses
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdKillmailsRecent(characterId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KillmailsApi.GetCharactersCharacterIdKillmailsRecent: " + e.Message );
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
 **page** | **int?**| Which page of results to return | [optional] [default to 1]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

**List<Object>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidkillmailsrecent"></a>
# **GetCorporationsCorporationIdKillmailsRecent**
> List<Object> GetCorporationsCorporationIdKillmailsRecent (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get a corporation's recent kills and losses

Get a list of a corporation's kills and losses going back 90 days  - --  This route is cached for up to 300 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdKillmailsRecentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KillmailsApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get a corporation's recent kills and losses
                List&lt;Object&gt; result = apiInstance.GetCorporationsCorporationIdKillmailsRecent(corporationId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KillmailsApi.GetCorporationsCorporationIdKillmailsRecent: " + e.Message );
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
 **page** | **int?**| Which page of results to return | [optional] [default to 1]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

**List<Object>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkillmailskillmailidkillmailhash"></a>
# **GetKillmailsKillmailIdKillmailHash**
> GetKillmailsKillmailIdKillmailHashOk GetKillmailsKillmailIdKillmailHash (string killmailHash, int? killmailId, string datasource = null, string ifNoneMatch = null)

Get a single killmail

Return a single killmail from its ID and hash  - --  This route is cached for up to 30758400 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetKillmailsKillmailIdKillmailHashExample
    {
        public void main()
        {
            var apiInstance = new KillmailsApi();
            var killmailHash = killmailHash_example;  // string | The killmail hash for verification
            var killmailId = 56;  // int? | The killmail ID to be queried
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Get a single killmail
                GetKillmailsKillmailIdKillmailHashOk result = apiInstance.GetKillmailsKillmailIdKillmailHash(killmailHash, killmailId, datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KillmailsApi.GetKillmailsKillmailIdKillmailHash: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **killmailHash** | **string**| The killmail hash for verification | 
 **killmailId** | **int?**| The killmail ID to be queried | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 

### Return type

[**GetKillmailsKillmailIdKillmailHashOk**](GetKillmailsKillmailIdKillmailHashOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

