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

// ProjectWebAuthnConfig struct for ProjectWebAuthnConfig
type ProjectWebAuthnConfig struct {
	// Set to true to enable the WebAuthn authentication method.
	Enabled *bool `json:"enabled,omitempty"`
	// The display name to show in the authenticator.
	RpDisplayName *string `json:"rp_display_name,omitempty"`
	// A URL to an icon which might be shown in the authenticator.
	RpIcon *string `json:"rp_icon,omitempty"`
	// This must be the hostname of the login page.
	RpId *string `json:"rp_id,omitempty"`
	// This must be the scheme://hostname of the login page.
	RpOrigin *string `json:"rp_origin,omitempty"`
}

// NewProjectWebAuthnConfig instantiates a new ProjectWebAuthnConfig object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewProjectWebAuthnConfig() *ProjectWebAuthnConfig {
	this := ProjectWebAuthnConfig{}
	return &this
}

// NewProjectWebAuthnConfigWithDefaults instantiates a new ProjectWebAuthnConfig object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewProjectWebAuthnConfigWithDefaults() *ProjectWebAuthnConfig {
	this := ProjectWebAuthnConfig{}
	return &this
}

// GetEnabled returns the Enabled field value if set, zero value otherwise.
func (o *ProjectWebAuthnConfig) GetEnabled() bool {
	if o == nil || o.Enabled == nil {
		var ret bool
		return ret
	}
	return *o.Enabled
}

// GetEnabledOk returns a tuple with the Enabled field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectWebAuthnConfig) GetEnabledOk() (*bool, bool) {
	if o == nil || o.Enabled == nil {
		return nil, false
	}
	return o.Enabled, true
}

// HasEnabled returns a boolean if a field has been set.
func (o *ProjectWebAuthnConfig) HasEnabled() bool {
	if o != nil && o.Enabled != nil {
		return true
	}

	return false
}

// SetEnabled gets a reference to the given bool and assigns it to the Enabled field.
func (o *ProjectWebAuthnConfig) SetEnabled(v bool) {
	o.Enabled = &v
}

// GetRpDisplayName returns the RpDisplayName field value if set, zero value otherwise.
func (o *ProjectWebAuthnConfig) GetRpDisplayName() string {
	if o == nil || o.RpDisplayName == nil {
		var ret string
		return ret
	}
	return *o.RpDisplayName
}

// GetRpDisplayNameOk returns a tuple with the RpDisplayName field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectWebAuthnConfig) GetRpDisplayNameOk() (*string, bool) {
	if o == nil || o.RpDisplayName == nil {
		return nil, false
	}
	return o.RpDisplayName, true
}

// HasRpDisplayName returns a boolean if a field has been set.
func (o *ProjectWebAuthnConfig) HasRpDisplayName() bool {
	if o != nil && o.RpDisplayName != nil {
		return true
	}

	return false
}

// SetRpDisplayName gets a reference to the given string and assigns it to the RpDisplayName field.
func (o *ProjectWebAuthnConfig) SetRpDisplayName(v string) {
	o.RpDisplayName = &v
}

// GetRpIcon returns the RpIcon field value if set, zero value otherwise.
func (o *ProjectWebAuthnConfig) GetRpIcon() string {
	if o == nil || o.RpIcon == nil {
		var ret string
		return ret
	}
	return *o.RpIcon
}

// GetRpIconOk returns a tuple with the RpIcon field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectWebAuthnConfig) GetRpIconOk() (*string, bool) {
	if o == nil || o.RpIcon == nil {
		return nil, false
	}
	return o.RpIcon, true
}

// HasRpIcon returns a boolean if a field has been set.
func (o *ProjectWebAuthnConfig) HasRpIcon() bool {
	if o != nil && o.RpIcon != nil {
		return true
	}

	return false
}

// SetRpIcon gets a reference to the given string and assigns it to the RpIcon field.
func (o *ProjectWebAuthnConfig) SetRpIcon(v string) {
	o.RpIcon = &v
}

// GetRpId returns the RpId field value if set, zero value otherwise.
func (o *ProjectWebAuthnConfig) GetRpId() string {
	if o == nil || o.RpId == nil {
		var ret string
		return ret
	}
	return *o.RpId
}

// GetRpIdOk returns a tuple with the RpId field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectWebAuthnConfig) GetRpIdOk() (*string, bool) {
	if o == nil || o.RpId == nil {
		return nil, false
	}
	return o.RpId, true
}

// HasRpId returns a boolean if a field has been set.
func (o *ProjectWebAuthnConfig) HasRpId() bool {
	if o != nil && o.RpId != nil {
		return true
	}

	return false
}

// SetRpId gets a reference to the given string and assigns it to the RpId field.
func (o *ProjectWebAuthnConfig) SetRpId(v string) {
	o.RpId = &v
}

// GetRpOrigin returns the RpOrigin field value if set, zero value otherwise.
func (o *ProjectWebAuthnConfig) GetRpOrigin() string {
	if o == nil || o.RpOrigin == nil {
		var ret string
		return ret
	}
	return *o.RpOrigin
}

// GetRpOriginOk returns a tuple with the RpOrigin field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectWebAuthnConfig) GetRpOriginOk() (*string, bool) {
	if o == nil || o.RpOrigin == nil {
		return nil, false
	}
	return o.RpOrigin, true
}

// HasRpOrigin returns a boolean if a field has been set.
func (o *ProjectWebAuthnConfig) HasRpOrigin() bool {
	if o != nil && o.RpOrigin != nil {
		return true
	}

	return false
}

// SetRpOrigin gets a reference to the given string and assigns it to the RpOrigin field.
func (o *ProjectWebAuthnConfig) SetRpOrigin(v string) {
	o.RpOrigin = &v
}

func (o ProjectWebAuthnConfig) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.Enabled != nil {
		toSerialize["enabled"] = o.Enabled
	}
	if o.RpDisplayName != nil {
		toSerialize["rp_display_name"] = o.RpDisplayName
	}
	if o.RpIcon != nil {
		toSerialize["rp_icon"] = o.RpIcon
	}
	if o.RpId != nil {
		toSerialize["rp_id"] = o.RpId
	}
	if o.RpOrigin != nil {
		toSerialize["rp_origin"] = o.RpOrigin
	}
	return json.Marshal(toSerialize)
}

type NullableProjectWebAuthnConfig struct {
	value *ProjectWebAuthnConfig
	isSet bool
}

func (v NullableProjectWebAuthnConfig) Get() *ProjectWebAuthnConfig {
	return v.value
}

func (v *NullableProjectWebAuthnConfig) Set(val *ProjectWebAuthnConfig) {
	v.value = val
	v.isSet = true
}

func (v NullableProjectWebAuthnConfig) IsSet() bool {
	return v.isSet
}

func (v *NullableProjectWebAuthnConfig) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableProjectWebAuthnConfig(val *ProjectWebAuthnConfig) *NullableProjectWebAuthnConfig {
	return &NullableProjectWebAuthnConfig{value: val, isSet: true}
}

func (v NullableProjectWebAuthnConfig) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableProjectWebAuthnConfig) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


