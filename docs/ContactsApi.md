# IO.Swagger.Api.ContactsApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCharactersCharacterIdContacts**](ContactsApi.md#deletecharacterscharacteridcontacts) | **DELETE** /v2/characters/{character_id}/contacts/ | Delete contacts
[**GetAlliancesAllianceIdContacts**](ContactsApi.md#getalliancesallianceidcontacts) | **GET** /v1/alliances/{alliance_id}/contacts/ | Get alliance contacts
[**GetCharactersCharacterIdContacts**](ContactsApi.md#getcharacterscharacteridcontacts) | **GET** /v1/characters/{character_id}/contacts/ | Get contacts
[**GetCharactersCharacterIdContactsLabels**](ContactsApi.md#getcharacterscharacteridcontactslabels) | **GET** /v1/characters/{character_id}/contacts/labels/ | Get contact labels
[**GetCorporationsCorporationIdContacts**](ContactsApi.md#getcorporationscorporationidcontacts) | **GET** /v1/corporations/{corporation_id}/contacts/ | Get corporation contacts
[**PostCharactersCharacterIdContacts**](ContactsApi.md#postcharacterscharacteridcontacts) | **POST** /v1/characters/{character_id}/contacts/ | Add contacts
[**PutCharactersCharacterIdContacts**](ContactsApi.md#putcharacterscharacteridcontacts) | **PUT** /v1/characters/{character_id}/contacts/ | Edit contacts


<a name="deletecharacterscharacteridcontacts"></a>
# **DeleteCharactersCharacterIdContacts**
> void DeleteCharactersCharacterIdContacts (int? characterId, List<int?> contactIds, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Delete contacts

Bulk delete contacts  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCharactersCharacterIdContactsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var characterId = 56;  // int? | An EVE character ID
            var contactIds = new List<int?>(); // List<int?> | A list of contacts to delete
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Delete contacts
                apiInstance.DeleteCharactersCharacterIdContacts(characterId, contactIds, datasource, token, userAgent, xUserAgent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.DeleteCharactersCharacterIdContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **contactIds** | [**List&lt;int?&gt;**](int?.md)| A list of contacts to delete | 
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

<a name="getalliancesallianceidcontacts"></a>
# **GetAlliancesAllianceIdContacts**
> List<GetAlliancesAllianceIdContacts200Ok> GetAlliancesAllianceIdContacts (int? allianceId, string datasource = null, int? page = null, string token = null, string userAgent = null, string xUserAgent = null)

Get alliance contacts

Return contacts of an alliance  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAlliancesAllianceIdContactsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var allianceId = 56;  // int? | An EVE alliance ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get alliance contacts
                List&lt;GetAlliancesAllianceIdContacts200Ok&gt; result = apiInstance.GetAlliancesAllianceIdContacts(allianceId, datasource, page, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetAlliancesAllianceIdContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **allianceId** | **int?**| An EVE alliance ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **page** | **int?**| Which page of results to return | [optional] [default to 1]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetAlliancesAllianceIdContacts200Ok>**](GetAlliancesAllianceIdContacts200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridcontacts"></a>
# **GetCharactersCharacterIdContacts**
> List<GetCharactersCharacterIdContacts200Ok> GetCharactersCharacterIdContacts (int? characterId, string datasource = null, int? page = null, string token = null, string userAgent = null, string xUserAgent = null)

Get contacts

Return contacts of a character  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdContactsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get contacts
                List&lt;GetCharactersCharacterIdContacts200Ok&gt; result = apiInstance.GetCharactersCharacterIdContacts(characterId, datasource, page, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetCharactersCharacterIdContacts: " + e.Message );
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

[**List<GetCharactersCharacterIdContacts200Ok>**](GetCharactersCharacterIdContacts200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridcontactslabels"></a>
# **GetCharactersCharacterIdContactsLabels**
> List<GetCharactersCharacterIdContactsLabels200Ok> GetCharactersCharacterIdContactsLabels (int? characterId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get contact labels

Return custom labels for contacts the character defined  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdContactsLabelsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get contact labels
                List&lt;GetCharactersCharacterIdContactsLabels200Ok&gt; result = apiInstance.GetCharactersCharacterIdContactsLabels(characterId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetCharactersCharacterIdContactsLabels: " + e.Message );
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

[**List<GetCharactersCharacterIdContactsLabels200Ok>**](GetCharactersCharacterIdContactsLabels200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidcontacts"></a>
# **GetCorporationsCorporationIdContacts**
> List<GetCorporationsCorporationIdContacts200Ok> GetCorporationsCorporationIdContacts (int? corporationId, string datasource = null, int? page = null, string token = null, string userAgent = null, string xUserAgent = null)

Get corporation contacts

Return contacts of a corporation  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCorporationsCorporationIdContactsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get corporation contacts
                List&lt;GetCorporationsCorporationIdContacts200Ok&gt; result = apiInstance.GetCorporationsCorporationIdContacts(corporationId, datasource, page, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetCorporationsCorporationIdContacts: " + e.Message );
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

[**List<GetCorporationsCorporationIdContacts200Ok>**](GetCorporationsCorporationIdContacts200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcharacterscharacteridcontacts"></a>
# **PostCharactersCharacterIdContacts**
> List<int?> PostCharactersCharacterIdContacts (int? characterId, List<int?> contactIds, float? standing, string datasource = null, long? labelId = null, string token = null, string userAgent = null, bool? watched = null, string xUserAgent = null)

Add contacts

Bulk add contacts with same settings  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostCharactersCharacterIdContactsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var characterId = 56;  // int? | An EVE character ID
            var contactIds = ;  // List<int?> | A list of contacts to add
            var standing = 3.4;  // float? | Standing for the new contact
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var labelId = 789;  // long? | Add a custom label to the new contact (optional)  (default to 0)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var watched = true;  // bool? | Whether the new contact should be watched, note this is only effective on characters (optional)  (default to false)
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Add contacts
                List&lt;int?&gt; result = apiInstance.PostCharactersCharacterIdContacts(characterId, contactIds, standing, datasource, labelId, token, userAgent, watched, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.PostCharactersCharacterIdContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **contactIds** | **List&lt;int?&gt;**| A list of contacts to add | 
 **standing** | **float?**| Standing for the new contact | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **labelId** | **long?**| Add a custom label to the new contact | [optional] [default to 0]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **watched** | **bool?**| Whether the new contact should be watched, note this is only effective on characters | [optional] [default to false]
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**List<int?>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcharacterscharacteridcontacts"></a>
# **PutCharactersCharacterIdContacts**
> void PutCharactersCharacterIdContacts (int? characterId, List<int?> contactIds, float? standing, string datasource = null, long? labelId = null, string token = null, string userAgent = null, bool? watched = null, string xUserAgent = null)

Edit contacts

Bulk edit contacts with same settings  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutCharactersCharacterIdContactsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var characterId = 56;  // int? | An EVE character ID
            var contactIds = ;  // List<int?> | A list of contacts to edit
            var standing = 3.4;  // float? | Standing for the contact
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var labelId = 789;  // long? | Add a custom label to the contact, use 0 for clearing label (optional)  (default to 0)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var watched = true;  // bool? | Whether the contact should be watched, note this is only effective on characters (optional)  (default to false)
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Edit contacts
                apiInstance.PutCharactersCharacterIdContacts(characterId, contactIds, standing, datasource, labelId, token, userAgent, watched, xUserAgent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.PutCharactersCharacterIdContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **contactIds** | **List&lt;int?&gt;**| A list of contacts to edit | 
 **standing** | **float?**| Standing for the contact | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **labelId** | **long?**| Add a custom label to the contact, use 0 for clearing label | [optional] [default to 0]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **watched** | **bool?**| Whether the contact should be watched, note this is only effective on characters | [optional] [default to false]
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

