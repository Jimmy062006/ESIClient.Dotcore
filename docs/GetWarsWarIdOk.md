# IO.Swagger.Model.GetWarsWarIdOk
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | ID of the specified war | 
**Declared** | **DateTime?** | Time that the war was declared | 
**Started** | **DateTime?** | Time when the war started and both sides could shoot each other | [optional] 
**Retracted** | **DateTime?** | Time the war was retracted but both sides could still shoot each other | [optional] 
**Finished** | **DateTime?** | Time the war ended and shooting was no longer allowed | [optional] 
**Mutual** | **bool?** | Was the war declared mutual by both parties | 
**OpenForAllies** | **bool?** | Is the war currently open for allies or not | 
**Aggressor** | [**GetWarsWarIdAggressor**](GetWarsWarIdAggressor.md) |  | 
**Defender** | [**GetWarsWarIdDefender**](GetWarsWarIdDefender.md) |  | 
**Allies** | [**List&lt;GetWarsWarIdAlly&gt;**](GetWarsWarIdAlly.md) | allied corporations or alliances, each object contains either corporation_id or alliance_id | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

