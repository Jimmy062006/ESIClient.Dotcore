# IO.Swagger.Api.IndustryApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdIndustryJobs**](IndustryApi.md#getcharacterscharacteridindustryjobs) | **GET** /v1/characters/{character_id}/industry/jobs/ | List character industry jobs
[**GetCharactersCharacterIdMining**](IndustryApi.md#getcharacterscharacteridmining) | **GET** /v1/characters/{character_id}/mining/ | Character mining ledger
[**GetCorporationCorporationIdMiningExtractions**](IndustryApi.md#getcorporationcorporationidminingextractions) | **GET** /v1/corporation/{corporation_id}/mining/extractions/ | Moon extraction timers
[**GetCorporationCorporationIdMiningObservers**](IndustryApi.md#getcorporationcorporationidminingobservers) | **GET** /v1/corporation/{corporation_id}/mining/observers/ | Corporation mining observers
[**GetCorporationCorporationIdMiningObserversObserverId**](IndustryApi.md#getcorporationcorporationidminingobserversobserverid) | **GET** /v1/corporation/{corporation_id}/mining/observers/{observer_id}/ | Observed corporation mining
[**GetCorporationsCorporationIdIndustryJobs**](IndustryApi.md#getcorporationscorporationidindustryjobs) | **GET** /v1/corporations/{corporation_id}/industry/jobs/ | List corporation industry jobs
[**GetIndustryFacilities**](IndustryApi.md#getindustryfacilities) | **GET** /v1/industry/facilities/ | List industry facilities
[**GetIndustrySystems**](IndustryApi.md#getindustrysystems) | **GET** /v1/industry/systems/ | List solar system cost indices


<a name="getcharacterscharacteridindustryjobs"></a>
# **GetCharactersCharacterIdIndustryJobs**
> List<GetCharactersCharacterIdIndustryJobs200Ok> GetCharactersCharacterIdIndustryJobs (int? characterId, string datasource = null, bool? includeCompleted = null, string token = null, string userAgent = null, string xUserAgent = null)

List character industry jobs

List industry jobs placed by a character  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdIndustryJobsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndustryApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var includeCompleted = true;  // bool? | Whether retrieve completed character industry jobs as well (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // List character industry jobs
                List&lt;GetCharactersCharacterIdIndustryJobs200Ok&gt; result = apiInstance.GetCharactersCharacterIdIndustryJobs(characterId, datasource, includeCompleted, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndustryApi.GetCharactersCharacterIdIndustryJobs: " + e.Message );
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
 **includeCompleted** | **bool?**| Whether retrieve completed character industry jobs as well | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetCharactersCharacterIdIndustryJobs200Ok>**](GetCharactersCharacterIdIndustryJobs200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridmining"></a>
# **GetCharactersCharacterIdMining**
> List<GetCharactersCharacterIdMining200Ok> GetCharactersCharacterIdMining (int? characterId, string datasource = null, int? page = null, string token = null, string userAgent = null, string xUserAgent = null)

Character mining ledger

Paginated record of all mining done by a character for the past 30 days  - --  This route is cached for up to 600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdMiningExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndustryApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Character mining ledger
                List&lt;GetCharactersCharacterIdMining200Ok&gt; result = apiInstance.GetCharactersCharacterIdMining(characterId, datasource, page, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndustryApi.GetCharactersCharacterIdMining: " + e.Message );
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

[**List<GetCharactersCharacterIdMining200Ok>**](GetCharactersCharacterIdMining200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationcorporationidminingextractions"></a>
# **GetCorporationCorporationIdMiningExtractions**
> List<GetCorporationCorporationIdMiningExtractions200Ok> GetCorporationCorporationIdMiningExtractions (int? corporationId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Moon extraction timers

Extraction timers for all moon chunks being extracted by refineries belonging to a corporation.  - --  This route is cached for up to 1800 seconds  - -- Requires one of the following EVE corporation role(s): Structure_manager

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCorporationCorporationIdMiningExtractionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndustryApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Moon extraction timers
                List&lt;GetCorporationCorporationIdMiningExtractions200Ok&gt; result = apiInstance.GetCorporationCorporationIdMiningExtractions(corporationId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndustryApi.GetCorporationCorporationIdMiningExtractions: " + e.Message );
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

[**List<GetCorporationCorporationIdMiningExtractions200Ok>**](GetCorporationCorporationIdMiningExtractions200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationcorporationidminingobservers"></a>
# **GetCorporationCorporationIdMiningObservers**
> List<GetCorporationCorporationIdMiningObservers200Ok> GetCorporationCorporationIdMiningObservers (int? corporationId, string datasource = null, int? page = null, string token = null, string userAgent = null, string xUserAgent = null)

Corporation mining observers

Paginated list of all entities capable of observing and recording mining for a corporation  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCorporationCorporationIdMiningObserversExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndustryApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Corporation mining observers
                List&lt;GetCorporationCorporationIdMiningObservers200Ok&gt; result = apiInstance.GetCorporationCorporationIdMiningObservers(corporationId, datasource, page, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndustryApi.GetCorporationCorporationIdMiningObservers: " + e.Message );
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

[**List<GetCorporationCorporationIdMiningObservers200Ok>**](GetCorporationCorporationIdMiningObservers200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationcorporationidminingobserversobserverid"></a>
# **GetCorporationCorporationIdMiningObserversObserverId**
> List<GetCorporationCorporationIdMiningObserversObserverId200Ok> GetCorporationCorporationIdMiningObserversObserverId (int? corporationId, long? observerId, string datasource = null, int? page = null, string token = null, string userAgent = null, string xUserAgent = null)

Observed corporation mining

Paginated record of all mining seen by an observer  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCorporationCorporationIdMiningObserversObserverIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndustryApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var observerId = 789;  // long? | A mining observer id
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Observed corporation mining
                List&lt;GetCorporationCorporationIdMiningObserversObserverId200Ok&gt; result = apiInstance.GetCorporationCorporationIdMiningObserversObserverId(corporationId, observerId, datasource, page, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndustryApi.GetCorporationCorporationIdMiningObserversObserverId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationId** | **int?**| An EVE corporation ID | 
 **observerId** | **long?**| A mining observer id | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **page** | **int?**| Which page of results to return | [optional] [default to 1]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetCorporationCorporationIdMiningObserversObserverId200Ok>**](GetCorporationCorporationIdMiningObserversObserverId200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidindustryjobs"></a>
# **GetCorporationsCorporationIdIndustryJobs**
> List<GetCorporationsCorporationIdIndustryJobs200Ok> GetCorporationsCorporationIdIndustryJobs (int? corporationId, string datasource = null, bool? includeCompleted = null, int? page = null, string token = null, string userAgent = null, string xUserAgent = null)

List corporation industry jobs

List industry jobs run by a corporation  - --  This route is cached for up to 300 seconds  - -- Requires one of the following EVE corporation role(s): FactoryManager

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCorporationsCorporationIdIndustryJobsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IndustryApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var includeCompleted = true;  // bool? | Whether retrieve completed industry jobs as well (optional)  (default to false)
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // List corporation industry jobs
                List&lt;GetCorporationsCorporationIdIndustryJobs200Ok&gt; result = apiInstance.GetCorporationsCorporationIdIndustryJobs(corporationId, datasource, includeCompleted, page, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndustryApi.GetCorporationsCorporationIdIndustryJobs: " + e.Message );
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
 **includeCompleted** | **bool?**| Whether retrieve completed industry jobs as well | [optional] [default to false]
 **page** | **int?**| Which page of results to return | [optional] [default to 1]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetCorporationsCorporationIdIndustryJobs200Ok>**](GetCorporationsCorporationIdIndustryJobs200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getindustryfacilities"></a>
# **GetIndustryFacilities**
> List<GetIndustryFacilities200Ok> GetIndustryFacilities (string datasource = null, string userAgent = null, string xUserAgent = null)

List industry facilities

Return a list of industry facilities  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIndustryFacilitiesExample
    {
        public void main()
        {
            var apiInstance = new IndustryApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // List industry facilities
                List&lt;GetIndustryFacilities200Ok&gt; result = apiInstance.GetIndustryFacilities(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndustryApi.GetIndustryFacilities: " + e.Message );
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

[**List<GetIndustryFacilities200Ok>**](GetIndustryFacilities200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getindustrysystems"></a>
# **GetIndustrySystems**
> List<GetIndustrySystems200Ok> GetIndustrySystems (string datasource = null, string userAgent = null, string xUserAgent = null)

List solar system cost indices

Return cost indices for solar systems  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetIndustrySystemsExample
    {
        public void main()
        {
            var apiInstance = new IndustryApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // List solar system cost indices
                List&lt;GetIndustrySystems200Ok&gt; result = apiInstance.GetIndustrySystems(datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IndustryApi.GetIndustrySystems: " + e.Message );
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

[**List<GetIndustrySystems200Ok>**](GetIndustrySystems200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

