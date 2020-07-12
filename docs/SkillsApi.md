# ESIClient.Dotcore.Api.SkillsApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdAttributes**](SkillsApi.md#getcharacterscharacteridattributes) | **GET** /v1/characters/{character_id}/attributes/ | Get character attributes
[**GetCharactersCharacterIdSkillqueue**](SkillsApi.md#getcharacterscharacteridskillqueue) | **GET** /v2/characters/{character_id}/skillqueue/ | Get character&#39;s skill queue
[**GetCharactersCharacterIdSkills**](SkillsApi.md#getcharacterscharacteridskills) | **GET** /v4/characters/{character_id}/skills/ | Get character skills


<a name="getcharacterscharacteridattributes"></a>
# **GetCharactersCharacterIdAttributes**
> GetCharactersCharacterIdAttributesOk GetCharactersCharacterIdAttributes (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Get character attributes

Return attributes of a character  - --  This route is cached for up to 120 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdAttributesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SkillsApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get character attributes
                GetCharactersCharacterIdAttributesOk result = apiInstance.GetCharactersCharacterIdAttributes(characterId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SkillsApi.GetCharactersCharacterIdAttributes: " + e.Message );
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

[**GetCharactersCharacterIdAttributesOk**](GetCharactersCharacterIdAttributesOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridskillqueue"></a>
# **GetCharactersCharacterIdSkillqueue**
> List<Object> GetCharactersCharacterIdSkillqueue (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Get character's skill queue

List the configured skill queue for the given character  - --  This route is cached for up to 120 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdSkillqueueExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SkillsApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get character's skill queue
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdSkillqueue(characterId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SkillsApi.GetCharactersCharacterIdSkillqueue: " + e.Message );
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

<a name="getcharacterscharacteridskills"></a>
# **GetCharactersCharacterIdSkills**
> GetCharactersCharacterIdSkillsOk GetCharactersCharacterIdSkills (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Get character skills

List all trained skills for the given character  - --  This route is cached for up to 120 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdSkillsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SkillsApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get character skills
                GetCharactersCharacterIdSkillsOk result = apiInstance.GetCharactersCharacterIdSkills(characterId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SkillsApi.GetCharactersCharacterIdSkills: " + e.Message );
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

[**GetCharactersCharacterIdSkillsOk**](GetCharactersCharacterIdSkillsOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

