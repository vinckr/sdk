/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.24
 * Contact: support@ory.sh
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
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Model
{
    /// <summary>
    /// ClientProjectLookupSecretConfig
    /// </summary>
    [DataContract(Name = "projectLookupSecretConfig")]
    public partial class ClientProjectLookupSecretConfig : IEquatable<ClientProjectLookupSecretConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProjectLookupSecretConfig" /> class.
        /// </summary>
        /// <param name="enabled">Set to true to enable the WebAuthn authentication method..</param>
        public ClientProjectLookupSecretConfig(bool enabled = default(bool))
        {
            this.Enabled = enabled;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Set to true to enable the WebAuthn authentication method.
        /// </summary>
        /// <value>Set to true to enable the WebAuthn authentication method.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

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
            sb.Append("class ClientProjectLookupSecretConfig {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as ClientProjectLookupSecretConfig);
        }

        /// <summary>
        /// Returns true if ClientProjectLookupSecretConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientProjectLookupSecretConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientProjectLookupSecretConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
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
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
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
