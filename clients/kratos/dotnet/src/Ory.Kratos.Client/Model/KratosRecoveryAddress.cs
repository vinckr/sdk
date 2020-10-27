/* 
 * Ory Kratos
 *
 * Welcome to the ORY Kratos HTTP API documentation!
 *
 * The version of the OpenAPI document: v0.5.3-alpha.1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// KratosRecoveryAddress
    /// </summary>
    [DataContract]
    public partial class KratosRecoveryAddress :  IEquatable<KratosRecoveryAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosRecoveryAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosRecoveryAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosRecoveryAddress" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="value">value (required).</param>
        /// <param name="via">via (required).</param>
        public KratosRecoveryAddress(string id = default(string), string value = default(string), string via = default(string))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for KratosRecoveryAddress and cannot be null");
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for KratosRecoveryAddress and cannot be null");
            // to ensure "via" is required (not null)
            this.Via = via ?? throw new ArgumentNullException("via is a required property for KratosRecoveryAddress and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Via
        /// </summary>
        [DataMember(Name="via", EmitDefaultValue=false)]
        public string Via { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosRecoveryAddress {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Via: ").Append(Via).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as KratosRecoveryAddress);
        }

        /// <summary>
        /// Returns true if KratosRecoveryAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosRecoveryAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosRecoveryAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Via == input.Via ||
                    (this.Via != null &&
                    this.Via.Equals(input.Via))
                );
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Via != null)
                    hashCode = hashCode * 59 + this.Via.GetHashCode();
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
