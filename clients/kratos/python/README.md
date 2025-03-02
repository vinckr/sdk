# ory-kratos-client
Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs
are exposed on different ports. Public APIs can face the public internet without any protection
while administrative APIs should never be exposed without prior authorization. To protect
the administative API port you should use something like Nginx, Ory Oathkeeper, or any other
technology capable of authorizing incoming requests.


This Python package is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v0.8.0-alpha.2
- Package version: v0.8.0-alpha.2
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
import ory_kratos_client
```

### Setuptools

Install via [Setuptools](http://pypi.python.org/pypi/setuptools).

```sh
python setup.py install --user
```
(or `sudo python setup.py install` to install the package for all users)

Then import the package:
```python
import ory_kratos_client
```

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

```python

import time
import ory_kratos_client
from pprint import pprint
from ory_kratos_client.api import metadata_api
from ory_kratos_client.model.generic_error import GenericError
from ory_kratos_client.model.inline_response200 import InlineResponse200
from ory_kratos_client.model.inline_response2001 import InlineResponse2001
from ory_kratos_client.model.inline_response503 import InlineResponse503
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ory_kratos_client.Configuration(
    host = "http://localhost"
)



# Enter a context with an instance of the API client
with ory_kratos_client.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = metadata_api.MetadataApi(api_client)
    
    try:
        # Return Running Software Version.
        api_response = api_instance.get_version()
        pprint(api_response)
    except ory_kratos_client.ApiException as e:
        print("Exception when calling MetadataApi->get_version: %s\n" % e)
```

## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*MetadataApi* | [**get_version**](docs/MetadataApi.md#get_version) | **GET** /version | Return Running Software Version.
*MetadataApi* | [**is_alive**](docs/MetadataApi.md#is_alive) | **GET** /health/alive | Check HTTP Server Status
*MetadataApi* | [**is_ready**](docs/MetadataApi.md#is_ready) | **GET** /health/ready | Check HTTP Server and Database Status
*V0alpha2Api* | [**admin_create_identity**](docs/V0alpha2Api.md#admin_create_identity) | **POST** /identities | Create an Identity
*V0alpha2Api* | [**admin_create_self_service_recovery_link**](docs/V0alpha2Api.md#admin_create_self_service_recovery_link) | **POST** /recovery/link | Create a Recovery Link
*V0alpha2Api* | [**admin_delete_identity**](docs/V0alpha2Api.md#admin_delete_identity) | **DELETE** /identities/{id} | Delete an Identity
*V0alpha2Api* | [**admin_delete_identity_sessions**](docs/V0alpha2Api.md#admin_delete_identity_sessions) | **DELETE** /identities/{id}/sessions | Calling this endpoint irrecoverably and permanently deletes and invalidates all sessions that belong to the given Identity.
*V0alpha2Api* | [**admin_get_identity**](docs/V0alpha2Api.md#admin_get_identity) | **GET** /identities/{id} | Get an Identity
*V0alpha2Api* | [**admin_list_identities**](docs/V0alpha2Api.md#admin_list_identities) | **GET** /identities | List Identities
*V0alpha2Api* | [**admin_update_identity**](docs/V0alpha2Api.md#admin_update_identity) | **PUT** /identities/{id} | Update an Identity
*V0alpha2Api* | [**create_self_service_logout_flow_url_for_browsers**](docs/V0alpha2Api.md#create_self_service_logout_flow_url_for_browsers) | **GET** /self-service/logout/browser | Create a Logout URL for Browsers
*V0alpha2Api* | [**get_json_schema**](docs/V0alpha2Api.md#get_json_schema) | **GET** /schemas/{id} | 
*V0alpha2Api* | [**get_self_service_error**](docs/V0alpha2Api.md#get_self_service_error) | **GET** /self-service/errors | Get Self-Service Errors
*V0alpha2Api* | [**get_self_service_login_flow**](docs/V0alpha2Api.md#get_self_service_login_flow) | **GET** /self-service/login/flows | Get Login Flow
*V0alpha2Api* | [**get_self_service_recovery_flow**](docs/V0alpha2Api.md#get_self_service_recovery_flow) | **GET** /self-service/recovery/flows | Get Recovery Flow
*V0alpha2Api* | [**get_self_service_registration_flow**](docs/V0alpha2Api.md#get_self_service_registration_flow) | **GET** /self-service/registration/flows | Get Registration Flow
*V0alpha2Api* | [**get_self_service_settings_flow**](docs/V0alpha2Api.md#get_self_service_settings_flow) | **GET** /self-service/settings/flows | Get Settings Flow
*V0alpha2Api* | [**get_self_service_verification_flow**](docs/V0alpha2Api.md#get_self_service_verification_flow) | **GET** /self-service/verification/flows | Get Verification Flow
*V0alpha2Api* | [**get_web_authn_java_script**](docs/V0alpha2Api.md#get_web_authn_java_script) | **GET** /.well-known/ory/webauthn.js | Get WebAuthn JavaScript
*V0alpha2Api* | [**initialize_self_service_login_flow_for_browsers**](docs/V0alpha2Api.md#initialize_self_service_login_flow_for_browsers) | **GET** /self-service/login/browser | Initialize Login Flow for Browsers
*V0alpha2Api* | [**initialize_self_service_login_flow_without_browser**](docs/V0alpha2Api.md#initialize_self_service_login_flow_without_browser) | **GET** /self-service/login/api | Initialize Login Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initialize_self_service_recovery_flow_for_browsers**](docs/V0alpha2Api.md#initialize_self_service_recovery_flow_for_browsers) | **GET** /self-service/recovery/browser | Initialize Recovery Flow for Browsers
*V0alpha2Api* | [**initialize_self_service_recovery_flow_without_browser**](docs/V0alpha2Api.md#initialize_self_service_recovery_flow_without_browser) | **GET** /self-service/recovery/api | Initialize Recovery Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initialize_self_service_registration_flow_for_browsers**](docs/V0alpha2Api.md#initialize_self_service_registration_flow_for_browsers) | **GET** /self-service/registration/browser | Initialize Registration Flow for Browsers
*V0alpha2Api* | [**initialize_self_service_registration_flow_without_browser**](docs/V0alpha2Api.md#initialize_self_service_registration_flow_without_browser) | **GET** /self-service/registration/api | Initialize Registration Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initialize_self_service_settings_flow_for_browsers**](docs/V0alpha2Api.md#initialize_self_service_settings_flow_for_browsers) | **GET** /self-service/settings/browser | Initialize Settings Flow for Browsers
*V0alpha2Api* | [**initialize_self_service_settings_flow_without_browser**](docs/V0alpha2Api.md#initialize_self_service_settings_flow_without_browser) | **GET** /self-service/settings/api | Initialize Settings Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initialize_self_service_verification_flow_for_browsers**](docs/V0alpha2Api.md#initialize_self_service_verification_flow_for_browsers) | **GET** /self-service/verification/browser | Initialize Verification Flow for Browser Clients
*V0alpha2Api* | [**initialize_self_service_verification_flow_without_browser**](docs/V0alpha2Api.md#initialize_self_service_verification_flow_without_browser) | **GET** /self-service/verification/api | Initialize Verification Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**list_identity_schemas**](docs/V0alpha2Api.md#list_identity_schemas) | **GET** /schemas | 
*V0alpha2Api* | [**submit_self_service_login_flow**](docs/V0alpha2Api.md#submit_self_service_login_flow) | **POST** /self-service/login | Submit a Login Flow
*V0alpha2Api* | [**submit_self_service_logout_flow**](docs/V0alpha2Api.md#submit_self_service_logout_flow) | **GET** /self-service/logout | Complete Self-Service Logout
*V0alpha2Api* | [**submit_self_service_logout_flow_without_browser**](docs/V0alpha2Api.md#submit_self_service_logout_flow_without_browser) | **DELETE** /self-service/logout/api | Perform Logout for APIs, Services, Apps, ...
*V0alpha2Api* | [**submit_self_service_recovery_flow**](docs/V0alpha2Api.md#submit_self_service_recovery_flow) | **POST** /self-service/recovery | Complete Recovery Flow
*V0alpha2Api* | [**submit_self_service_registration_flow**](docs/V0alpha2Api.md#submit_self_service_registration_flow) | **POST** /self-service/registration | Submit a Registration Flow
*V0alpha2Api* | [**submit_self_service_settings_flow**](docs/V0alpha2Api.md#submit_self_service_settings_flow) | **POST** /self-service/settings | Complete Settings Flow
*V0alpha2Api* | [**submit_self_service_verification_flow**](docs/V0alpha2Api.md#submit_self_service_verification_flow) | **POST** /self-service/verification | Complete Verification Flow
*V0alpha2Api* | [**to_session**](docs/V0alpha2Api.md#to_session) | **GET** /sessions/whoami | Check Who the Current HTTP Session Belongs To


## Documentation For Models

 - [AdminCreateIdentityBody](docs/AdminCreateIdentityBody.md)
 - [AdminCreateSelfServiceRecoveryLinkBody](docs/AdminCreateSelfServiceRecoveryLinkBody.md)
 - [AdminUpdateIdentityBody](docs/AdminUpdateIdentityBody.md)
 - [AuthenticatorAssuranceLevel](docs/AuthenticatorAssuranceLevel.md)
 - [ErrorAuthenticatorAssuranceLevelNotSatisfied](docs/ErrorAuthenticatorAssuranceLevelNotSatisfied.md)
 - [GenericError](docs/GenericError.md)
 - [HealthNotReadyStatus](docs/HealthNotReadyStatus.md)
 - [HealthStatus](docs/HealthStatus.md)
 - [Identity](docs/Identity.md)
 - [IdentityCredentials](docs/IdentityCredentials.md)
 - [IdentityCredentialsType](docs/IdentityCredentialsType.md)
 - [IdentityList](docs/IdentityList.md)
 - [IdentitySchema](docs/IdentitySchema.md)
 - [IdentitySchemas](docs/IdentitySchemas.md)
 - [IdentityState](docs/IdentityState.md)
 - [InlineResponse200](docs/InlineResponse200.md)
 - [InlineResponse2001](docs/InlineResponse2001.md)
 - [InlineResponse503](docs/InlineResponse503.md)
 - [JsonError](docs/JsonError.md)
 - [NeedsPrivilegedSessionError](docs/NeedsPrivilegedSessionError.md)
 - [RecoveryAddress](docs/RecoveryAddress.md)
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
 - [VerifiableIdentityAddress](docs/VerifiableIdentityAddress.md)
 - [Version](docs/Version.md)


## Documentation For Authorization


## oryAccessToken

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header


## Author

hi@ory.sh


## Notes for Large OpenAPI documents
If the OpenAPI document is large, imports in ory_kratos_client.apis and ory_kratos_client.models may fail with a
RecursionError indicating the maximum recursion limit has been exceeded. In that case, there are a couple of solutions:

Solution 1:
Use specific imports for apis and models like:
- `from ory_kratos_client.api.default_api import DefaultApi`
- `from ory_kratos_client.model.pet import Pet`

Solution 2:
Before importing the package, adjust the maximum recursion limit as shown below:
```
import sys
sys.setrecursionlimit(1500)
import ory_kratos_client
from ory_kratos_client.apis import *
from ory_kratos_client.models import *
```

