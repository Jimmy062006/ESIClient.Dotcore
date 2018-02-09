# IO.Swagger.Api.LoyaltyApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdLoyaltyPoints**](LoyaltyApi.md#getcharacterscharacteridloyaltypoints) | **GET** /v1/characters/{character_id}/loyalty/points/ | Get loyalty points
[**GetLoyaltyStoresCorporationIdOffers**](LoyaltyApi.md#getloyaltystorescorporationidoffers) | **GET** /v1/loyalty/stores/{corporation_id}/offers/ | List loyalty store offers


<a name="getcharacterscharacteridloyaltypoints"></a>
# **GetCharactersCharacterIdLoyaltyPoints**
> List<GetCharactersCharacterIdLoyaltyPoints200Ok> GetCharactersCharacterIdLoyaltyPoints (int? characterId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get loyalty points

Return a list of loyalty points for all corporations the character has worked for  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdLoyaltyPointsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoyaltyApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get loyalty points
                List&lt;GetCharactersCharacterIdLoyaltyPoints200Ok&gt; result = apiInstance.GetCharactersCharacterIdLoyaltyPoints(characterId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyApi.GetCharactersCharacterIdLoyaltyPoints: " + e.Message );
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

[**List<GetCharactersCharacterIdLoyaltyPoints200Ok>**](GetCharactersCharacterIdLoyaltyPoints200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltystorescorporationidoffers"></a>
# **GetLoyaltyStoresCorporationIdOffers**
> List<GetLoyaltyStoresCorporationIdOffers200Ok> GetLoyaltyStoresCorporationIdOffers (int? corporationId, string datasource = null, string userAgent = null, string xUserAgent = null)

List loyalty store offers

Return a list of offers from a specific corporation's loyalty store  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLoyaltyStoresCorporationIdOffersExample
    {
        public void main()
        {
            var apiInstance = new LoyaltyApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // List loyalty store offers
                List&lt;GetLoyaltyStoresCorporationIdOffers200Ok&gt; result = apiInstance.GetLoyaltyStoresCorporationIdOffers(corporationId, datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoyaltyApi.GetLoyaltyStoresCorporationIdOffers: " + e.Message );
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
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetLoyaltyStoresCorporationIdOffers200Ok>**](GetLoyaltyStoresCorporationIdOffers200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

