/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.8.0-alpha.2
 * Contact: hi@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// KratosSubmitSelfServiceSettingsFlowWithLookupMethodBody
    /// </summary>
    [DataContract(Name = "submitSelfServiceSettingsFlowWithLookupMethodBody")]
    public partial class KratosSubmitSelfServiceSettingsFlowWithLookupMethodBody : IEquatable<KratosSubmitSelfServiceSettingsFlowWithLookupMethodBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSubmitSelfServiceSettingsFlowWithLookupMethodBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosSubmitSelfServiceSettingsFlowWithLookupMethodBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSubmitSelfServiceSettingsFlowWithLookupMethodBody" /> class.
        /// </summary>
        /// <param name="csrfToken">CSRFToken is the anti-CSRF token.</param>
        /// <param name="lookupSecretConfirm">If set to true will save the regenerated lookup secrets.</param>
        /// <param name="lookupSecretDisable">Disables this method if true..</param>
        /// <param name="lookupSecretRegenerate">If set to true will regenerate the lookup secrets.</param>
        /// <param name="lookupSecretReveal">If set to true will reveal the lookup secrets.</param>
        /// <param name="method">Method  Should be set to \&quot;lookup\&quot; when trying to add, update, or remove a lookup pairing. (required).</param>
        public KratosSubmitSelfServiceSettingsFlowWithLookupMethodBody(string csrfToken = default(string), bool lookupSecretConfirm = default(bool), bool lookupSecretDisable = default(bool), bool lookupSecretRegenerate = default(bool), bool lookupSecretReveal = default(bool), string method = default(string))
        {
            // to ensure "method" is required (not null)
            if (method == null) {
                throw new ArgumentNullException("method is a required property for KratosSubmitSelfServiceSettingsFlowWithLookupMethodBody and cannot be null");
            }
            this.Method = method;
            this.CsrfToken = csrfToken;
            this.LookupSecretConfirm = lookupSecretConfirm;
            this.LookupSecretDisable = lookupSecretDisable;
            this.LookupSecretRegenerate = lookupSecretRegenerate;
            this.LookupSecretReveal = lookupSecretReveal;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// CSRFToken is the anti-CSRF token
        /// </summary>
        /// <value>CSRFToken is the anti-CSRF token</value>
        [DataMember(Name = "csrf_token", EmitDefaultValue = false)]
        public string CsrfToken { get; set; }

        /// <summary>
        /// If set to true will save the regenerated lookup secrets
        /// </summary>
        /// <value>If set to true will save the regenerated lookup secrets</value>
        [DataMember(Name = "lookup_secret_confirm", EmitDefaultValue = true)]
        public bool LookupSecretConfirm { get; set; }

        /// <summary>
        /// Disables this method if true.
        /// </summary>
        /// <value>Disables this method if true.</value>
        [DataMember(Name = "lookup_secret_disable", EmitDefaultValue = true)]
        public bool LookupSecretDisable { get; set; }

        /// <summary>
        /// If set to true will regenerate the lookup secrets
        /// </summary>
        /// <value>If set to true will regenerate the lookup secrets</value>
        [DataMember(Name = "lookup_secret_regenerate", EmitDefaultValue = true)]
        public bool LookupSecretRegenerate { get; set; }

        /// <summary>
        /// If set to true will reveal the lookup secrets
        /// </summary>
        /// <value>If set to true will reveal the lookup secrets</value>
        [DataMember(Name = "lookup_secret_reveal", EmitDefaultValue = true)]
        public bool LookupSecretReveal { get; set; }

        /// <summary>
        /// Method  Should be set to \&quot;lookup\&quot; when trying to add, update, or remove a lookup pairing.
        /// </summary>
        /// <value>Method  Should be set to \&quot;lookup\&quot; when trying to add, update, or remove a lookup pairing.</value>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosSubmitSelfServiceSettingsFlowWithLookupMethodBody {\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  LookupSecretConfirm: ").Append(LookupSecretConfirm).Append("\n");
            sb.Append("  LookupSecretDisable: ").Append(LookupSecretDisable).Append("\n");
            sb.Append("  LookupSecretRegenerate: ").Append(LookupSecretRegenerate).Append("\n");
            sb.Append("  LookupSecretReveal: ").Append(LookupSecretReveal).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as KratosSubmitSelfServiceSettingsFlowWithLookupMethodBody);
        }

        /// <summary>
        /// Returns true if KratosSubmitSelfServiceSettingsFlowWithLookupMethodBody instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosSubmitSelfServiceSettingsFlowWithLookupMethodBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosSubmitSelfServiceSettingsFlowWithLookupMethodBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CsrfToken == input.CsrfToken ||
                    (this.CsrfToken != null &&
                    this.CsrfToken.Equals(input.CsrfToken))
                ) && 
                (
                    this.LookupSecretConfirm == input.LookupSecretConfirm ||
                    this.LookupSecretConfirm.Equals(input.LookupSecretConfirm)
                ) && 
                (
                    this.LookupSecretDisable == input.LookupSecretDisable ||
                    this.LookupSecretDisable.Equals(input.LookupSecretDisable)
                ) && 
                (
                    this.LookupSecretRegenerate == input.LookupSecretRegenerate ||
                    this.LookupSecretRegenerate.Equals(input.LookupSecretRegenerate)
                ) && 
                (
                    this.LookupSecretReveal == input.LookupSecretReveal ||
                    this.LookupSecretReveal.Equals(input.LookupSecretReveal)
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CsrfToken != null)
                    hashCode = hashCode * 59 + this.CsrfToken.GetHashCode();
                hashCode = hashCode * 59 + this.LookupSecretConfirm.GetHashCode();
                hashCode = hashCode * 59 + this.LookupSecretDisable.GetHashCode();
                hashCode = hashCode * 59 + this.LookupSecretRegenerate.GetHashCode();
                hashCode = hashCode * 59 + this.LookupSecretReveal.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
