# IO.Swagger.Model.GetCharactersCharacterIdOrders200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **long?** | Unique order ID | 
**TypeId** | **int?** | The type ID of the item transacted in this order | 
**RegionId** | **int?** | ID of the region where order was placed | 
**LocationId** | **long?** | ID of the location where order was placed | 
**Range** | **string** | Valid order range, numbers are ranges in jumps | 
**IsBuyOrder** | **bool?** | True for a bid (buy) order. False for an offer (sell) order | 
**Price** | **double?** | Cost per unit for this order | 
**VolumeTotal** | **int?** | Quantity of items required or offered at time order was placed | 
**VolumeRemain** | **int?** | Quantity of items still required or offered | 
**Issued** | **DateTime?** | Date and time when this order was issued | 
**State** | **string** | Current order state | 
**MinVolume** | **int?** | For bids (buy orders), the minimum quantity that will be accepted in a matching offer (sell order) | 
**AccountId** | **int?** | Wallet division for the buyer or seller of this order. Always 1000 for characters. Currently 1000 through 1006 for corporations | 
**Duration** | **int?** | Number of days the order is valid for (starting from the issued date). An order expires at time issued + duration | 
**IsCorp** | **bool?** | is_corp boolean | 
**Escrow** | **double?** | For buy orders, the amount of ISK in escrow | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

