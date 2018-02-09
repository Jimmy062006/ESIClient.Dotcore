# IO.Swagger.Model.GetCorporationsCorporationIdWalletsDivisionJournal200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTime?** | Date and time of transaction | 
**RefId** | **long?** | Unique journal reference ID | 
**RefType** | **string** | Transaction type, different type of transaction will populate different fields in &#x60;extra_info&#x60; Note: If you have an existing XML API application that is using ref_types, you will need to know which string ESI ref_type maps to which integer. You can use the following gist to see string-&gt;int mappings: https://gist.github.com/ccp-zoetrope/c03db66d90c2148724c06171bc52e0ec | 
**FirstPartyId** | **int?** | first_party_id integer | [optional] 
**FirstPartyType** | **string** | first_party_type string | [optional] 
**SecondPartyId** | **int?** | second_party_id integer | [optional] 
**SecondPartyType** | **string** | second_party_type string | [optional] 
**Amount** | **double?** | Transaction amount. Positive when value transferred to the first party. Negative otherwise | [optional] 
**Balance** | **double?** | Wallet balance after transaction occurred | [optional] 
**Reason** | **string** | reason string | [optional] 
**TaxReceiverId** | **int?** | the corporation ID receiving any tax paid | [optional] 
**Tax** | **double?** | Tax amount received for tax related transactions | [optional] 
**ExtraInfo** | [**GetCorporationsCorporationIdWalletsDivisionJournalExtraInfo**](GetCorporationsCorporationIdWalletsDivisionJournalExtraInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

