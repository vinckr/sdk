# # SelfServiceLoginFlow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**active** | [**\Ory\Client\Model\IdentityCredentialsType**](IdentityCredentialsType.md) |  | [optional]
**createdAt** | [**\DateTime**](\DateTime.md) | CreatedAt is a helper struct field for gobuffalo.pop. | [optional]
**expiresAt** | [**\DateTime**](\DateTime.md) | ExpiresAt is the time (UTC) when the flow expires. If the user still wishes to log in, a new flow has to be initiated. |
**id** | **string** |  |
**issuedAt** | [**\DateTime**](\DateTime.md) | IssuedAt is the time (UTC) when the flow started. |
**refresh** | **bool** | Refresh stores whether this login flow should enforce re-authentication. | [optional]
**requestUrl** | **string** | RequestURL is the initial URL that was requested from Ory Kratos. It can be used to forward information contained in the URL&#39;s path or query for example. |
**requestedAal** | [**\Ory\Client\Model\AuthenticatorAssuranceLevel**](AuthenticatorAssuranceLevel.md) |  | [optional]
**returnTo** | **string** | ReturnTo contains the requested return_to URL. | [optional]
**type** | **string** | The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;. |
**ui** | [**\Ory\Client\Model\UiContainer**](UiContainer.md) |  |
**updatedAt** | [**\DateTime**](\DateTime.md) | UpdatedAt is a helper struct field for gobuffalo.pop. | [optional]

[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)
