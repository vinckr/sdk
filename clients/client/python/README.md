# ory-client
Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed
with a valid Personal Access Token. Public APIs are mostly used in browsers.


This Python package is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v0.0.1-alpha.30
- Package version: v0.0.1-alpha.30
- Build package: org.openapitools.codegen.languages.PythonClientCodegen

## Requirements.

Python >= 3.6

## Installation & Usage
### pip install

If the python package is hosted on a repository, you can install directly using:

```sh
pip install git+https://github.com/ory/sdk.git
```
(you may need to run `pip` with root permission: `sudo pip install git+https://github.com/ory/sdk.git`)

Then import the package:
```python
import ory_client
```

### Setuptools

Install via [Setuptools](http://pypi.python.org/pypi/setuptools).

```sh
python setup.py install --user
```
(or `sudo python setup.py install` to install the package for all users)

Then import the package:
```python
import ory_client
```

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

```python

import time
import ory_client
from pprint import pprint
from ory_client.api import metadata_api
from ory_client.model.generic_error import GenericError
from ory_client.model.inline_response200 import InlineResponse200
from ory_client.model.inline_response2001 import InlineResponse2001
from ory_client.model.inline_response503 import InlineResponse503
# Defining the host is optional and defaults to https://playground.projects.oryapis.com
# See configuration.py for a list of all supported configuration parameters.
configuration = ory_client.Configuration(
    host = "https://playground.projects.oryapis.com"
)



# Enter a context with an instance of the API client
with ory_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = metadata_api.MetadataApi(api_client)
    
    try:
        # Return Running Software Version.
        api_response = api_instance.get_version()
        pprint(api_response)
    except ory_client.ApiException as e:
        print("Exception when calling MetadataApi->get_version: %s\n" % e)
```

## Documentation for API Endpoints

All URIs are relative to *https://playground.projects.oryapis.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*MetadataApi* | [**get_version**](docs/MetadataApi.md#get_version) | **GET** /api/kratos/public/version | Return Running Software Version.
*MetadataApi* | [**is_alive**](docs/MetadataApi.md#is_alive) | **GET** /api/kratos/public/health/alive | Check HTTP Server Status
*MetadataApi* | [**is_ready**](docs/MetadataApi.md#is_ready) | **GET** /api/kratos/public/health/ready | Check HTTP Server and Database Status
*V0alpha0Api* | [**create_project**](docs/V0alpha0Api.md#create_project) | **POST** /backoffice/public/projects | Create a Project
*V0alpha0Api* | [**get_project**](docs/V0alpha0Api.md#get_project) | **GET** /backoffice/public/projects/{project_id} | Get a Project
*V0alpha0Api* | [**list_projects**](docs/V0alpha0Api.md#list_projects) | **GET** /backoffice/public/projects | List All Projects
*V0alpha0Api* | [**update_project**](docs/V0alpha0Api.md#update_project) | **PUT** /backoffice/public/projects/{project_id} | Update a Project
*V0alpha2Api* | [**admin_create_identity**](docs/V0alpha2Api.md#admin_create_identity) | **POST** /api/kratos/admin/identities | Create an Identity
*V0alpha2Api* | [**admin_create_self_service_recovery_link**](docs/V0alpha2Api.md#admin_create_self_service_recovery_link) | **POST** /api/kratos/admin/recovery/link | Create a Recovery Link
*V0alpha2Api* | [**admin_delete_identity**](docs/V0alpha2Api.md#admin_delete_identity) | **DELETE** /api/kratos/admin/identities/{id} | Delete an Identity
*V0alpha2Api* | [**admin_delete_identity_sessions**](docs/V0alpha2Api.md#admin_delete_identity_sessions) | **DELETE** /api/kratos/admin/identities/{id}/sessions | Calling this endpoint irrecoverably and permanently deletes and invalidates all sessions that belong to the given Identity.
*V0alpha2Api* | [**admin_get_identity**](docs/V0alpha2Api.md#admin_get_identity) | **GET** /api/kratos/admin/identities/{id} | Get an Identity
*V0alpha2Api* | [**admin_list_identities**](docs/V0alpha2Api.md#admin_list_identities) | **GET** /api/kratos/admin/identities | List Identities
*V0alpha2Api* | [**admin_update_identity**](docs/V0alpha2Api.md#admin_update_identity) | **PUT** /api/kratos/admin/identities/{id} | Update an Identity
*V0alpha2Api* | [**create_self_service_logout_flow_url_for_browsers**](docs/V0alpha2Api.md#create_self_service_logout_flow_url_for_browsers) | **GET** /api/kratos/public/self-service/logout/browser | Create a Logout URL for Browsers
*V0alpha2Api* | [**get_json_schema**](docs/V0alpha2Api.md#get_json_schema) | **GET** /api/kratos/public/schemas/{id} | 
*V0alpha2Api* | [**get_self_service_error**](docs/V0alpha2Api.md#get_self_service_error) | **GET** /api/kratos/public/self-service/errors | Get Self-Service Errors
*V0alpha2Api* | [**get_self_service_login_flow**](docs/V0alpha2Api.md#get_self_service_login_flow) | **GET** /api/kratos/public/self-service/login/flows | Get Login Flow
*V0alpha2Api* | [**get_self_service_recovery_flow**](docs/V0alpha2Api.md#get_self_service_recovery_flow) | **GET** /api/kratos/public/self-service/recovery/flows | Get Recovery Flow
*V0alpha2Api* | [**get_self_service_registration_flow**](docs/V0alpha2Api.md#get_self_service_registration_flow) | **GET** /api/kratos/public/self-service/registration/flows | Get Registration Flow
*V0alpha2Api* | [**get_self_service_settings_flow**](docs/V0alpha2Api.md#get_self_service_settings_flow) | **GET** /api/kratos/public/self-service/settings/flows | Get Settings Flow
*V0alpha2Api* | [**get_self_service_verification_flow**](docs/V0alpha2Api.md#get_self_service_verification_flow) | **GET** /api/kratos/public/self-service/verification/flows | Get Verification Flow
*V0alpha2Api* | [**get_web_authn_java_script**](docs/V0alpha2Api.md#get_web_authn_java_script) | **GET** /api/kratos/public/.well-known/ory/webauthn.js | Get WebAuthn JavaScript
*V0alpha2Api* | [**initialize_self_service_login_flow_for_browsers**](docs/V0alpha2Api.md#initialize_self_service_login_flow_for_browsers) | **GET** /api/kratos/public/self-service/login/browser | Initialize Login Flow for Browsers
*V0alpha2Api* | [**initialize_self_service_login_flow_without_browser**](docs/V0alpha2Api.md#initialize_self_service_login_flow_without_browser) | **GET** /api/kratos/public/self-service/login/api | Initialize Login Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initialize_self_service_recovery_flow_for_browsers**](docs/V0alpha2Api.md#initialize_self_service_recovery_flow_for_browsers) | **GET** /api/kratos/public/self-service/recovery/browser | Initialize Recovery Flow for Browsers
*V0alpha2Api* | [**initialize_self_service_recovery_flow_without_browser**](docs/V0alpha2Api.md#initialize_self_service_recovery_flow_without_browser) | **GET** /api/kratos/public/self-service/recovery/api | Initialize Recovery Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initialize_self_service_registration_flow_for_browsers**](docs/V0alpha2Api.md#initialize_self_service_registration_flow_for_browsers) | **GET** /api/kratos/public/self-service/registration/browser | Initialize Registration Flow for Browsers
*V0alpha2Api* | [**initialize_self_service_registration_flow_without_browser**](docs/V0alpha2Api.md#initialize_self_service_registration_flow_without_browser) | **GET** /api/kratos/public/self-service/registration/api | Initialize Registration Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initialize_self_service_settings_flow_for_browsers**](docs/V0alpha2Api.md#initialize_self_service_settings_flow_for_browsers) | **GET** /api/kratos/public/self-service/settings/browser | Initialize Settings Flow for Browsers
*V0alpha2Api* | [**initialize_self_service_settings_flow_without_browser**](docs/V0alpha2Api.md#initialize_self_service_settings_flow_without_browser) | **GET** /api/kratos/public/self-service/settings/api | Initialize Settings Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initialize_self_service_verification_flow_for_browsers**](docs/V0alpha2Api.md#initialize_self_service_verification_flow_for_browsers) | **GET** /api/kratos/public/self-service/verification/browser | Initialize Verification Flow for Browser Clients
*V0alpha2Api* | [**initialize_self_service_verification_flow_without_browser**](docs/V0alpha2Api.md#initialize_self_service_verification_flow_without_browser) | **GET** /api/kratos/public/self-service/verification/api | Initialize Verification Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**list_identity_schemas**](docs/V0alpha2Api.md#list_identity_schemas) | **GET** /api/kratos/public/schemas | 
*V0alpha2Api* | [**submit_self_service_login_flow**](docs/V0alpha2Api.md#submit_self_service_login_flow) | **POST** /api/kratos/public/self-service/login | Submit a Login Flow
*V0alpha2Api* | [**submit_self_service_logout_flow**](docs/V0alpha2Api.md#submit_self_service_logout_flow) | **GET** /api/kratos/public/self-service/logout | Complete Self-Service Logout
*V0alpha2Api* | [**submit_self_service_logout_flow_without_browser**](docs/V0alpha2Api.md#submit_self_service_logout_flow_without_browser) | **DELETE** /api/kratos/public/self-service/logout/api | Perform Logout for APIs, Services, Apps, ...
*V0alpha2Api* | [**submit_self_service_recovery_flow**](docs/V0alpha2Api.md#submit_self_service_recovery_flow) | **POST** /api/kratos/public/self-service/recovery | Complete Recovery Flow
*V0alpha2Api* | [**submit_self_service_registration_flow**](docs/V0alpha2Api.md#submit_self_service_registration_flow) | **POST** /api/kratos/public/self-service/registration | Submit a Registration Flow
*V0alpha2Api* | [**submit_self_service_settings_flow**](docs/V0alpha2Api.md#submit_self_service_settings_flow) | **POST** /api/kratos/public/self-service/settings | Complete Settings Flow
*V0alpha2Api* | [**submit_self_service_verification_flow**](docs/V0alpha2Api.md#submit_self_service_verification_flow) | **POST** /api/kratos/public/self-service/verification | Complete Verification Flow
*V0alpha2Api* | [**to_session**](docs/V0alpha2Api.md#to_session) | **GET** /api/kratos/public/sessions/whoami | Check Who the Current HTTP Session Belongs To


## Documentation For Models

 - [ActiveProject](docs/ActiveProject.md)
 - [AdminCreateIdentityBody](docs/AdminCreateIdentityBody.md)
 - [AdminCreateSelfServiceRecoveryLinkBody](docs/AdminCreateSelfServiceRecoveryLinkBody.md)
 - [AdminUpdateIdentityBody](docs/AdminUpdateIdentityBody.md)
 - [ApiToken](docs/ApiToken.md)
 - [ApiTokens](docs/ApiTokens.md)
 - [AuthenticatorAssuranceLevel](docs/AuthenticatorAssuranceLevel.md)
 - [CnameSettings](docs/CnameSettings.md)
 - [CreateCustomHostnameBody](docs/CreateCustomHostnameBody.md)
 - [ErrorAuthenticatorAssuranceLevelNotSatisfied](docs/ErrorAuthenticatorAssuranceLevelNotSatisfied.md)
 - [GenericError](docs/GenericError.md)
 - [HealthNotReadyStatus](docs/HealthNotReadyStatus.md)
 - [HealthStatus](docs/HealthStatus.md)
 - [Identity](docs/Identity.md)
 - [IdentityCredentials](docs/IdentityCredentials.md)
 - [IdentityCredentialsType](docs/IdentityCredentialsType.md)
 - [IdentityList](docs/IdentityList.md)
 - [IdentityPreset](docs/IdentityPreset.md)
 - [IdentityPresets](docs/IdentityPresets.md)
 - [IdentitySchema](docs/IdentitySchema.md)
 - [IdentitySchemaLocation](docs/IdentitySchemaLocation.md)
 - [IdentitySchemaValidationResult](docs/IdentitySchemaValidationResult.md)
 - [IdentitySchemas](docs/IdentitySchemas.md)
 - [IdentityState](docs/IdentityState.md)
 - [InlineResponse200](docs/InlineResponse200.md)
 - [InlineResponse2001](docs/InlineResponse2001.md)
 - [InlineResponse503](docs/InlineResponse503.md)
 - [IsOwnerForProjectBySlug](docs/IsOwnerForProjectBySlug.md)
 - [IsOwnerForProjectBySlugPayload](docs/IsOwnerForProjectBySlugPayload.md)
 - [JsonError](docs/JsonError.md)
 - [ListCustomHostnamesResponse](docs/ListCustomHostnamesResponse.md)
 - [NeedsPrivilegedSessionError](docs/NeedsPrivilegedSessionError.md)
 - [NullString](docs/NullString.md)
 - [NullUUID](docs/NullUUID.md)
 - [Project](docs/Project.md)
 - [ProjectHost](docs/ProjectHost.md)
 - [ProjectLookupSecretConfig](docs/ProjectLookupSecretConfig.md)
 - [ProjectOidcConfig](docs/ProjectOidcConfig.md)
 - [ProjectOidcConfigs](docs/ProjectOidcConfigs.md)
 - [ProjectPasswordConfig](docs/ProjectPasswordConfig.md)
 - [ProjectPatch](docs/ProjectPatch.md)
 - [ProjectRecoveryConfig](docs/ProjectRecoveryConfig.md)
 - [ProjectRevision](docs/ProjectRevision.md)
 - [ProjectRevisions](docs/ProjectRevisions.md)
 - [ProjectSlug](docs/ProjectSlug.md)
 - [ProjectTotpConfig](docs/ProjectTotpConfig.md)
 - [ProjectVerificationConfig](docs/ProjectVerificationConfig.md)
 - [ProjectWebAuthnConfig](docs/ProjectWebAuthnConfig.md)
 - [Projects](docs/Projects.md)
 - [ProvisionProjectPayload](docs/ProvisionProjectPayload.md)
 - [RecoveryAddress](docs/RecoveryAddress.md)
 - [RedirectionConfig](docs/RedirectionConfig.md)
 - [RedirectionField](docs/RedirectionField.md)
 - [SchemaPatch](docs/SchemaPatch.md)
 - [SelfServiceBrowserLocationChangeRequiredError](docs/SelfServiceBrowserLocationChangeRequiredError.md)
 - [SelfServiceError](docs/SelfServiceError.md)
 - [SelfServiceFlowExpiredError](docs/SelfServiceFlowExpiredError.md)
 - [SelfServiceLoginFlow](docs/SelfServiceLoginFlow.md)
 - [SelfServiceLogoutUrl](docs/SelfServiceLogoutUrl.md)
 - [SelfServiceRecoveryFlow](docs/SelfServiceRecoveryFlow.md)
 - [SelfServiceRecoveryFlowState](docs/SelfServiceRecoveryFlowState.md)
 - [SelfServiceRecoveryLink](docs/SelfServiceRecoveryLink.md)
 - [SelfServiceRegistrationFlow](docs/SelfServiceRegistrationFlow.md)
 - [SelfServiceSettingsFlow](docs/SelfServiceSettingsFlow.md)
 - [SelfServiceSettingsFlowState](docs/SelfServiceSettingsFlowState.md)
 - [SelfServiceVerificationFlow](docs/SelfServiceVerificationFlow.md)
 - [SelfServiceVerificationFlowState](docs/SelfServiceVerificationFlowState.md)
 - [Session](docs/Session.md)
 - [SessionAuthenticationMethod](docs/SessionAuthenticationMethod.md)
 - [SessionAuthenticationMethods](docs/SessionAuthenticationMethods.md)
 - [SessionDevice](docs/SessionDevice.md)
 - [SettingsProfileFormConfig](docs/SettingsProfileFormConfig.md)
 - [StringSlicePipeDelimiter](docs/StringSlicePipeDelimiter.md)
 - [StripeCustomerResponse](docs/StripeCustomerResponse.md)
 - [SubmitSelfServiceLoginFlowBody](docs/SubmitSelfServiceLoginFlowBody.md)
 - [SubmitSelfServiceLoginFlowWithLookupSecretMethodBody](docs/SubmitSelfServiceLoginFlowWithLookupSecretMethodBody.md)
 - [SubmitSelfServiceLoginFlowWithOidcMethodBody](docs/SubmitSelfServiceLoginFlowWithOidcMethodBody.md)
 - [SubmitSelfServiceLoginFlowWithPasswordMethodBody](docs/SubmitSelfServiceLoginFlowWithPasswordMethodBody.md)
 - [SubmitSelfServiceLoginFlowWithTotpMethodBody](docs/SubmitSelfServiceLoginFlowWithTotpMethodBody.md)
 - [SubmitSelfServiceLoginFlowWithWebAuthnMethodBody](docs/SubmitSelfServiceLoginFlowWithWebAuthnMethodBody.md)
 - [SubmitSelfServiceLogoutFlowWithoutBrowserBody](docs/SubmitSelfServiceLogoutFlowWithoutBrowserBody.md)
 - [SubmitSelfServiceRecoveryFlowBody](docs/SubmitSelfServiceRecoveryFlowBody.md)
 - [SubmitSelfServiceRecoveryFlowWithLinkMethodBody](docs/SubmitSelfServiceRecoveryFlowWithLinkMethodBody.md)
 - [SubmitSelfServiceRegistrationFlowBody](docs/SubmitSelfServiceRegistrationFlowBody.md)
 - [SubmitSelfServiceRegistrationFlowWithOidcMethodBody](docs/SubmitSelfServiceRegistrationFlowWithOidcMethodBody.md)
 - [SubmitSelfServiceRegistrationFlowWithPasswordMethodBody](docs/SubmitSelfServiceRegistrationFlowWithPasswordMethodBody.md)
 - [SubmitSelfServiceSettingsFlowBody](docs/SubmitSelfServiceSettingsFlowBody.md)
 - [SubmitSelfServiceSettingsFlowWithLookupMethodBody](docs/SubmitSelfServiceSettingsFlowWithLookupMethodBody.md)
 - [SubmitSelfServiceSettingsFlowWithOidcMethodBody](docs/SubmitSelfServiceSettingsFlowWithOidcMethodBody.md)
 - [SubmitSelfServiceSettingsFlowWithPasswordMethodBody](docs/SubmitSelfServiceSettingsFlowWithPasswordMethodBody.md)
 - [SubmitSelfServiceSettingsFlowWithProfileMethodBody](docs/SubmitSelfServiceSettingsFlowWithProfileMethodBody.md)
 - [SubmitSelfServiceSettingsFlowWithTotpMethodBody](docs/SubmitSelfServiceSettingsFlowWithTotpMethodBody.md)
 - [SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody](docs/SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody.md)
 - [SubmitSelfServiceVerificationFlowBody](docs/SubmitSelfServiceVerificationFlowBody.md)
 - [SubmitSelfServiceVerificationFlowWithLinkMethodBody](docs/SubmitSelfServiceVerificationFlowWithLinkMethodBody.md)
 - [SuccessfulSelfServiceLoginWithoutBrowser](docs/SuccessfulSelfServiceLoginWithoutBrowser.md)
 - [SuccessfulSelfServiceRegistrationWithoutBrowser](docs/SuccessfulSelfServiceRegistrationWithoutBrowser.md)
 - [UiContainer](docs/UiContainer.md)
 - [UiNode](docs/UiNode.md)
 - [UiNodeAnchorAttributes](docs/UiNodeAnchorAttributes.md)
 - [UiNodeAttributes](docs/UiNodeAttributes.md)
 - [UiNodeImageAttributes](docs/UiNodeImageAttributes.md)
 - [UiNodeInputAttributes](docs/UiNodeInputAttributes.md)
 - [UiNodeMeta](docs/UiNodeMeta.md)
 - [UiNodeScriptAttributes](docs/UiNodeScriptAttributes.md)
 - [UiNodeTextAttributes](docs/UiNodeTextAttributes.md)
 - [UiNodes](docs/UiNodes.md)
 - [UiText](docs/UiText.md)
 - [UiTexts](docs/UiTexts.md)
 - [UpdateCustomHostnameBody](docs/UpdateCustomHostnameBody.md)
 - [VerifiableIdentityAddress](docs/VerifiableIdentityAddress.md)
 - [Version](docs/Version.md)


## Documentation For Authorization


## oryAccessToken

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header


## Author

support@ory.sh


## Notes for Large OpenAPI documents
If the OpenAPI document is large, imports in ory_client.apis and ory_client.models may fail with a
RecursionError indicating the maximum recursion limit has been exceeded. In that case, there are a couple of solutions:

Solution 1:
Use specific imports for apis and models like:
- `from ory_client.api.default_api import DefaultApi`
- `from ory_client.model.pet import Pet`

Solution 2:
Before importing the package, adjust the maximum recursion limit as shown below:
```
import sys
sys.setrecursionlimit(1500)
import ory_client
from ory_client.apis import *
from ory_client.models import *
```

