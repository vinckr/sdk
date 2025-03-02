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
    /// ClientAdminUpdateIdentityBody
    /// </summary>
    [DataContract(Name = "AdminUpdateIdentityBody")]
    public partial class ClientAdminUpdateIdentityBody : IEquatable<ClientAdminUpdateIdentityBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAdminUpdateIdentityBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientAdminUpdateIdentityBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAdminUpdateIdentityBody" /> class.
        /// </summary>
        /// <param name="schemaId">SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits. If set will update the Identity&#39;s SchemaID..</param>
        /// <param name="state">state (required).</param>
        /// <param name="traits">Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_id&#x60;. (required).</param>
        public ClientAdminUpdateIdentityBody(string schemaId = default(string), ClientIdentityState state = default(ClientIdentityState), Object traits = default(Object))
        {
            // to ensure "state" is required (not null)
            if (state == null) {
                throw new ArgumentNullException("state is a required property for ClientAdminUpdateIdentityBody and cannot be null");
            }
            this.State = state;
            // to ensure "traits" is required (not null)
            if (traits == null) {
                throw new ArgumentNullException("traits is a required property for ClientAdminUpdateIdentityBody and cannot be null");
            }
            this.Traits = traits;
            this.SchemaId = schemaId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits. If set will update the Identity&#39;s SchemaID.
        /// </summary>
        /// <value>SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits. If set will update the Identity&#39;s SchemaID.</value>
        [DataMember(Name = "schema_id", EmitDefaultValue = false)]
        public string SchemaId { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = false)]
        public ClientIdentityState State { get; set; }

        /// <summary>
        /// Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_id&#x60;.
        /// </summary>
        /// <value>Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_id&#x60;.</value>
        [DataMember(Name = "traits", IsRequired = true, EmitDefaultValue = false)]
        public Object Traits { get; set; }

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
            sb.Append("class ClientAdminUpdateIdentityBody {\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
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
            return this.Equals(input as ClientAdminUpdateIdentityBody);
        }

        /// <summary>
        /// Returns true if ClientAdminUpdateIdentityBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientAdminUpdateIdentityBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientAdminUpdateIdentityBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SchemaId == input.SchemaId ||
                    (this.SchemaId != null &&
                    this.SchemaId.Equals(input.SchemaId))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Traits == input.Traits ||
                    (this.Traits != null &&
                    this.Traits.Equals(input.Traits))
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
                if (this.SchemaId != null)
                    hashCode = hashCode * 59 + this.SchemaId.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Traits != null)
                    hashCode = hashCode * 59 + this.Traits.GetHashCode();
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
