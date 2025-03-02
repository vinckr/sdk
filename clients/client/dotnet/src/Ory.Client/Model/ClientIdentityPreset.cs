/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.30
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
    /// ClientIdentityPreset
    /// </summary>
    [DataContract(Name = "identityPreset")]
    public partial class ClientIdentityPreset : IEquatable<ClientIdentityPreset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientIdentityPreset" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientIdentityPreset()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientIdentityPreset" /> class.
        /// </summary>
        /// <param name="schema">Schema is the Identity JSON Schema (required).</param>
        /// <param name="url">URL is the preset identifier (required).</param>
        public ClientIdentityPreset(Object schema = default(Object), string url = default(string))
        {
            // to ensure "schema" is required (not null)
            if (schema == null) {
                throw new ArgumentNullException("schema is a required property for ClientIdentityPreset and cannot be null");
            }
            this.Schema = schema;
            // to ensure "url" is required (not null)
            if (url == null) {
                throw new ArgumentNullException("url is a required property for ClientIdentityPreset and cannot be null");
            }
            this.Url = url;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Schema is the Identity JSON Schema
        /// </summary>
        /// <value>Schema is the Identity JSON Schema</value>
        [DataMember(Name = "schema", IsRequired = true, EmitDefaultValue = false)]
        public Object Schema { get; set; }

        /// <summary>
        /// URL is the preset identifier
        /// </summary>
        /// <value>URL is the preset identifier</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; }

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
            sb.Append("class ClientIdentityPreset {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as ClientIdentityPreset);
        }

        /// <summary>
        /// Returns true if ClientIdentityPreset instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientIdentityPreset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientIdentityPreset input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Schema != null)
                    hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
