# ESIClient.Dotcore.Model.GetCorporationsCorporationIdStructures200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorporationId** | **int?** | ID of the corporation that owns the structure | 
**FuelExpires** | **DateTime?** | Date on which the structure will run out of fuel | [optional] 
**NextReinforceApply** | **DateTime?** | The date and time when the structure&#39;s newly requested reinforcement times (e.g. next_reinforce_hour and next_reinforce_day) will take effect | [optional] 
**NextReinforceHour** | **int?** | The requested change to reinforce_hour that will take effect at the time shown by next_reinforce_apply | [optional] 
**NextReinforceWeekday** | **int?** | The requested change to reinforce_weekday that will take effect at the time shown by next_reinforce_apply | [optional] 
**ProfileId** | **int?** | The id of the ACL profile for this citadel | 
**ReinforceHour** | **int?** | The hour of day that determines the four hour window when the structure will randomly exit its reinforcement periods and become vulnerable to attack against its armor and/or hull. The structure will become vulnerable at a random time that is +/- 2 hours centered on the value of this property | 
**ReinforceWeekday** | **int?** | The day of the week when the structure exits its final reinforcement period and becomes vulnerable to attack against its hull. Monday is 0 and Sunday is 6 | [optional] 
**Services** | [**List&lt;GetCorporationsCorporationIdStructuresService&gt;**](GetCorporationsCorporationIdStructuresService.md) | Contains a list of service upgrades, and their state | [optional] 
**State** | **string** | state string | 
**StateTimerEnd** | **DateTime?** | Date at which the structure will move to it&#39;s next state | [optional] 
**StateTimerStart** | **DateTime?** | Date at which the structure entered it&#39;s current state | [optional] 
**StructureId** | **long?** | The Item ID of the structure | 
**SystemId** | **int?** | The solar system the structure is in | 
**TypeId** | **int?** | The type id of the structure | 
**UnanchorsAt** | **DateTime?** | Date at which the structure will unanchor | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

