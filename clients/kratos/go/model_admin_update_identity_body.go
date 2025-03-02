/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * API version: v0.8.0-alpha.2
 * Contact: hi@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// AdminUpdateIdentityBody struct for AdminUpdateIdentityBody
type AdminUpdateIdentityBody struct {
	// SchemaID is the ID of the JSON Schema to be used for validating the identity's traits. If set will update the Identity's SchemaID.
	SchemaId *string `json:"schema_id,omitempty"`
	State IdentityState `json:"state"`
	// Traits represent an identity's traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in `schema_id`.
	Traits map[string]interface{} `json:"traits"`
}

// NewAdminUpdateIdentityBody instantiates a new AdminUpdateIdentityBody object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewAdminUpdateIdentityBody(state IdentityState, traits map[string]interface{}) *AdminUpdateIdentityBody {
	this := AdminUpdateIdentityBody{}
	this.State = state
	this.Traits = traits
	return &this
}

// NewAdminUpdateIdentityBodyWithDefaults instantiates a new AdminUpdateIdentityBody object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewAdminUpdateIdentityBodyWithDefaults() *AdminUpdateIdentityBody {
	this := AdminUpdateIdentityBody{}
	return &this
}

// GetSchemaId returns the SchemaId field value if set, zero value otherwise.
func (o *AdminUpdateIdentityBody) GetSchemaId() string {
	if o == nil || o.SchemaId == nil {
		var ret string
		return ret
	}
	return *o.SchemaId
}

// GetSchemaIdOk returns a tuple with the SchemaId field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *AdminUpdateIdentityBody) GetSchemaIdOk() (*string, bool) {
	if o == nil || o.SchemaId == nil {
		return nil, false
	}
	return o.SchemaId, true
}

// HasSchemaId returns a boolean if a field has been set.
func (o *AdminUpdateIdentityBody) HasSchemaId() bool {
	if o != nil && o.SchemaId != nil {
		return true
	}

	return false
}

// SetSchemaId gets a reference to the given string and assigns it to the SchemaId field.
func (o *AdminUpdateIdentityBody) SetSchemaId(v string) {
	o.SchemaId = &v
}

// GetState returns the State field value
func (o *AdminUpdateIdentityBody) GetState() IdentityState {
	if o == nil {
		var ret IdentityState
		return ret
	}

	return o.State
}

// GetStateOk returns a tuple with the State field value
// and a boolean to check if the value has been set.
func (o *AdminUpdateIdentityBody) GetStateOk() (*IdentityState, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.State, true
}

// SetState sets field value
func (o *AdminUpdateIdentityBody) SetState(v IdentityState) {
	o.State = v
}

// GetTraits returns the Traits field value
func (o *AdminUpdateIdentityBody) GetTraits() map[string]interface{} {
	if o == nil {
		var ret map[string]interface{}
		return ret
	}

	return o.Traits
}

// GetTraitsOk returns a tuple with the Traits field value
// and a boolean to check if the value has been set.
func (o *AdminUpdateIdentityBody) GetTraitsOk() (map[string]interface{}, bool) {
	if o == nil  {
		return nil, false
	}
	return o.Traits, true
}

// SetTraits sets field value
func (o *AdminUpdateIdentityBody) SetTraits(v map[string]interface{}) {
	o.Traits = v
}

func (o AdminUpdateIdentityBody) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.SchemaId != nil {
		toSerialize["schema_id"] = o.SchemaId
	}
	if true {
		toSerialize["state"] = o.State
	}
	if true {
		toSerialize["traits"] = o.Traits
	}
	return json.Marshal(toSerialize)
}

type NullableAdminUpdateIdentityBody struct {
	value *AdminUpdateIdentityBody
	isSet bool
}

func (v NullableAdminUpdateIdentityBody) Get() *AdminUpdateIdentityBody {
	return v.value
}

func (v *NullableAdminUpdateIdentityBody) Set(val *AdminUpdateIdentityBody) {
	v.value = val
	v.isSet = true
}

func (v NullableAdminUpdateIdentityBody) IsSet() bool {
	return v.isSet
}

func (v *NullableAdminUpdateIdentityBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableAdminUpdateIdentityBody(val *AdminUpdateIdentityBody) *NullableAdminUpdateIdentityBody {
	return &NullableAdminUpdateIdentityBody{value: val, isSet: true}
}

func (v NullableAdminUpdateIdentityBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableAdminUpdateIdentityBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


