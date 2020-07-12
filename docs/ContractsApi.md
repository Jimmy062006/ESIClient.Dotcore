# ESIClient.Dotcore.Api.ContractsApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdContracts**](ContractsApi.md#getcharacterscharacteridcontracts) | **GET** /v1/characters/{character_id}/contracts/ | Get contracts
[**GetCharactersCharacterIdContractsContractIdBids**](ContractsApi.md#getcharacterscharacteridcontractscontractidbids) | **GET** /v1/characters/{character_id}/contracts/{contract_id}/bids/ | Get contract bids
[**GetCharactersCharacterIdContractsContractIdItems**](ContractsApi.md#getcharacterscharacteridcontractscontractiditems) | **GET** /v1/characters/{character_id}/contracts/{contract_id}/items/ | Get contract items
[**GetContractsPublicBidsContractId**](ContractsApi.md#getcontractspublicbidscontractid) | **GET** /v1/contracts/public/bids/{contract_id}/ | Get public contract bids
[**GetContractsPublicItemsContractId**](ContractsApi.md#getcontractspublicitemscontractid) | **GET** /v1/contracts/public/items/{contract_id}/ | Get public contract items
[**GetContractsPublicRegionId**](ContractsApi.md#getcontractspublicregionid) | **GET** /v1/contracts/public/{region_id}/ | Get public contracts
[**GetCorporationsCorporationIdContracts**](ContractsApi.md#getcorporationscorporationidcontracts) | **GET** /v1/corporations/{corporation_id}/contracts/ | Get corporation contracts
[**GetCorporationsCorporationIdContractsContractIdBids**](ContractsApi.md#getcorporationscorporationidcontractscontractidbids) | **GET** /v1/corporations/{corporation_id}/contracts/{contract_id}/bids/ | Get corporation contract bids
[**GetCorporationsCorporationIdContractsContractIdItems**](ContractsApi.md#getcorporationscorporationidcontractscontractiditems) | **GET** /v1/corporations/{corporation_id}/contracts/{contract_id}/items/ | Get corporation contract items


<a name="getcharacterscharacteridcontracts"></a>
# **GetCharactersCharacterIdContracts**
> List<Object> GetCharactersCharacterIdContracts (int? characterId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get contracts

Returns contracts available to a character, only if the character is issuer, acceptor or assignee. Only returns contracts no older than 30 days, or if the status is \"in_progress\".  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdContractsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractsApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get contracts
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdContracts(characterId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.GetCharactersCharacterIdContracts: " + e.Message );
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

<a name="getcharacterscharacteridcontractscontractidbids"></a>
# **GetCharactersCharacterIdContractsContractIdBids**
> List<Object> GetCharactersCharacterIdContractsContractIdBids (int? characterId, int? contractId, string datasource = null, string ifNoneMatch = null, string token = null)

Get contract bids

Lists bids on a particular auction contract  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdContractsContractIdBidsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractsApi();
            var characterId = 56;  // int? | An EVE character ID
            var contractId = 56;  // int? | ID of a contract
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get contract bids
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdContractsContractIdBids(characterId, contractId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.GetCharactersCharacterIdContractsContractIdBids: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **contractId** | **int?**| ID of a contract | 
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

<a name="getcharacterscharacteridcontractscontractiditems"></a>
# **GetCharactersCharacterIdContractsContractIdItems**
> List<Object> GetCharactersCharacterIdContractsContractIdItems (int? characterId, int? contractId, string datasource = null, string ifNoneMatch = null, string token = null)

Get contract items

Lists items of a particular contract  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdContractsContractIdItemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractsApi();
            var characterId = 56;  // int? | An EVE character ID
            var contractId = 56;  // int? | ID of a contract
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get contract items
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdContractsContractIdItems(characterId, contractId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.GetCharactersCharacterIdContractsContractIdItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **contractId** | **int?**| ID of a contract | 
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

<a name="getcontractspublicbidscontractid"></a>
# **GetContractsPublicBidsContractId**
> List<Object> GetContractsPublicBidsContractId (int? contractId, string datasource = null, string ifNoneMatch = null, int? page = null)

Get public contract bids

Lists bids on a public auction contract  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetContractsPublicBidsContractIdExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractId = 56;  // int? | ID of a contract
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)

            try
            {
                // Get public contract bids
                List&lt;Object&gt; result = apiInstance.GetContractsPublicBidsContractId(contractId, datasource, ifNoneMatch, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.GetContractsPublicBidsContractId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **int?**| ID of a contract | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **page** | **int?**| Which page of results to return | [optional] [default to 1]

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontractspublicitemscontractid"></a>
# **GetContractsPublicItemsContractId**
> List<Object> GetContractsPublicItemsContractId (int? contractId, string datasource = null, string ifNoneMatch = null, int? page = null)

Get public contract items

Lists items of a public contract  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetContractsPublicItemsContractIdExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractId = 56;  // int? | ID of a contract
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)

            try
            {
                // Get public contract items
                List&lt;Object&gt; result = apiInstance.GetContractsPublicItemsContractId(contractId, datasource, ifNoneMatch, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.GetContractsPublicItemsContractId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **int?**| ID of a contract | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **page** | **int?**| Which page of results to return | [optional] [default to 1]

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontractspublicregionid"></a>
# **GetContractsPublicRegionId**
> List<Object> GetContractsPublicRegionId (int? regionId, string datasource = null, string ifNoneMatch = null, int? page = null)

Get public contracts

Returns a paginated list of all public contracts in the given region  - --  This route is cached for up to 1800 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetContractsPublicRegionIdExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var regionId = 56;  // int? | An EVE region id
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)

            try
            {
                // Get public contracts
                List&lt;Object&gt; result = apiInstance.GetContractsPublicRegionId(regionId, datasource, ifNoneMatch, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.GetContractsPublicRegionId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **regionId** | **int?**| An EVE region id | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **page** | **int?**| Which page of results to return | [optional] [default to 1]

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidcontracts"></a>
# **GetCorporationsCorporationIdContracts**
> List<Object> GetCorporationsCorporationIdContracts (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get corporation contracts

Returns contracts available to a corporation, only if the corporation is issuer, acceptor or assignee. Only returns contracts no older than 30 days, or if the status is \"in_progress\".  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdContractsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractsApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation contracts
                List&lt;Object&gt; result = apiInstance.GetCorporationsCorporationIdContracts(corporationId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.GetCorporationsCorporationIdContracts: " + e.Message );
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

<a name="getcorporationscorporationidcontractscontractidbids"></a>
# **GetCorporationsCorporationIdContractsContractIdBids**
> List<Object> GetCorporationsCorporationIdContractsContractIdBids (int? contractId, int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get corporation contract bids

Lists bids on a particular auction contract  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdContractsContractIdBidsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractsApi();
            var contractId = 56;  // int? | ID of a contract
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation contract bids
                List&lt;Object&gt; result = apiInstance.GetCorporationsCorporationIdContractsContractIdBids(contractId, corporationId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.GetCorporationsCorporationIdContractsContractIdBids: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **int?**| ID of a contract | 
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

<a name="getcorporationscorporationidcontractscontractiditems"></a>
# **GetCorporationsCorporationIdContractsContractIdItems**
> List<Object> GetCorporationsCorporationIdContractsContractIdItems (int? contractId, int? corporationId, string datasource = null, string ifNoneMatch = null, string token = null)

Get corporation contract items

Lists items of a particular contract  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdContractsContractIdItemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractsApi();
            var contractId = 56;  // int? | ID of a contract
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation contract items
                List&lt;Object&gt; result = apiInstance.GetCorporationsCorporationIdContractsContractIdItems(contractId, corporationId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.GetCorporationsCorporationIdContractsContractIdItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **int?**| ID of a contract | 
 **corporationId** | **int?**| An EVE corporation ID | 
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

