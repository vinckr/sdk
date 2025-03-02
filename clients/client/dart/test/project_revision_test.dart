//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//
// @dart=2.7

// ignore_for_file: unused_import

import 'package:ory_client/model/project_revision.dart';
import 'package:test/test.dart';

// tests for ProjectRevision
void main() {
  final instance = ProjectRevisionBuilder();
  // TODO add properties to the builder and call build()

  group(ProjectRevision, () {
    // The Project API URL  The URL where the Project's APIs are available.
    // String apiUrl
    test('to test the property `apiUrl`', () async {
      // TODO
    });

    // Your Application URL  The URL where your application is available. Your users will be redirected to this URL when they successfully complete a login, logout, verification, recovery, or registration flow.  More fine-grained redirection patterns are available for the individual flows.
    // String applicationUrl
    test('to test the property `applicationUrl`', () async {
      // TODO
    });

    // The Project's Revision Creation Date
    // DateTime createdAt
    test('to test the property `createdAt`', () async {
      // TODO
    });

    // Default Identity Schema URL  This represents your Ory Kratos Default Identity Schema. It is your identity's default schema. This allows setting custom fields such as \"address\", specifying whether you want to log in using email or a username, and more. For more information on this topic, please check out the identity documentation.  The value of this field can be either any \"https://\" URL - for example a file hosted at GitHub, or a `preset://`-prefixed string. Available profiles are:  profile://email profile://username
    // String defaultIdentitySchemaUrl
    test('to test the property `defaultIdentitySchemaUrl`', () async {
      // TODO
    });

    // Self-Service Error UI URL  Sets the UI URL for the error UI. If left empty, this will use Ory's hosted pages.
    // String errorUiUrl
    test('to test the property `errorUiUrl`', () async {
      // TODO
    });

    // BuiltList<String> hosts
    test('to test the property `hosts`', () async {
      // TODO
    });

    // String id
    test('to test the property `id`', () async {
      // TODO
    });

    // The Project's Kratos Config Version
    // String kratosConfigVersion
    test('to test the property `kratosConfigVersion`', () async {
      // TODO
    });

    // NullUUID kratosCustomSchemaId
    test('to test the property `kratosCustomSchemaId`', () async {
      // TODO
    });

    // Self-Service Login UI URL  Sets the UI URL for the login UI. If left empty, this will use Ory's hosted pages.
    // String loginUiUrl
    test('to test the property `loginUiUrl`', () async {
      // TODO
    });

    // ProjectLookupSecretConfig lookupSecret
    test('to test the property `lookupSecret`', () async {
      // TODO
    });

    // The project's name.
    // String name
    test('to test the property `name`', () async {
      // TODO
    });

    // BuiltList<ProjectOidcConfig> oidcProviders
    test('to test the property `oidcProviders`', () async {
      // TODO
    });

    // ProjectPasswordConfig password
    test('to test the property `password`', () async {
      // TODO
    });

    // String projectId
    test('to test the property `projectId`', () async {
      // TODO
    });

    // ProjectRecoveryConfig recovery
    test('to test the property `recovery`', () async {
      // TODO
    });

    // Self-Service Login UI URL  Sets the UI URL for the recovery UI. If left empty, this will use Ory's hosted pages.
    // String recoveryUiUrl
    test('to test the property `recoveryUiUrl`', () async {
      // TODO
    });

    // RedirectionConfig redirectionConfig
    test('to test the property `redirectionConfig`', () async {
      // TODO
    });

    // Self-Service Login UI URL  Sets the UI URL for the registration UI. If left empty, this will use Ory's hosted pages.
    // String registrationUiUrl
    test('to test the property `registrationUiUrl`', () async {
      // TODO
    });

    // Issue Session after Sign Up  If set to true, users will receive a session after they successfully signed up. Enabling this option allows account enumeration during registration flows. Read more: https://www.ory.sh/kratos/docs/self-service/flows/user-registration#successful-registration
    // bool sessionAfterSignUp
    test('to test the property `sessionAfterSignUp`', () async {
      // TODO
    });

    // Enable Soft 2FA for Login Sessions
    // bool sessionSoft2fa
    test('to test the property `sessionSoft2fa`', () async {
      // TODO
    });

    // Duration in Seconds of how long a Session is Privileged  Defines how long a session is considered privileged in seconds. If the session's authenticated_at is older than the value specified here, the user needs to re-authenticate to perform certain actions (e.g. password change).
    // int settingsPrivilegedSessionMaxAgeSeconds
    test('to test the property `settingsPrivilegedSessionMaxAgeSeconds`', () async {
      // TODO
    });

    // Enable Soft 2FA for Self-Service Settings Flows
    // bool settingsSoft2fa
    test('to test the property `settingsSoft2fa`', () async {
      // TODO
    });

    // Self-Service Settings UI URL  Sets the UI URL for the settings UI. If left empty, this will use Ory's hosted pages.
    // String settingsUiUrl
    test('to test the property `settingsUiUrl`', () async {
      // TODO
    });

    // ProjectTotpConfig totp
    test('to test the property `totp`', () async {
      // TODO
    });

    // Last Time Project's Revision was Updated
    // DateTime updatedAt
    test('to test the property `updatedAt`', () async {
      // TODO
    });

    // ProjectVerificationConfig verification
    test('to test the property `verification`', () async {
      // TODO
    });

    // Self-Service Login UI URL  Sets the UI URL for the verification UI. If left empty, this will use Ory's hosted pages.
    // String verificationUiUrl
    test('to test the property `verificationUiUrl`', () async {
      // TODO
    });

    // ProjectWebAuthnConfig webauthn
    test('to test the property `webauthn`', () async {
      // TODO
    });


  });

}
