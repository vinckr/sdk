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
pub struct ApiToken {
    #[serde(rename = "id")]
    pub id: String,
    /// The Token's Name  Set this to help you remember, for example, where you use the token.
    #[serde(rename = "name")]
    pub name: String,
    #[serde(rename = "owner_id")]
    pub owner_id: String,
    #[serde(rename = "project_id", skip_serializing_if = "Option::is_none")]
    pub project_id: Option<String>,
    /// The token's value
    #[serde(rename = "value", skip_serializing_if = "Option::is_none")]
    pub value: Option<String>,
}

impl ApiToken {
    pub fn new(id: String, name: String, owner_id: String) -> ApiToken {
        ApiToken {
            id,
            name,
            owner_id,
            project_id: None,
            value: None,
        }
    }
}


