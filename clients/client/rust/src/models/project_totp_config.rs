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
pub struct ProjectTotpConfig {
    /// Set to true to enable the TOTP authentication method.
    #[serde(rename = "enabled", skip_serializing_if = "Option::is_none")]
    pub enabled: Option<bool>,
    /// The issuer is the name which will appear in the Authenticator app.
    #[serde(rename = "issuer", skip_serializing_if = "Option::is_none")]
    pub issuer: Option<String>,
}

impl ProjectTotpConfig {
    pub fn new() -> ProjectTotpConfig {
        ProjectTotpConfig {
            enabled: None,
            issuer: None,
        }
    }
}


