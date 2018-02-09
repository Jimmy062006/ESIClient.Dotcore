# IO.Swagger.Api.PlanetaryInteractionApi

All URIs are relative to *https://esi.tech.ccp.is*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdPlanets**](PlanetaryInteractionApi.md#getcharacterscharacteridplanets) | **GET** /v1/characters/{character_id}/planets/ | Get colonies
[**GetCharactersCharacterIdPlanetsPlanetId**](PlanetaryInteractionApi.md#getcharacterscharacteridplanetsplanetid) | **GET** /v3/characters/{character_id}/planets/{planet_id}/ | Get colony layout
[**GetCorporationsCorporationIdCustomsOffices**](PlanetaryInteractionApi.md#getcorporationscorporationidcustomsoffices) | **GET** /v1/corporations/{corporation_id}/customs_offices/ | List corporation customs offices
[**GetUniverseSchematicsSchematicId**](PlanetaryInteractionApi.md#getuniverseschematicsschematicid) | **GET** /v1/universe/schematics/{schematic_id}/ | Get schematic information


<a name="getcharacterscharacteridplanets"></a>
# **GetCharactersCharacterIdPlanets**
> List<GetCharactersCharacterIdPlanets200Ok> GetCharactersCharacterIdPlanets (int? characterId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get colonies

Returns a list of all planetary colonies owned by a character.  - --  This route is cached for up to 600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdPlanetsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlanetaryInteractionApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get colonies
                List&lt;GetCharactersCharacterIdPlanets200Ok&gt; result = apiInstance.GetCharactersCharacterIdPlanets(characterId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanetaryInteractionApi.GetCharactersCharacterIdPlanets: " + e.Message );
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

[**List<GetCharactersCharacterIdPlanets200Ok>**](GetCharactersCharacterIdPlanets200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridplanetsplanetid"></a>
# **GetCharactersCharacterIdPlanetsPlanetId**
> GetCharactersCharacterIdPlanetsPlanetIdOk GetCharactersCharacterIdPlanetsPlanetId (int? characterId, int? planetId, string datasource = null, string token = null, string userAgent = null, string xUserAgent = null)

Get colony layout

Returns full details on the layout of a single planetary colony, including links, pins and routes. Note: Planetary information is only recalculated when the colony is viewed through the client. Information will not update until this criteria is met.  - --  This route is cached for up to 600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCharactersCharacterIdPlanetsPlanetIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlanetaryInteractionApi();
            var characterId = 56;  // int? | An EVE character ID
            var planetId = 56;  // int? | Planet id of the target planet
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get colony layout
                GetCharactersCharacterIdPlanetsPlanetIdOk result = apiInstance.GetCharactersCharacterIdPlanetsPlanetId(characterId, planetId, datasource, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanetaryInteractionApi.GetCharactersCharacterIdPlanetsPlanetId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **planetId** | **int?**| Planet id of the target planet | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetCharactersCharacterIdPlanetsPlanetIdOk**](GetCharactersCharacterIdPlanetsPlanetIdOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporationscorporationidcustomsoffices"></a>
# **GetCorporationsCorporationIdCustomsOffices**
> List<GetCorporationsCorporationIdCustomsOffices200Ok> GetCorporationsCorporationIdCustomsOffices (int? corporationId, string datasource = null, int? page = null, string token = null, string userAgent = null, string xUserAgent = null)

List corporation customs offices

List customs offices owned by a corporation  - --  This route is cached for up to 3600 seconds  - -- Requires one of the following EVE corporation role(s): Director

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCorporationsCorporationIdCustomsOfficesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PlanetaryInteractionApi();
            var corporationId = 56;  // int? | An EVE corporation ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var page = 56;  // int? | Which page of results to return (optional)  (default to 1)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // List corporation customs offices
                List&lt;GetCorporationsCorporationIdCustomsOffices200Ok&gt; result = apiInstance.GetCorporationsCorporationIdCustomsOffices(corporationId, datasource, page, token, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanetaryInteractionApi.GetCorporationsCorporationIdCustomsOffices: " + e.Message );
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

[**List<GetCorporationsCorporationIdCustomsOffices200Ok>**](GetCorporationsCorporationIdCustomsOffices200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuniverseschematicsschematicid"></a>
# **GetUniverseSchematicsSchematicId**
> GetUniverseSchematicsSchematicIdOk GetUniverseSchematicsSchematicId (int? schematicId, string datasource = null, string userAgent = null, string xUserAgent = null)

Get schematic information

Get information on a planetary factory schematic  - --  This route is cached for up to 3600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUniverseSchematicsSchematicIdExample
    {
        public void main()
        {
            var apiInstance = new PlanetaryInteractionApi();
            var schematicId = 56;  // int? | A PI schematic ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var userAgent = userAgent_example;  // string | Client identifier, takes precedence over headers (optional) 
            var xUserAgent = xUserAgent_example;  // string | Client identifier, takes precedence over User-Agent (optional) 

            try
            {
                // Get schematic information
                GetUniverseSchematicsSchematicIdOk result = apiInstance.GetUniverseSchematicsSchematicId(schematicId, datasource, userAgent, xUserAgent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlanetaryInteractionApi.GetUniverseSchematicsSchematicId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schematicId** | **int?**| A PI schematic ID | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **userAgent** | **string**| Client identifier, takes precedence over headers | [optional] 
 **xUserAgent** | **string**| Client identifier, takes precedence over User-Agent | [optional] 

### Return type

[**GetUniverseSchematicsSchematicIdOk**](GetUniverseSchematicsSchematicIdOk.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

