# Ory.Client.Model.ClientSubmitSelfServiceSettingsFlowBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CsrfToken** | **string** | CSRFToken is the anti-CSRF token | [optional] 
**Method** | **string** | Method  Should be set to \&quot;totp\&quot; when trying to add, update, or remove a totp pairing. | 
**Password** | **string** | Password is the updated password | 
**Traits** | **Object** | The identity&#39;s traits  in: body | 
**Flow** | **string** | Flow ID is the flow&#39;s ID.  in: query | [optional] 
**Link** | **string** | Link this provider  Either this or &#x60;unlink&#x60; must be set.  type: string in: body | [optional] 
**Unlink** | **string** | Unlink this provider  Either this or &#x60;link&#x60; must be set.  type: string in: body | [optional] 
**TotpCode** | **string** | ValidationTOTP must contain a valid TOTP based on the | [optional] 
**TotpUnlink** | **bool** | UnlinkTOTP if true will remove the TOTP pairing, effectively removing the credential. This can be used to set up a new TOTP device. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

