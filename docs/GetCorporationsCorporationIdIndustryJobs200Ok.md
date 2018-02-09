# IO.Swagger.Model.GetCorporationsCorporationIdIndustryJobs200Ok
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobId** | **int?** | Unique job ID | 
**InstallerId** | **int?** | ID of the character which installed this job | 
**FacilityId** | **long?** | ID of the facility where this job is running | 
**LocationId** | **long?** | ID of the location for the industry facility | 
**ActivityId** | **int?** | Job activity ID | 
**BlueprintId** | **long?** | blueprint_id integer | 
**BlueprintTypeId** | **int?** | blueprint_type_id integer | 
**BlueprintLocationId** | **long?** | Location ID of the location from which the blueprint was installed. Normally a station ID, but can also be an asset (e.g. container) or corporation facility | 
**OutputLocationId** | **long?** | Location ID of the location to which the output of the job will be delivered. Normally a station ID, but can also be a corporation facility | 
**Runs** | **int?** | Number of runs for a manufacturing job, or number of copies to make for a blueprint copy | 
**Cost** | **double?** | The sume of job installation fee and industry facility tax | [optional] 
**LicensedRuns** | **int?** | Number of runs blueprint is licensed for | [optional] 
**Probability** | **float?** | Chance of success for invention | [optional] 
**ProductTypeId** | **int?** | Type ID of product (manufactured, copied or invented) | [optional] 
**Status** | **string** | status string | 
**Duration** | **int?** | Job duration in seconds | 
**StartDate** | **DateTime?** | Date and time when this job started | 
**EndDate** | **DateTime?** | Date and time when this job finished | 
**PauseDate** | **DateTime?** | Date and time when this job was paused (i.e. time when the facility where this job was installed went offline) | [optional] 
**CompletedDate** | **DateTime?** | Date and time when this job was completed | [optional] 
**CompletedCharacterId** | **int?** | ID of the character which completed this job | [optional] 
**SuccessfulRuns** | **int?** | Number of successful runs for this job. Equal to runs unless this is an invention job | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

