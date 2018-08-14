# ESIClient.Dotcore.Api.WalletApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdWallet**](WalletApi.md#getcharacterscharacteridwallet) | **GET** /v1/characters/{character_id}/wallet/ | Get a character&#39;s wallet balance
[**GetCharactersCharacterIdWalletJournal**](WalletApi.md#getcharacterscharacteridwalletjournal) | **GET** /v4/characters/{character_id}/wallet/journal/ | Get character wallet journal
[**GetCharactersCharacterIdWalletTransactions**](WalletApi.md#getcharacterscharacteridwallettransactions) | **GET** /v1/characters/{character_id}/wallet/transactions/ | Get wallet transactions
[**GetCorporationsCorporationIdWallets**](WalletApi.md#getcorporationscorporationidwallets) | **GET** /v1/corporations/{corporation_id}/wallets/ | Returns a corporation&#39;s wallet balance
[**GetCorporationsCorporationIdWalletsDivisionJournal**](WalletApi.md#getcorporationscorporationidwalletsdivisionjournal) | **GET** /v3/corporations/{corporation_id}/wallets/{division}/journal/ | Get corporation wallet journal
[**GetCorporationsCorporationIdWalletsDivisionTransactions**](WalletApi.md#getcorporationscorporationidwalletsdivisiontransactions) | **GET** /v1/corporations/{corporation_id}/wallets/{division}/transactions/ | Get corporation wallet transactions


<a name="getcharacterscharacteridwallet"></a>
# **GetCharactersCharacterIdWallet**
> double? GetCharactersCharacterIdWallet (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

Get a character's wallet balance

Returns a character's wallet balance  - --  This route is cached for up to 120 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdWalletExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WalletApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get a character's wallet balance
                double? result = apiInstance.GetCharactersCharacterIdWallet(characterId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WalletApi.GetCharactersCharacterIdWallet: " + e.Message );
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

**double?**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridwalletjournal"></a>
# **GetCharactersCharacterIdWalletJournal**
> List<Object> GetCharactersCharacterIdWalletJournal (int? characterId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get character wallet journal

Retrieve the given character's wallet journal going 30 days back  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdWalletJournalExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WalletApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get character wallet journal
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdWalletJournal(characterId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WalletApi.GetCharactersCharacterIdWalletJournal: " + e.Message );
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

<a name="getcharacterscharacteridwallettransactions"></a>
# **GetCharactersCharacterIdWalletTransactions**
> List<Object> GetCharactersCharacterIdWalletTransactions (int? characterId, string datasource = null, long? fromId = null, string ifNoneMatch = null, string token = null)

Get wallet transactions

Get wallet transactions of a character  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdWalletTransactionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WalletApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var fromId = 789;  // long? | Only show transactions happened before the one referenced by this id (optional) 
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get wallet transactions
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdWalletTransactions(characterId, datasource, fromId, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WalletApi.GetCharactersCharacterIdWalletTransactions: " + e.Message );
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
 **fromId** | **long?**| Only show transactions happened before the one referenced by this id | [optional] 
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

<a name="getcorporationscorporationidwallets"></a>
# **GetCorporationsCorporationIdWallets**
> List<Object> GetCorporationsCorporationIdWallets (int? corporationId, string datasource = null, string ifNoneMatch = null, string token = null)

Returns a corporation's wallet balance

Get a corporation's wallets  - --  This route is cached for up to 300 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdWalletsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WalletApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Returns a corporation's wallet balance
                List&lt;Object&gt; result = apiInstance.GetCorporationsCorporationIdWallets(corporationId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WalletApi.GetCorporationsCorporationIdWallets: " + e.Message );
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

**List<Object>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidwalletsdivisionjournal"></a>
# **GetCorporationsCorporationIdWalletsDivisionJournal**
> List<Object> GetCorporationsCorporationIdWalletsDivisionJournal (int? corporationId, int? division, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get corporation wallet journal

Retrieve the given corporation's wallet journal for the given division going 30 days back  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdWalletsDivisionJournalExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WalletApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var division = 56;  // int? | Wallet key of the division to fetch journals from
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation wallet journal
                List&lt;Object&gt; result = apiInstance.GetCorporationsCorporationIdWalletsDivisionJournal(corporationId, division, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WalletApi.GetCorporationsCorporationIdWalletsDivisionJournal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationId** | **int?**| An EVE corporation ID | 
 **division** | **int?**| Wallet key of the division to fetch journals from | 
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

<a name="getcorporationscorporationidwalletsdivisiontransactions"></a>
# **GetCorporationsCorporationIdWalletsDivisionTransactions**
> List<Object> GetCorporationsCorporationIdWalletsDivisionTransactions (int? corporationId, int? division, string datasource = null, long? fromId = null, string ifNoneMatch = null, string token = null)

Get corporation wallet transactions

Get wallet transactions of a corporation  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdWalletsDivisionTransactionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WalletApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var division = 56;  // int? | Wallet key of the division to fetch journals from
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var fromId = 789;  // long? | Only show journal entries happened before the transaction referenced by this id (optional) 
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation wallet transactions
                List&lt;Object&gt; result = apiInstance.GetCorporationsCorporationIdWalletsDivisionTransactions(corporationId, division, datasource, fromId, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WalletApi.GetCorporationsCorporationIdWalletsDivisionTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationId** | **int?**| An EVE corporation ID | 
 **division** | **int?**| Wallet key of the division to fetch journals from | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **fromId** | **long?**| Only show journal entries happened before the transaction referenced by this id | [optional] 
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

