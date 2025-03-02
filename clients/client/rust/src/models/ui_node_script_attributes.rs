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
pub struct UiNodeScriptAttributes {
    /// The script async type
    #[serde(rename = "async")]
    pub _async: bool,
    /// The script cross origin policy
    #[serde(rename = "crossorigin")]
    pub crossorigin: String,
    /// A unique identifier
    #[serde(rename = "id")]
    pub id: String,
    /// The script's integrity hash
    #[serde(rename = "integrity")]
    pub integrity: String,
    #[serde(rename = "node_type")]
    pub node_type: String,
    /// The script referrer policy
    #[serde(rename = "referrerpolicy")]
    pub referrerpolicy: String,
    /// The script source
    #[serde(rename = "src")]
    pub src: String,
    /// The script MIME type
    #[serde(rename = "type")]
    pub _type: String,
}

impl UiNodeScriptAttributes {
    pub fn new(_async: bool, crossorigin: String, id: String, integrity: String, node_type: String, referrerpolicy: String, src: String, _type: String) -> UiNodeScriptAttributes {
        UiNodeScriptAttributes {
            _async,
            crossorigin,
            id,
            integrity,
            node_type,
            referrerpolicy,
            src,
            _type,
        }
    }
}


