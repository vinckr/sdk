/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.30
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// ActiveProject : The Active Project ID



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct ActiveProject {
    /// The Active Project ID  format: uuid
    #[serde(rename = "project_id", skip_serializing_if = "Option::is_none")]
    pub project_id: Option<String>,
}

impl ActiveProject {
    /// The Active Project ID
    pub fn new() -> ActiveProject {
        ActiveProject {
            project_id: None,
        }
    }
}


