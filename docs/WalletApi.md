# IO.Swagger.Api.WalletApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdWallet**](WalletApi.md#getcharacterscharacteridwallet) | **GET** /v1/characters/{character_id}/wallet/ | Get a character&#39;s wallet balance
[**GetCharactersCharacterIdWalletJournal**](WalletApi.md#getcharacterscharacteridwalletjournal) | **GET** /v3/characters/{character_id}/wallet/journal/ | Get character wallet journal
[**GetCharactersCharacterIdWalletTransactions**](WalletApi.md#getcharacterscharacteridwallettransactions) | **GET** /v1/characters/{character_id}/wallet/transactions/ | Get wallet transactions
[**GetCorporationsCorporationIdWallets**](WalletApi.md#getcorporationscorporationidwallets) | **GET** /v1/corporations/{corporation_id}/wallets/ | Returns a corporation&#39;s wallet balance
[**GetCorporationsCorporationIdWalletsDivisionJournal**](WalletApi.md#getcorporationscorporationidwalletsdivisionjournal) | **GET** /v2/corporations/{corporation_id}/wallets/{division}/journal/ | Get corporation wallet journal
[**GetCorporationsCorporationIdWalletsDivisionTransactions**](WalletApi.md#getcorporationscorporationidwalletsdivisiontransactions) | **GET** /v1/corporations/{corporation_id}/wallets/{division}/transactions/ | Get corporation wallet transactions


<a name="getcharacterscharacteridwallet"></a>
# **GetCharactersCharacterIdWallet**
> double? GetCharactersCharacterIdWallet (int? characterId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get a character's wallet balance

Returns a character's wallet balance  - --  This route is cached for up to 120 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get a character's wallet balance
                double? result = apiInstance.GetCharactersCharacterIdWallet(characterId, datasource, token, userAgent, xUserAgent);
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
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**double?**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridwalletjournal"></a>
# **GetCharactersCharacterIdWalletJournal**
> List<GetCharactersCharacterIdWalletJournal200Ok> GetCharactersCharacterIdWalletJournal (int? characterId, string datasource = null, long? fromId = null, string token = null, string userAgent = null, string xUserAgent = null)

Get character wallet journal

Retrieve character wallet journal  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var fromId = 789;  // long? | Only show journal entries happened before the transaction referenced by this id (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get character wallet journal
                List&lt;GetCharactersCharacterIdWalletJournal200Ok&gt; result = apiInstance.GetCharactersCharacterIdWalletJournal(characterId, datasource, fromId, token, userAgent, xUserAgent);
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
 **fromId** | **long?**| Only show journal entries happened before the transaction referenced by this id | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetCharactersCharacterIdWalletJournal200Ok>**](GetCharactersCharacterIdWalletJournal200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridwallettransactions"></a>
# **GetCharactersCharacterIdWalletTransactions**
> List<GetCharactersCharacterIdWalletTransactions200Ok> GetCharactersCharacterIdWalletTransactions (int? characterId, string datasource = null, long? fromId = null, string token = null, string userAgent = null, string xUserAgent = null)

Get wallet transactions

Get wallet transactions of a character  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get wallet transactions
                List&lt;GetCharactersCharacterIdWalletTransactions200Ok&gt; result = apiInstance.GetCharactersCharacterIdWalletTransactions(characterId, datasource, fromId, token, userAgent, xUserAgent);
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
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetCharactersCharacterIdWalletTransactions200Ok>**](GetCharactersCharacterIdWalletTransactions200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidwallets"></a>
# **GetCorporationsCorporationIdWallets**
> List<GetCorporationsCorporationIdWallets200Ok> GetCorporationsCorporationIdWallets (int? corporationId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Returns a corporation's wallet balance

Get a corporation's wallets  - --  This route is cached for up to 300 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Returns a corporation's wallet balance
                List&lt;GetCorporationsCorporationIdWallets200Ok&gt; result = apiInstance.GetCorporationsCorporationIdWallets(corporationId, datasource, token, userAgent, xUserAgent);
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
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetCorporationsCorporationIdWallets200Ok>**](GetCorporationsCorporationIdWallets200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidwalletsdivisionjournal"></a>
# **GetCorporationsCorporationIdWalletsDivisionJournal**
> List<GetCorporationsCorporationIdWalletsDivisionJournal200Ok> GetCorporationsCorporationIdWalletsDivisionJournal (int? corporationId, int? division, string datasource = null, long? fromId = null, string token = null, string userAgent = null, string xUserAgent = null)

Get corporation wallet journal

Retrieve corporation wallet journal  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var fromId = 789;  // long? | Only show journal entries happened before the transaction referenced by this id (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get corporation wallet journal
                List&lt;GetCorporationsCorporationIdWalletsDivisionJournal200Ok&gt; result = apiInstance.GetCorporationsCorporationIdWalletsDivisionJournal(corporationId, division, datasource, fromId, token, userAgent, xUserAgent);
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
 **fromId** | **long?**| Only show journal entries happened before the transaction referenced by this id | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetCorporationsCorporationIdWalletsDivisionJournal200Ok>**](GetCorporationsCorporationIdWalletsDivisionJournal200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidwalletsdivisiontransactions"></a>
# **GetCorporationsCorporationIdWalletsDivisionTransactions**
> List<GetCorporationsCorporationIdWalletsDivisionTransactions200Ok> GetCorporationsCorporationIdWalletsDivisionTransactions (int? corporationId, int? division, string datasource = null, long? fromId = null, string token = null, string userAgent = null, string xUserAgent = null)

Get corporation wallet transactions

Get wallet transactions of a corporation  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Junior_Accountant

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

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
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get corporation wallet transactions
                List&lt;GetCorporationsCorporationIdWalletsDivisionTransactions200Ok&gt; result = apiInstance.GetCorporationsCorporationIdWalletsDivisionTransactions(corporationId, division, datasource, fromId, token, userAgent, xUserAgent);
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
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetCorporationsCorporationIdWalletsDivisionTransactions200Ok>**](GetCorporationsCorporationIdWalletsDivisionTransactions200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

