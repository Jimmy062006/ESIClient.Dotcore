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
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetCorporationsCorporationIdFwStatsOk :  IEquatable<GetCorporationsCorporationIdFwStatsOk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdFwStatsOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationsCorporationIdFwStatsOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdFwStatsOk" /> class.
        /// </summary>
        /// <param name="enlistedOn">The enlistment date of the given corporation into faction warfare. Will not be included if corporation is not enlisted in faction warfare.</param>
        /// <param name="factionId">The faction the given corporation is enlisted to fight for. Will not be included if corporation is not enlisted in faction warfare.</param>
        /// <param name="kills">kills (required).</param>
        /// <param name="pilots">How many pilots the enlisted corporation has. Will not be included if corporation is not enlisted in faction warfare.</param>
        /// <param name="victoryPoints">victoryPoints (required).</param>
        public GetCorporationsCorporationIdFwStatsOk(DateTime? enlistedOn = default(DateTime?), int? factionId = default(int?), GetCorporationsCorporationIdFwStatsKills kills = default(GetCorporationsCorporationIdFwStatsKills), int? pilots = default(int?), GetCorporationsCorporationIdFwStatsVictoryPoints victoryPoints = default(GetCorporationsCorporationIdFwStatsVictoryPoints))
        {
            // to ensure "kills" is required (not null)
            if (kills == null)
            {
                throw new InvalidDataException("kills is a required property for GetCorporationsCorporationIdFwStatsOk and cannot be null");
            }
            else
            {
                this.Kills = kills;
            }
            // to ensure "victoryPoints" is required (not null)
            if (victoryPoints == null)
            {
                throw new InvalidDataException("victoryPoints is a required property for GetCorporationsCorporationIdFwStatsOk and cannot be null");
            }
            else
            {
                this.VictoryPoints = victoryPoints;
            }
            this.EnlistedOn = enlistedOn;
            this.FactionId = factionId;
            this.Pilots = pilots;
        }
        
        /// <summary>
        /// The enlistment date of the given corporation into faction warfare. Will not be included if corporation is not enlisted in faction warfare
        /// </summary>
        /// <value>The enlistment date of the given corporation into faction warfare. Will not be included if corporation is not enlisted in faction warfare</value>
        [DataMember(Name="enlisted_on", EmitDefaultValue=false)]
        public DateTime? EnlistedOn { get; set; }

        /// <summary>
        /// The faction the given corporation is enlisted to fight for. Will not be included if corporation is not enlisted in faction warfare
        /// </summary>
        /// <value>The faction the given corporation is enlisted to fight for. Will not be included if corporation is not enlisted in faction warfare</value>
        [DataMember(Name="faction_id", EmitDefaultValue=false)]
        public int? FactionId { get; set; }

        /// <summary>
        /// Gets or Sets Kills
        /// </summary>
        [DataMember(Name="kills", EmitDefaultValue=false)]
        public GetCorporationsCorporationIdFwStatsKills Kills { get; set; }

        /// <summary>
        /// How many pilots the enlisted corporation has. Will not be included if corporation is not enlisted in faction warfare
        /// </summary>
        /// <value>How many pilots the enlisted corporation has. Will not be included if corporation is not enlisted in faction warfare</value>
        [DataMember(Name="pilots", EmitDefaultValue=false)]
        public int? Pilots { get; set; }

        /// <summary>
        /// Gets or Sets VictoryPoints
        /// </summary>
        [DataMember(Name="victory_points", EmitDefaultValue=false)]
        public GetCorporationsCorporationIdFwStatsVictoryPoints VictoryPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationsCorporationIdFwStatsOk {\n");
            sb.Append("  EnlistedOn: ").Append(EnlistedOn).Append("\n");
            sb.Append("  FactionId: ").Append(FactionId).Append("\n");
            sb.Append("  Kills: ").Append(Kills).Append("\n");
            sb.Append("  Pilots: ").Append(Pilots).Append("\n");
            sb.Append("  VictoryPoints: ").Append(VictoryPoints).Append("\n");
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
            return this.Equals(input as GetCorporationsCorporationIdFwStatsOk);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdFwStatsOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationsCorporationIdFwStatsOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdFwStatsOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnlistedOn == input.EnlistedOn ||
                    (this.EnlistedOn != null &&
                    this.EnlistedOn.Equals(input.EnlistedOn))
                ) && 
                (
                    this.FactionId == input.FactionId ||
                    (this.FactionId != null &&
                    this.FactionId.Equals(input.FactionId))
                ) && 
                (
                    this.Kills == input.Kills ||
                    (this.Kills != null &&
                    this.Kills.Equals(input.Kills))
                ) && 
                (
                    this.Pilots == input.Pilots ||
                    (this.Pilots != null &&
                    this.Pilots.Equals(input.Pilots))
                ) && 
                (
                    this.VictoryPoints == input.VictoryPoints ||
                    (this.VictoryPoints != null &&
                    this.VictoryPoints.Equals(input.VictoryPoints))
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
                if (this.EnlistedOn != null)
                    hashCode = hashCode * 59 + this.EnlistedOn.GetHashCode();
                if (this.FactionId != null)
                    hashCode = hashCode * 59 + this.FactionId.GetHashCode();
                if (this.Kills != null)
                    hashCode = hashCode * 59 + this.Kills.GetHashCode();
                if (this.Pilots != null)
                    hashCode = hashCode * 59 + this.Pilots.GetHashCode();
                if (this.VictoryPoints != null)
                    hashCode = hashCode * 59 + this.VictoryPoints.GetHashCode();
                return hashCode;
            }
        }
    }

}
