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
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdMining200Ok :  IEquatable<GetCharactersCharacterIdMining200Ok>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdMining200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdMining200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdMining200Ok" /> class.
        /// </summary>
        /// <param name="date">date string (required).</param>
        /// <param name="quantity">quantity integer (required).</param>
        /// <param name="solarSystemId">solar_system_id integer (required).</param>
        /// <param name="typeId">type_id integer (required).</param>
        public GetCharactersCharacterIdMining200Ok(DateTime? date = default(DateTime?), long? quantity = default(long?), int? solarSystemId = default(int?), int? typeId = default(int?))
        {
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new InvalidDataException("date is a required property for GetCharactersCharacterIdMining200Ok and cannot be null");
            }
            else
            {
                this.Date = date;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for GetCharactersCharacterIdMining200Ok and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            // to ensure "solarSystemId" is required (not null)
            if (solarSystemId == null)
            {
                throw new InvalidDataException("solarSystemId is a required property for GetCharactersCharacterIdMining200Ok and cannot be null");
            }
            else
            {
                this.SolarSystemId = solarSystemId;
            }
            // to ensure "typeId" is required (not null)
            if (typeId == null)
            {
                throw new InvalidDataException("typeId is a required property for GetCharactersCharacterIdMining200Ok and cannot be null");
            }
            else
            {
                this.TypeId = typeId;
            }
        }
        
        /// <summary>
        /// date string
        /// </summary>
        /// <value>date string</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// quantity integer
        /// </summary>
        /// <value>quantity integer</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        /// <value>solar_system_id integer</value>
        [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
        public int? SolarSystemId { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        /// <value>type_id integer</value>
        [DataMember(Name="type_id", EmitDefaultValue=false)]
        public int? TypeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdMining200Ok {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdMining200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdMining200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdMining200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdMining200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.SolarSystemId == input.SolarSystemId ||
                    (this.SolarSystemId != null &&
                    this.SolarSystemId.Equals(input.SolarSystemId))
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.SolarSystemId != null)
                    hashCode = hashCode * 59 + this.SolarSystemId.GetHashCode();
                if (this.TypeId != null)
                    hashCode = hashCode * 59 + this.TypeId.GetHashCode();
                return hashCode;
            }
        }
    }

}
