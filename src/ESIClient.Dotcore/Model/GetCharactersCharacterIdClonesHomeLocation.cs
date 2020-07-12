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
    /// home_location object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdClonesHomeLocation :  IEquatable<GetCharactersCharacterIdClonesHomeLocation>
    {
        /// <summary>
        /// location_type string
        /// </summary>
        /// <value>location_type string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LocationTypeEnum
        {
            
            /// <summary>
            /// Enum Station for value: station
            /// </summary>
            [EnumMember(Value = "station")]
            Station = 1,
            
            /// <summary>
            /// Enum Structure for value: structure
            /// </summary>
            [EnumMember(Value = "structure")]
            Structure = 2
        }

        /// <summary>
        /// location_type string
        /// </summary>
        /// <value>location_type string</value>
        [DataMember(Name="location_type", EmitDefaultValue=false)]
        public LocationTypeEnum? LocationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdClonesHomeLocation" /> class.
        /// </summary>
        /// <param name="locationId">location_id integer.</param>
        /// <param name="locationType">location_type string.</param>
        public GetCharactersCharacterIdClonesHomeLocation(long? locationId = default(long?), LocationTypeEnum? locationType = default(LocationTypeEnum?))
        {
            this.LocationId = locationId;
            this.LocationType = locationType;
        }
        
        /// <summary>
        /// location_id integer
        /// </summary>
        /// <value>location_id integer</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public long? LocationId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdClonesHomeLocation {\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  LocationType: ").Append(LocationType).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdClonesHomeLocation);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdClonesHomeLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdClonesHomeLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdClonesHomeLocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.LocationType == input.LocationType ||
                    (this.LocationType != null &&
                    this.LocationType.Equals(input.LocationType))
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
                if (this.LocationId != null)
                    hashCode = hashCode * 59 + this.LocationId.GetHashCode();
                if (this.LocationType != null)
                    hashCode = hashCode * 59 + this.LocationType.GetHashCode();
                return hashCode;
            }
        }
    }

}
