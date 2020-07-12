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
    public partial class GetIncursions200Ok :  IEquatable<GetIncursions200Ok>
    {
        /// <summary>
        /// The state of this incursion
        /// </summary>
        /// <value>The state of this incursion</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Withdrawing for value: withdrawing
            /// </summary>
            [EnumMember(Value = "withdrawing")]
            Withdrawing = 1,
            
            /// <summary>
            /// Enum Mobilizing for value: mobilizing
            /// </summary>
            [EnumMember(Value = "mobilizing")]
            Mobilizing = 2,
            
            /// <summary>
            /// Enum Established for value: established
            /// </summary>
            [EnumMember(Value = "established")]
            Established = 3
        }

        /// <summary>
        /// The state of this incursion
        /// </summary>
        /// <value>The state of this incursion</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetIncursions200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetIncursions200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetIncursions200Ok" /> class.
        /// </summary>
        /// <param name="constellationId">The constellation id in which this incursion takes place (required).</param>
        /// <param name="factionId">The attacking faction&#39;s id (required).</param>
        /// <param name="hasBoss">Whether the final encounter has boss or not (required).</param>
        /// <param name="infestedSolarSystems">A list of infested solar system ids that are a part of this incursion (required).</param>
        /// <param name="influence">Influence of this incursion as a float from 0 to 1 (required).</param>
        /// <param name="stagingSolarSystemId">Staging solar system for this incursion (required).</param>
        /// <param name="state">The state of this incursion (required).</param>
        /// <param name="type">The type of this incursion (required).</param>
        public GetIncursions200Ok(int? constellationId = default(int?), int? factionId = default(int?), bool? hasBoss = default(bool?), List<int?> infestedSolarSystems = default(List<int?>), float? influence = default(float?), int? stagingSolarSystemId = default(int?), StateEnum state = default(StateEnum), string type = default(string))
        {
            // to ensure "constellationId" is required (not null)
            if (constellationId == null)
            {
                throw new InvalidDataException("constellationId is a required property for GetIncursions200Ok and cannot be null");
            }
            else
            {
                this.ConstellationId = constellationId;
            }
            // to ensure "factionId" is required (not null)
            if (factionId == null)
            {
                throw new InvalidDataException("factionId is a required property for GetIncursions200Ok and cannot be null");
            }
            else
            {
                this.FactionId = factionId;
            }
            // to ensure "hasBoss" is required (not null)
            if (hasBoss == null)
            {
                throw new InvalidDataException("hasBoss is a required property for GetIncursions200Ok and cannot be null");
            }
            else
            {
                this.HasBoss = hasBoss;
            }
            // to ensure "infestedSolarSystems" is required (not null)
            if (infestedSolarSystems == null)
            {
                throw new InvalidDataException("infestedSolarSystems is a required property for GetIncursions200Ok and cannot be null");
            }
            else
            {
                this.InfestedSolarSystems = infestedSolarSystems;
            }
            // to ensure "influence" is required (not null)
            if (influence == null)
            {
                throw new InvalidDataException("influence is a required property for GetIncursions200Ok and cannot be null");
            }
            else
            {
                this.Influence = influence;
            }
            // to ensure "stagingSolarSystemId" is required (not null)
            if (stagingSolarSystemId == null)
            {
                throw new InvalidDataException("stagingSolarSystemId is a required property for GetIncursions200Ok and cannot be null");
            }
            else
            {
                this.StagingSolarSystemId = stagingSolarSystemId;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for GetIncursions200Ok and cannot be null");
            }
            else
            {
                this.State = state;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for GetIncursions200Ok and cannot be null");
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// The constellation id in which this incursion takes place
        /// </summary>
        /// <value>The constellation id in which this incursion takes place</value>
        [DataMember(Name="constellation_id", EmitDefaultValue=false)]
        public int? ConstellationId { get; set; }

        /// <summary>
        /// The attacking faction&#39;s id
        /// </summary>
        /// <value>The attacking faction&#39;s id</value>
        [DataMember(Name="faction_id", EmitDefaultValue=false)]
        public int? FactionId { get; set; }

        /// <summary>
        /// Whether the final encounter has boss or not
        /// </summary>
        /// <value>Whether the final encounter has boss or not</value>
        [DataMember(Name="has_boss", EmitDefaultValue=false)]
        public bool? HasBoss { get; set; }

        /// <summary>
        /// A list of infested solar system ids that are a part of this incursion
        /// </summary>
        /// <value>A list of infested solar system ids that are a part of this incursion</value>
        [DataMember(Name="infested_solar_systems", EmitDefaultValue=false)]
        public List<int?> InfestedSolarSystems { get; set; }

        /// <summary>
        /// Influence of this incursion as a float from 0 to 1
        /// </summary>
        /// <value>Influence of this incursion as a float from 0 to 1</value>
        [DataMember(Name="influence", EmitDefaultValue=false)]
        public float? Influence { get; set; }

        /// <summary>
        /// Staging solar system for this incursion
        /// </summary>
        /// <value>Staging solar system for this incursion</value>
        [DataMember(Name="staging_solar_system_id", EmitDefaultValue=false)]
        public int? StagingSolarSystemId { get; set; }


        /// <summary>
        /// The type of this incursion
        /// </summary>
        /// <value>The type of this incursion</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetIncursions200Ok {\n");
            sb.Append("  ConstellationId: ").Append(ConstellationId).Append("\n");
            sb.Append("  FactionId: ").Append(FactionId).Append("\n");
            sb.Append("  HasBoss: ").Append(HasBoss).Append("\n");
            sb.Append("  InfestedSolarSystems: ").Append(InfestedSolarSystems).Append("\n");
            sb.Append("  Influence: ").Append(Influence).Append("\n");
            sb.Append("  StagingSolarSystemId: ").Append(StagingSolarSystemId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GetIncursions200Ok);
        }

        /// <summary>
        /// Returns true if GetIncursions200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetIncursions200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetIncursions200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConstellationId == input.ConstellationId ||
                    (this.ConstellationId != null &&
                    this.ConstellationId.Equals(input.ConstellationId))
                ) && 
                (
                    this.FactionId == input.FactionId ||
                    (this.FactionId != null &&
                    this.FactionId.Equals(input.FactionId))
                ) && 
                (
                    this.HasBoss == input.HasBoss ||
                    (this.HasBoss != null &&
                    this.HasBoss.Equals(input.HasBoss))
                ) && 
                (
                    this.InfestedSolarSystems == input.InfestedSolarSystems ||
                    this.InfestedSolarSystems != null &&
                    this.InfestedSolarSystems.SequenceEqual(input.InfestedSolarSystems)
                ) && 
                (
                    this.Influence == input.Influence ||
                    (this.Influence != null &&
                    this.Influence.Equals(input.Influence))
                ) && 
                (
                    this.StagingSolarSystemId == input.StagingSolarSystemId ||
                    (this.StagingSolarSystemId != null &&
                    this.StagingSolarSystemId.Equals(input.StagingSolarSystemId))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ConstellationId != null)
                    hashCode = hashCode * 59 + this.ConstellationId.GetHashCode();
                if (this.FactionId != null)
                    hashCode = hashCode * 59 + this.FactionId.GetHashCode();
                if (this.HasBoss != null)
                    hashCode = hashCode * 59 + this.HasBoss.GetHashCode();
                if (this.InfestedSolarSystems != null)
                    hashCode = hashCode * 59 + this.InfestedSolarSystems.GetHashCode();
                if (this.Influence != null)
                    hashCode = hashCode * 59 + this.Influence.GetHashCode();
                if (this.StagingSolarSystemId != null)
                    hashCode = hashCode * 59 + this.StagingSolarSystemId.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }

}
