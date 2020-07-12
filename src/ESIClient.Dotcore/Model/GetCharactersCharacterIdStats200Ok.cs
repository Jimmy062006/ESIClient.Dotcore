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
    /// Aggregate stats for a year
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdStats200Ok :  IEquatable<GetCharactersCharacterIdStats200Ok>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdStats200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdStats200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdStats200Ok" /> class.
        /// </summary>
        /// <param name="character">character.</param>
        /// <param name="combat">combat.</param>
        /// <param name="industry">industry.</param>
        /// <param name="inventory">inventory.</param>
        /// <param name="isk">isk.</param>
        /// <param name="market">market.</param>
        /// <param name="mining">mining.</param>
        /// <param name="module">module.</param>
        /// <param name="orbital">orbital.</param>
        /// <param name="pve">pve.</param>
        /// <param name="social">social.</param>
        /// <param name="travel">travel.</param>
        /// <param name="year">Gregorian year for this set of aggregates (required).</param>
        public GetCharactersCharacterIdStats200Ok(GetCharactersCharacterIdStatsCharacter character = default(GetCharactersCharacterIdStatsCharacter), GetCharactersCharacterIdStatsCombat combat = default(GetCharactersCharacterIdStatsCombat), GetCharactersCharacterIdStatsIndustry industry = default(GetCharactersCharacterIdStatsIndustry), GetCharactersCharacterIdStatsInventory inventory = default(GetCharactersCharacterIdStatsInventory), GetCharactersCharacterIdStatsIsk isk = default(GetCharactersCharacterIdStatsIsk), GetCharactersCharacterIdStatsMarket market = default(GetCharactersCharacterIdStatsMarket), GetCharactersCharacterIdStatsMining mining = default(GetCharactersCharacterIdStatsMining), GetCharactersCharacterIdStatsModule module = default(GetCharactersCharacterIdStatsModule), GetCharactersCharacterIdStatsOrbital orbital = default(GetCharactersCharacterIdStatsOrbital), GetCharactersCharacterIdStatsPve pve = default(GetCharactersCharacterIdStatsPve), GetCharactersCharacterIdStatsSocial social = default(GetCharactersCharacterIdStatsSocial), GetCharactersCharacterIdStatsTravel travel = default(GetCharactersCharacterIdStatsTravel), int? year = default(int?))
        {
            // to ensure "year" is required (not null)
            if (year == null)
            {
                throw new InvalidDataException("year is a required property for GetCharactersCharacterIdStats200Ok and cannot be null");
            }
            else
            {
                this.Year = year;
            }
            this.Character = character;
            this.Combat = combat;
            this.Industry = industry;
            this.Inventory = inventory;
            this.Isk = isk;
            this.Market = market;
            this.Mining = mining;
            this.Module = module;
            this.Orbital = orbital;
            this.Pve = pve;
            this.Social = social;
            this.Travel = travel;
        }
        
        /// <summary>
        /// Gets or Sets Character
        /// </summary>
        [DataMember(Name="character", EmitDefaultValue=false)]
        public GetCharactersCharacterIdStatsCharacter Character { get; set; }

        /// <summary>
        /// Gets or Sets Combat
        /// </summary>
        [DataMember(Name="combat", EmitDefaultValue=false)]
        public GetCharactersCharacterIdStatsCombat Combat { get; set; }

        /// <summary>
        /// Gets or Sets Industry
        /// </summary>
        [DataMember(Name="industry", EmitDefaultValue=false)]
        public GetCharactersCharacterIdStatsIndustry Industry { get; set; }

        /// <summary>
        /// Gets or Sets Inventory
        /// </summary>
        [DataMember(Name="inventory", EmitDefaultValue=false)]
        public GetCharactersCharacterIdStatsInventory Inventory { get; set; }

        /// <summary>
        /// Gets or Sets Isk
        /// </summary>
        [DataMember(Name="isk", EmitDefaultValue=false)]
        public GetCharactersCharacterIdStatsIsk Isk { get; set; }

        /// <summary>
        /// Gets or Sets Market
        /// </summary>
        [DataMember(Name="market", EmitDefaultValue=false)]
        public GetCharactersCharacterIdStatsMarket Market { get; set; }

        /// <summary>
        /// Gets or Sets Mining
        /// </summary>
        [DataMember(Name="mining", EmitDefaultValue=false)]
        public GetCharactersCharacterIdStatsMining Mining { get; set; }

        /// <summary>
        /// Gets or Sets Module
        /// </summary>
        [DataMember(Name="module", EmitDefaultValue=false)]
        public GetCharactersCharacterIdStatsModule Module { get; set; }

        /// <summary>
        /// Gets or Sets Orbital
        /// </summary>
        [DataMember(Name="orbital", EmitDefaultValue=false)]
        public GetCharactersCharacterIdStatsOrbital Orbital { get; set; }

        /// <summary>
        /// Gets or Sets Pve
        /// </summary>
        [DataMember(Name="pve", EmitDefaultValue=false)]
        public GetCharactersCharacterIdStatsPve Pve { get; set; }

        /// <summary>
        /// Gets or Sets Social
        /// </summary>
        [DataMember(Name="social", EmitDefaultValue=false)]
        public GetCharactersCharacterIdStatsSocial Social { get; set; }

        /// <summary>
        /// Gets or Sets Travel
        /// </summary>
        [DataMember(Name="travel", EmitDefaultValue=false)]
        public GetCharactersCharacterIdStatsTravel Travel { get; set; }

        /// <summary>
        /// Gregorian year for this set of aggregates
        /// </summary>
        /// <value>Gregorian year for this set of aggregates</value>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdStats200Ok {\n");
            sb.Append("  Character: ").Append(Character).Append("\n");
            sb.Append("  Combat: ").Append(Combat).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  Inventory: ").Append(Inventory).Append("\n");
            sb.Append("  Isk: ").Append(Isk).Append("\n");
            sb.Append("  Market: ").Append(Market).Append("\n");
            sb.Append("  Mining: ").Append(Mining).Append("\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  Orbital: ").Append(Orbital).Append("\n");
            sb.Append("  Pve: ").Append(Pve).Append("\n");
            sb.Append("  Social: ").Append(Social).Append("\n");
            sb.Append("  Travel: ").Append(Travel).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdStats200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdStats200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdStats200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdStats200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Character == input.Character ||
                    (this.Character != null &&
                    this.Character.Equals(input.Character))
                ) && 
                (
                    this.Combat == input.Combat ||
                    (this.Combat != null &&
                    this.Combat.Equals(input.Combat))
                ) && 
                (
                    this.Industry == input.Industry ||
                    (this.Industry != null &&
                    this.Industry.Equals(input.Industry))
                ) && 
                (
                    this.Inventory == input.Inventory ||
                    (this.Inventory != null &&
                    this.Inventory.Equals(input.Inventory))
                ) && 
                (
                    this.Isk == input.Isk ||
                    (this.Isk != null &&
                    this.Isk.Equals(input.Isk))
                ) && 
                (
                    this.Market == input.Market ||
                    (this.Market != null &&
                    this.Market.Equals(input.Market))
                ) && 
                (
                    this.Mining == input.Mining ||
                    (this.Mining != null &&
                    this.Mining.Equals(input.Mining))
                ) && 
                (
                    this.Module == input.Module ||
                    (this.Module != null &&
                    this.Module.Equals(input.Module))
                ) && 
                (
                    this.Orbital == input.Orbital ||
                    (this.Orbital != null &&
                    this.Orbital.Equals(input.Orbital))
                ) && 
                (
                    this.Pve == input.Pve ||
                    (this.Pve != null &&
                    this.Pve.Equals(input.Pve))
                ) && 
                (
                    this.Social == input.Social ||
                    (this.Social != null &&
                    this.Social.Equals(input.Social))
                ) && 
                (
                    this.Travel == input.Travel ||
                    (this.Travel != null &&
                    this.Travel.Equals(input.Travel))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
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
                if (this.Character != null)
                    hashCode = hashCode * 59 + this.Character.GetHashCode();
                if (this.Combat != null)
                    hashCode = hashCode * 59 + this.Combat.GetHashCode();
                if (this.Industry != null)
                    hashCode = hashCode * 59 + this.Industry.GetHashCode();
                if (this.Inventory != null)
                    hashCode = hashCode * 59 + this.Inventory.GetHashCode();
                if (this.Isk != null)
                    hashCode = hashCode * 59 + this.Isk.GetHashCode();
                if (this.Market != null)
                    hashCode = hashCode * 59 + this.Market.GetHashCode();
                if (this.Mining != null)
                    hashCode = hashCode * 59 + this.Mining.GetHashCode();
                if (this.Module != null)
                    hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.Orbital != null)
                    hashCode = hashCode * 59 + this.Orbital.GetHashCode();
                if (this.Pve != null)
                    hashCode = hashCode * 59 + this.Pve.GetHashCode();
                if (this.Social != null)
                    hashCode = hashCode * 59 + this.Social.GetHashCode();
                if (this.Travel != null)
                    hashCode = hashCode * 59 + this.Travel.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                return hashCode;
            }
        }
    }

}
