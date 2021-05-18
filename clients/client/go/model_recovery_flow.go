/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * API version: v0.0.1-alpha.1
 * Contact: support@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"time"
)

// RecoveryFlow This request is used when an identity wants to recover their account.  We recommend reading the [Account Recovery Documentation](../self-service/flows/password-reset-account-recovery)
type RecoveryFlow struct {
	// Active, if set, contains the registration method that is being used. It is initially not set.
	Active *string `json:"active,omitempty"`
	// ExpiresAt is the time (UTC) when the request expires. If the user still wishes to update the setting, a new request has to be initiated.
	ExpiresAt time.Time `json:"expires_at"`
	Id string `json:"id"`
	// IssuedAt is the time (UTC) when the request occurred.
	IssuedAt time.Time `json:"issued_at"`
	// RequestURL is the initial URL that was requested from Ory Kratos. It can be used to forward information contained in the URL's path or query for example.
	RequestUrl string `json:"request_url"`
	State string `json:"state"`
	// The flow type can either be `api` or `browser`.
	Type *string `json:"type,omitempty"`
	Ui UiContainer `json:"ui"`
}

// NewRecoveryFlow instantiates a new RecoveryFlow object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewRecoveryFlow(expiresAt time.Time, id string, issuedAt time.Time, requestUrl string, state string, ui UiContainer) *RecoveryFlow {
	this := RecoveryFlow{}
	this.ExpiresAt = expiresAt
	this.Id = id
	this.IssuedAt = issuedAt
	this.RequestUrl = requestUrl
	this.State = state
	this.Ui = ui
	return &this
}

// NewRecoveryFlowWithDefaults instantiates a new RecoveryFlow object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewRecoveryFlowWithDefaults() *RecoveryFlow {
	this := RecoveryFlow{}
	return &this
}

// GetActive returns the Active field value if set, zero value otherwise.
func (o *RecoveryFlow) GetActive() string {
	if o == nil || o.Active == nil {
		var ret string
		return ret
	}
	return *o.Active
}

// GetActiveOk returns a tuple with the Active field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *RecoveryFlow) GetActiveOk() (*string, bool) {
	if o == nil || o.Active == nil {
		return nil, false
	}
	return o.Active, true
}

// HasActive returns a boolean if a field has been set.
func (o *RecoveryFlow) HasActive() bool {
	if o != nil && o.Active != nil {
		return true
	}

	return false
}

// SetActive gets a reference to the given string and assigns it to the Active field.
func (o *RecoveryFlow) SetActive(v string) {
	o.Active = &v
}

// GetExpiresAt returns the ExpiresAt field value
func (o *RecoveryFlow) GetExpiresAt() time.Time {
	if o == nil {
		var ret time.Time
		return ret
	}

	return o.ExpiresAt
}

// GetExpiresAtOk returns a tuple with the ExpiresAt field value
// and a boolean to check if the value has been set.
func (o *RecoveryFlow) GetExpiresAtOk() (*time.Time, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.ExpiresAt, true
}

// SetExpiresAt sets field value
func (o *RecoveryFlow) SetExpiresAt(v time.Time) {
	o.ExpiresAt = v
}

// GetId returns the Id field value
func (o *RecoveryFlow) GetId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Id
}

// GetIdOk returns a tuple with the Id field value
// and a boolean to check if the value has been set.
func (o *RecoveryFlow) GetIdOk() (*string, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.Id, true
}

// SetId sets field value
func (o *RecoveryFlow) SetId(v string) {
	o.Id = v
}

// GetIssuedAt returns the IssuedAt field value
func (o *RecoveryFlow) GetIssuedAt() time.Time {
	if o == nil {
		var ret time.Time
		return ret
	}

	return o.IssuedAt
}

// GetIssuedAtOk returns a tuple with the IssuedAt field value
// and a boolean to check if the value has been set.
func (o *RecoveryFlow) GetIssuedAtOk() (*time.Time, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.IssuedAt, true
}

// SetIssuedAt sets field value
func (o *RecoveryFlow) SetIssuedAt(v time.Time) {
	o.IssuedAt = v
}

// GetRequestUrl returns the RequestUrl field value
func (o *RecoveryFlow) GetRequestUrl() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.RequestUrl
}

// GetRequestUrlOk returns a tuple with the RequestUrl field value
// and a boolean to check if the value has been set.
func (o *RecoveryFlow) GetRequestUrlOk() (*string, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.RequestUrl, true
}

// SetRequestUrl sets field value
func (o *RecoveryFlow) SetRequestUrl(v string) {
	o.RequestUrl = v
}

// GetState returns the State field value
func (o *RecoveryFlow) GetState() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.State
}

// GetStateOk returns a tuple with the State field value
// and a boolean to check if the value has been set.
func (o *RecoveryFlow) GetStateOk() (*string, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.State, true
}

// SetState sets field value
func (o *RecoveryFlow) SetState(v string) {
	o.State = v
}

// GetType returns the Type field value if set, zero value otherwise.
func (o *RecoveryFlow) GetType() string {
	if o == nil || o.Type == nil {
		var ret string
		return ret
	}
	return *o.Type
}

// GetTypeOk returns a tuple with the Type field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *RecoveryFlow) GetTypeOk() (*string, bool) {
	if o == nil || o.Type == nil {
		return nil, false
	}
	return o.Type, true
}

// HasType returns a boolean if a field has been set.
func (o *RecoveryFlow) HasType() bool {
	if o != nil && o.Type != nil {
		return true
	}

	return false
}

// SetType gets a reference to the given string and assigns it to the Type field.
func (o *RecoveryFlow) SetType(v string) {
	o.Type = &v
}

// GetUi returns the Ui field value
func (o *RecoveryFlow) GetUi() UiContainer {
	if o == nil {
		var ret UiContainer
		return ret
	}

	return o.Ui
}

// GetUiOk returns a tuple with the Ui field value
// and a boolean to check if the value has been set.
func (o *RecoveryFlow) GetUiOk() (*UiContainer, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.Ui, true
}

// SetUi sets field value
func (o *RecoveryFlow) SetUi(v UiContainer) {
	o.Ui = v
}

func (o RecoveryFlow) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.Active != nil {
		toSerialize["active"] = o.Active
	}
	if true {
		toSerialize["expires_at"] = o.ExpiresAt
	}
	if true {
		toSerialize["id"] = o.Id
	}
	if true {
		toSerialize["issued_at"] = o.IssuedAt
	}
	if true {
		toSerialize["request_url"] = o.RequestUrl
	}
	if true {
		toSerialize["state"] = o.State
	}
	if o.Type != nil {
		toSerialize["type"] = o.Type
	}
	if true {
		toSerialize["ui"] = o.Ui
	}
	return json.Marshal(toSerialize)
}

type NullableRecoveryFlow struct {
	value *RecoveryFlow
	isSet bool
}

func (v NullableRecoveryFlow) Get() *RecoveryFlow {
	return v.value
}

func (v *NullableRecoveryFlow) Set(val *RecoveryFlow) {
	v.value = val
	v.isSet = true
}

func (v NullableRecoveryFlow) IsSet() bool {
	return v.isSet
}

func (v *NullableRecoveryFlow) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableRecoveryFlow(val *RecoveryFlow) *NullableRecoveryFlow {
	return &NullableRecoveryFlow{value: val, isSet: true}
}

func (v NullableRecoveryFlow) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableRecoveryFlow) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


