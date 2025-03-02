// Code generated by go-swagger; DO NOT EDIT.

package models

// This file was generated by the swagger tool.
// Editing this file might prove futile when you re-run the swagger generate command

import (
	"context"

	"github.com/go-openapi/errors"
	"github.com/go-openapi/strfmt"
	"github.com/go-openapi/swag"
)

// SwaggerRuleResponse SwaggerRuleResponse A rule
//
// swagger:model swaggerRuleResponse
type SwaggerRuleResponse struct {

	// body
	Body *SwaggerRule `json:"Body,omitempty"`
}

// Validate validates this swagger rule response
func (m *SwaggerRuleResponse) Validate(formats strfmt.Registry) error {
	var res []error

	if err := m.validateBody(formats); err != nil {
		res = append(res, err)
	}

	if len(res) > 0 {
		return errors.CompositeValidationError(res...)
	}
	return nil
}

func (m *SwaggerRuleResponse) validateBody(formats strfmt.Registry) error {
	if swag.IsZero(m.Body) { // not required
		return nil
	}

	if m.Body != nil {
		if err := m.Body.Validate(formats); err != nil {
			if ve, ok := err.(*errors.Validation); ok {
				return ve.ValidateName("Body")
			}
			return err
		}
	}

	return nil
}

// ContextValidate validate this swagger rule response based on the context it is used
func (m *SwaggerRuleResponse) ContextValidate(ctx context.Context, formats strfmt.Registry) error {
	var res []error

	if err := m.contextValidateBody(ctx, formats); err != nil {
		res = append(res, err)
	}

	if len(res) > 0 {
		return errors.CompositeValidationError(res...)
	}
	return nil
}

func (m *SwaggerRuleResponse) contextValidateBody(ctx context.Context, formats strfmt.Registry) error {

	if m.Body != nil {
		if err := m.Body.ContextValidate(ctx, formats); err != nil {
			if ve, ok := err.(*errors.Validation); ok {
				return ve.ValidateName("Body")
			}
			return err
		}
	}

	return nil
}

// MarshalBinary interface implementation
func (m *SwaggerRuleResponse) MarshalBinary() ([]byte, error) {
	if m == nil {
		return nil, nil
	}
	return swag.WriteJSON(m)
}

// UnmarshalBinary interface implementation
func (m *SwaggerRuleResponse) UnmarshalBinary(b []byte) error {
	var res SwaggerRuleResponse
	if err := swag.ReadJSON(b, &res); err != nil {
		return err
	}
	*m = res
	return nil
}
