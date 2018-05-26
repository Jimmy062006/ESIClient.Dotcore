# ESIClient.Dotcore.Api.ContactsApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCharactersCharacterIdContacts**](ContactsApi.md#deletecharacterscharacteridcontacts) | **DELETE** /v2/characters/{character_id}/contacts/ | Delete contacts
[**GetAlliancesAllianceIdContacts**](ContactsApi.md#getalliancesallianceidcontacts) | **GET** /v1/alliances/{alliance_id}/contacts/ | Get alliance contacts
[**GetAlliancesAllianceIdContactsLabels**](ContactsApi.md#getalliancesallianceidcontactslabels) | **GET** /v1/alliances/{alliance_id}/contacts/labels/ | Get alliance contact labels
[**GetCharactersCharacterIdContacts**](ContactsApi.md#getcharacterscharacteridcontacts) | **GET** /v1/characters/{character_id}/contacts/ | Get contacts
[**GetCharactersCharacterIdContactsLabels**](ContactsApi.md#getcharacterscharacteridcontactslabels) | **GET** /v1/characters/{character_id}/contacts/labels/ | Get contact labels
[**GetCorporationsCorporationIdContacts**](ContactsApi.md#getcorporationscorporationidcontacts) | **GET** /v1/corporations/{corporation_id}/contacts/ | Get corporation contacts
[**GetCorporationsCorporationIdContactsLabels**](ContactsApi.md#getcorporationscorporationidcontactslabels) | **GET** /v1/corporations/{corporation_id}/contacts/labels/ | Get corporation contact labels
[**PostCharactersCharacterIdContacts**](ContactsApi.md#postcharacterscharacteridcontacts) | **POST** /v1/characters/{character_id}/contacts/ | Add contacts
[**PutCharactersCharacterIdContacts**](ContactsApi.md#putcharacterscharacteridcontacts) | **PUT** /v1/characters/{character_id}/contacts/ | Edit contacts


<a name="deletecharacterscharacteridcontacts"></a>
# **DeleteCharactersCharacterIdContacts**
> void DeleteCharactersCharacterIdContacts (int? characterId, List<int?> contactIds, string datasource = null, string token = null)

Delete contacts

Bulk delete contacts  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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

            try
            {
                // Delete contacts
                apiInstance.DeleteCharactersCharacterIdContacts(characterId, contactIds, datasource, token);
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

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalliancesallianceidcontacts"></a>
# **GetAlliancesAllianceIdContacts**
> List<GetAlliancesAllianceIdContacts200Ok> GetAlliancesAllianceIdContacts (int? allianceId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get alliance contacts

Return contacts of an alliance  - --  This route is cached for up to 300 seconds  - -- Warning: This route has an upgrade available.  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/alliances/{alliance_id}/contacts/)

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get alliance contacts
                List&lt;GetAlliancesAllianceIdContacts200Ok&gt; result = apiInstance.GetAlliancesAllianceIdContacts(allianceId, datasource, ifNoneMatch, page, token);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **page** | **int?**| Which page of results to return | [optional] [default to 1]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**List<GetAlliancesAllianceIdContacts200Ok>**](GetAlliancesAllianceIdContacts200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalliancesallianceidcontactslabels"></a>
# **GetAlliancesAllianceIdContactsLabels**
> List<GetAlliancesAllianceIdContactsLabels200Ok> GetAlliancesAllianceIdContactsLabels (int? allianceId, string datasource = null, string ifNoneMatch = null, string token = null)

Get alliance contact labels

Return custom labels for an alliance's contacts  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetAlliancesAllianceIdContactsLabelsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var allianceId = 56;  // int? | An EVE alliance ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get alliance contact labels
                List&lt;GetAlliancesAllianceIdContactsLabels200Ok&gt; result = apiInstance.GetAlliancesAllianceIdContactsLabels(allianceId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetAlliancesAllianceIdContactsLabels: " + e.Message );
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**List<GetAlliancesAllianceIdContactsLabels200Ok>**](GetAlliancesAllianceIdContactsLabels200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridcontacts"></a>
# **GetCharactersCharacterIdContacts**
> List<GetCharactersCharacterIdContacts200Ok> GetCharactersCharacterIdContacts (int? characterId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get contacts

Return contacts of a character  - --  This route is cached for up to 300 seconds  - -- Warning: This route has an upgrade available.  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/characters/{character_id}/contacts/)

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get contacts
                List&lt;GetCharactersCharacterIdContacts200Ok&gt; result = apiInstance.GetCharactersCharacterIdContacts(characterId, datasource, ifNoneMatch, page, token);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **page** | **int?**| Which page of results to return | [optional] [default to 1]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**List<GetCharactersCharacterIdContacts200Ok>**](GetCharactersCharacterIdContacts200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridcontactslabels"></a>
# **GetCharactersCharacterIdContactsLabels**
> List<GetCharactersCharacterIdContactsLabels200Ok> GetCharactersCharacterIdContactsLabels (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Get contact labels

Return custom labels for a character's contacts  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get contact labels
                List&lt;GetCharactersCharacterIdContactsLabels200Ok&gt; result = apiInstance.GetCharactersCharacterIdContactsLabels(characterId, datasource, ifNoneMatch, token);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**List<GetCharactersCharacterIdContactsLabels200Ok>**](GetCharactersCharacterIdContactsLabels200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidcontacts"></a>
# **GetCorporationsCorporationIdContacts**
> List<GetCorporationsCorporationIdContacts200Ok> GetCorporationsCorporationIdContacts (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get corporation contacts

Return contacts of a corporation  - --  This route is cached for up to 300 seconds  - -- Warning: This route has an upgrade available.  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/corporations/{corporation_id}/contacts/)

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation contacts
                List&lt;GetCorporationsCorporationIdContacts200Ok&gt; result = apiInstance.GetCorporationsCorporationIdContacts(corporationId, datasource, ifNoneMatch, page, token);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **page** | **int?**| Which page of results to return | [optional] [default to 1]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**List<GetCorporationsCorporationIdContacts200Ok>**](GetCorporationsCorporationIdContacts200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidcontactslabels"></a>
# **GetCorporationsCorporationIdContactsLabels**
> List<GetCorporationsCorporationIdContactsLabels200Ok> GetCorporationsCorporationIdContactsLabels (int? corporationId, string datasource = null, string ifNoneMatch = null, string token = null)

Get corporation contact labels

Return custom labels for a corporation's contacts  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdContactsLabelsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation contact labels
                List&lt;GetCorporationsCorporationIdContactsLabels200Ok&gt; result = apiInstance.GetCorporationsCorporationIdContactsLabels(corporationId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetCorporationsCorporationIdContactsLabels: " + e.Message );
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

[**List<GetCorporationsCorporationIdContactsLabels200Ok>**](GetCorporationsCorporationIdContactsLabels200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcharacterscharacteridcontacts"></a>
# **PostCharactersCharacterIdContacts**
> List<int?> PostCharactersCharacterIdContacts (int? characterId, List<int?> contactIds, float? standing, string datasource = null, long? labelId = null, string token = null, bool? watched = null)

Add contacts

Bulk add contacts with same settings  - --  Warning: This route has an upgrade available.  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#POST-/characters/{character_id}/contacts/)

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var contactIds = ;  // List<int?> | A list of contacts
            var standing = 3.4;  // float? | Standing for the contact
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var labelId = 789;  // long? | Add a custom label to the new contact (optional)  (default to 0)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var watched = true;  // bool? | Whether the contact should be watched, note this is only effective on characters (optional)  (default to false)

            try
            {
                // Add contacts
                List&lt;int?&gt; result = apiInstance.PostCharactersCharacterIdContacts(characterId, contactIds, standing, datasource, labelId, token, watched);
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
 **contactIds** | **List&lt;int?&gt;**| A list of contacts | 
 **standing** | **float?**| Standing for the contact | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **labelId** | **long?**| Add a custom label to the new contact | [optional] [default to 0]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **watched** | **bool?**| Whether the contact should be watched, note this is only effective on characters | [optional] [default to false]

### Return type

**List<int?>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcharacterscharacteridcontacts"></a>
# **PutCharactersCharacterIdContacts**
> void PutCharactersCharacterIdContacts (int? characterId, List<int?> contactIds, float? standing, string datasource = null, long? labelId = null, string token = null, bool? watched = null)

Edit contacts

Bulk edit contacts with same settings  - --  Warning: This route has an upgrade available.  - -- [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#PUT-/characters/{character_id}/contacts/)

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var contactIds = ;  // List<int?> | A list of contacts
            var standing = 3.4;  // float? | Standing for the contact
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var labelId = 789;  // long? | Add a custom label to the contact, use 0 for clearing label (optional)  (default to 0)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var watched = true;  // bool? | Whether the contact should be watched, note this is only effective on characters (optional)  (default to false)

            try
            {
                // Edit contacts
                apiInstance.PutCharactersCharacterIdContacts(characterId, contactIds, standing, datasource, labelId, token, watched);
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
 **contactIds** | **List&lt;int?&gt;**| A list of contacts | 
 **standing** | **float?**| Standing for the contact | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **labelId** | **long?**| Add a custom label to the contact, use 0 for clearing label | [optional] [default to 0]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **watched** | **bool?**| Whether the contact should be watched, note this is only effective on characters | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

