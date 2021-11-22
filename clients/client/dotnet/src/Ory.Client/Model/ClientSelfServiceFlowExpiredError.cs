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
    /// Is sent when a flow is expired
    /// </summary>
    [DataContract(Name = "selfServiceFlowExpiredError")]
    public partial class ClientSelfServiceFlowExpiredError : IEquatable<ClientSelfServiceFlowExpiredError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSelfServiceFlowExpiredError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientSelfServiceFlowExpiredError()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSelfServiceFlowExpiredError" /> class.
        /// </summary>
        /// <param name="code">The status code.</param>
        /// <param name="debug">Debug information  This field is often not exposed to protect against leaking sensitive information..</param>
        /// <param name="details">Further error details.</param>
        /// <param name="id">The error ID  Useful when trying to identify various errors in application logic..</param>
        /// <param name="message">Error message  The error&#39;s message. (required).</param>
        /// <param name="reason">A human-readable reason for the error.</param>
        /// <param name="request">The request ID  The request ID is often exposed internally in order to trace errors across service architectures. This is often a UUID..</param>
        /// <param name="since">A Duration represents the elapsed time between two instants as an int64 nanosecond count. The representation limits the largest representable duration to approximately 290 years..</param>
        /// <param name="status">The status description.</param>
        /// <param name="useFlowId">useFlowId.</param>
        public ClientSelfServiceFlowExpiredError(long code = default(long), string debug = default(string), Dictionary<string, Object> details = default(Dictionary<string, Object>), string id = default(string), string message = default(string), string reason = default(string), string request = default(string), long since = default(long), string status = default(string), string useFlowId = default(string))
        {
            // to ensure "message" is required (not null)
            if (message == null) {
                throw new ArgumentNullException("message is a required property for ClientSelfServiceFlowExpiredError and cannot be null");
            }
            this.Message = message;
            this.Code = code;
            this.Debug = debug;
            this.Details = details;
            this.Id = id;
            this.Reason = reason;
            this.Request = request;
            this.Since = since;
            this.Status = status;
            this.UseFlowId = useFlowId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The status code
        /// </summary>
        /// <value>The status code</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public long Code { get; set; }

        /// <summary>
        /// Debug information  This field is often not exposed to protect against leaking sensitive information.
        /// </summary>
        /// <value>Debug information  This field is often not exposed to protect against leaking sensitive information.</value>
        [DataMember(Name = "debug", EmitDefaultValue = false)]
        public string Debug { get; set; }

        /// <summary>
        /// Further error details
        /// </summary>
        /// <value>Further error details</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public Dictionary<string, Object> Details { get; set; }

        /// <summary>
        /// The error ID  Useful when trying to identify various errors in application logic.
        /// </summary>
        /// <value>The error ID  Useful when trying to identify various errors in application logic.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Error message  The error&#39;s message.
        /// </summary>
        /// <value>Error message  The error&#39;s message.</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// A human-readable reason for the error
        /// </summary>
        /// <value>A human-readable reason for the error</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// The request ID  The request ID is often exposed internally in order to trace errors across service architectures. This is often a UUID.
        /// </summary>
        /// <value>The request ID  The request ID is often exposed internally in order to trace errors across service architectures. This is often a UUID.</value>
        [DataMember(Name = "request", EmitDefaultValue = false)]
        public string Request { get; set; }

        /// <summary>
        /// A Duration represents the elapsed time between two instants as an int64 nanosecond count. The representation limits the largest representable duration to approximately 290 years.
        /// </summary>
        /// <value>A Duration represents the elapsed time between two instants as an int64 nanosecond count. The representation limits the largest representable duration to approximately 290 years.</value>
        [DataMember(Name = "since", EmitDefaultValue = false)]
        public long Since { get; set; }

        /// <summary>
        /// The status description
        /// </summary>
        /// <value>The status description</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets UseFlowId
        /// </summary>
        [DataMember(Name = "use_flow_id", EmitDefaultValue = false)]
        public string UseFlowId { get; set; }

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
            sb.Append("class ClientSelfServiceFlowExpiredError {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Debug: ").Append(Debug).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  Since: ").Append(Since).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UseFlowId: ").Append(UseFlowId).Append("\n");
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
            return this.Equals(input as ClientSelfServiceFlowExpiredError);
        }

        /// <summary>
        /// Returns true if ClientSelfServiceFlowExpiredError instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientSelfServiceFlowExpiredError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientSelfServiceFlowExpiredError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.Debug == input.Debug ||
                    (this.Debug != null &&
                    this.Debug.Equals(input.Debug))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.Since == input.Since ||
                    this.Since.Equals(input.Since)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UseFlowId == input.UseFlowId ||
                    (this.UseFlowId != null &&
                    this.UseFlowId.Equals(input.UseFlowId))
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
                hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Debug != null)
                    hashCode = hashCode * 59 + this.Debug.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Request != null)
                    hashCode = hashCode * 59 + this.Request.GetHashCode();
                hashCode = hashCode * 59 + this.Since.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UseFlowId != null)
                    hashCode = hashCode * 59 + this.UseFlowId.GetHashCode();
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
