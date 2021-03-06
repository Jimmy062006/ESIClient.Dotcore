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
    /// The aggressor corporation or alliance that declared this war, only contains either corporation_id or alliance_id
    /// </summary>
    [DataContract]
    public partial class GetWarsWarIdAggressor :  IEquatable<GetWarsWarIdAggressor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWarsWarIdAggressor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetWarsWarIdAggressor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWarsWarIdAggressor" /> class.
        /// </summary>
        /// <param name="allianceId">Alliance ID if and only if the aggressor is an alliance.</param>
        /// <param name="corporationId">Corporation ID if and only if the aggressor is a corporation.</param>
        /// <param name="iskDestroyed">ISK value of ships the aggressor has destroyed (required).</param>
        /// <param name="shipsKilled">The number of ships the aggressor has killed (required).</param>
        public GetWarsWarIdAggressor(int? allianceId = default(int?), int? corporationId = default(int?), float? iskDestroyed = default(float?), int? shipsKilled = default(int?))
        {
            // to ensure "iskDestroyed" is required (not null)
            if (iskDestroyed == null)
            {
                throw new InvalidDataException("iskDestroyed is a required property for GetWarsWarIdAggressor and cannot be null");
            }
            else
            {
                this.IskDestroyed = iskDestroyed;
            }
            // to ensure "shipsKilled" is required (not null)
            if (shipsKilled == null)
            {
                throw new InvalidDataException("shipsKilled is a required property for GetWarsWarIdAggressor and cannot be null");
            }
            else
            {
                this.ShipsKilled = shipsKilled;
            }
            this.AllianceId = allianceId;
            this.CorporationId = corporationId;
        }
        
        /// <summary>
        /// Alliance ID if and only if the aggressor is an alliance
        /// </summary>
        /// <value>Alliance ID if and only if the aggressor is an alliance</value>
        [DataMember(Name="alliance_id", EmitDefaultValue=false)]
        public int? AllianceId { get; set; }

        /// <summary>
        /// Corporation ID if and only if the aggressor is a corporation
        /// </summary>
        /// <value>Corporation ID if and only if the aggressor is a corporation</value>
        [DataMember(Name="corporation_id", EmitDefaultValue=false)]
        public int? CorporationId { get; set; }

        /// <summary>
        /// ISK value of ships the aggressor has destroyed
        /// </summary>
        /// <value>ISK value of ships the aggressor has destroyed</value>
        [DataMember(Name="isk_destroyed", EmitDefaultValue=false)]
        public float? IskDestroyed { get; set; }

        /// <summary>
        /// The number of ships the aggressor has killed
        /// </summary>
        /// <value>The number of ships the aggressor has killed</value>
        [DataMember(Name="ships_killed", EmitDefaultValue=false)]
        public int? ShipsKilled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetWarsWarIdAggressor {\n");
            sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
            sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
            sb.Append("  IskDestroyed: ").Append(IskDestroyed).Append("\n");
            sb.Append("  ShipsKilled: ").Append(ShipsKilled).Append("\n");
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
            return this.Equals(input as GetWarsWarIdAggressor);
        }

        /// <summary>
        /// Returns true if GetWarsWarIdAggressor instances are equal
        /// </summary>
        /// <param name="input">Instance of GetWarsWarIdAggressor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetWarsWarIdAggressor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllianceId == input.AllianceId ||
                    (this.AllianceId != null &&
                    this.AllianceId.Equals(input.AllianceId))
                ) && 
                (
                    this.CorporationId == input.CorporationId ||
                    (this.CorporationId != null &&
                    this.CorporationId.Equals(input.CorporationId))
                ) && 
                (
                    this.IskDestroyed == input.IskDestroyed ||
                    (this.IskDestroyed != null &&
                    this.IskDestroyed.Equals(input.IskDestroyed))
                ) && 
                (
                    this.ShipsKilled == input.ShipsKilled ||
                    (this.ShipsKilled != null &&
                    this.ShipsKilled.Equals(input.ShipsKilled))
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
                if (this.AllianceId != null)
                    hashCode = hashCode * 59 + this.AllianceId.GetHashCode();
                if (this.CorporationId != null)
                    hashCode = hashCode * 59 + this.CorporationId.GetHashCode();
                if (this.IskDestroyed != null)
                    hashCode = hashCode * 59 + this.IskDestroyed.GetHashCode();
                if (this.ShipsKilled != null)
                    hashCode = hashCode * 59 + this.ShipsKilled.GetHashCode();
                return hashCode;
            }
        }
    }

}
