/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.7.5
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = ESIClient.Client.SwaggerDateConverter;

namespace ESIClient.Model
{
    /// <summary>
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetCorporationsCorporationIdStructures200Ok :  IEquatable<GetCorporationsCorporationIdStructures200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdStructures200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationsCorporationIdStructures200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdStructures200Ok" /> class.
        /// </summary>
        /// <param name="structureId">The Item ID of the structure (required).</param>
        /// <param name="typeId">The type id of the structure (required).</param>
        /// <param name="corporationId">ID of the corporation that owns the structure (required).</param>
        /// <param name="systemId">The solar system the structure is in (required).</param>
        /// <param name="profileId">The id of the ACL profile for this citadel (required).</param>
        /// <param name="currentVul">This week&#39;s vulnerability windows, Monday is day 0 (required).</param>
        /// <param name="nextVul">Next week&#39;s vulnerability windows, Monday is day 0 (required).</param>
        /// <param name="fuelExpires">Date on which the structure will run out of fuel.</param>
        /// <param name="services">Contains a list of service upgrades, and their state.</param>
        /// <param name="stateTimerStart">Date at which the structure entered it&#39;s current state.</param>
        /// <param name="stateTimerEnd">Date at which the structure will move to it&#39;s next state.</param>
        /// <param name="unanchorsAt">Date at which the structure will unanchor.</param>
        public GetCorporationsCorporationIdStructures200Ok(long? structureId = default(long?), int? typeId = default(int?), int? corporationId = default(int?), int? systemId = default(int?), int? profileId = default(int?), List<GetCorporationsCorporationIdStructuresCurrentVul> currentVul = default(List<GetCorporationsCorporationIdStructuresCurrentVul>), List<GetCorporationsCorporationIdStructuresNextVul> nextVul = default(List<GetCorporationsCorporationIdStructuresNextVul>), DateTime? fuelExpires = default(DateTime?), List<GetCorporationsCorporationIdStructuresService> services = default(List<GetCorporationsCorporationIdStructuresService>), DateTime? stateTimerStart = default(DateTime?), DateTime? stateTimerEnd = default(DateTime?), DateTime? unanchorsAt = default(DateTime?))
        {
            // to ensure "structureId" is required (not null)
            if (structureId == null)
            {
                throw new InvalidDataException("structureId is a required property for GetCorporationsCorporationIdStructures200Ok and cannot be null");
            }
            else
            {
                this.StructureId = structureId;
            }
            // to ensure "typeId" is required (not null)
            if (typeId == null)
            {
                throw new InvalidDataException("typeId is a required property for GetCorporationsCorporationIdStructures200Ok and cannot be null");
            }
            else
            {
                this.TypeId = typeId;
            }
            // to ensure "corporationId" is required (not null)
            if (corporationId == null)
            {
                throw new InvalidDataException("corporationId is a required property for GetCorporationsCorporationIdStructures200Ok and cannot be null");
            }
            else
            {
                this.CorporationId = corporationId;
            }
            // to ensure "systemId" is required (not null)
            if (systemId == null)
            {
                throw new InvalidDataException("systemId is a required property for GetCorporationsCorporationIdStructures200Ok and cannot be null");
            }
            else
            {
                this.SystemId = systemId;
            }
            // to ensure "profileId" is required (not null)
            if (profileId == null)
            {
                throw new InvalidDataException("profileId is a required property for GetCorporationsCorporationIdStructures200Ok and cannot be null");
            }
            else
            {
                this.ProfileId = profileId;
            }
            // to ensure "currentVul" is required (not null)
            if (currentVul == null)
            {
                throw new InvalidDataException("currentVul is a required property for GetCorporationsCorporationIdStructures200Ok and cannot be null");
            }
            else
            {
                this.CurrentVul = currentVul;
            }
            // to ensure "nextVul" is required (not null)
            if (nextVul == null)
            {
                throw new InvalidDataException("nextVul is a required property for GetCorporationsCorporationIdStructures200Ok and cannot be null");
            }
            else
            {
                this.NextVul = nextVul;
            }
            this.FuelExpires = fuelExpires;
            this.Services = services;
            this.StateTimerStart = stateTimerStart;
            this.StateTimerEnd = stateTimerEnd;
            this.UnanchorsAt = unanchorsAt;
        }
        
        /// <summary>
        /// The Item ID of the structure
        /// </summary>
        /// <value>The Item ID of the structure</value>
        [DataMember(Name="structure_id", EmitDefaultValue=false)]
        public long? StructureId { get; set; }

        /// <summary>
        /// The type id of the structure
        /// </summary>
        /// <value>The type id of the structure</value>
        [DataMember(Name="type_id", EmitDefaultValue=false)]
        public int? TypeId { get; set; }

        /// <summary>
        /// ID of the corporation that owns the structure
        /// </summary>
        /// <value>ID of the corporation that owns the structure</value>
        [DataMember(Name="corporation_id", EmitDefaultValue=false)]
        public int? CorporationId { get; set; }

        /// <summary>
        /// The solar system the structure is in
        /// </summary>
        /// <value>The solar system the structure is in</value>
        [DataMember(Name="system_id", EmitDefaultValue=false)]
        public int? SystemId { get; set; }

        /// <summary>
        /// The id of the ACL profile for this citadel
        /// </summary>
        /// <value>The id of the ACL profile for this citadel</value>
        [DataMember(Name="profile_id", EmitDefaultValue=false)]
        public int? ProfileId { get; set; }

        /// <summary>
        /// This week&#39;s vulnerability windows, Monday is day 0
        /// </summary>
        /// <value>This week&#39;s vulnerability windows, Monday is day 0</value>
        [DataMember(Name="current_vul", EmitDefaultValue=false)]
        public List<GetCorporationsCorporationIdStructuresCurrentVul> CurrentVul { get; set; }

        /// <summary>
        /// Next week&#39;s vulnerability windows, Monday is day 0
        /// </summary>
        /// <value>Next week&#39;s vulnerability windows, Monday is day 0</value>
        [DataMember(Name="next_vul", EmitDefaultValue=false)]
        public List<GetCorporationsCorporationIdStructuresNextVul> NextVul { get; set; }

        /// <summary>
        /// Date on which the structure will run out of fuel
        /// </summary>
        /// <value>Date on which the structure will run out of fuel</value>
        [DataMember(Name="fuel_expires", EmitDefaultValue=false)]
        public DateTime? FuelExpires { get; set; }

        /// <summary>
        /// Contains a list of service upgrades, and their state
        /// </summary>
        /// <value>Contains a list of service upgrades, and their state</value>
        [DataMember(Name="services", EmitDefaultValue=false)]
        public List<GetCorporationsCorporationIdStructuresService> Services { get; set; }

        /// <summary>
        /// Date at which the structure entered it&#39;s current state
        /// </summary>
        /// <value>Date at which the structure entered it&#39;s current state</value>
        [DataMember(Name="state_timer_start", EmitDefaultValue=false)]
        public DateTime? StateTimerStart { get; set; }

        /// <summary>
        /// Date at which the structure will move to it&#39;s next state
        /// </summary>
        /// <value>Date at which the structure will move to it&#39;s next state</value>
        [DataMember(Name="state_timer_end", EmitDefaultValue=false)]
        public DateTime? StateTimerEnd { get; set; }

        /// <summary>
        /// Date at which the structure will unanchor
        /// </summary>
        /// <value>Date at which the structure will unanchor</value>
        [DataMember(Name="unanchors_at", EmitDefaultValue=false)]
        public DateTime? UnanchorsAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationsCorporationIdStructures200Ok {\n");
            sb.Append("  StructureId: ").Append(StructureId).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  CurrentVul: ").Append(CurrentVul).Append("\n");
            sb.Append("  NextVul: ").Append(NextVul).Append("\n");
            sb.Append("  FuelExpires: ").Append(FuelExpires).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  StateTimerStart: ").Append(StateTimerStart).Append("\n");
            sb.Append("  StateTimerEnd: ").Append(StateTimerEnd).Append("\n");
            sb.Append("  UnanchorsAt: ").Append(UnanchorsAt).Append("\n");
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
            return this.Equals(input as GetCorporationsCorporationIdStructures200Ok);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdStructures200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationsCorporationIdStructures200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdStructures200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StructureId == input.StructureId ||
                    (this.StructureId != null &&
                    this.StructureId.Equals(input.StructureId))
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
                ) && 
                (
                    this.CorporationId == input.CorporationId ||
                    (this.CorporationId != null &&
                    this.CorporationId.Equals(input.CorporationId))
                ) && 
                (
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
                ) && 
                (
                    this.ProfileId == input.ProfileId ||
                    (this.ProfileId != null &&
                    this.ProfileId.Equals(input.ProfileId))
                ) && 
                (
                    this.CurrentVul == input.CurrentVul ||
                    this.CurrentVul != null &&
                    this.CurrentVul.SequenceEqual(input.CurrentVul)
                ) && 
                (
                    this.NextVul == input.NextVul ||
                    this.NextVul != null &&
                    this.NextVul.SequenceEqual(input.NextVul)
                ) && 
                (
                    this.FuelExpires == input.FuelExpires ||
                    (this.FuelExpires != null &&
                    this.FuelExpires.Equals(input.FuelExpires))
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    this.Services.SequenceEqual(input.Services)
                ) && 
                (
                    this.StateTimerStart == input.StateTimerStart ||
                    (this.StateTimerStart != null &&
                    this.StateTimerStart.Equals(input.StateTimerStart))
                ) && 
                (
                    this.StateTimerEnd == input.StateTimerEnd ||
                    (this.StateTimerEnd != null &&
                    this.StateTimerEnd.Equals(input.StateTimerEnd))
                ) && 
                (
                    this.UnanchorsAt == input.UnanchorsAt ||
                    (this.UnanchorsAt != null &&
                    this.UnanchorsAt.Equals(input.UnanchorsAt))
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
                if (this.StructureId != null)
                    hashCode = hashCode * 59 + this.StructureId.GetHashCode();
                if (this.TypeId != null)
                    hashCode = hashCode * 59 + this.TypeId.GetHashCode();
                if (this.CorporationId != null)
                    hashCode = hashCode * 59 + this.CorporationId.GetHashCode();
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
                if (this.ProfileId != null)
                    hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                if (this.CurrentVul != null)
                    hashCode = hashCode * 59 + this.CurrentVul.GetHashCode();
                if (this.NextVul != null)
                    hashCode = hashCode * 59 + this.NextVul.GetHashCode();
                if (this.FuelExpires != null)
                    hashCode = hashCode * 59 + this.FuelExpires.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.StateTimerStart != null)
                    hashCode = hashCode * 59 + this.StateTimerStart.GetHashCode();
                if (this.StateTimerEnd != null)
                    hashCode = hashCode * 59 + this.StateTimerEnd.GetHashCode();
                if (this.UnanchorsAt != null)
                    hashCode = hashCode * 59 + this.UnanchorsAt.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}