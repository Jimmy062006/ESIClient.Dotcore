# ESIClient.Dotcore.Model.GetCorporationsCorporationIdOrdersHistory200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Duration** | **int?** | Number of days the order was valid for (starting from the issued date). An order expires at time issued + duration | 
**Escrow** | **double?** | For buy orders, the amount of ISK in escrow | [optional] 
**IsBuyOrder** | **bool?** | True if the order is a bid (buy) order | [optional] 
**Issued** | **DateTime?** | Date and time when this order was issued | 
**LocationId** | **long?** | ID of the location where order was placed | 
**MinVolume** | **int?** | For buy orders, the minimum quantity that will be accepted in a matching sell order | [optional] 
**OrderId** | **long?** | Unique order ID | 
**Price** | **double?** | Cost per unit for this order | 
**Range** | **string** | Valid order range, numbers are ranges in jumps | 
**RegionId** | **int?** | ID of the region where order was placed | 
**State** | **string** | Current order state | 
**TypeId** | **int?** | The type ID of the item transacted in this order | 
**VolumeRemain** | **int?** | Quantity of items still required or offered | 
**VolumeTotal** | **int?** | Quantity of items required or offered at time order was placed | 
**WalletDivision** | **int?** | The corporation wallet division used for this order. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

