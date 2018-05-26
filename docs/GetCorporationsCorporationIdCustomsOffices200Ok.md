# ESIClient.Dotcore.Model.GetCorporationsCorporationIdCustomsOffices200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllianceTaxRate** | **float?** | Only present if alliance access is allowed | [optional] 
**AllowAccessWithStandings** | **bool?** | standing_level and any standing related tax rate only present when this is true | 
**AllowAllianceAccess** | **bool?** | allow_alliance_access boolean | 
**BadStandingTaxRate** | **float?** | bad_standing_tax_rate number | [optional] 
**CorporationTaxRate** | **float?** | corporation_tax_rate number | [optional] 
**ExcellentStandingTaxRate** | **float?** | Tax rate for entities with excellent level of standing, only present if this level is allowed, same for all other standing related tax rates | [optional] 
**GoodStandingTaxRate** | **float?** | good_standing_tax_rate number | [optional] 
**NeutralStandingTaxRate** | **float?** | neutral_standing_tax_rate number | [optional] 
**OfficeId** | **long?** | unique ID of this customs office | 
**ReinforceExitEnd** | **int?** | reinforce_exit_end integer | 
**ReinforceExitStart** | **int?** | Together with reinforce_exit_end, marks a 2-hour period where this customs office could exit reinforcement mode during the day after initial attack | 
**StandingLevel** | **string** | Access is allowed only for entities with this level of standing or better | [optional] 
**SystemId** | **int?** | ID of the solar system this customs office is located in | 
**TerribleStandingTaxRate** | **float?** | terrible_standing_tax_rate number | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

