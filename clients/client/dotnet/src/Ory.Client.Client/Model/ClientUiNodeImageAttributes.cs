/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.1
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
using OpenAPIDateConverter = Ory.Client.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Client.Model
{
    /// <summary>
    /// ClientUiNodeImageAttributes
    /// </summary>
    [DataContract(Name = "uiNodeImageAttributes")]
    public partial class ClientUiNodeImageAttributes : IEquatable<ClientUiNodeImageAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUiNodeImageAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientUiNodeImageAttributes()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUiNodeImageAttributes" /> class.
        /// </summary>
        /// <param name="src">The image&#39;s source URL.  format: uri (required).</param>
        public ClientUiNodeImageAttributes(string src = default(string))
        {
            // to ensure "src" is required (not null)
            this.Src = src ?? throw new ArgumentNullException("src is a required property for ClientUiNodeImageAttributes and cannot be null");
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The image&#39;s source URL.  format: uri
        /// </summary>
        /// <value>The image&#39;s source URL.  format: uri</value>
        [DataMember(Name = "src", IsRequired = true, EmitDefaultValue = false)]
        public string Src { get; set; }

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
            sb.Append("class ClientUiNodeImageAttributes {\n");
            sb.Append("  Src: ").Append(Src).Append("\n");
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
            return this.Equals(input as ClientUiNodeImageAttributes);
        }

        /// <summary>
        /// Returns true if ClientUiNodeImageAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientUiNodeImageAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientUiNodeImageAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Src == input.Src ||
                    (this.Src != null &&
                    this.Src.Equals(input.Src))
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
                if (this.Src != null)
                    hashCode = hashCode * 59 + this.Src.GetHashCode();
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
