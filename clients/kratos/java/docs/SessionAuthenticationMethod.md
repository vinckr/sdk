

# SessionAuthenticationMethod

A singular authenticator used during authentication / login.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**completedAt** | **OffsetDateTime** | When the authentication challenge was completed. |  [optional]
**method** | [**MethodEnum**](#MethodEnum) |  |  [optional]



## Enum: MethodEnum

Name | Value
---- | -----
LINK_RECOVERY | &quot;link_recovery&quot;
PASSWORD | &quot;password&quot;
TOTP | &quot;totp&quot;
OIDC | &quot;oidc&quot;



