# IO.Swagger.Model.GetCharactersCharacterIdChatChannels200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChannelId** | **int?** | Unique channel ID. Always negative for player-created channels. Permanent (CCP created) channels have a positive ID, but don&#39;t appear in the API | 
**Name** | **string** | Displayed name of channel | 
**OwnerId** | **int?** | owner_id integer | 
**ComparisonKey** | **string** | Normalized, unique string used to compare channel names | 
**HasPassword** | **bool?** | If this is a password protected channel | 
**Motd** | **string** | Message of the day for this channel | 
**Allowed** | [**List&lt;GetCharactersCharacterIdChatChannelsAllowed&gt;**](GetCharactersCharacterIdChatChannelsAllowed.md) | allowed array | 
**Operators** | [**List&lt;GetCharactersCharacterIdChatChannelsOperator&gt;**](GetCharactersCharacterIdChatChannelsOperator.md) | operators array | 
**Blocked** | [**List&lt;GetCharactersCharacterIdChatChannelsBlocked&gt;**](GetCharactersCharacterIdChatChannelsBlocked.md) | blocked array | 
**Muted** | [**List&lt;GetCharactersCharacterIdChatChannelsMuted&gt;**](GetCharactersCharacterIdChatChannelsMuted.md) | muted array | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

