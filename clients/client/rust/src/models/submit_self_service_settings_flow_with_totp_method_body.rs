/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.30
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct SubmitSelfServiceSettingsFlowWithTotpMethodBody {
    /// CSRFToken is the anti-CSRF token
    #[serde(rename = "csrf_token", skip_serializing_if = "Option::is_none")]
    pub csrf_token: Option<String>,
    /// Method  Should be set to \"totp\" when trying to add, update, or remove a totp pairing.
    #[serde(rename = "method")]
    pub method: String,
    /// ValidationTOTP must contain a valid TOTP based on the
    #[serde(rename = "totp_code", skip_serializing_if = "Option::is_none")]
    pub totp_code: Option<String>,
    /// UnlinkTOTP if true will remove the TOTP pairing, effectively removing the credential. This can be used to set up a new TOTP device.
    #[serde(rename = "totp_unlink", skip_serializing_if = "Option::is_none")]
    pub totp_unlink: Option<bool>,
}

impl SubmitSelfServiceSettingsFlowWithTotpMethodBody {
    pub fn new(method: String) -> SubmitSelfServiceSettingsFlowWithTotpMethodBody {
        SubmitSelfServiceSettingsFlowWithTotpMethodBody {
            csrf_token: None,
            method,
            totp_code: None,
            totp_unlink: None,
        }
    }
}


