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
pub struct ProjectVerificationConfig {
    /// Set to true to enable email / phone verification.
    #[serde(rename = "enabled", skip_serializing_if = "Option::is_none")]
    pub enabled: Option<bool>,
    /// Set to true to only allow users with a verified address to sign in.
    #[serde(rename = "require_verified_address", skip_serializing_if = "Option::is_none")]
    pub require_verified_address: Option<bool>,
}

impl ProjectVerificationConfig {
    pub fn new() -> ProjectVerificationConfig {
        ProjectVerificationConfig {
            enabled: None,
            require_verified_address: None,
        }
    }
}


