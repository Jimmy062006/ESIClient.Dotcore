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
    /// Summary of victory points gained by the given character for the enlisted faction
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdFwStatsVictoryPoints :  IEquatable<GetCharactersCharacterIdFwStatsVictoryPoints>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdFwStatsVictoryPoints" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdFwStatsVictoryPoints() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdFwStatsVictoryPoints" /> class.
        /// </summary>
        /// <param name="lastWeek">Last week&#39;s victory points gained by the given character (required).</param>
        /// <param name="total">Total victory points gained since the given character enlisted (required).</param>
        /// <param name="yesterday">Yesterday&#39;s victory points gained by the given character (required).</param>
        public GetCharactersCharacterIdFwStatsVictoryPoints(int? lastWeek = default(int?), int? total = default(int?), int? yesterday = default(int?))
        {
            // to ensure "lastWeek" is required (not null)
            if (lastWeek == null)
            {
                throw new InvalidDataException("lastWeek is a required property for GetCharactersCharacterIdFwStatsVictoryPoints and cannot be null");
            }
            else
            {
                this.LastWeek = lastWeek;
            }
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new InvalidDataException("total is a required property for GetCharactersCharacterIdFwStatsVictoryPoints and cannot be null");
            }
            else
            {
                this.Total = total;
            }
            // to ensure "yesterday" is required (not null)
            if (yesterday == null)
            {
                throw new InvalidDataException("yesterday is a required property for GetCharactersCharacterIdFwStatsVictoryPoints and cannot be null");
            }
            else
            {
                this.Yesterday = yesterday;
            }
        }
        
        /// <summary>
        /// Last week&#39;s victory points gained by the given character
        /// </summary>
        /// <value>Last week&#39;s victory points gained by the given character</value>
        [DataMember(Name="last_week", EmitDefaultValue=false)]
        public int? LastWeek { get; set; }

        /// <summary>
        /// Total victory points gained since the given character enlisted
        /// </summary>
        /// <value>Total victory points gained since the given character enlisted</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Yesterday&#39;s victory points gained by the given character
        /// </summary>
        /// <value>Yesterday&#39;s victory points gained by the given character</value>
        [DataMember(Name="yesterday", EmitDefaultValue=false)]
        public int? Yesterday { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdFwStatsVictoryPoints {\n");
            sb.Append("  LastWeek: ").Append(LastWeek).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Yesterday: ").Append(Yesterday).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdFwStatsVictoryPoints);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdFwStatsVictoryPoints instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdFwStatsVictoryPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdFwStatsVictoryPoints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastWeek == input.LastWeek ||
                    (this.LastWeek != null &&
                    this.LastWeek.Equals(input.LastWeek))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Yesterday == input.Yesterday ||
                    (this.Yesterday != null &&
                    this.Yesterday.Equals(input.Yesterday))
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
                if (this.LastWeek != null)
                    hashCode = hashCode * 59 + this.LastWeek.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Yesterday != null)
                    hashCode = hashCode * 59 + this.Yesterday.GetHashCode();
                return hashCode;
            }
        }
    }

}
