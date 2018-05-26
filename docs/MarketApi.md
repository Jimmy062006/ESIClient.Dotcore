# ESIClient.Dotcore.Api.MarketApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdOrders**](MarketApi.md#getcharacterscharacteridorders) | **GET** /v2/characters/{character_id}/orders/ | List open orders from a character
[**GetCharactersCharacterIdOrdersHistory**](MarketApi.md#getcharacterscharacteridordershistory) | **GET** /v1/characters/{character_id}/orders/history/ | List historical orders by a character
[**GetCorporationsCorporationIdOrders**](MarketApi.md#getcorporationscorporationidorders) | **GET** /v2/corporations/{corporation_id}/orders/ | List open orders from a corporation
[**GetCorporationsCorporationIdOrdersHistory**](MarketApi.md#getcorporationscorporationidordershistory) | **GET** /v1/corporations/{corporation_id}/orders/history/ | List historical orders from a corporation
[**GetMarketsGroups**](MarketApi.md#getmarketsgroups) | **GET** /v1/markets/groups/ | Get item groups
[**GetMarketsGroupsMarketGroupId**](MarketApi.md#getmarketsgroupsmarketgroupid) | **GET** /v1/markets/groups/{market_group_id}/ | Get item group information
[**GetMarketsPrices**](MarketApi.md#getmarketsprices) | **GET** /v1/markets/prices/ | List market prices
[**GetMarketsRegionIdHistory**](MarketApi.md#getmarketsregionidhistory) | **GET** /v1/markets/{region_id}/history/ | List historical market statistics in a region
[**GetMarketsRegionIdOrders**](MarketApi.md#getmarketsregionidorders) | **GET** /v1/markets/{region_id}/orders/ | List orders in a region
[**GetMarketsRegionIdTypes**](MarketApi.md#getmarketsregionidtypes) | **GET** /v1/markets/{region_id}/types/ | List type IDs relevant to a market
[**GetMarketsStructuresStructureId**](MarketApi.md#getmarketsstructuresstructureid) | **GET** /v1/markets/structures/{structure_id}/ | List orders in a structure


<a name="getcharacterscharacteridorders"></a>
# **GetCharactersCharacterIdOrders**
> List<GetCharactersCharacterIdOrders200Ok> GetCharactersCharacterIdOrders (int? characterId, string datasource = null, string ifNoneMatch = null, string token = null)

List open orders from a character

List open market orders placed by a character  - --  This route is cached for up to 1200 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdOrdersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MarketApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // List open orders from a character
                List&lt;GetCharactersCharacterIdOrders200Ok&gt; result = apiInstance.GetCharactersCharacterIdOrders(characterId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.GetCharactersCharacterIdOrders: " + e.Message );
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

[**List<GetCharactersCharacterIdOrders200Ok>**](GetCharactersCharacterIdOrders200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridordershistory"></a>
# **GetCharactersCharacterIdOrdersHistory**
> List<GetCharactersCharacterIdOrdersHistory200Ok> GetCharactersCharacterIdOrdersHistory (int? characterId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

List historical orders by a character

List cancelled and expired market orders placed by a character up to 90 days in the past.  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdOrdersHistoryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MarketApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // List historical orders by a character
                List&lt;GetCharactersCharacterIdOrdersHistory200Ok&gt; result = apiInstance.GetCharactersCharacterIdOrdersHistory(characterId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.GetCharactersCharacterIdOrdersHistory: " + e.Message );
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

[**List<GetCharactersCharacterIdOrdersHistory200Ok>**](GetCharactersCharacterIdOrdersHistory200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidorders"></a>
# **GetCorporationsCorporationIdOrders**
> List<GetCorporationsCorporationIdOrders200Ok> GetCorporationsCorporationIdOrders (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

List open orders from a corporation

List open market orders placed on behalf of a corporation  - --  This route is cached for up to 1200 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Trader

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdOrdersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MarketApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // List open orders from a corporation
                List&lt;GetCorporationsCorporationIdOrders200Ok&gt; result = apiInstance.GetCorporationsCorporationIdOrders(corporationId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.GetCorporationsCorporationIdOrders: " + e.Message );
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

[**List<GetCorporationsCorporationIdOrders200Ok>**](GetCorporationsCorporationIdOrders200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidordershistory"></a>
# **GetCorporationsCorporationIdOrdersHistory**
> List<GetCorporationsCorporationIdOrdersHistory200Ok> GetCorporationsCorporationIdOrdersHistory (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

List historical orders from a corporation

List cancelled and expired market orders placed on behalf of a corporation up to 90 days in the past.  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant, Trader

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdOrdersHistoryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MarketApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // List historical orders from a corporation
                List&lt;GetCorporationsCorporationIdOrdersHistory200Ok&gt; result = apiInstance.GetCorporationsCorporationIdOrdersHistory(corporationId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.GetCorporationsCorporationIdOrdersHistory: " + e.Message );
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

[**List<GetCorporationsCorporationIdOrdersHistory200Ok>**](GetCorporationsCorporationIdOrdersHistory200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketsgroups"></a>
# **GetMarketsGroups**
> List<int?> GetMarketsGroups (string datasource = null, string ifNoneMatch = null)

Get item groups

Get a list of item groups  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetMarketsGroupsExample
    {
        public void main()
        {
            var apiInstance = new MarketApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Get item groups
                List&lt;int?&gt; result = apiInstance.GetMarketsGroups(datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.GetMarketsGroups: " + e.Message );
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

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketsgroupsmarketgroupid"></a>
# **GetMarketsGroupsMarketGroupId**
> GetMarketsGroupsMarketGroupIdOk GetMarketsGroupsMarketGroupId (int? marketGroupId, string acceptLanguage = null, string datasource = null, string ifNoneMatch = null, string language = null)

Get item group information

Get information on an item group  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetMarketsGroupsMarketGroupIdExample
    {
        public void main()
        {
            var apiInstance = new MarketApi();
            var marketGroupId = 56;  // int? | An Eve item group ID
            var acceptLanguage = acceptLanguage_example;  // string | Language to use in the response (optional)  (default to en-us)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var language = language_example;  // string | Language to use in the response, takes precedence over Accept-Language (optional)  (default to en-us)

            try
            {
                // Get item group information
                GetMarketsGroupsMarketGroupIdOk result = apiInstance.GetMarketsGroupsMarketGroupId(marketGroupId, acceptLanguage, datasource, ifNoneMatch, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.GetMarketsGroupsMarketGroupId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **marketGroupId** | **int?**| An Eve item group ID | 
 **acceptLanguage** | **string**| Language to use in the response | [optional] [default to en-us]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **language** | **string**| Language to use in the response, takes precedence over Accept-Language | [optional] [default to en-us]

### Return type

[**GetMarketsGroupsMarketGroupIdOk**](GetMarketsGroupsMarketGroupIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketsprices"></a>
# **GetMarketsPrices**
> List<GetMarketsPrices200Ok> GetMarketsPrices (string datasource = null, string ifNoneMatch = null)

List market prices

Return a list of prices  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetMarketsPricesExample
    {
        public void main()
        {
            var apiInstance = new MarketApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // List market prices
                List&lt;GetMarketsPrices200Ok&gt; result = apiInstance.GetMarketsPrices(datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.GetMarketsPrices: " + e.Message );
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

[**List<GetMarketsPrices200Ok>**](GetMarketsPrices200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketsregionidhistory"></a>
# **GetMarketsRegionIdHistory**
> List<GetMarketsRegionIdHistory200Ok> GetMarketsRegionIdHistory (int? regionId, int? typeId, string datasource = null, string ifNoneMatch = null)

List historical market statistics in a region

Return a list of historical market statistics for the specified type in a region  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetMarketsRegionIdHistoryExample
    {
        public void main()
        {
            var apiInstance = new MarketApi();
            var regionId = 56;  // int? | Return statistics in this region
            var typeId = 56;  // int? | Return statistics for this type
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // List historical market statistics in a region
                List&lt;GetMarketsRegionIdHistory200Ok&gt; result = apiInstance.GetMarketsRegionIdHistory(regionId, typeId, datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.GetMarketsRegionIdHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **regionId** | **int?**| Return statistics in this region | 
 **typeId** | **int?**| Return statistics for this type | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 

### Return type

[**List<GetMarketsRegionIdHistory200Ok>**](GetMarketsRegionIdHistory200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketsregionidorders"></a>
# **GetMarketsRegionIdOrders**
> List<GetMarketsRegionIdOrders200Ok> GetMarketsRegionIdOrders (string orderType, int? regionId, string datasource = null, string ifNoneMatch = null, int? page = null, int? typeId = null)

List orders in a region

Return a list of orders in a region  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetMarketsRegionIdOrdersExample
    {
        public void main()
        {
            var apiInstance = new MarketApi();
            var orderType = orderType_example;  // string | Filter buy/sell orders, return all orders by default. If you query without type_id, we always return both buy and sell orders. (default to all)
            var regionId = 56;  // int? | Return orders in this region
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var typeId = 56;  // int? | Return orders only for this type (optional) 

            try
            {
                // List orders in a region
                List&lt;GetMarketsRegionIdOrders200Ok&gt; result = apiInstance.GetMarketsRegionIdOrders(orderType, regionId, datasource, ifNoneMatch, page, typeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.GetMarketsRegionIdOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderType** | **string**| Filter buy/sell orders, return all orders by default. If you query without type_id, we always return both buy and sell orders. | [default to all]
 **regionId** | **int?**| Return orders in this region | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **page** | **int?**| Which page of results to return | [optional] [default to 1]
 **typeId** | **int?**| Return orders only for this type | [optional] 

### Return type

[**List<GetMarketsRegionIdOrders200Ok>**](GetMarketsRegionIdOrders200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketsregionidtypes"></a>
# **GetMarketsRegionIdTypes**
> List<int?> GetMarketsRegionIdTypes (int? regionId, string datasource = null, string ifNoneMatch = null, int? page = null)

List type IDs relevant to a market

Return a list of type IDs that have active orders in the region, for efficient market indexing.  - --  This route is cached for up to 600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetMarketsRegionIdTypesExample
    {
        public void main()
        {
            var apiInstance = new MarketApi();
            var regionId = 56;  // int? | Return statistics in this region
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)

            try
            {
                // List type IDs relevant to a market
                List&lt;int?&gt; result = apiInstance.GetMarketsRegionIdTypes(regionId, datasource, ifNoneMatch, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.GetMarketsRegionIdTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **regionId** | **int?**| Return statistics in this region | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **page** | **int?**| Which page of results to return | [optional] [default to 1]

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmarketsstructuresstructureid"></a>
# **GetMarketsStructuresStructureId**
> List<GetMarketsStructuresStructureId200Ok> GetMarketsStructuresStructureId (long? structureId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

List orders in a structure

Return all orders in a structure  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetMarketsStructuresStructureIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MarketApi();
            var structureId = 789;  // long? | Return orders in this structure
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // List orders in a structure
                List&lt;GetMarketsStructuresStructureId200Ok&gt; result = apiInstance.GetMarketsStructuresStructureId(structureId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketApi.GetMarketsStructuresStructureId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **structureId** | **long?**| Return orders in this structure | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **page** | **int?**| Which page of results to return | [optional] [default to 1]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**List<GetMarketsStructuresStructureId200Ok>**](GetMarketsStructuresStructureId200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

