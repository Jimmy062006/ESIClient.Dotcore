# ESIClient.Dotcore.Model.GetCorporationsCorporationIdBlueprints200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemId** | **long?** | Unique ID for this item. | 
**LocationFlag** | **string** | Type of the location_id | 
**LocationId** | **long?** | References a station, a ship or an item_id if this blueprint is located within a container. | 
**MaterialEfficiency** | **int?** | Material Efficiency Level of the blueprint. | 
**Quantity** | **int?** | A range of numbers with a minimum of -2 and no maximum value where -1 is an original and -2 is a copy. It can be a positive integer if it is a stack of blueprint originals fresh from the market (e.g. no activities performed on them yet). | 
**Runs** | **int?** | Number of runs remaining if the blueprint is a copy, -1 if it is an original. | 
**TimeEfficiency** | **int?** | Time Efficiency Level of the blueprint. | 
**TypeId** | **int?** | type_id integer | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

