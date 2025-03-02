/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.8.0-alpha.2
 * Contact: hi@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// JsonError : The standard Ory JSON API error format.



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct JsonError {
    #[serde(rename = "error")]
    pub error: Box<crate::models::GenericError>,
}

impl JsonError {
    /// The standard Ory JSON API error format.
    pub fn new(error: crate::models::GenericError) -> JsonError {
        JsonError {
            error: Box::new(error),
        }
    }
}


