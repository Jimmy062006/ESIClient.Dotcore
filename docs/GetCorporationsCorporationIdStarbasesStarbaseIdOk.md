# ESIClient.Dotcore.Model.GetCorporationsCorporationIdStarbasesStarbaseIdOk
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowAllianceMembers** | **bool?** | allow_alliance_members boolean | 
**AllowCorporationMembers** | **bool?** | allow_corporation_members boolean | 
**Anchor** | **string** | Who can anchor starbase (POS) and its structures | 
**AttackIfAtWar** | **bool?** | attack_if_at_war boolean | 
**AttackIfOtherSecurityStatusDropping** | **bool?** | attack_if_other_security_status_dropping boolean | 
**AttackSecurityStatusThreshold** | **float?** | Starbase (POS) will attack if target&#39;s security standing is lower than this value | [optional] 
**AttackStandingThreshold** | **float?** | Starbase (POS) will attack if target&#39;s standing is lower than this value | [optional] 
**FuelBayTake** | **string** | Who can take fuel blocks out of the starbase (POS)&#39;s fuel bay | 
**FuelBayView** | **string** | Who can view the starbase (POS)&#39;s fule bay. Characters either need to have required role or belong to the starbase (POS) owner&#39;s corporation or alliance, as described by the enum, all other access settings follows the same scheme | 
**Fuels** | [**List&lt;GetCorporationsCorporationIdStarbasesStarbaseIdFuel&gt;**](GetCorporationsCorporationIdStarbasesStarbaseIdFuel.md) | Fuel blocks and other things that will be consumed when operating a starbase (POS) | [optional] 
**Offline** | **string** | Who can offline starbase (POS) and its structures | 
**Online** | **string** | Who can online starbase (POS) and its structures | 
**Unanchor** | **string** | Who can unanchor starbase (POS) and its structures | 
**UseAllianceStandings** | **bool?** | True if the starbase (POS) is using alliance standings, otherwise using corporation&#39;s | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

