/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * API version: v0.0.1-alpha.30
 * Contact: support@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// ProjectVerificationConfig struct for ProjectVerificationConfig
type ProjectVerificationConfig struct {
	// Set to true to enable email / phone verification.
	Enabled *bool `json:"enabled,omitempty"`
	// Set to true to only allow users with a verified address to sign in.
	RequireVerifiedAddress *bool `json:"require_verified_address,omitempty"`
}

// NewProjectVerificationConfig instantiates a new ProjectVerificationConfig object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewProjectVerificationConfig() *ProjectVerificationConfig {
	this := ProjectVerificationConfig{}
	return &this
}

// NewProjectVerificationConfigWithDefaults instantiates a new ProjectVerificationConfig object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewProjectVerificationConfigWithDefaults() *ProjectVerificationConfig {
	this := ProjectVerificationConfig{}
	return &this
}

// GetEnabled returns the Enabled field value if set, zero value otherwise.
func (o *ProjectVerificationConfig) GetEnabled() bool {
	if o == nil || o.Enabled == nil {
		var ret bool
		return ret
	}
	return *o.Enabled
}

// GetEnabledOk returns a tuple with the Enabled field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectVerificationConfig) GetEnabledOk() (*bool, bool) {
	if o == nil || o.Enabled == nil {
		return nil, false
	}
	return o.Enabled, true
}

// HasEnabled returns a boolean if a field has been set.
func (o *ProjectVerificationConfig) HasEnabled() bool {
	if o != nil && o.Enabled != nil {
		return true
	}

	return false
}

// SetEnabled gets a reference to the given bool and assigns it to the Enabled field.
func (o *ProjectVerificationConfig) SetEnabled(v bool) {
	o.Enabled = &v
}

// GetRequireVerifiedAddress returns the RequireVerifiedAddress field value if set, zero value otherwise.
func (o *ProjectVerificationConfig) GetRequireVerifiedAddress() bool {
	if o == nil || o.RequireVerifiedAddress == nil {
		var ret bool
		return ret
	}
	return *o.RequireVerifiedAddress
}

// GetRequireVerifiedAddressOk returns a tuple with the RequireVerifiedAddress field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectVerificationConfig) GetRequireVerifiedAddressOk() (*bool, bool) {
	if o == nil || o.RequireVerifiedAddress == nil {
		return nil, false
	}
	return o.RequireVerifiedAddress, true
}

// HasRequireVerifiedAddress returns a boolean if a field has been set.
func (o *ProjectVerificationConfig) HasRequireVerifiedAddress() bool {
	if o != nil && o.RequireVerifiedAddress != nil {
		return true
	}

	return false
}

// SetRequireVerifiedAddress gets a reference to the given bool and assigns it to the RequireVerifiedAddress field.
func (o *ProjectVerificationConfig) SetRequireVerifiedAddress(v bool) {
	o.RequireVerifiedAddress = &v
}

func (o ProjectVerificationConfig) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.Enabled != nil {
		toSerialize["enabled"] = o.Enabled
	}
	if o.RequireVerifiedAddress != nil {
		toSerialize["require_verified_address"] = o.RequireVerifiedAddress
	}
	return json.Marshal(toSerialize)
}

type NullableProjectVerificationConfig struct {
	value *ProjectVerificationConfig
	isSet bool
}

func (v NullableProjectVerificationConfig) Get() *ProjectVerificationConfig {
	return v.value
}

func (v *NullableProjectVerificationConfig) Set(val *ProjectVerificationConfig) {
	v.value = val
	v.isSet = true
}

func (v NullableProjectVerificationConfig) IsSet() bool {
	return v.isSet
}

func (v *NullableProjectVerificationConfig) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableProjectVerificationConfig(val *ProjectVerificationConfig) *NullableProjectVerificationConfig {
	return &NullableProjectVerificationConfig{value: val, isSet: true}
}

func (v NullableProjectVerificationConfig) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableProjectVerificationConfig) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


