/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 1.3.8
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = ESIClient.Dotcore.Client.SwaggerDateConverter;

namespace ESIClient.Dotcore.Model
{
    /// <summary>
    /// Unauthorized model
    /// </summary>
    [DataContract]
    public partial class Unauthorized :  IEquatable<Unauthorized>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Unauthorized" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Unauthorized() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Unauthorized" /> class.
        /// </summary>
        /// <param name="error">Unauthorized message (required).</param>
        public Unauthorized(string error = default(string))
        {
            // to ensure "error" is required (not null)
            if (error == null)
            {
                throw new InvalidDataException("error is a required property for Unauthorized and cannot be null");
            }
            else
            {
                this.Error = error;
            }
        }
        
        /// <summary>
        /// Unauthorized message
        /// </summary>
        /// <value>Unauthorized message</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Unauthorized {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as Unauthorized);
        }

        /// <summary>
        /// Returns true if Unauthorized instances are equal
        /// </summary>
        /// <param name="input">Instance of Unauthorized to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Unauthorized input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }
    }

}
