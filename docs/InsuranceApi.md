# ESIClient.Dotcore.Api.InsuranceApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInsurancePrices**](InsuranceApi.md#getinsuranceprices) | **GET** /v1/insurance/prices/ | List insurance levels


<a name="getinsuranceprices"></a>
# **GetInsurancePrices**
> List<GetInsurancePrices200Ok> GetInsurancePrices (string acceptLanguage = null, string datasource = null, string ifNoneMatch = null, string language = null)

List insurance levels

Return available insurance levels for all ship types  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetInsurancePricesExample
    {
        public void main()
        {
            var apiInstance = new InsuranceApi();
            var acceptLanguage = acceptLanguage_example;  // string | Language to use in the response (optional)  (default to en-us)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var language = language_example;  // string | Language to use in the response, takes precedence over Accept-Language (optional)  (default to en-us)

            try
            {
                // List insurance levels
                List&lt;GetInsurancePrices200Ok&gt; result = apiInstance.GetInsurancePrices(acceptLanguage, datasource, ifNoneMatch, language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InsuranceApi.GetInsurancePrices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acceptLanguage** | **string**| Language to use in the response | [optional] [default to en-us]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **language** | **string**| Language to use in the response, takes precedence over Accept-Language | [optional] [default to en-us]

### Return type

[**List<GetInsurancePrices200Ok>**](GetInsurancePrices200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

