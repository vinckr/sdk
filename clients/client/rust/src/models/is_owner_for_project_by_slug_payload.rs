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
pub struct IsOwnerForProjectBySlugPayload {
    /// ProjectScope is the project_id resolved from the API Token.
    #[serde(rename = "project_scope", skip_serializing_if = "Option::is_none")]
    pub project_scope: Option<String>,
    /// ProjectSlug is the project's slug.
    #[serde(rename = "project_slug")]
    pub project_slug: String,
    /// Subject is the subject from the API Token.
    #[serde(rename = "subject")]
    pub subject: String,
}

impl IsOwnerForProjectBySlugPayload {
    pub fn new(project_slug: String, subject: String) -> IsOwnerForProjectBySlugPayload {
        IsOwnerForProjectBySlugPayload {
            project_scope: None,
            project_slug,
            subject,
        }
    }
}


