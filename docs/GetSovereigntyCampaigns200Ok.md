# ESIClient.Dotcore.Model.GetSovereigntyCampaigns200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttackersScore** | **float?** | Score for all attacking parties, only present in Defense Events.  | [optional] 
**CampaignId** | **int?** | Unique ID for this campaign. | 
**ConstellationId** | **int?** | The constellation in which the campaign will take place.  | 
**DefenderId** | **int?** | Defending alliance, only present in Defense Events  | [optional] 
**DefenderScore** | **float?** | Score for the defending alliance, only present in Defense Events.  | [optional] 
**EventType** | **string** | Type of event this campaign is for. tcu_defense, ihub_defense and station_defense are referred to as \&quot;Defense Events\&quot;, station_freeport as \&quot;Freeport Events\&quot;.  | 
**Participants** | [**List&lt;GetSovereigntyCampaignsParticipant&gt;**](GetSovereigntyCampaignsParticipant.md) | Alliance participating and their respective scores, only present in Freeport Events.  | [optional] 
**SolarSystemId** | **int?** | The solar system the structure is located in.  | 
**StartTime** | **DateTime?** | Time the event is scheduled to start.  | 
**StructureId** | **long?** | The structure item ID that is related to this campaign.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

