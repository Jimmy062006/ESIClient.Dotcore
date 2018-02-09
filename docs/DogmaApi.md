# IO.Swagger.Api.DogmaApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDogmaAttributes**](DogmaApi.md#getdogmaattributes) | **GET** /v1/dogma/attributes/ | Get attributes
[**GetDogmaAttributesAttributeId**](DogmaApi.md#getdogmaattributesattributeid) | **GET** /v1/dogma/attributes/{attribute_id}/ | Get attribute information
[**GetDogmaEffects**](DogmaApi.md#getdogmaeffects) | **GET** /v1/dogma/effects/ | Get effects
[**GetDogmaEffectsEffectId**](DogmaApi.md#getdogmaeffectseffectid) | **GET** /v2/dogma/effects/{effect_id}/ | Get effect information


<a name="getdogmaattributes"></a>
# **GetDogmaAttributes**
> List<int?> GetDogmaAttributes (string datasource = null, string userAgent = null, string xUserAgent = null)

Get attributes

Get a list of dogma attribute ids  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDogmaAttributesExample
    {
        public void main()
        {
            var apiInstance = new DogmaApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get attributes
                List&lt;int?&gt; result = apiInstance.GetDogmaAttributes(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DogmaApi.GetDogmaAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdogmaattributesattributeid"></a>
# **GetDogmaAttributesAttributeId**
> GetDogmaAttributesAttributeIdOk GetDogmaAttributesAttributeId (int? attributeId, string datasource = null, string userAgent = null, string xUserAgent = null)

Get attribute information

Get information on a dogma attribute  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDogmaAttributesAttributeIdExample
    {
        public void main()
        {
            var apiInstance = new DogmaApi();
            var attributeId = 56;  // int? | A dogma attribute ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get attribute information
                GetDogmaAttributesAttributeIdOk result = apiInstance.GetDogmaAttributesAttributeId(attributeId, datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DogmaApi.GetDogmaAttributesAttributeId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attributeId** | **int?**| A dogma attribute ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetDogmaAttributesAttributeIdOk**](GetDogmaAttributesAttributeIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdogmaeffects"></a>
# **GetDogmaEffects**
> List<int?> GetDogmaEffects (string datasource = null, string userAgent = null, string xUserAgent = null)

Get effects

Get a list of dogma effect ids  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDogmaEffectsExample
    {
        public void main()
        {
            var apiInstance = new DogmaApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get effects
                List&lt;int?&gt; result = apiInstance.GetDogmaEffects(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DogmaApi.GetDogmaEffects: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

**List<int?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdogmaeffectseffectid"></a>
# **GetDogmaEffectsEffectId**
> GetDogmaEffectsEffectIdOk GetDogmaEffectsEffectId (int? effectId, string datasource = null, string userAgent = null, string xUserAgent = null)

Get effect information

Get information on a dogma effect  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDogmaEffectsEffectIdExample
    {
        public void main()
        {
            var apiInstance = new DogmaApi();
            var effectId = 56;  // int? | A dogma effect ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get effect information
                GetDogmaEffectsEffectIdOk result = apiInstance.GetDogmaEffectsEffectId(effectId, datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DogmaApi.GetDogmaEffectsEffectId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **effectId** | **int?**| A dogma effect ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetDogmaEffectsEffectIdOk**](GetDogmaEffectsEffectIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

