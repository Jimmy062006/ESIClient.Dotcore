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
    /// attacker object
    /// </summary>
    [DataContract]
    public partial class GetKillmailsKillmailIdKillmailHashAttacker :  IEquatable<GetKillmailsKillmailIdKillmailHashAttacker>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetKillmailsKillmailIdKillmailHashAttacker" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetKillmailsKillmailIdKillmailHashAttacker() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetKillmailsKillmailIdKillmailHashAttacker" /> class.
        /// </summary>
        /// <param name="allianceId">alliance_id integer.</param>
        /// <param name="characterId">character_id integer.</param>
        /// <param name="corporationId">corporation_id integer.</param>
        /// <param name="damageDone">damage_done integer (required).</param>
        /// <param name="factionId">faction_id integer.</param>
        /// <param name="finalBlow">Was the attacker the one to achieve the final blow  (required).</param>
        /// <param name="securityStatus">Security status for the attacker  (required).</param>
        /// <param name="shipTypeId">What ship was the attacker flying .</param>
        /// <param name="weaponTypeId">What weapon was used by the attacker for the kill .</param>
        public GetKillmailsKillmailIdKillmailHashAttacker(int? allianceId = default(int?), int? characterId = default(int?), int? corporationId = default(int?), int? damageDone = default(int?), int? factionId = default(int?), bool? finalBlow = default(bool?), float? securityStatus = default(float?), int? shipTypeId = default(int?), int? weaponTypeId = default(int?))
        {
            // to ensure "damageDone" is required (not null)
            if (damageDone == null)
            {
                throw new InvalidDataException("damageDone is a required property for GetKillmailsKillmailIdKillmailHashAttacker and cannot be null");
            }
            else
            {
                this.DamageDone = damageDone;
            }
            // to ensure "finalBlow" is required (not null)
            if (finalBlow == null)
            {
                throw new InvalidDataException("finalBlow is a required property for GetKillmailsKillmailIdKillmailHashAttacker and cannot be null");
            }
            else
            {
                this.FinalBlow = finalBlow;
            }
            // to ensure "securityStatus" is required (not null)
            if (securityStatus == null)
            {
                throw new InvalidDataException("securityStatus is a required property for GetKillmailsKillmailIdKillmailHashAttacker and cannot be null");
            }
            else
            {
                this.SecurityStatus = securityStatus;
            }
            this.AllianceId = allianceId;
            this.CharacterId = characterId;
            this.CorporationId = corporationId;
            this.FactionId = factionId;
            this.ShipTypeId = shipTypeId;
            this.WeaponTypeId = weaponTypeId;
        }
        
        /// <summary>
        /// alliance_id integer
        /// </summary>
        /// <value>alliance_id integer</value>
        [DataMember(Name="alliance_id", EmitDefaultValue=false)]
        public int? AllianceId { get; set; }

        /// <summary>
        /// character_id integer
        /// </summary>
        /// <value>character_id integer</value>
        [DataMember(Name="character_id", EmitDefaultValue=false)]
        public int? CharacterId { get; set; }

        /// <summary>
        /// corporation_id integer
        /// </summary>
        /// <value>corporation_id integer</value>
        [DataMember(Name="corporation_id", EmitDefaultValue=false)]
        public int? CorporationId { get; set; }

        /// <summary>
        /// damage_done integer
        /// </summary>
        /// <value>damage_done integer</value>
        [DataMember(Name="damage_done", EmitDefaultValue=false)]
        public int? DamageDone { get; set; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        /// <value>faction_id integer</value>
        [DataMember(Name="faction_id", EmitDefaultValue=false)]
        public int? FactionId { get; set; }

        /// <summary>
        /// Was the attacker the one to achieve the final blow 
        /// </summary>
        /// <value>Was the attacker the one to achieve the final blow </value>
        [DataMember(Name="final_blow", EmitDefaultValue=false)]
        public bool? FinalBlow { get; set; }

        /// <summary>
        /// Security status for the attacker 
        /// </summary>
        /// <value>Security status for the attacker </value>
        [DataMember(Name="security_status", EmitDefaultValue=false)]
        public float? SecurityStatus { get; set; }

        /// <summary>
        /// What ship was the attacker flying 
        /// </summary>
        /// <value>What ship was the attacker flying </value>
        [DataMember(Name="ship_type_id", EmitDefaultValue=false)]
        public int? ShipTypeId { get; set; }

        /// <summary>
        /// What weapon was used by the attacker for the kill 
        /// </summary>
        /// <value>What weapon was used by the attacker for the kill </value>
        [DataMember(Name="weapon_type_id", EmitDefaultValue=false)]
        public int? WeaponTypeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetKillmailsKillmailIdKillmailHashAttacker {\n");
            sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
            sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
            sb.Append("  DamageDone: ").Append(DamageDone).Append("\n");
            sb.Append("  FactionId: ").Append(FactionId).Append("\n");
            sb.Append("  FinalBlow: ").Append(FinalBlow).Append("\n");
            sb.Append("  SecurityStatus: ").Append(SecurityStatus).Append("\n");
            sb.Append("  ShipTypeId: ").Append(ShipTypeId).Append("\n");
            sb.Append("  WeaponTypeId: ").Append(WeaponTypeId).Append("\n");
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
            return this.Equals(input as GetKillmailsKillmailIdKillmailHashAttacker);
        }

        /// <summary>
        /// Returns true if GetKillmailsKillmailIdKillmailHashAttacker instances are equal
        /// </summary>
        /// <param name="input">Instance of GetKillmailsKillmailIdKillmailHashAttacker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetKillmailsKillmailIdKillmailHashAttacker input)
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
                    this.CharacterId == input.CharacterId ||
                    (this.CharacterId != null &&
                    this.CharacterId.Equals(input.CharacterId))
                ) && 
                (
                    this.CorporationId == input.CorporationId ||
                    (this.CorporationId != null &&
                    this.CorporationId.Equals(input.CorporationId))
                ) && 
                (
                    this.DamageDone == input.DamageDone ||
                    (this.DamageDone != null &&
                    this.DamageDone.Equals(input.DamageDone))
                ) && 
                (
                    this.FactionId == input.FactionId ||
                    (this.FactionId != null &&
                    this.FactionId.Equals(input.FactionId))
                ) && 
                (
                    this.FinalBlow == input.FinalBlow ||
                    (this.FinalBlow != null &&
                    this.FinalBlow.Equals(input.FinalBlow))
                ) && 
                (
                    this.SecurityStatus == input.SecurityStatus ||
                    (this.SecurityStatus != null &&
                    this.SecurityStatus.Equals(input.SecurityStatus))
                ) && 
                (
                    this.ShipTypeId == input.ShipTypeId ||
                    (this.ShipTypeId != null &&
                    this.ShipTypeId.Equals(input.ShipTypeId))
                ) && 
                (
                    this.WeaponTypeId == input.WeaponTypeId ||
                    (this.WeaponTypeId != null &&
                    this.WeaponTypeId.Equals(input.WeaponTypeId))
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
                if (this.CharacterId != null)
                    hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
                if (this.CorporationId != null)
                    hashCode = hashCode * 59 + this.CorporationId.GetHashCode();
                if (this.DamageDone != null)
                    hashCode = hashCode * 59 + this.DamageDone.GetHashCode();
                if (this.FactionId != null)
                    hashCode = hashCode * 59 + this.FactionId.GetHashCode();
                if (this.FinalBlow != null)
                    hashCode = hashCode * 59 + this.FinalBlow.GetHashCode();
                if (this.SecurityStatus != null)
                    hashCode = hashCode * 59 + this.SecurityStatus.GetHashCode();
                if (this.ShipTypeId != null)
                    hashCode = hashCode * 59 + this.ShipTypeId.GetHashCode();
                if (this.WeaponTypeId != null)
                    hashCode = hashCode * 59 + this.WeaponTypeId.GetHashCode();
                return hashCode;
            }
        }
    }

}
