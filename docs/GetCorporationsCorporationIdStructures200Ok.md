# IO.Swagger.Model.GetCorporationsCorporationIdStructures200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StructureId** | **long?** | The Item ID of the structure | 
**TypeId** | **int?** | The type id of the structure | 
**CorporationId** | **int?** | ID of the corporation that owns the structure | 
**SystemId** | **int?** | The solar system the structure is in | 
**ProfileId** | **int?** | The id of the ACL profile for this citadel | 
**CurrentVul** | [**List&lt;GetCorporationsCorporationIdStructuresCurrentVul&gt;**](GetCorporationsCorporationIdStructuresCurrentVul.md) | This week&#39;s vulnerability windows, Monday is day 0 | 
**NextVul** | [**List&lt;GetCorporationsCorporationIdStructuresNextVul&gt;**](GetCorporationsCorporationIdStructuresNextVul.md) | Next week&#39;s vulnerability windows, Monday is day 0 | 
**FuelExpires** | **DateTime?** | Date on which the structure will run out of fuel | [optional] 
**Services** | [**List&lt;GetCorporationsCorporationIdStructuresService&gt;**](GetCorporationsCorporationIdStructuresService.md) | Contains a list of service upgrades, and their state | [optional] 
**StateTimerStart** | **DateTime?** | Date at which the structure entered it&#39;s current state | [optional] 
**StateTimerEnd** | **DateTime?** | Date at which the structure will move to it&#39;s next state | [optional] 
**UnanchorsAt** | **DateTime?** | Date at which the structure will unanchor | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

