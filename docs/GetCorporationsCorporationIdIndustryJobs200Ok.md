# ESIClient.Dotcore.Model.GetCorporationsCorporationIdIndustryJobs200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivityId** | **int?** | Job activity ID | 
**BlueprintId** | **long?** | blueprint_id integer | 
**BlueprintLocationId** | **long?** | Location ID of the location from which the blueprint was installed. Normally a station ID, but can also be an asset (e.g. container) or corporation facility | 
**BlueprintTypeId** | **int?** | blueprint_type_id integer | 
**CompletedCharacterId** | **int?** | ID of the character which completed this job | [optional] 
**CompletedDate** | **DateTime?** | Date and time when this job was completed | [optional] 
**Cost** | **double?** | The sume of job installation fee and industry facility tax | [optional] 
**Duration** | **int?** | Job duration in seconds | 
**EndDate** | **DateTime?** | Date and time when this job finished | 
**FacilityId** | **long?** | ID of the facility where this job is running | 
**InstallerId** | **int?** | ID of the character which installed this job | 
**JobId** | **int?** | Unique job ID | 
**LicensedRuns** | **int?** | Number of runs blueprint is licensed for | [optional] 
**LocationId** | **long?** | ID of the location for the industry facility | 
**OutputLocationId** | **long?** | Location ID of the location to which the output of the job will be delivered. Normally a station ID, but can also be a corporation facility | 
**PauseDate** | **DateTime?** | Date and time when this job was paused (i.e. time when the facility where this job was installed went offline) | [optional] 
**Probability** | **float?** | Chance of success for invention | [optional] 
**ProductTypeId** | **int?** | Type ID of product (manufactured, copied or invented) | [optional] 
**Runs** | **int?** | Number of runs for a manufacturing job, or number of copies to make for a blueprint copy | 
**StartDate** | **DateTime?** | Date and time when this job started | 
**Status** | **string** | status string | 
**SuccessfulRuns** | **int?** | Number of successful runs for this job. Equal to runs unless this is an invention job | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

