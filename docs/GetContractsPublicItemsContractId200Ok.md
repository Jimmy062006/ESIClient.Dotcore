# ESIClient.Dotcore.Model.GetContractsPublicItemsContractId200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsBlueprintCopy** | **bool?** | is_blueprint_copy boolean | [optional] 
**IsIncluded** | **bool?** | true if the contract issuer has submitted this item with the contract, false if the isser is asking for this item in the contract | 
**ItemId** | **long?** | Unique ID for the item being sold. Not present if item is being requested by contract rather than sold with contract | [optional] 
**MaterialEfficiency** | **int?** | Material Efficiency Level of the blueprint | [optional] 
**Quantity** | **int?** | Number of items in the stack | 
**RecordId** | **long?** | Unique ID for the item, used by the contract system | 
**Runs** | **int?** | Number of runs remaining if the blueprint is a copy, -1 if it is an original | [optional] 
**TimeEfficiency** | **int?** | Time Efficiency Level of the blueprint | [optional] 
**TypeId** | **int?** | Type ID for item | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

