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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// KratosSubmitSelfServiceRegistrationFlowBody
    /// </summary>
    [JsonConverter(typeof(KratosSubmitSelfServiceRegistrationFlowBodyJsonConverter))]
    [DataContract(Name = "submitSelfServiceRegistrationFlowBody")]
    public partial class KratosSubmitSelfServiceRegistrationFlowBody : AbstractOpenAPISchema, IEquatable<KratosSubmitSelfServiceRegistrationFlowBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSubmitSelfServiceRegistrationFlowBody" /> class
        /// with the <see cref="KratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody.</param>
        public KratosSubmitSelfServiceRegistrationFlowBody(KratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSubmitSelfServiceRegistrationFlowBody" /> class
        /// with the <see cref="KratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody.</param>
        public KratosSubmitSelfServiceRegistrationFlowBody(KratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(KratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: KratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody, KratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `KratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody`. If the actual instance is not `KratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody</returns>
        public KratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody GetKratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody()
        {
            return (KratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody`. If the actual instance is not `KratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody</returns>
        public KratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody GetKratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody()
        {
            return (KratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosSubmitSelfServiceRegistrationFlowBody {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, KratosSubmitSelfServiceRegistrationFlowBody.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of KratosSubmitSelfServiceRegistrationFlowBody
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of KratosSubmitSelfServiceRegistrationFlowBody</returns>
        public static KratosSubmitSelfServiceRegistrationFlowBody FromJson(string jsonString)
        {
            KratosSubmitSelfServiceRegistrationFlowBody newKratosSubmitSelfServiceRegistrationFlowBody = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newKratosSubmitSelfServiceRegistrationFlowBody;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody).GetProperty("AdditionalProperties") == null)
                {
                    newKratosSubmitSelfServiceRegistrationFlowBody = new KratosSubmitSelfServiceRegistrationFlowBody(JsonConvert.DeserializeObject<KratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody>(jsonString, KratosSubmitSelfServiceRegistrationFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosSubmitSelfServiceRegistrationFlowBody = new KratosSubmitSelfServiceRegistrationFlowBody(JsonConvert.DeserializeObject<KratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody>(jsonString, KratosSubmitSelfServiceRegistrationFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosSubmitSelfServiceRegistrationFlowWithOidcMethodBody: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody).GetProperty("AdditionalProperties") == null)
                {
                    newKratosSubmitSelfServiceRegistrationFlowBody = new KratosSubmitSelfServiceRegistrationFlowBody(JsonConvert.DeserializeObject<KratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody>(jsonString, KratosSubmitSelfServiceRegistrationFlowBody.SerializerSettings));
                }
                else
                {
                    newKratosSubmitSelfServiceRegistrationFlowBody = new KratosSubmitSelfServiceRegistrationFlowBody(JsonConvert.DeserializeObject<KratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody>(jsonString, KratosSubmitSelfServiceRegistrationFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KratosSubmitSelfServiceRegistrationFlowWithPasswordMethodBody: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newKratosSubmitSelfServiceRegistrationFlowBody;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as KratosSubmitSelfServiceRegistrationFlowBody);
        }

        /// <summary>
        /// Returns true if KratosSubmitSelfServiceRegistrationFlowBody instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosSubmitSelfServiceRegistrationFlowBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosSubmitSelfServiceRegistrationFlowBody input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for KratosSubmitSelfServiceRegistrationFlowBody
    /// </summary>
    public class KratosSubmitSelfServiceRegistrationFlowBodyJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(KratosSubmitSelfServiceRegistrationFlowBody).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return KratosSubmitSelfServiceRegistrationFlowBody.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
