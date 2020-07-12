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
    /// invitation object
    /// </summary>
    [DataContract]
    public partial class PostFleetsFleetIdMembersInvitation :  IEquatable<PostFleetsFleetIdMembersInvitation>
    {
        /// <summary>
        /// If a character is invited with the &#x60;fleet_commander&#x60; role, neither &#x60;wing_id&#x60; or &#x60;squad_id&#x60; should be specified. If a character is invited with the &#x60;wing_commander&#x60; role, only &#x60;wing_id&#x60; should be specified. If a character is invited with the &#x60;squad_commander&#x60; role, both &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should be specified. If a character is invited with the &#x60;squad_member&#x60; role, &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should either both be specified or not specified at all. If they aren’t specified, the invited character will join any squad with available positions.
        /// </summary>
        /// <value>If a character is invited with the &#x60;fleet_commander&#x60; role, neither &#x60;wing_id&#x60; or &#x60;squad_id&#x60; should be specified. If a character is invited with the &#x60;wing_commander&#x60; role, only &#x60;wing_id&#x60; should be specified. If a character is invited with the &#x60;squad_commander&#x60; role, both &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should be specified. If a character is invited with the &#x60;squad_member&#x60; role, &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should either both be specified or not specified at all. If they aren’t specified, the invited character will join any squad with available positions.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            
            /// <summary>
            /// Enum Fleetcommander for value: fleet_commander
            /// </summary>
            [EnumMember(Value = "fleet_commander")]
            Fleetcommander = 1,
            
            /// <summary>
            /// Enum Wingcommander for value: wing_commander
            /// </summary>
            [EnumMember(Value = "wing_commander")]
            Wingcommander = 2,
            
            /// <summary>
            /// Enum Squadcommander for value: squad_commander
            /// </summary>
            [EnumMember(Value = "squad_commander")]
            Squadcommander = 3,
            
            /// <summary>
            /// Enum Squadmember for value: squad_member
            /// </summary>
            [EnumMember(Value = "squad_member")]
            Squadmember = 4
        }

        /// <summary>
        /// If a character is invited with the &#x60;fleet_commander&#x60; role, neither &#x60;wing_id&#x60; or &#x60;squad_id&#x60; should be specified. If a character is invited with the &#x60;wing_commander&#x60; role, only &#x60;wing_id&#x60; should be specified. If a character is invited with the &#x60;squad_commander&#x60; role, both &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should be specified. If a character is invited with the &#x60;squad_member&#x60; role, &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should either both be specified or not specified at all. If they aren’t specified, the invited character will join any squad with available positions.
        /// </summary>
        /// <value>If a character is invited with the &#x60;fleet_commander&#x60; role, neither &#x60;wing_id&#x60; or &#x60;squad_id&#x60; should be specified. If a character is invited with the &#x60;wing_commander&#x60; role, only &#x60;wing_id&#x60; should be specified. If a character is invited with the &#x60;squad_commander&#x60; role, both &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should be specified. If a character is invited with the &#x60;squad_member&#x60; role, &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should either both be specified or not specified at all. If they aren’t specified, the invited character will join any squad with available positions.</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostFleetsFleetIdMembersInvitation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostFleetsFleetIdMembersInvitation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostFleetsFleetIdMembersInvitation" /> class.
        /// </summary>
        /// <param name="characterId">The character you want to invite (required).</param>
        /// <param name="role">If a character is invited with the &#x60;fleet_commander&#x60; role, neither &#x60;wing_id&#x60; or &#x60;squad_id&#x60; should be specified. If a character is invited with the &#x60;wing_commander&#x60; role, only &#x60;wing_id&#x60; should be specified. If a character is invited with the &#x60;squad_commander&#x60; role, both &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should be specified. If a character is invited with the &#x60;squad_member&#x60; role, &#x60;wing_id&#x60; and &#x60;squad_id&#x60; should either both be specified or not specified at all. If they aren’t specified, the invited character will join any squad with available positions. (required).</param>
        /// <param name="squadId">squad_id integer.</param>
        /// <param name="wingId">wing_id integer.</param>
        public PostFleetsFleetIdMembersInvitation(int? characterId = default(int?), RoleEnum role = default(RoleEnum), long? squadId = default(long?), long? wingId = default(long?))
        {
            // to ensure "characterId" is required (not null)
            if (characterId == null)
            {
                throw new InvalidDataException("characterId is a required property for PostFleetsFleetIdMembersInvitation and cannot be null");
            }
            else
            {
                this.CharacterId = characterId;
            }
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new InvalidDataException("role is a required property for PostFleetsFleetIdMembersInvitation and cannot be null");
            }
            else
            {
                this.Role = role;
            }
            this.SquadId = squadId;
            this.WingId = wingId;
        }
        
        /// <summary>
        /// The character you want to invite
        /// </summary>
        /// <value>The character you want to invite</value>
        [DataMember(Name="character_id", EmitDefaultValue=false)]
        public int? CharacterId { get; set; }


        /// <summary>
        /// squad_id integer
        /// </summary>
        /// <value>squad_id integer</value>
        [DataMember(Name="squad_id", EmitDefaultValue=false)]
        public long? SquadId { get; set; }

        /// <summary>
        /// wing_id integer
        /// </summary>
        /// <value>wing_id integer</value>
        [DataMember(Name="wing_id", EmitDefaultValue=false)]
        public long? WingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostFleetsFleetIdMembersInvitation {\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  SquadId: ").Append(SquadId).Append("\n");
            sb.Append("  WingId: ").Append(WingId).Append("\n");
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
            return this.Equals(input as PostFleetsFleetIdMembersInvitation);
        }

        /// <summary>
        /// Returns true if PostFleetsFleetIdMembersInvitation instances are equal
        /// </summary>
        /// <param name="input">Instance of PostFleetsFleetIdMembersInvitation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostFleetsFleetIdMembersInvitation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CharacterId == input.CharacterId ||
                    (this.CharacterId != null &&
                    this.CharacterId.Equals(input.CharacterId))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.SquadId == input.SquadId ||
                    (this.SquadId != null &&
                    this.SquadId.Equals(input.SquadId))
                ) && 
                (
                    this.WingId == input.WingId ||
                    (this.WingId != null &&
                    this.WingId.Equals(input.WingId))
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
                if (this.CharacterId != null)
                    hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.SquadId != null)
                    hashCode = hashCode * 59 + this.SquadId.GetHashCode();
                if (this.WingId != null)
                    hashCode = hashCode * 59 + this.WingId.GetHashCode();
                return hashCode;
            }
        }
    }

}
