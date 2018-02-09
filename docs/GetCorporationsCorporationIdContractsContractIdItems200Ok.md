# IO.Swagger.Model.GetCorporationsCorporationIdContractsContractIdItems200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecordId** | **long?** | Unique ID for the item | 
**TypeId** | **int?** | Type ID for item | 
**Quantity** | **int?** | Number of items in the stack | 
**RawQuantity** | **int?** | -1 indicates that the item is a singleton (non-stackable). If the item happens to be a Blueprint, -1 is an Original and -2 is a Blueprint Copy | [optional] 
**IsSingleton** | **bool?** | is_singleton boolean | 
**IsIncluded** | **bool?** | true if the contract issuer has submitted this item with the contract, false if the isser is asking for this item in the contract. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

