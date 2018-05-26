/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.8.2
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
    public partial class GetCharactersCharacterIdStandings200Ok :  IEquatable<GetCharactersCharacterIdStandings200Ok>
    {
        /// <summary>
        /// from_type string
        /// </summary>
        /// <value>from_type string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FromTypeEnum
        {
            
            /// <summary>
            /// Enum Agent for value: agent
            /// </summary>
            [EnumMember(Value = "agent")]
            Agent = 1,
            
            /// <summary>
            /// Enum Npccorp for value: npc_corp
            /// </summary>
            [EnumMember(Value = "npc_corp")]
            Npccorp = 2,
            
            /// <summary>
            /// Enum Faction for value: faction
            /// </summary>
            [EnumMember(Value = "faction")]
            Faction = 3
        }

        /// <summary>
        /// from_type string
        /// </summary>
        /// <value>from_type string</value>
        [DataMember(Name="from_type", EmitDefaultValue=false)]
        public FromTypeEnum FromType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdStandings200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdStandings200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdStandings200Ok" /> class.
        /// </summary>
        /// <param name="fromId">from_id integer (required).</param>
        /// <param name="fromType">from_type string (required).</param>
        /// <param name="standing">standing number (required).</param>
        public GetCharactersCharacterIdStandings200Ok(int? fromId = default(int?), FromTypeEnum fromType = default(FromTypeEnum), float? standing = default(float?))
        {
            // to ensure "fromId" is required (not null)
            if (fromId == null)
            {
                throw new InvalidDataException("fromId is a required property for GetCharactersCharacterIdStandings200Ok and cannot be null");
            }
            else
            {
                this.FromId = fromId;
            }
            // to ensure "fromType" is required (not null)
            if (fromType == null)
            {
                throw new InvalidDataException("fromType is a required property for GetCharactersCharacterIdStandings200Ok and cannot be null");
            }
            else
            {
                this.FromType = fromType;
            }
            // to ensure "standing" is required (not null)
            if (standing == null)
            {
                throw new InvalidDataException("standing is a required property for GetCharactersCharacterIdStandings200Ok and cannot be null");
            }
            else
            {
                this.Standing = standing;
            }
        }
        
        /// <summary>
        /// from_id integer
        /// </summary>
        /// <value>from_id integer</value>
        [DataMember(Name="from_id", EmitDefaultValue=false)]
        public int? FromId { get; set; }


        /// <summary>
        /// standing number
        /// </summary>
        /// <value>standing number</value>
        [DataMember(Name="standing", EmitDefaultValue=false)]
        public float? Standing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdStandings200Ok {\n");
            sb.Append("  FromId: ").Append(FromId).Append("\n");
            sb.Append("  FromType: ").Append(FromType).Append("\n");
            sb.Append("  Standing: ").Append(Standing).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdStandings200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdStandings200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdStandings200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdStandings200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FromId == input.FromId ||
                    (this.FromId != null &&
                    this.FromId.Equals(input.FromId))
                ) && 
                (
                    this.FromType == input.FromType ||
                    (this.FromType != null &&
                    this.FromType.Equals(input.FromType))
                ) && 
                (
                    this.Standing == input.Standing ||
                    (this.Standing != null &&
                    this.Standing.Equals(input.Standing))
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
                if (this.FromId != null)
                    hashCode = hashCode * 59 + this.FromId.GetHashCode();
                if (this.FromType != null)
                    hashCode = hashCode * 59 + this.FromType.GetHashCode();
                if (this.Standing != null)
                    hashCode = hashCode * 59 + this.Standing.GetHashCode();
                return hashCode;
            }
        }
    }

}