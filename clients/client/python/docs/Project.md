# Project


## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**created_at** | **datetime** | The Project&#39;s Creation Date | [readonly] 
**current_revision** | [**ProjectRevision**](ProjectRevision.md) |  | 
**id** | **str** |  | 
**revisions** | [**ProjectRevisions**](ProjectRevisions.md) |  | 
**slug** | **str** | The project&#39;s slug | [readonly] 
**state** | **str** | The state of the project. | [readonly] 
**updated_at** | **datetime** | Last Time Project was Updated | [readonly] 
**ongoing_stripe_checkout_id** | [**NullString**](NullString.md) |  | [optional] 
**subscription_id** | [**NullUUID**](NullUUID.md) |  | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


