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
    /// level object
    /// </summary>
    [DataContract]
    public partial class GetInsurancePricesLevel :  IEquatable<GetInsurancePricesLevel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInsurancePricesLevel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetInsurancePricesLevel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInsurancePricesLevel" /> class.
        /// </summary>
        /// <param name="cost">cost number (required).</param>
        /// <param name="name">Localized insurance level (required).</param>
        /// <param name="payout">payout number (required).</param>
        public GetInsurancePricesLevel(float? cost = default(float?), string name = default(string), float? payout = default(float?))
        {
            // to ensure "cost" is required (not null)
            if (cost == null)
            {
                throw new InvalidDataException("cost is a required property for GetInsurancePricesLevel and cannot be null");
            }
            else
            {
                this.Cost = cost;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetInsurancePricesLevel and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "payout" is required (not null)
            if (payout == null)
            {
                throw new InvalidDataException("payout is a required property for GetInsurancePricesLevel and cannot be null");
            }
            else
            {
                this.Payout = payout;
            }
        }
        
        /// <summary>
        /// cost number
        /// </summary>
        /// <value>cost number</value>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public float? Cost { get; set; }

        /// <summary>
        /// Localized insurance level
        /// </summary>
        /// <value>Localized insurance level</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// payout number
        /// </summary>
        /// <value>payout number</value>
        [DataMember(Name="payout", EmitDefaultValue=false)]
        public float? Payout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetInsurancePricesLevel {\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Payout: ").Append(Payout).Append("\n");
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
            return this.Equals(input as GetInsurancePricesLevel);
        }

        /// <summary>
        /// Returns true if GetInsurancePricesLevel instances are equal
        /// </summary>
        /// <param name="input">Instance of GetInsurancePricesLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetInsurancePricesLevel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Payout == input.Payout ||
                    (this.Payout != null &&
                    this.Payout.Equals(input.Payout))
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
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Payout != null)
                    hashCode = hashCode * 59 + this.Payout.GetHashCode();
                return hashCode;
            }
        }
    }

}
