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
pub struct UiNodeImageAttributes {
    /// Height of the image
    #[serde(rename = "height", skip_serializing_if = "Option::is_none")]
    pub height: Option<i64>,
    /// A unique identifier
    #[serde(rename = "id")]
    pub id: String,
    #[serde(rename = "node_type")]
    pub node_type: String,
    /// The image's source URL.  format: uri
    #[serde(rename = "src")]
    pub src: String,
    /// Width of the image
    #[serde(rename = "width", skip_serializing_if = "Option::is_none")]
    pub width: Option<i64>,
}

impl UiNodeImageAttributes {
    pub fn new(id: String, node_type: String, src: String) -> UiNodeImageAttributes {
        UiNodeImageAttributes {
            height: None,
            id,
            node_type,
            src,
            width: None,
        }
    }
}


