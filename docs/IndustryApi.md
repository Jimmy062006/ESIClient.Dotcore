# ESIClient.Dotcore.Api.IndustryApi

All URIs are relative to *https://esi.evetech.net*

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
> List<Object> GetCharactersCharacterIdIndustryJobs (int? characterId, string datasource = null, string ifNoneMatch = null, bool? includeCompleted = null, string token = null)

List character industry jobs

List industry jobs placed by a character  - --  This route is cached for up to 300 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var includeCompleted = true;  // bool? | Whether to retrieve completed character industry jobs. Only includes jobs from the past 90 days (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // List character industry jobs
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdIndustryJobs(characterId, datasource, ifNoneMatch, includeCompleted, token);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **includeCompleted** | **bool?**| Whether to retrieve completed character industry jobs. Only includes jobs from the past 90 days | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

**List<Object>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridmining"></a>
# **GetCharactersCharacterIdMining**
> List<Object> GetCharactersCharacterIdMining (int? characterId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Character mining ledger

Paginated record of all mining done by a character for the past 30 days  - --  This route is cached for up to 600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Character mining ledger
                List&lt;Object&gt; result = apiInstance.GetCharactersCharacterIdMining(characterId, datasource, ifNoneMatch, page, token);
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

<a name="getcorporationcorporationidminingextractions"></a>
# **GetCorporationCorporationIdMiningExtractions**
> List<Object> GetCorporationCorporationIdMiningExtractions (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Moon extraction timers

Extraction timers for all moon chunks being extracted by refineries belonging to a corporation.  - --  This route is cached for up to 1800 seconds  - -- Requires one of the following EVE corporation role(s): Station_Manager

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Moon extraction timers
                List&lt;Object&gt; result = apiInstance.GetCorporationCorporationIdMiningExtractions(corporationId, datasource, ifNoneMatch, page, token);
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

<a name="getcorporationcorporationidminingobservers"></a>
# **GetCorporationCorporationIdMiningObservers**
> List<Object> GetCorporationCorporationIdMiningObservers (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Corporation mining observers

Paginated list of all entities capable of observing and recording mining for a corporation  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Corporation mining observers
                List&lt;Object&gt; result = apiInstance.GetCorporationCorporationIdMiningObservers(corporationId, datasource, ifNoneMatch, page, token);
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

<a name="getcorporationcorporationidminingobserversobserverid"></a>
# **GetCorporationCorporationIdMiningObserversObserverId**
> List<Object> GetCorporationCorporationIdMiningObserversObserverId (int? corporationId, long? observerId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Observed corporation mining

Paginated record of all mining seen by an observer  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Accountant

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Observed corporation mining
                List&lt;Object&gt; result = apiInstance.GetCorporationCorporationIdMiningObserversObserverId(corporationId, observerId, datasource, ifNoneMatch, page, token);
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

<a name="getcorporationscorporationidindustryjobs"></a>
# **GetCorporationsCorporationIdIndustryJobs**
> List<Object> GetCorporationsCorporationIdIndustryJobs (int? corporationId, string datasource = null, string ifNoneMatch = null, bool? includeCompleted = null, int? page = null, string token = null)

List corporation industry jobs

List industry jobs run by a corporation  - --  This route is cached for up to 300 seconds  - -- Requires one of the following EVE corporation role(s): Factory_Manager

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

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
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var includeCompleted = true;  // bool? | Whether to retrieve completed corporation industry jobs. Only includes jobs from the past 90 days (optional)  (default to false)
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // List corporation industry jobs
                List&lt;Object&gt; result = apiInstance.GetCorporationsCorporationIdIndustryJobs(corporationId, datasource, ifNoneMatch, includeCompleted, page, token);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **includeCompleted** | **bool?**| Whether to retrieve completed corporation industry jobs. Only includes jobs from the past 90 days | [optional] [default to false]
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

<a name="getindustryfacilities"></a>
# **GetIndustryFacilities**
> List<Object> GetIndustryFacilities (string datasource = null, string ifNoneMatch = null)

List industry facilities

Return a list of industry facilities  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetIndustryFacilitiesExample
    {
        public void main()
        {
            var apiInstance = new IndustryApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // List industry facilities
                List&lt;Object&gt; result = apiInstance.GetIndustryFacilities(datasource, ifNoneMatch);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getindustrysystems"></a>
# **GetIndustrySystems**
> List<Object> GetIndustrySystems (string datasource = null, string ifNoneMatch = null)

List solar system cost indices

Return cost indices for solar systems  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetIndustrySystemsExample
    {
        public void main()
        {
            var apiInstance = new IndustryApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // List solar system cost indices
                List&lt;Object&gt; result = apiInstance.GetIndustrySystems(datasource, ifNoneMatch);
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
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

