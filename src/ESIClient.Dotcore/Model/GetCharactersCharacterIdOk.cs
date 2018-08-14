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
    public partial class GetCharactersCharacterIdOk :  IEquatable<GetCharactersCharacterIdOk>
    {
        /// <summary>
        /// gender string
        /// </summary>
        /// <value>gender string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GenderEnum
        {
            
            /// <summary>
            /// Enum Female for value: female
            /// </summary>
            [EnumMember(Value = "female")]
            Female = 1,
            
            /// <summary>
            /// Enum Male for value: male
            /// </summary>
            [EnumMember(Value = "male")]
            Male = 2
        }

        /// <summary>
        /// gender string
        /// </summary>
        /// <value>gender string</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public GenderEnum Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdOk" /> class.
        /// </summary>
        /// <param name="allianceId">The character&#39;s alliance ID.</param>
        /// <param name="ancestryId">ancestry_id integer.</param>
        /// <param name="birthday">Creation date of the character (required).</param>
        /// <param name="bloodlineId">bloodline_id integer (required).</param>
        /// <param name="corporationId">The character&#39;s corporation ID (required).</param>
        /// <param name="description">description string.</param>
        /// <param name="factionId">ID of the faction the character is fighting for, if the character is enlisted in Factional Warfare.</param>
        /// <param name="gender">gender string (required).</param>
        /// <param name="name">name string (required).</param>
        /// <param name="raceId">race_id integer (required).</param>
        /// <param name="securityStatus">security_status number.</param>
        public GetCharactersCharacterIdOk(int? allianceId = default(int?), int? ancestryId = default(int?), DateTime? birthday = default(DateTime?), int? bloodlineId = default(int?), int? corporationId = default(int?), string description = default(string), int? factionId = default(int?), GenderEnum gender = default(GenderEnum), string name = default(string), int? raceId = default(int?), float? securityStatus = default(float?))
        {
            // to ensure "birthday" is required (not null)
            if (birthday == null)
            {
                throw new InvalidDataException("birthday is a required property for GetCharactersCharacterIdOk and cannot be null");
            }
            else
            {
                this.Birthday = birthday;
            }
            // to ensure "bloodlineId" is required (not null)
            if (bloodlineId == null)
            {
                throw new InvalidDataException("bloodlineId is a required property for GetCharactersCharacterIdOk and cannot be null");
            }
            else
            {
                this.BloodlineId = bloodlineId;
            }
            // to ensure "corporationId" is required (not null)
            if (corporationId == null)
            {
                throw new InvalidDataException("corporationId is a required property for GetCharactersCharacterIdOk and cannot be null");
            }
            else
            {
                this.CorporationId = corporationId;
            }
            // to ensure "gender" is required (not null)
            if (gender == null)
            {
                throw new InvalidDataException("gender is a required property for GetCharactersCharacterIdOk and cannot be null");
            }
            else
            {
                this.Gender = gender;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetCharactersCharacterIdOk and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "raceId" is required (not null)
            if (raceId == null)
            {
                throw new InvalidDataException("raceId is a required property for GetCharactersCharacterIdOk and cannot be null");
            }
            else
            {
                this.RaceId = raceId;
            }
            this.AllianceId = allianceId;
            this.AncestryId = ancestryId;
            this.Description = description;
            this.FactionId = factionId;
            this.SecurityStatus = securityStatus;
        }
        
        /// <summary>
        /// The character&#39;s alliance ID
        /// </summary>
        /// <value>The character&#39;s alliance ID</value>
        [DataMember(Name="alliance_id", EmitDefaultValue=false)]
        public int? AllianceId { get; set; }

        /// <summary>
        /// ancestry_id integer
        /// </summary>
        /// <value>ancestry_id integer</value>
        [DataMember(Name="ancestry_id", EmitDefaultValue=false)]
        public int? AncestryId { get; set; }

        /// <summary>
        /// Creation date of the character
        /// </summary>
        /// <value>Creation date of the character</value>
        [DataMember(Name="birthday", EmitDefaultValue=false)]
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// bloodline_id integer
        /// </summary>
        /// <value>bloodline_id integer</value>
        [DataMember(Name="bloodline_id", EmitDefaultValue=false)]
        public int? BloodlineId { get; set; }

        /// <summary>
        /// The character&#39;s corporation ID
        /// </summary>
        /// <value>The character&#39;s corporation ID</value>
        [DataMember(Name="corporation_id", EmitDefaultValue=false)]
        public int? CorporationId { get; set; }

        /// <summary>
        /// description string
        /// </summary>
        /// <value>description string</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// ID of the faction the character is fighting for, if the character is enlisted in Factional Warfare
        /// </summary>
        /// <value>ID of the faction the character is fighting for, if the character is enlisted in Factional Warfare</value>
        [DataMember(Name="faction_id", EmitDefaultValue=false)]
        public int? FactionId { get; set; }


        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// race_id integer
        /// </summary>
        /// <value>race_id integer</value>
        [DataMember(Name="race_id", EmitDefaultValue=false)]
        public int? RaceId { get; set; }

        /// <summary>
        /// security_status number
        /// </summary>
        /// <value>security_status number</value>
        [DataMember(Name="security_status", EmitDefaultValue=false)]
        public float? SecurityStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdOk {\n");
            sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
            sb.Append("  AncestryId: ").Append(AncestryId).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  BloodlineId: ").Append(BloodlineId).Append("\n");
            sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FactionId: ").Append(FactionId).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RaceId: ").Append(RaceId).Append("\n");
            sb.Append("  SecurityStatus: ").Append(SecurityStatus).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdOk);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdOk input)
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
                    this.AncestryId == input.AncestryId ||
                    (this.AncestryId != null &&
                    this.AncestryId.Equals(input.AncestryId))
                ) && 
                (
                    this.Birthday == input.Birthday ||
                    (this.Birthday != null &&
                    this.Birthday.Equals(input.Birthday))
                ) && 
                (
                    this.BloodlineId == input.BloodlineId ||
                    (this.BloodlineId != null &&
                    this.BloodlineId.Equals(input.BloodlineId))
                ) && 
                (
                    this.CorporationId == input.CorporationId ||
                    (this.CorporationId != null &&
                    this.CorporationId.Equals(input.CorporationId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FactionId == input.FactionId ||
                    (this.FactionId != null &&
                    this.FactionId.Equals(input.FactionId))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RaceId == input.RaceId ||
                    (this.RaceId != null &&
                    this.RaceId.Equals(input.RaceId))
                ) && 
                (
                    this.SecurityStatus == input.SecurityStatus ||
                    (this.SecurityStatus != null &&
                    this.SecurityStatus.Equals(input.SecurityStatus))
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
                if (this.AncestryId != null)
                    hashCode = hashCode * 59 + this.AncestryId.GetHashCode();
                if (this.Birthday != null)
                    hashCode = hashCode * 59 + this.Birthday.GetHashCode();
                if (this.BloodlineId != null)
                    hashCode = hashCode * 59 + this.BloodlineId.GetHashCode();
                if (this.CorporationId != null)
                    hashCode = hashCode * 59 + this.CorporationId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FactionId != null)
                    hashCode = hashCode * 59 + this.FactionId.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RaceId != null)
                    hashCode = hashCode * 59 + this.RaceId.GetHashCode();
                if (this.SecurityStatus != null)
                    hashCode = hashCode * 59 + this.SecurityStatus.GetHashCode();
                return hashCode;
            }
        }
    }

}
