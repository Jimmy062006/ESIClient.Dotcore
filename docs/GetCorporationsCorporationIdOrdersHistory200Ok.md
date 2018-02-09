# IO.Swagger.Model.GetCorporationsCorporationIdOrdersHistory200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **long?** | Unique order ID | 
**TypeId** | **int?** | The type ID of the item transacted in this order | 
**RegionId** | **int?** | ID of the region where order was placed | 
**LocationId** | **long?** | ID of the location where order was placed | 
**Range** | **string** | Valid order range, numbers are ranges in jumps | 
**Price** | **double?** | Cost per unit for this order | 
**VolumeTotal** | **int?** | Quantity of items required or offered at time order was placed | 
**VolumeRemain** | **int?** | Quantity of items still required or offered | 
**Issued** | **DateTime?** | Date and time when this order was issued | 
**IsBuyOrder** | **bool?** | True if the order is a bid (buy) order | [optional] 
**MinVolume** | **int?** | For buy orders, the minimum quantity that will be accepted in a matching sell order | [optional] 
**Escrow** | **double?** | For buy orders, the amount of ISK in escrow | [optional] 
**Duration** | **int?** | Number of days the order was valid for (starting from the issued date). An order expires at time issued + duration | 
**State** | **string** | Current order state | 
**WalletDivision** | **int?** | The corporation wallet division used for this order. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

