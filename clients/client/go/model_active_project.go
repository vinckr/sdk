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

// ActiveProject The Active Project ID
type ActiveProject struct {
	// The Active Project ID  format: uuid
	ProjectId *string `json:"project_id,omitempty"`
}

// NewActiveProject instantiates a new ActiveProject object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewActiveProject() *ActiveProject {
	this := ActiveProject{}
	return &this
}

// NewActiveProjectWithDefaults instantiates a new ActiveProject object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewActiveProjectWithDefaults() *ActiveProject {
	this := ActiveProject{}
	return &this
}

// GetProjectId returns the ProjectId field value if set, zero value otherwise.
func (o *ActiveProject) GetProjectId() string {
	if o == nil || o.ProjectId == nil {
		var ret string
		return ret
	}
	return *o.ProjectId
}

// GetProjectIdOk returns a tuple with the ProjectId field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ActiveProject) GetProjectIdOk() (*string, bool) {
	if o == nil || o.ProjectId == nil {
		return nil, false
	}
	return o.ProjectId, true
}

// HasProjectId returns a boolean if a field has been set.
func (o *ActiveProject) HasProjectId() bool {
	if o != nil && o.ProjectId != nil {
		return true
	}

	return false
}

// SetProjectId gets a reference to the given string and assigns it to the ProjectId field.
func (o *ActiveProject) SetProjectId(v string) {
	o.ProjectId = &v
}

func (o ActiveProject) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.ProjectId != nil {
		toSerialize["project_id"] = o.ProjectId
	}
	return json.Marshal(toSerialize)
}

type NullableActiveProject struct {
	value *ActiveProject
	isSet bool
}

func (v NullableActiveProject) Get() *ActiveProject {
	return v.value
}

func (v *NullableActiveProject) Set(val *ActiveProject) {
	v.value = val
	v.isSet = true
}

func (v NullableActiveProject) IsSet() bool {
	return v.isSet
}

func (v *NullableActiveProject) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableActiveProject(val *ActiveProject) *NullableActiveProject {
	return &NullableActiveProject{value: val, isSet: true}
}

func (v NullableActiveProject) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableActiveProject) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


