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
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetCorporationsCorporationIdMedalsIssued200Ok :  IEquatable<GetCorporationsCorporationIdMedalsIssued200Ok>
    {
        /// <summary>
        /// status string
        /// </summary>
        /// <value>status string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Private for value: private
            /// </summary>
            [EnumMember(Value = "private")]
            Private = 1,
            
            /// <summary>
            /// Enum Public for value: public
            /// </summary>
            [EnumMember(Value = "public")]
            Public = 2
        }

        /// <summary>
        /// status string
        /// </summary>
        /// <value>status string</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdMedalsIssued200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationsCorporationIdMedalsIssued200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdMedalsIssued200Ok" /> class.
        /// </summary>
        /// <param name="characterId">ID of the character who was rewarded this medal (required).</param>
        /// <param name="issuedAt">issued_at string (required).</param>
        /// <param name="issuerId">ID of the character who issued the medal (required).</param>
        /// <param name="medalId">medal_id integer (required).</param>
        /// <param name="reason">reason string (required).</param>
        /// <param name="status">status string (required).</param>
        public GetCorporationsCorporationIdMedalsIssued200Ok(int? characterId = default(int?), DateTime? issuedAt = default(DateTime?), int? issuerId = default(int?), int? medalId = default(int?), string reason = default(string), StatusEnum status = default(StatusEnum))
        {
            // to ensure "characterId" is required (not null)
            if (characterId == null)
            {
                throw new InvalidDataException("characterId is a required property for GetCorporationsCorporationIdMedalsIssued200Ok and cannot be null");
            }
            else
            {
                this.CharacterId = characterId;
            }
            // to ensure "issuedAt" is required (not null)
            if (issuedAt == null)
            {
                throw new InvalidDataException("issuedAt is a required property for GetCorporationsCorporationIdMedalsIssued200Ok and cannot be null");
            }
            else
            {
                this.IssuedAt = issuedAt;
            }
            // to ensure "issuerId" is required (not null)
            if (issuerId == null)
            {
                throw new InvalidDataException("issuerId is a required property for GetCorporationsCorporationIdMedalsIssued200Ok and cannot be null");
            }
            else
            {
                this.IssuerId = issuerId;
            }
            // to ensure "medalId" is required (not null)
            if (medalId == null)
            {
                throw new InvalidDataException("medalId is a required property for GetCorporationsCorporationIdMedalsIssued200Ok and cannot be null");
            }
            else
            {
                this.MedalId = medalId;
            }
            // to ensure "reason" is required (not null)
            if (reason == null)
            {
                throw new InvalidDataException("reason is a required property for GetCorporationsCorporationIdMedalsIssued200Ok and cannot be null");
            }
            else
            {
                this.Reason = reason;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for GetCorporationsCorporationIdMedalsIssued200Ok and cannot be null");
            }
            else
            {
                this.Status = status;
            }
        }
        
        /// <summary>
        /// ID of the character who was rewarded this medal
        /// </summary>
        /// <value>ID of the character who was rewarded this medal</value>
        [DataMember(Name="character_id", EmitDefaultValue=false)]
        public int? CharacterId { get; set; }

        /// <summary>
        /// issued_at string
        /// </summary>
        /// <value>issued_at string</value>
        [DataMember(Name="issued_at", EmitDefaultValue=false)]
        public DateTime? IssuedAt { get; set; }

        /// <summary>
        /// ID of the character who issued the medal
        /// </summary>
        /// <value>ID of the character who issued the medal</value>
        [DataMember(Name="issuer_id", EmitDefaultValue=false)]
        public int? IssuerId { get; set; }

        /// <summary>
        /// medal_id integer
        /// </summary>
        /// <value>medal_id integer</value>
        [DataMember(Name="medal_id", EmitDefaultValue=false)]
        public int? MedalId { get; set; }

        /// <summary>
        /// reason string
        /// </summary>
        /// <value>reason string</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationsCorporationIdMedalsIssued200Ok {\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
            sb.Append("  IssuedAt: ").Append(IssuedAt).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  MedalId: ").Append(MedalId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as GetCorporationsCorporationIdMedalsIssued200Ok);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdMedalsIssued200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationsCorporationIdMedalsIssued200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdMedalsIssued200Ok input)
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
                    this.IssuedAt == input.IssuedAt ||
                    (this.IssuedAt != null &&
                    this.IssuedAt.Equals(input.IssuedAt))
                ) && 
                (
                    this.IssuerId == input.IssuerId ||
                    (this.IssuerId != null &&
                    this.IssuerId.Equals(input.IssuerId))
                ) && 
                (
                    this.MedalId == input.MedalId ||
                    (this.MedalId != null &&
                    this.MedalId.Equals(input.MedalId))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.IssuedAt != null)
                    hashCode = hashCode * 59 + this.IssuedAt.GetHashCode();
                if (this.IssuerId != null)
                    hashCode = hashCode * 59 + this.IssuerId.GetHashCode();
                if (this.MedalId != null)
                    hashCode = hashCode * 59 + this.MedalId.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }

}
