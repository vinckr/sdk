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
    /// The Response for Settings Flows via API
    /// </summary>
    [DataContract]
    public partial class KratosSettingsViaApiResponse :  IEquatable<KratosSettingsViaApiResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSettingsViaApiResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosSettingsViaApiResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSettingsViaApiResponse" /> class.
        /// </summary>
        /// <param name="flow">flow (required).</param>
        /// <param name="identity">identity (required).</param>
        public KratosSettingsViaApiResponse(KratosSettingsFlow flow = default(KratosSettingsFlow), KratosIdentity identity = default(KratosIdentity))
        {
            // to ensure "flow" is required (not null)
            this.Flow = flow ?? throw new ArgumentNullException("flow is a required property for KratosSettingsViaApiResponse and cannot be null");
            // to ensure "identity" is required (not null)
            this.Identity = identity ?? throw new ArgumentNullException("identity is a required property for KratosSettingsViaApiResponse and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Flow
        /// </summary>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public KratosSettingsFlow Flow { get; set; }

        /// <summary>
        /// Gets or Sets Identity
        /// </summary>
        [DataMember(Name="identity", EmitDefaultValue=false)]
        public KratosIdentity Identity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosSettingsViaApiResponse {\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
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
            return this.Equals(input as KratosSettingsViaApiResponse);
        }

        /// <summary>
        /// Returns true if KratosSettingsViaApiResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosSettingsViaApiResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosSettingsViaApiResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Flow == input.Flow ||
                    (this.Flow != null &&
                    this.Flow.Equals(input.Flow))
                ) && 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
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
                if (this.Flow != null)
                    hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.Identity != null)
                    hashCode = hashCode * 59 + this.Identity.GetHashCode();
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
