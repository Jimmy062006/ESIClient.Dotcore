# ESIClient.Dotcore.Api.CalendarApi

All URIs are relative to *https://esi.evetech.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCharactersCharacterIdCalendar**](CalendarApi.md#getcharacterscharacteridcalendar) | **GET** /v1/characters/{character_id}/calendar/ | List calendar event summaries
[**GetCharactersCharacterIdCalendarEventId**](CalendarApi.md#getcharacterscharacteridcalendareventid) | **GET** /v3/characters/{character_id}/calendar/{event_id}/ | Get an event
[**GetCharactersCharacterIdCalendarEventIdAttendees**](CalendarApi.md#getcharacterscharacteridcalendareventidattendees) | **GET** /v1/characters/{character_id}/calendar/{event_id}/attendees/ | Get attendees
[**PutCharactersCharacterIdCalendarEventId**](CalendarApi.md#putcharacterscharacteridcalendareventid) | **PUT** /v3/characters/{character_id}/calendar/{event_id}/ | Respond to an event


<a name="getcharacterscharacteridcalendar"></a>
# **GetCharactersCharacterIdCalendar**
> List<GetCharactersCharacterIdCalendar200Ok> GetCharactersCharacterIdCalendar (int? characterId, string datasource = null, int? fromEvent = null, string ifNoneMatch = null, string token = null)

List calendar event summaries

Get 50 event summaries from the calendar. If no from_event ID is given, the resource will return the next 50 chronological event summaries from now. If a from_event ID is specified, it will return the next 50 chronological event summaries from after that event.  - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdCalendarExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarApi();
            var characterId = 56;  // int? | An EVE character ID
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var fromEvent = 56;  // int? | The event ID to retrieve events from (optional) 
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // List calendar event summaries
                List&lt;GetCharactersCharacterIdCalendar200Ok&gt; result = apiInstance.GetCharactersCharacterIdCalendar(characterId, datasource, fromEvent, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.GetCharactersCharacterIdCalendar: " + e.Message );
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
 **fromEvent** | **int?**| The event ID to retrieve events from | [optional] 
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**List<GetCharactersCharacterIdCalendar200Ok>**](GetCharactersCharacterIdCalendar200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridcalendareventid"></a>
# **GetCharactersCharacterIdCalendarEventId**
> GetCharactersCharacterIdCalendarEventIdOk GetCharactersCharacterIdCalendarEventId (int? characterId, int? eventId, string datasource = null, string ifNoneMatch = null, string token = null)

Get an event

Get all the information for a specific event  - --  This route is cached for up to 5 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdCalendarEventIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarApi();
            var characterId = 56;  // int? | An EVE character ID
            var eventId = 56;  // int? | The id of the event requested
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get an event
                GetCharactersCharacterIdCalendarEventIdOk result = apiInstance.GetCharactersCharacterIdCalendarEventId(characterId, eventId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.GetCharactersCharacterIdCalendarEventId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **eventId** | **int?**| The id of the event requested | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**GetCharactersCharacterIdCalendarEventIdOk**](GetCharactersCharacterIdCalendarEventIdOk.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcharacterscharacteridcalendareventidattendees"></a>
# **GetCharactersCharacterIdCalendarEventIdAttendees**
> List<GetCharactersCharacterIdCalendarEventIdAttendees200Ok> GetCharactersCharacterIdCalendarEventIdAttendees (int? characterId, int? eventId, string datasource = null, string ifNoneMatch = null, string token = null)

Get attendees

Get all invited attendees for a given event  - --  This route is cached for up to 600 seconds

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class GetCharactersCharacterIdCalendarEventIdAttendeesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarApi();
            var characterId = 56;  // int? | An EVE character ID
            var eventId = 56;  // int? | The id of the event requested
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var ifNoneMatch = ifNoneMatch_example;  // string | ETag from a previous request. A 304 will be returned if this matches the current ETag (optional) 
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Get attendees
                List&lt;GetCharactersCharacterIdCalendarEventIdAttendees200Ok&gt; result = apiInstance.GetCharactersCharacterIdCalendarEventIdAttendees(characterId, eventId, datasource, ifNoneMatch, token);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.GetCharactersCharacterIdCalendarEventIdAttendees: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **eventId** | **int?**| The id of the event requested | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **ifNoneMatch** | **string**| ETag from a previous request. A 304 will be returned if this matches the current ETag | [optional] 
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

[**List<GetCharactersCharacterIdCalendarEventIdAttendees200Ok>**](GetCharactersCharacterIdCalendarEventIdAttendees200Ok.md)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcharacterscharacteridcalendareventid"></a>
# **PutCharactersCharacterIdCalendarEventId**
> void PutCharactersCharacterIdCalendarEventId (int? characterId, int? eventId, PutCharactersCharacterIdCalendarEventIdResponse response, string datasource = null, string token = null)

Respond to an event

Set your response status to an event  - -- 

### Example
```csharp
using System;
using System.Diagnostics;
using ESIClient.Dotcore.Api;
using ESIClient.Dotcore.Client;
using ESIClient.Dotcore.Model;

namespace Example
{
    public class PutCharactersCharacterIdCalendarEventIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: evesso
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarApi();
            var characterId = 56;  // int? | An EVE character ID
            var eventId = 56;  // int? | The ID of the event requested
            var response = new PutCharactersCharacterIdCalendarEventIdResponse(); // PutCharactersCharacterIdCalendarEventIdResponse | The response value to set, overriding current value.
            var datasource = datasource_example;  // string | The server name you would like data from (optional)  (default to tranquility)
            var token = token_example;  // string | Access token to use if unable to set a header (optional) 

            try
            {
                // Respond to an event
                apiInstance.PutCharactersCharacterIdCalendarEventId(characterId, eventId, response, datasource, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarApi.PutCharactersCharacterIdCalendarEventId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **int?**| An EVE character ID | 
 **eventId** | **int?**| The ID of the event requested | 
 **response** | [**PutCharactersCharacterIdCalendarEventIdResponse**](PutCharactersCharacterIdCalendarEventIdResponse.md)| The response value to set, overriding current value. | 
 **datasource** | **string**| The server name you would like data from | [optional] [default to tranquility]
 **token** | **string**| Access token to use if unable to set a header | [optional] 

### Return type

void (empty response body)

### Authorization

[evesso](../README.md#evesso)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

