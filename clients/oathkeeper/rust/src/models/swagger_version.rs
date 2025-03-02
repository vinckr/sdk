/*
 * ORY Oathkeeper
 *
 * ORY Oathkeeper is a reverse proxy that checks the HTTP Authorization for validity against a set of rules. This service uses Hydra to validate access tokens and policies.
 *
 * The version of the OpenAPI document: v0.0.0-alpha.62
 * Contact: hi@ory.am
 * Generated by: https://openapi-generator.tech
 */

/// SwaggerVersion : SwaggerVersion swagger version



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct SwaggerVersion {
    /// Version is the service's version.
    #[serde(rename = "version", skip_serializing_if = "Option::is_none")]
    pub version: Option<String>,
}

impl SwaggerVersion {
    /// SwaggerVersion swagger version
    pub fn new() -> SwaggerVersion {
        SwaggerVersion {
            version: None,
        }
    }
}


