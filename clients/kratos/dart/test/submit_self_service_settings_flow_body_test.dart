//
// AUTO-GENERATED FILE, DO NOT MODIFY!
//
// @dart=2.7

// ignore_for_file: unused_import

import 'package:ory_kratos_client/model/submit_self_service_settings_flow_body.dart';
import 'package:test/test.dart';

// tests for SubmitSelfServiceSettingsFlowBody
void main() {
  final instance = SubmitSelfServiceSettingsFlowBodyBuilder();
  // TODO add properties to the builder and call build()

  group(SubmitSelfServiceSettingsFlowBody, () {
    // CSRFToken is the anti-CSRF token
    // String csrfToken
    test('to test the property `csrfToken`', () async {
      // TODO
    });

    // Method  Should be set to \"totp\" when trying to add, update, or remove a totp pairing.
    // String method
    test('to test the property `method`', () async {
      // TODO
    });

    // Password is the updated password
    // String password
    test('to test the property `password`', () async {
      // TODO
    });

    // The identity's traits  in: body
    // JsonObject traits
    test('to test the property `traits`', () async {
      // TODO
    });

    // Flow ID is the flow's ID.  in: query
    // String flow
    test('to test the property `flow`', () async {
      // TODO
    });

    // Link this provider  Either this or `unlink` must be set.  type: string in: body
    // String link
    test('to test the property `link`', () async {
      // TODO
    });

    // Unlink this provider  Either this or `link` must be set.  type: string in: body
    // String unlink
    test('to test the property `unlink`', () async {
      // TODO
    });

    // ValidationTOTP must contain a valid TOTP based on the
    // String totpCode
    test('to test the property `totpCode`', () async {
      // TODO
    });

    // UnlinkTOTP if true will remove the TOTP pairing, effectively removing the credential. This can be used to set up a new TOTP device.
    // bool totpUnlink
    test('to test the property `totpUnlink`', () async {
      // TODO
    });


  });

}
