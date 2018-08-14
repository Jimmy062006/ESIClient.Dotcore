/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.8.5
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
    /// position object
    /// </summary>
    [DataContract]
    public partial class GetUniverseAsteroidBeltsAsteroidBeltIdPosition :  IEquatable<GetUniverseAsteroidBeltsAsteroidBeltIdPosition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseAsteroidBeltsAsteroidBeltIdPosition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetUniverseAsteroidBeltsAsteroidBeltIdPosition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseAsteroidBeltsAsteroidBeltIdPosition" /> class.
        /// </summary>
        /// <param name="x">x number (required).</param>
        /// <param name="y">y number (required).</param>
        /// <param name="z">z number (required).</param>
        public GetUniverseAsteroidBeltsAsteroidBeltIdPosition(double? x = default(double?), double? y = default(double?), double? z = default(double?))
        {
            // to ensure "x" is required (not null)
            if (x == null)
            {
                throw new InvalidDataException("x is a required property for GetUniverseAsteroidBeltsAsteroidBeltIdPosition and cannot be null");
            }
            else
            {
                this.X = x;
            }
            // to ensure "y" is required (not null)
            if (y == null)
            {
                throw new InvalidDataException("y is a required property for GetUniverseAsteroidBeltsAsteroidBeltIdPosition and cannot be null");
            }
            else
            {
                this.Y = y;
            }
            // to ensure "z" is required (not null)
            if (z == null)
            {
                throw new InvalidDataException("z is a required property for GetUniverseAsteroidBeltsAsteroidBeltIdPosition and cannot be null");
            }
            else
            {
                this.Z = z;
            }
        }
        
        /// <summary>
        /// x number
        /// </summary>
        /// <value>x number</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public double? X { get; set; }

        /// <summary>
        /// y number
        /// </summary>
        /// <value>y number</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public double? Y { get; set; }

        /// <summary>
        /// z number
        /// </summary>
        /// <value>z number</value>
        [DataMember(Name="z", EmitDefaultValue=false)]
        public double? Z { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUniverseAsteroidBeltsAsteroidBeltIdPosition {\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Z: ").Append(Z).Append("\n");
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
            return this.Equals(input as GetUniverseAsteroidBeltsAsteroidBeltIdPosition);
        }

        /// <summary>
        /// Returns true if GetUniverseAsteroidBeltsAsteroidBeltIdPosition instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUniverseAsteroidBeltsAsteroidBeltIdPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUniverseAsteroidBeltsAsteroidBeltIdPosition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
                ) && 
                (
                    this.Z == input.Z ||
                    (this.Z != null &&
                    this.Z.Equals(input.Z))
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
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
                if (this.Z != null)
                    hashCode = hashCode * 59 + this.Z.GetHashCode();
                return hashCode;
            }
        }
    }

}
