# ESIClient.Dotcore.Api.CorporationApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCorporationsCorporationId**](CorporationApi.md#getcorporationscorporationid) | **GET** /v4/corporations/{corporation_id}/ | Get corporation information
[**GetCorporationsCorporationIdAlliancehistory**](CorporationApi.md#getcorporationscorporationidalliancehistory) | **GET** /v2/corporations/{corporation_id}/alliancehistory/ | Get alliance history
[**GetCorporationsCorporationIdBlueprints**](CorporationApi.md#getcorporationscorporationidblueprints) | **GET** /v2/corporations/{corporation_id}/blueprints/ | Get corporation blueprints
[**GetCorporationsCorporationIdContainersLogs**](CorporationApi.md#getcorporationscorporationidcontainerslogs) | **GET** /v2/corporations/{corporation_id}/containers/logs/ | Get all corporation ALSC logs
[**GetCorporationsCorporationIdDivisions**](CorporationApi.md#getcorporationscorporationiddivisions) | **GET** /v1/corporations/{corporation_id}/divisions/ | Get corporation divisions
[**GetCorporationsCorporationIdFacilities**](CorporationApi.md#getcorporationscorporationidfacilities) | **GET** /v1/corporations/{corporation_id}/facilities/ | Get corporation facilities
[**GetCorporationsCorporationIdIcons**](CorporationApi.md#getcorporationscorporationidicons) | **GET** /v1/corporations/{corporation_id}/icons/ | Get corporation icon
[**GetCorporationsCorporationIdMedals**](CorporationApi.md#getcorporationscorporationidmedals) | **GET** /v1/corporations/{corporation_id}/medals/ | Get corporation medals
[**GetCorporationsCorporationIdMedalsIssued**](CorporationApi.md#getcorporationscorporationidmedalsissued) | **GET** /v1/corporations/{corporation_id}/medals/issued/ | Get corporation issued medals
[**GetCorporationsCorporationIdMembers**](CorporationApi.md#getcorporationscorporationidmembers) | **GET** /v3/corporations/{corporation_id}/members/ | Get corporation members
[**GetCorporationsCorporationIdMembersLimit**](CorporationApi.md#getcorporationscorporationidmemberslimit) | **GET** /v1/corporations/{corporation_id}/members/limit/ | Get corporation member limit
[**GetCorporationsCorporationIdMembersTitles**](CorporationApi.md#getcorporationscorporationidmemberstitles) | **GET** /v1/corporations/{corporation_id}/members/titles/ | Get corporation&#39;s members&#39; titles
[**GetCorporationsCorporationIdMembertracking**](CorporationApi.md#getcorporationscorporationidmembertracking) | **GET** /v1/corporations/{corporation_id}/membertracking/ | Track corporation members
[**GetCorporationsCorporationIdOutposts**](CorporationApi.md#getcorporationscorporationidoutposts) | **GET** /v1/corporations/{corporation_id}/outposts/ | Get corporation outposts
[**GetCorporationsCorporationIdOutpostsOutpostId**](CorporationApi.md#getcorporationscorporationidoutpostsoutpostid) | **GET** /v1/corporations/{corporation_id}/outposts/{outpost_id}/ | Get corporation outpost details
[**GetCorporationsCorporationIdRoles**](CorporationApi.md#getcorporationscorporationidroles) | **GET** /v1/corporations/{corporation_id}/roles/ | Get corporation member roles
[**GetCorporationsCorporationIdRolesHistory**](CorporationApi.md#getcorporationscorporationidroleshistory) | **GET** /v1/corporations/{corporation_id}/roles/history/ | Get corporation member roles history
[**GetCorporationsCorporationIdShareholders**](CorporationApi.md#getcorporationscorporationidshareholders) | **GET** /v1/corporations/{corporation_id}/shareholders/ | Get corporation shareholders
[**GetCorporationsCorporationIdStandings**](CorporationApi.md#getcorporationscorporationidstandings) | **GET** /v1/corporations/{corporation_id}/standings/ | Get corporation standings
[**GetCorporationsCorporationIdStarbases**](CorporationApi.md#getcorporationscorporationidstarbases) | **GET** /v1/corporations/{corporation_id}/starbases/ | Get corporation starbases (POSes)
[**GetCorporationsCorporationIdStarbasesStarbaseId**](CorporationApi.md#getcorporationscorporationidstarbasesstarbaseid) | **GET** /v1/corporations/{corporation_id}/starbases/{starbase_id}/ | Get starbase (POS) detail
[**GetCorporationsCorporationIdStructures**](CorporationApi.md#getcorporationscorporationidstructures) | **GET** /v2/corporations/{corporation_id}/structures/ | Get corporation structures
[**GetCorporationsCorporationIdTitles**](CorporationApi.md#getcorporationscorporationidtitles) | **GET** /v1/corporations/{corporation_id}/titles/ | Get corporation titles
[**GetCorporationsNames**](CorporationApi.md#getcorporationsnames) | **GET** /v2/corporations/names/ | Get corporation names
[**GetCorporationsNpccorps**](CorporationApi.md#getcorporationsnpccorps) | **GET** /v1/corporations/npccorps/ | Get npc corporations


<a name="getcorporationscorporationid"></a>
# **GetCorporationsCorporationId**
> GetCorporationsCorporationIdOk GetCorporationsCorporationId (int? corporationId, string datasource = null, string ifNoneMatch = null)

Get corporation information

Public information about a corporation  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdExample
    {
        public void main()
        {
            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Get corporation information
                GetCorporationsCorporationIdOk result = apiInstance.GetCorporationsCorporationId(corporationId, datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationId: " + e.Message );
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

### Return type

[**GetCorporationsCorporationIdOk**](GetCorporationsCorporationIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidalliancehistory"></a>
# **GetCorporationsCorporationIdAlliancehistory**
> List<GetCorporationsCorporationIdAlliancehistory200Ok> GetCorporationsCorporationIdAlliancehistory (int? corporationId, string datasource = null, string ifNoneMatch = null)

Get alliance history

Get a list of all the alliances a corporation has been a member of  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdAlliancehistoryExample
    {
        public void main()
        {
            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Get alliance history
                List&lt;GetCorporationsCorporationIdAlliancehistory200Ok&gt; result = apiInstance.GetCorporationsCorporationIdAlliancehistory(corporationId, datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdAlliancehistory: " + e.Message );
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

### Return type

[**List<GetCorporationsCorporationIdAlliancehistory200Ok>**](GetCorporationsCorporationIdAlliancehistory200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidblueprints"></a>
# **GetCorporationsCorporationIdBlueprints**
> List<GetCorporationsCorporationIdBlueprints200Ok> GetCorporationsCorporationIdBlueprints (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get corporation blueprints

Returns a list of blueprints the corporation owns  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdBlueprintsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation blueprints
                List&lt;GetCorporationsCorporationIdBlueprints200Ok&gt; result = apiInstance.GetCorporationsCorporationIdBlueprints(corporationId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdBlueprints: " + e.Message );
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

[**List<GetCorporationsCorporationIdBlueprints200Ok>**](GetCorporationsCorporationIdBlueprints200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidcontainerslogs"></a>
# **GetCorporationsCorporationIdContainersLogs**
> List<GetCorporationsCorporationIdContainersLogs200Ok> GetCorporationsCorporationIdContainersLogs (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get all corporation ALSC logs

Returns logs recorded in the past seven days from all audit log secure containers (ALSC) owned by a given corporation  - --  This route is cached for up to 600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdContainersLogsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get all corporation ALSC logs
                List&lt;GetCorporationsCorporationIdContainersLogs200Ok&gt; result = apiInstance.GetCorporationsCorporationIdContainersLogs(corporationId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdContainersLogs: " + e.Message );
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

[**List<GetCorporationsCorporationIdContainersLogs200Ok>**](GetCorporationsCorporationIdContainersLogs200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationiddivisions"></a>
# **GetCorporationsCorporationIdDivisions**
> GetCorporationsCorporationIdDivisionsOk GetCorporationsCorporationIdDivisions (int? corporationId, string datasource = null, string ifNoneMatch = null, string token = null)

Get corporation divisions

Return corporation hangar and wallet division names, only show if a division is not using the default name  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdDivisionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation divisions
                GetCorporationsCorporationIdDivisionsOk result = apiInstance.GetCorporationsCorporationIdDivisions(corporationId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdDivisions: " + e.Message );
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

[**GetCorporationsCorporationIdDivisionsOk**](GetCorporationsCorporationIdDivisionsOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidfacilities"></a>
# **GetCorporationsCorporationIdFacilities**
> List<GetCorporationsCorporationIdFacilities200Ok> GetCorporationsCorporationIdFacilities (int? corporationId, string datasource = null, string ifNoneMatch = null, string token = null)

Get corporation facilities

Return a corporation's facilities  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Factory_Manager

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdFacilitiesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation facilities
                List&lt;GetCorporationsCorporationIdFacilities200Ok&gt; result = apiInstance.GetCorporationsCorporationIdFacilities(corporationId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdFacilities: " + e.Message );
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

[**List<GetCorporationsCorporationIdFacilities200Ok>**](GetCorporationsCorporationIdFacilities200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidicons"></a>
# **GetCorporationsCorporationIdIcons**
> GetCorporationsCorporationIdIconsOk GetCorporationsCorporationIdIcons (int? corporationId, string datasource = null, string ifNoneMatch = null)

Get corporation icon

Get the icon urls for a corporation  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdIconsExample
    {
        public void main()
        {
            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Get corporation icon
                GetCorporationsCorporationIdIconsOk result = apiInstance.GetCorporationsCorporationIdIcons(corporationId, datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdIcons: " + e.Message );
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

### Return type

[**GetCorporationsCorporationIdIconsOk**](GetCorporationsCorporationIdIconsOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidmedals"></a>
# **GetCorporationsCorporationIdMedals**
> List<GetCorporationsCorporationIdMedals200Ok> GetCorporationsCorporationIdMedals (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get corporation medals

Returns a corporation's medals  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdMedalsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation medals
                List&lt;GetCorporationsCorporationIdMedals200Ok&gt; result = apiInstance.GetCorporationsCorporationIdMedals(corporationId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdMedals: " + e.Message );
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

[**List<GetCorporationsCorporationIdMedals200Ok>**](GetCorporationsCorporationIdMedals200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidmedalsissued"></a>
# **GetCorporationsCorporationIdMedalsIssued**
> List<GetCorporationsCorporationIdMedalsIssued200Ok> GetCorporationsCorporationIdMedalsIssued (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get corporation issued medals

Returns medals issued by a corporation  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdMedalsIssuedExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation issued medals
                List&lt;GetCorporationsCorporationIdMedalsIssued200Ok&gt; result = apiInstance.GetCorporationsCorporationIdMedalsIssued(corporationId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdMedalsIssued: " + e.Message );
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

[**List<GetCorporationsCorporationIdMedalsIssued200Ok>**](GetCorporationsCorporationIdMedalsIssued200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidmembers"></a>
# **GetCorporationsCorporationIdMembers**
> List<int?> GetCorporationsCorporationIdMembers (int? corporationId, string datasource = null, string ifNoneMatch = null, string token = null)

Get corporation members

Return the current member list of a corporation, the token's character need to be a member of the corporation.  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdMembersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation members
                List&lt;int?&gt; result = apiInstance.GetCorporationsCorporationIdMembers(corporationId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdMembers: " + e.Message );
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

**List<int?>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidmemberslimit"></a>
# **GetCorporationsCorporationIdMembersLimit**
> int? GetCorporationsCorporationIdMembersLimit (int? corporationId, string datasource = null, string ifNoneMatch = null, string token = null)

Get corporation member limit

Return a corporation's member limit, not including CEO himself  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdMembersLimitExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation member limit
                int? result = apiInstance.GetCorporationsCorporationIdMembersLimit(corporationId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdMembersLimit: " + e.Message );
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

**int?**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidmemberstitles"></a>
# **GetCorporationsCorporationIdMembersTitles**
> List<GetCorporationsCorporationIdMembersTitles200Ok> GetCorporationsCorporationIdMembersTitles (int? corporationId, string datasource = null, string ifNoneMatch = null, string token = null)

Get corporation's members' titles

Returns a corporation's members' titles  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdMembersTitlesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation's members' titles
                List&lt;GetCorporationsCorporationIdMembersTitles200Ok&gt; result = apiInstance.GetCorporationsCorporationIdMembersTitles(corporationId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdMembersTitles: " + e.Message );
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

[**List<GetCorporationsCorporationIdMembersTitles200Ok>**](GetCorporationsCorporationIdMembersTitles200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidmembertracking"></a>
# **GetCorporationsCorporationIdMembertracking**
> List<GetCorporationsCorporationIdMembertracking200Ok> GetCorporationsCorporationIdMembertracking (int? corporationId, string datasource = null, string ifNoneMatch = null, string token = null)

Track corporation members

Returns additional information about a corporation's members which helps tracking their activities  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdMembertrackingExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Track corporation members
                List&lt;GetCorporationsCorporationIdMembertracking200Ok&gt; result = apiInstance.GetCorporationsCorporationIdMembertracking(corporationId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdMembertracking: " + e.Message );
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

[**List<GetCorporationsCorporationIdMembertracking200Ok>**](GetCorporationsCorporationIdMembertracking200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidoutposts"></a>
# **GetCorporationsCorporationIdOutposts**
> List<int?> GetCorporationsCorporationIdOutposts (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get corporation outposts

Get a list of corporation outpost IDs Note: This endpoint will be removed once outposts are migrated to Citadels as talked about in this blog: https://community.eveonline.com/news/dev-blogs/the-next-steps-in-structure-transition/  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdOutpostsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation outposts
                List&lt;int?&gt; result = apiInstance.GetCorporationsCorporationIdOutposts(corporationId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdOutposts: " + e.Message );
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

**List<int?>**

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidoutpostsoutpostid"></a>
# **GetCorporationsCorporationIdOutpostsOutpostId**
> GetCorporationsCorporationIdOutpostsOutpostIdOk GetCorporationsCorporationIdOutpostsOutpostId (int? corporationId, int? outpostId, string datasource = null, string ifNoneMatch = null, string token = null)

Get corporation outpost details

Get details about a given outpost. Note: This endpoint will be removed once outposts are migrated to Citadels as talked about in this blog: https://community.eveonline.com/news/dev-blogs/the-next-steps-in-structure-transition/  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdOutpostsOutpostIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var outpostId = 56;  // int? | A station (outpost) ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation outpost details
                GetCorporationsCorporationIdOutpostsOutpostIdOk result = apiInstance.GetCorporationsCorporationIdOutpostsOutpostId(corporationId, outpostId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdOutpostsOutpostId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationId** | **int?**| An EVE corporation ID | 
 **outpostId** | **int?**| A station (outpost) ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**GetCorporationsCorporationIdOutpostsOutpostIdOk**](GetCorporationsCorporationIdOutpostsOutpostIdOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidroles"></a>
# **GetCorporationsCorporationIdRoles**
> List<GetCorporationsCorporationIdRoles200Ok> GetCorporationsCorporationIdRoles (int? corporationId, string datasource = null, string ifNoneMatch = null, string token = null)

Get corporation member roles

Return the roles of all members if the character has the personnel manager role or any grantable role.  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdRolesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation member roles
                List&lt;GetCorporationsCorporationIdRoles200Ok&gt; result = apiInstance.GetCorporationsCorporationIdRoles(corporationId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdRoles: " + e.Message );
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

[**List<GetCorporationsCorporationIdRoles200Ok>**](GetCorporationsCorporationIdRoles200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidroleshistory"></a>
# **GetCorporationsCorporationIdRolesHistory**
> List<GetCorporationsCorporationIdRolesHistory200Ok> GetCorporationsCorporationIdRolesHistory (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get corporation member roles history

Return how roles have changed for a coporation's members, up to a month  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdRolesHistoryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation member roles history
                List&lt;GetCorporationsCorporationIdRolesHistory200Ok&gt; result = apiInstance.GetCorporationsCorporationIdRolesHistory(corporationId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdRolesHistory: " + e.Message );
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

[**List<GetCorporationsCorporationIdRolesHistory200Ok>**](GetCorporationsCorporationIdRolesHistory200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidshareholders"></a>
# **GetCorporationsCorporationIdShareholders**
> List<GetCorporationsCorporationIdShareholders200Ok> GetCorporationsCorporationIdShareholders (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get corporation shareholders

Return the current shareholders of a corporation.  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdShareholdersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation shareholders
                List&lt;GetCorporationsCorporationIdShareholders200Ok&gt; result = apiInstance.GetCorporationsCorporationIdShareholders(corporationId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdShareholders: " + e.Message );
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

[**List<GetCorporationsCorporationIdShareholders200Ok>**](GetCorporationsCorporationIdShareholders200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidstandings"></a>
# **GetCorporationsCorporationIdStandings**
> List<GetCorporationsCorporationIdStandings200Ok> GetCorporationsCorporationIdStandings (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get corporation standings

Return corporation standings from agents, NPC corporations, and factions  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdStandingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation standings
                List&lt;GetCorporationsCorporationIdStandings200Ok&gt; result = apiInstance.GetCorporationsCorporationIdStandings(corporationId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdStandings: " + e.Message );
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

[**List<GetCorporationsCorporationIdStandings200Ok>**](GetCorporationsCorporationIdStandings200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidstarbases"></a>
# **GetCorporationsCorporationIdStarbases**
> List<GetCorporationsCorporationIdStarbases200Ok> GetCorporationsCorporationIdStarbases (int? corporationId, string datasource = null, string ifNoneMatch = null, int? page = null, string token = null)

Get corporation starbases (POSes)

Returns list of corporation starbases (POSes)  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdStarbasesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation starbases (POSes)
                List&lt;GetCorporationsCorporationIdStarbases200Ok&gt; result = apiInstance.GetCorporationsCorporationIdStarbases(corporationId, datasource, ifNoneMatch, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdStarbases: " + e.Message );
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

[**List<GetCorporationsCorporationIdStarbases200Ok>**](GetCorporationsCorporationIdStarbases200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidstarbasesstarbaseid"></a>
# **GetCorporationsCorporationIdStarbasesStarbaseId**
> GetCorporationsCorporationIdStarbasesStarbaseIdOk GetCorporationsCorporationIdStarbasesStarbaseId (int? corporationId, long? starbaseId, int? systemId, string datasource = null, string ifNoneMatch = null, string token = null)

Get starbase (POS) detail

Returns various settings and fuels of a starbase (POS)  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdStarbasesStarbaseIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var starbaseId = 789;  // long? | An EVE starbase (POS) ID
            var systemId = 56;  // int? | The solar system this starbase (POS) is located in,
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get starbase (POS) detail
                GetCorporationsCorporationIdStarbasesStarbaseIdOk result = apiInstance.GetCorporationsCorporationIdStarbasesStarbaseId(corporationId, starbaseId, systemId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdStarbasesStarbaseId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationId** | **int?**| An EVE corporation ID | 
 **starbaseId** | **long?**| An EVE starbase (POS) ID | 
 **systemId** | **int?**| The solar system this starbase (POS) is located in, | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**GetCorporationsCorporationIdStarbasesStarbaseIdOk**](GetCorporationsCorporationIdStarbasesStarbaseIdOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidstructures"></a>
# **GetCorporationsCorporationIdStructures**
> List<GetCorporationsCorporationIdStructures200Ok> GetCorporationsCorporationIdStructures (int? corporationId, string acceptLanguage = null, string datasource = null, string ifNoneMatch = null, string language = null, int? page = null, string token = null)

Get corporation structures

Get a list of corporation structures. This route's version includes the changes to structures detailed in this blog: https://www.eveonline.com/article/upwell-2.0-structures-changes-coming-on-february-13th  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): StationManager

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdStructuresExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var acceptLanguage = acceptLanguage_example;  // string | Language to use in the response (optional)  (default to en-us)
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var language = language_example;  // string | Language to use in the response, takes precedence over Accept-Language (optional)  (default to en-us)
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation structures
                List&lt;GetCorporationsCorporationIdStructures200Ok&gt; result = apiInstance.GetCorporationsCorporationIdStructures(corporationId, acceptLanguage, datasource, ifNoneMatch, language, page, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdStructures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationId** | **int?**| An EVE corporation ID | 
 **acceptLanguage** | **string**| Language to use in the response | [optional] [default to en-us]
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **language** | **string**| Language to use in the response, takes precedence over Accept-Language | [optional] [default to en-us]
 **page** | **int?**| Which page of results to return | [optional] [default to 1]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**List<GetCorporationsCorporationIdStructures200Ok>**](GetCorporationsCorporationIdStructures200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidtitles"></a>
# **GetCorporationsCorporationIdTitles**
> List<GetCorporationsCorporationIdTitles200Ok> GetCorporationsCorporationIdTitles (int? corporationId, string datasource = null, string ifNoneMatch = null, string token = null)

Get corporation titles

Returns a corporation's titles  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsCorporationIdTitlesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporationApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get corporation titles
                List&lt;GetCorporationsCorporationIdTitles200Ok&gt; result = apiInstance.GetCorporationsCorporationIdTitles(corporationId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsCorporationIdTitles: " + e.Message );
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

[**List<GetCorporationsCorporationIdTitles200Ok>**](GetCorporationsCorporationIdTitles200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationsnames"></a>
# **GetCorporationsNames**
> List<GetCorporationsNames200Ok> GetCorporationsNames (List<int?> corporationIds, string datasource = null, string ifNoneMatch = null)

Get corporation names

Resolve a set of corporation IDs to corporation names  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsNamesExample
    {
        public void main()
        {
            var apiInstance = new CorporationApi();
            var corporationIds = new List<int?>(); // List<int?> | A comma separated list of corporation IDs
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Get corporation names
                List&lt;GetCorporationsNames200Ok&gt; result = apiInstance.GetCorporationsNames(corporationIds, datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsNames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corporationIds** | [**List&lt;int?&gt;**](int?.md)| A comma separated list of corporation IDs | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 

### Return type

[**List<GetCorporationsNames200Ok>**](GetCorporationsNames200Ok.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationsnpccorps"></a>
# **GetCorporationsNpccorps**
> List<int?> GetCorporationsNpccorps (string datasource = null, string ifNoneMatch = null)

Get npc corporations

Get a list of npc corporations  - --  This route expires daily at 11:05

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCorporationsNpccorpsExample
    {
        public void main()
        {
            var apiInstance = new CorporationApi();
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 

            try
            {
                // Get npc corporations
                List&lt;int?&gt; result = apiInstance.GetCorporationsNpccorps(datasource, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporationApi.GetCorporationsNpccorps: " + e.Message );
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

