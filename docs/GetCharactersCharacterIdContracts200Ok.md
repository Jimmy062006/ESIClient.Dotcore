# IO.Swagger.Model.GetCharactersCharacterIdContracts200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContractId** | **int?** | contract_id integer | 
**IssuerId** | **int?** | Character ID for the issuer | 
**IssuerCorporationId** | **int?** | Character&#39;s corporation ID for the issuer | 
**AssigneeId** | **int?** | ID to whom the contract is assigned, can be corporation or character ID | 
**AcceptorId** | **int?** | Who will accept the contract | 
**StartLocationId** | **long?** | Start location ID (for Couriers contract) | [optional] 
**EndLocationId** | **long?** | End location ID (for Couriers contract) | [optional] 
**Type** | **string** | Type of the contract | 
**Status** | **string** | Status of the the contract | 
**Title** | **string** | Title of the contract | [optional] 
**ForCorporation** | **bool?** | true if the contract was issued on behalf of the issuer&#39;s corporation | 
**Availability** | **string** | To whom the contract is available | 
**DateIssued** | **DateTime?** | Сreation date of the contract | 
**DateExpired** | **DateTime?** | Expiration date of the contract | 
**DateAccepted** | **DateTime?** | Date of confirmation of contract | [optional] 
**DaysToComplete** | **int?** | Number of days to perform the contract | [optional] 
**DateCompleted** | **DateTime?** | Date of completed of contract | [optional] 
**Price** | **double?** | Price of contract (for ItemsExchange and Auctions) | [optional] 
**Reward** | **double?** | Remuneration for contract (for Couriers only) | [optional] 
**Collateral** | **double?** | Collateral price (for Couriers only) | [optional] 
**Buyout** | **double?** | Buyout price (for Auctions only) | [optional] 
**Volume** | **double?** | Volume of items in the contract | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

