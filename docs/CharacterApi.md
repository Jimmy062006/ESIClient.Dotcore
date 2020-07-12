# ESIClient.Dotcore.Api.CharacterApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterId**](CharacterApi.md#getcharacterscharacterid) | **GET** /v4/characters/{character_id}/ | Get character&#39;s public information
[**GetCharactersCharacterIdAgentsResearch**](CharacterApi.md#getcharacterscharacteridagentsresearch) | **GET** /v1/characters/{character_id}/agents_research/ | Get agents research
[**GetCharactersCharacterIdBlueprints**](CharacterApi.md#getcharacterscharacteridblueprints) | **GET** /v2/characters/{character_id}/blueprints/ | Get blueprints
[**GetCharactersCharacterIdCorporationhistory**](CharacterApi.md#getcharacterscharacteridcorporationhistory) | **GET** /v1/characters/{character_id}/corporationhistory/ | Get corporation history
[**GetCharactersCharacterIdFatigue**](CharacterApi.md#getcharacterscharacteridfatigue) | **GET** /v1/characters/{character_id}/fatigue/ | Get jump fatigue
[**GetCharactersCharacterIdMedals**](CharacterApi.md#getcharacterscharacteridmedals) | **GET** /v1/characters/{character_id}/medals/ | Get medals
[**GetCharactersCharacterIdNotifications**](CharacterApi.md#getcharacterscharacteridnotifications) | **GET** /v5/characters/{character_id}/notifications/ | Get character notifications
[**GetCharactersCharacterIdNotificationsContacts**](CharacterApi.md#getcharacterscharacteridnotificationscontacts) | **GET** /v1/characters/{character_id}/notifications/contacts/ | Get new contact notifications
[**GetCharactersCharacterIdPortrait**](CharacterApi.md#getcharacterscharacteridportrait) | **GET** /v2/characters/{character_id}/portrait/ | Get character portraits
[**GetCharactersCharacterIdRoles**](CharacterApi.md#getcharacterscharacteridroles) | **GET** /v2/characters/{character_id}/roles/ | Get character corporation roles
[**GetCharactersCharacterIdStandings**](CharacterApi.md#getcharacterscharacteridstandings) | **GET** /v1/characters/{character_id}/standings/ | Get standings
[**GetCharactersCharacterIdStats**](CharacterApi.md#getcharacterscharacteridstats) | **GET** /v2/characters/{character_id}/stats/ | Yearly aggregate stats
[**GetCharactersCharacterIdTitles**](CharacterApi.md#getcharacterscharacteridtitles) | **GET** /v1/characters/{character_id}/titles/ | Get character corporation titles
[**PostCharactersAffiliation**](CharacterApi.md#postcharactersaffiliation) | **POST** /v1/characters/affiliation/ | Character affiliation
[**PostCharactersCharacterIdCspa**](CharacterApi.md#postcharacterscharacteridcspa) | **POST** /v4/characters/{character_id}/cspa/ | Calculate a CSPA charge cost


<a name="getcharacterscharacterid"></a>
# **GetCharactersCharacterId**
> GetCharactersCharacterIdOk GetCharactersCharacterId (int? characterId, string datasource = null, string ifNoneMatch = null)

Get character's public information

Public information about a character  - --  This route is cached for up to 86400 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdExample
    {
        public void main()
        {
            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Get character's public information
                GetCharactersCharacterIdOk result = apiInstance.GetCharactersCharacterId(characterId, datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterId: " + e.Message );
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

### Return type

[**GetCharactersCharacterIdOk**](GetCharactersCharacterIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridagentsresearch"></a>
# **GetCharactersCharacterIdAgentsResearch**
> List<Object> GetCharactersCharacterIdAgentsResearch (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Get agents research

Return a list of agents research information for a character. The formula for finding the current research points with an agent is: currentPoints = remainderPoints + pointsPerDay * days(currentTime - researchStartDate)  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdAgentsResearchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get agents research
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdAgentsResearch(characterId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterIdAgentsResearch: " + e.Message );
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

**List<Object>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridblueprints"></a>
# **GetCharactersCharacterIdBlueprints**
> List<Object> GetCharactersCharacterIdBlueprints (int? characterId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get blueprints

Return a list of blueprints the character owns  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdBlueprintsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get blueprints
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdBlueprints(characterId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterIdBlueprints: " + e.Message );
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

<a name="getcharacterscharacteridcorporationhistory"></a>
# **GetCharactersCharacterIdCorporationhistory**
> List<Object> GetCharactersCharacterIdCorporationhistory (int? characterId, string datasource = null, string ifNoneMatch = null)

Get corporation history

Get a list of all the corporations a character has been a member of  - --  This route is cached for up to 86400 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdCorporationhistoryExample
    {
        public void main()
        {
            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Get corporation history
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdCorporationhistory(characterId, datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterIdCorporationhistory: " + e.Message );
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

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridfatigue"></a>
# **GetCharactersCharacterIdFatigue**
> GetCharactersCharacterIdFatigueOk GetCharactersCharacterIdFatigue (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Get jump fatigue

Return a character's jump activation and fatigue information  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdFatigueExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get jump fatigue
                GetCharactersCharacterIdFatigueOk result = apiInstance.GetCharactersCharacterIdFatigue(characterId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterIdFatigue: " + e.Message );
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

[**GetCharactersCharacterIdFatigueOk**](GetCharactersCharacterIdFatigueOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridmedals"></a>
# **GetCharactersCharacterIdMedals**
> List<Object> GetCharactersCharacterIdMedals (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Get medals

Return a list of medals the character has  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdMedalsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get medals
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdMedals(characterId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterIdMedals: " + e.Message );
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

**List<Object>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridnotifications"></a>
# **GetCharactersCharacterIdNotifications**
> List<Object> GetCharactersCharacterIdNotifications (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Get character notifications

Return character notifications  - --  This route is cached for up to 600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdNotificationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get character notifications
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdNotifications(characterId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterIdNotifications: " + e.Message );
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

**List<Object>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridnotificationscontacts"></a>
# **GetCharactersCharacterIdNotificationsContacts**
> List<Object> GetCharactersCharacterIdNotificationsContacts (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Get new contact notifications

Return notifications about having been added to someone's contact list  - --  This route is cached for up to 600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdNotificationsContactsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get new contact notifications
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdNotificationsContacts(characterId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterIdNotificationsContacts: " + e.Message );
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

**List<Object>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridportrait"></a>
# **GetCharactersCharacterIdPortrait**
> GetCharactersCharacterIdPortraitOk GetCharactersCharacterIdPortrait (int? characterId, string datasource = null, string ifNoneMatch = null)

Get character portraits

Get portrait urls for a character  - --  This route expires daily at 11:05  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/characters/{character_id}/portrait/)

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdPortraitExample
    {
        public void main()
        {
            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Get character portraits
                GetCharactersCharacterIdPortraitOk result = apiInstance.GetCharactersCharacterIdPortrait(characterId, datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterIdPortrait: " + e.Message );
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

### Return type

[**GetCharactersCharacterIdPortraitOk**](GetCharactersCharacterIdPortraitOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridroles"></a>
# **GetCharactersCharacterIdRoles**
> GetCharactersCharacterIdRolesOk GetCharactersCharacterIdRoles (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Get character corporation roles

Returns a character's corporation roles  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdRolesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get character corporation roles
                GetCharactersCharacterIdRolesOk result = apiInstance.GetCharactersCharacterIdRoles(characterId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterIdRoles: " + e.Message );
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

[**GetCharactersCharacterIdRolesOk**](GetCharactersCharacterIdRolesOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridstandings"></a>
# **GetCharactersCharacterIdStandings**
> List<Object> GetCharactersCharacterIdStandings (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Get standings

Return character standings from agents, NPC corporations, and factions  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdStandingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get standings
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdStandings(characterId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterIdStandings: " + e.Message );
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

**List<Object>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridstats"></a>
# **GetCharactersCharacterIdStats**
> List<Object> GetCharactersCharacterIdStats (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Yearly aggregate stats

Returns aggregate yearly stats for a character  - --  This route is cached for up to 86400 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdStatsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Yearly aggregate stats
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdStats(characterId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterIdStats: " + e.Message );
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

**List<Object>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridtitles"></a>
# **GetCharactersCharacterIdTitles**
> List<Object> GetCharactersCharacterIdTitles (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Get character corporation titles

Returns a character's titles  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdTitlesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get character corporation titles
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdTitles(characterId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.GetCharactersCharacterIdTitles: " + e.Message );
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

**List<Object>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcharactersaffiliation"></a>
# **PostCharactersAffiliation**
> List<Object> PostCharactersAffiliation (List<int?> characters, string datasource = null)

Character affiliation

Bulk lookup of character IDs to corporation, alliance and faction  - --  This route is cached for up to 3600 seconds  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#POST-/characters/affiliation/)

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class PostCharactersAffiliationExample
    {
        public void main()
        {
            var apiInstance = new CharacterApi();
            var characters = ;  // List<int?> | The character IDs to fetch affiliations for. All characters must exist, or none will be returned
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)

            try
            {
                // Character affiliation
                List&lt;Object&gt; result = apiInstance.PostCharactersAffiliation(characters, datasource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.PostCharactersAffiliation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characters** | **List&lt;int?&gt;**| The character IDs to fetch affiliations for. All characters must exist, or none will be returned | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcharacterscharacteridcspa"></a>
# **PostCharactersCharacterIdCspa**
> float? PostCharactersCharacterIdCspa (int? characterId, List<int?> characters, string datasource = null, string token = null)

Calculate a CSPA charge cost

Takes a source character ID in the url and a set of target character ID's in the body, returns a CSPA charge cost  - --

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class PostCharactersCharacterIdCspaExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CharacterApi();
            var characterId = 56;  // int? | An EVE character ID
            var characters = ;  // List<int?> | The target characters to calculate the charge for
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Calculate a CSPA charge cost
                float? result = apiInstance.PostCharactersCharacterIdCspa(characterId, characters, datasource, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CharacterApi.PostCharactersCharacterIdCspa: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **characters** | **List&lt;int?&gt;**| The target characters to calculate the charge for | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

**float?**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

