# ESIClient.Dotcore.Model.GetCorporationsCorporationIdContracts200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcceptorId** | **int?** | Who will accept the contract | 
**AssigneeId** | **int?** | ID to whom the contract is assigned, can be corporation or character ID | 
**Availability** | **string** | To whom the contract is available | 
**Buyout** | **double?** | Buyout price (for Auctions only) | [optional] 
**Collateral** | **double?** | Collateral price (for Couriers only) | [optional] 
**ContractId** | **int?** | contract_id integer | 
**DateAccepted** | **DateTime?** | Date of confirmation of contract | [optional] 
**DateCompleted** | **DateTime?** | Date of completed of contract | [optional] 
**DateExpired** | **DateTime?** | Expiration date of the contract | 
**DateIssued** | **DateTime?** | Сreation date of the contract | 
**DaysToComplete** | **int?** | Number of days to perform the contract | [optional] 
**EndLocationId** | **long?** | End location ID (for Couriers contract) | [optional] 
**ForCorporation** | **bool?** | true if the contract was issued on behalf of the issuer&#39;s corporation | 
**IssuerCorporationId** | **int?** | Character&#39;s corporation ID for the issuer | 
**IssuerId** | **int?** | Character ID for the issuer | 
**Price** | **double?** | Price of contract (for ItemsExchange and Auctions) | [optional] 
**Reward** | **double?** | Remuneration for contract (for Couriers only) | [optional] 
**StartLocationId** | **long?** | Start location ID (for Couriers contract) | [optional] 
**Status** | **string** | Status of the the contract | 
**Title** | **string** | Title of the contract | [optional] 
**Type** | **string** | Type of the contract | 
**Volume** | **double?** | Volume of items in the contract | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

