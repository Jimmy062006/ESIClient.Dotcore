# IO.Swagger.Api.FleetsApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteFleetsFleetIdMembersMemberId**](FleetsApi.md#deletefleetsfleetidmembersmemberid) | **DELETE** /v1/fleets/{fleet_id}/members/{member_id}/ | Kick fleet member
[**DeleteFleetsFleetIdSquadsSquadId**](FleetsApi.md#deletefleetsfleetidsquadssquadid) | **DELETE** /v1/fleets/{fleet_id}/squads/{squad_id}/ | Delete fleet squad
[**DeleteFleetsFleetIdWingsWingId**](FleetsApi.md#deletefleetsfleetidwingswingid) | **DELETE** /v1/fleets/{fleet_id}/wings/{wing_id}/ | Delete fleet wing
[**GetCharactersCharacterIdFleet**](FleetsApi.md#getcharacterscharacteridfleet) | **GET** /v1/characters/{character_id}/fleet/ | Get character fleet info
[**GetFleetsFleetId**](FleetsApi.md#getfleetsfleetid) | **GET** /v1/fleets/{fleet_id}/ | Get fleet information
[**GetFleetsFleetIdMembers**](FleetsApi.md#getfleetsfleetidmembers) | **GET** /v1/fleets/{fleet_id}/members/ | Get fleet members
[**GetFleetsFleetIdWings**](FleetsApi.md#getfleetsfleetidwings) | **GET** /v1/fleets/{fleet_id}/wings/ | Get fleet wings
[**PostFleetsFleetIdMembers**](FleetsApi.md#postfleetsfleetidmembers) | **POST** /v1/fleets/{fleet_id}/members/ | Create fleet invitation
[**PostFleetsFleetIdWings**](FleetsApi.md#postfleetsfleetidwings) | **POST** /v1/fleets/{fleet_id}/wings/ | Create fleet wing
[**PostFleetsFleetIdWingsWingIdSquads**](FleetsApi.md#postfleetsfleetidwingswingidsquads) | **POST** /v1/fleets/{fleet_id}/wings/{wing_id}/squads/ | Create fleet squad
[**PutFleetsFleetId**](FleetsApi.md#putfleetsfleetid) | **PUT** /v1/fleets/{fleet_id}/ | Update fleet
[**PutFleetsFleetIdMembersMemberId**](FleetsApi.md#putfleetsfleetidmembersmemberid) | **PUT** /v1/fleets/{fleet_id}/members/{member_id}/ | Move fleet member
[**PutFleetsFleetIdSquadsSquadId**](FleetsApi.md#putfleetsfleetidsquadssquadid) | **PUT** /v1/fleets/{fleet_id}/squads/{squad_id}/ | Rename fleet squad
[**PutFleetsFleetIdWingsWingId**](FleetsApi.md#putfleetsfleetidwingswingid) | **PUT** /v1/fleets/{fleet_id}/wings/{wing_id}/ | Rename fleet wing


<a name="deletefleetsfleetidmembersmemberid"></a>
# **DeleteFleetsFleetIdMembersMemberId**
> void DeleteFleetsFleetIdMembersMemberId (long? fleetId, int? memberId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Kick fleet member

Kick a fleet member  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteFleetsFleetIdMembersMemberIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var memberId = 56;  // int? | The character ID of a member in this fleet
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Kick fleet member
                apiInstance.DeleteFleetsFleetIdMembersMemberId(fleetId, memberId, datasource, token, userAgent, xUserAgent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.DeleteFleetsFleetIdMembersMemberId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **memberId** | **int?**| The character ID of a member in this fleet | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefleetsfleetidsquadssquadid"></a>
# **DeleteFleetsFleetIdSquadsSquadId**
> void DeleteFleetsFleetIdSquadsSquadId (long? fleetId, long? squadId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Delete fleet squad

Delete a fleet squad, only empty squads can be deleted  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteFleetsFleetIdSquadsSquadIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var squadId = 789;  // long? | The squad to delete
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Delete fleet squad
                apiInstance.DeleteFleetsFleetIdSquadsSquadId(fleetId, squadId, datasource, token, userAgent, xUserAgent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.DeleteFleetsFleetIdSquadsSquadId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **squadId** | **long?**| The squad to delete | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefleetsfleetidwingswingid"></a>
# **DeleteFleetsFleetIdWingsWingId**
> void DeleteFleetsFleetIdWingsWingId (long? fleetId, long? wingId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Delete fleet wing

Delete a fleet wing, only empty wings can be deleted. The wing may contain squads, but the squads must be empty  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteFleetsFleetIdWingsWingIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var wingId = 789;  // long? | The wing to delete
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Delete fleet wing
                apiInstance.DeleteFleetsFleetIdWingsWingId(fleetId, wingId, datasource, token, userAgent, xUserAgent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.DeleteFleetsFleetIdWingsWingId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **wingId** | **long?**| The wing to delete | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridfleet"></a>
# **GetCharactersCharacterIdFleet**
> GetCharactersCharacterIdFleetOk GetCharactersCharacterIdFleet (int? characterId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get character fleet info

Return the fleet ID the character is in, if any.  - --  This route is cached for up to 60 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdFleetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get character fleet info
                GetCharactersCharacterIdFleetOk result = apiInstance.GetCharactersCharacterIdFleet(characterId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.GetCharactersCharacterIdFleet: " + e.Message );
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

[**GetCharactersCharacterIdFleetOk**](GetCharactersCharacterIdFleetOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfleetsfleetid"></a>
# **GetFleetsFleetId**
> GetFleetsFleetIdOk GetFleetsFleetId (long? fleetId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get fleet information

Return details about a fleet  - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFleetsFleetIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get fleet information
                GetFleetsFleetIdOk result = apiInstance.GetFleetsFleetId(fleetId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.GetFleetsFleetId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetFleetsFleetIdOk**](GetFleetsFleetIdOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfleetsfleetidmembers"></a>
# **GetFleetsFleetIdMembers**
> List<GetFleetsFleetIdMembers200Ok> GetFleetsFleetIdMembers (long? fleetId, string datasource = null, string language = null, string token = null, string userAgent = null, string xUserAgent = null)

Get fleet members

Return information about fleet members  - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFleetsFleetIdMembersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get fleet members
                List&lt;GetFleetsFleetIdMembers200Ok&gt; result = apiInstance.GetFleetsFleetIdMembers(fleetId, datasource, language, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.GetFleetsFleetIdMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetFleetsFleetIdMembers200Ok>**](GetFleetsFleetIdMembers200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfleetsfleetidwings"></a>
# **GetFleetsFleetIdWings**
> List<GetFleetsFleetIdWings200Ok> GetFleetsFleetIdWings (long? fleetId, string datasource = null, string language = null, string token = null, string userAgent = null, string xUserAgent = null)

Get fleet wings

Return information about wings in a fleet  - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFleetsFleetIdWingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var language = language_example;  // string | Language to use in the response (optional)  (default to en-us)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get fleet wings
                List&lt;GetFleetsFleetIdWings200Ok&gt; result = apiInstance.GetFleetsFleetIdWings(fleetId, datasource, language, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.GetFleetsFleetIdWings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **language** | **string**| Language to use in the response | [optional] [default to en-us]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**List<GetFleetsFleetIdWings200Ok>**](GetFleetsFleetIdWings200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfleetsfleetidmembers"></a>
# **PostFleetsFleetIdMembers**
> void PostFleetsFleetIdMembers (long? fleetId, PostFleetsFleetIdMembersInvitation invitation, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Create fleet invitation

Invite a character into the fleet. If a character has a CSPA charge set it is not possible to invite them to the fleet using ESI  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostFleetsFleetIdMembersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var invitation = new PostFleetsFleetIdMembersInvitation(); // PostFleetsFleetIdMembersInvitation | Details of the invitation
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Create fleet invitation
                apiInstance.PostFleetsFleetIdMembers(fleetId, invitation, datasource, token, userAgent, xUserAgent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.PostFleetsFleetIdMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **invitation** | [**PostFleetsFleetIdMembersInvitation**](PostFleetsFleetIdMembersInvitation.md)| Details of the invitation | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfleetsfleetidwings"></a>
# **PostFleetsFleetIdWings**
> PostFleetsFleetIdWingsCreated PostFleetsFleetIdWings (long? fleetId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Create fleet wing

Create a new wing in a fleet  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostFleetsFleetIdWingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Create fleet wing
                PostFleetsFleetIdWingsCreated result = apiInstance.PostFleetsFleetIdWings(fleetId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.PostFleetsFleetIdWings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**PostFleetsFleetIdWingsCreated**](PostFleetsFleetIdWingsCreated.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfleetsfleetidwingswingidsquads"></a>
# **PostFleetsFleetIdWingsWingIdSquads**
> PostFleetsFleetIdWingsWingIdSquadsCreated PostFleetsFleetIdWingsWingIdSquads (long? fleetId, long? wingId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Create fleet squad

Create a new squad in a fleet  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostFleetsFleetIdWingsWingIdSquadsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var wingId = 789;  // long? | The wing_id to create squad in
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Create fleet squad
                PostFleetsFleetIdWingsWingIdSquadsCreated result = apiInstance.PostFleetsFleetIdWingsWingIdSquads(fleetId, wingId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.PostFleetsFleetIdWingsWingIdSquads: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **wingId** | **long?**| The wing_id to create squad in | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**PostFleetsFleetIdWingsWingIdSquadsCreated**](PostFleetsFleetIdWingsWingIdSquadsCreated.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfleetsfleetid"></a>
# **PutFleetsFleetId**
> void PutFleetsFleetId (long? fleetId, PutFleetsFleetIdNewSettings newSettings, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Update fleet

Update settings about a fleet  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutFleetsFleetIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var newSettings = new PutFleetsFleetIdNewSettings(); // PutFleetsFleetIdNewSettings | What to update for this fleet
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Update fleet
                apiInstance.PutFleetsFleetId(fleetId, newSettings, datasource, token, userAgent, xUserAgent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.PutFleetsFleetId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **newSettings** | [**PutFleetsFleetIdNewSettings**](PutFleetsFleetIdNewSettings.md)| What to update for this fleet | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfleetsfleetidmembersmemberid"></a>
# **PutFleetsFleetIdMembersMemberId**
> void PutFleetsFleetIdMembersMemberId (long? fleetId, int? memberId, PutFleetsFleetIdMembersMemberIdMovement movement, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Move fleet member

Move a fleet member around  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutFleetsFleetIdMembersMemberIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var memberId = 56;  // int? | The character ID of a member in this fleet
            var movement = new PutFleetsFleetIdMembersMemberIdMovement(); // PutFleetsFleetIdMembersMemberIdMovement | Details of the invitation
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Move fleet member
                apiInstance.PutFleetsFleetIdMembersMemberId(fleetId, memberId, movement, datasource, token, userAgent, xUserAgent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.PutFleetsFleetIdMembersMemberId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **memberId** | **int?**| The character ID of a member in this fleet | 
 **movement** | [**PutFleetsFleetIdMembersMemberIdMovement**](PutFleetsFleetIdMembersMemberIdMovement.md)| Details of the invitation | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfleetsfleetidsquadssquadid"></a>
# **PutFleetsFleetIdSquadsSquadId**
> void PutFleetsFleetIdSquadsSquadId (long? fleetId, PutFleetsFleetIdSquadsSquadIdNaming naming, long? squadId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Rename fleet squad

Rename a fleet squad  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutFleetsFleetIdSquadsSquadIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var naming = new PutFleetsFleetIdSquadsSquadIdNaming(); // PutFleetsFleetIdSquadsSquadIdNaming | New name of the squad
            var squadId = 789;  // long? | The squad to rename
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Rename fleet squad
                apiInstance.PutFleetsFleetIdSquadsSquadId(fleetId, naming, squadId, datasource, token, userAgent, xUserAgent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.PutFleetsFleetIdSquadsSquadId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **naming** | [**PutFleetsFleetIdSquadsSquadIdNaming**](PutFleetsFleetIdSquadsSquadIdNaming.md)| New name of the squad | 
 **squadId** | **long?**| The squad to rename | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfleetsfleetidwingswingid"></a>
# **PutFleetsFleetIdWingsWingId**
> void PutFleetsFleetIdWingsWingId (long? fleetId, PutFleetsFleetIdWingsWingIdNaming naming, long? wingId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Rename fleet wing

Rename a fleet wing  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutFleetsFleetIdWingsWingIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FleetsApi();
            var fleetId = 789;  // long? | ID for a fleet
            var naming = new PutFleetsFleetIdWingsWingIdNaming(); // PutFleetsFleetIdWingsWingIdNaming | New name of the wing
            var wingId = 789;  // long? | The wing to rename
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Rename fleet wing
                apiInstance.PutFleetsFleetIdWingsWingId(fleetId, naming, wingId, datasource, token, userAgent, xUserAgent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetsApi.PutFleetsFleetIdWingsWingId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fleetId** | **long?**| ID for a fleet | 
 **naming** | [**PutFleetsFleetIdWingsWingIdNaming**](PutFleetsFleetIdWingsWingIdNaming.md)| New name of the wing | 
 **wingId** | **long?**| The wing to rename | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

