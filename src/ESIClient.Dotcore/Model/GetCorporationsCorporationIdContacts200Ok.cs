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
    public partial class GetCorporationsCorporationIdContacts200Ok :  IEquatable<GetCorporationsCorporationIdContacts200Ok>
    {
        /// <summary>
        /// contact_type string
        /// </summary>
        /// <value>contact_type string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContactTypeEnum
        {
            
            /// <summary>
            /// Enum Character for value: character
            /// </summary>
            [EnumMember(Value = "character")]
            Character = 1,
            
            /// <summary>
            /// Enum Corporation for value: corporation
            /// </summary>
            [EnumMember(Value = "corporation")]
            Corporation = 2,
            
            /// <summary>
            /// Enum Alliance for value: alliance
            /// </summary>
            [EnumMember(Value = "alliance")]
            Alliance = 3,
            
            /// <summary>
            /// Enum Faction for value: faction
            /// </summary>
            [EnumMember(Value = "faction")]
            Faction = 4
        }

        /// <summary>
        /// contact_type string
        /// </summary>
        /// <value>contact_type string</value>
        [DataMember(Name="contact_type", EmitDefaultValue=false)]
        public ContactTypeEnum ContactType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdContacts200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationsCorporationIdContacts200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdContacts200Ok" /> class.
        /// </summary>
        /// <param name="contactId">contact_id integer (required).</param>
        /// <param name="contactType">contact_type string (required).</param>
        /// <param name="isWatched">Whether this contact is being watched.</param>
        /// <param name="labelIds">label_ids array.</param>
        /// <param name="standing">Standing of the contact (required).</param>
        public GetCorporationsCorporationIdContacts200Ok(int? contactId = default(int?), ContactTypeEnum contactType = default(ContactTypeEnum), bool? isWatched = default(bool?), List<long?> labelIds = default(List<long?>), float? standing = default(float?))
        {
            // to ensure "contactId" is required (not null)
            if (contactId == null)
            {
                throw new InvalidDataException("contactId is a required property for GetCorporationsCorporationIdContacts200Ok and cannot be null");
            }
            else
            {
                this.ContactId = contactId;
            }
            // to ensure "contactType" is required (not null)
            if (contactType == null)
            {
                throw new InvalidDataException("contactType is a required property for GetCorporationsCorporationIdContacts200Ok and cannot be null");
            }
            else
            {
                this.ContactType = contactType;
            }
            // to ensure "standing" is required (not null)
            if (standing == null)
            {
                throw new InvalidDataException("standing is a required property for GetCorporationsCorporationIdContacts200Ok and cannot be null");
            }
            else
            {
                this.Standing = standing;
            }
            this.IsWatched = isWatched;
            this.LabelIds = labelIds;
        }
        
        /// <summary>
        /// contact_id integer
        /// </summary>
        /// <value>contact_id integer</value>
        [DataMember(Name="contact_id", EmitDefaultValue=false)]
        public int? ContactId { get; set; }


        /// <summary>
        /// Whether this contact is being watched
        /// </summary>
        /// <value>Whether this contact is being watched</value>
        [DataMember(Name="is_watched", EmitDefaultValue=false)]
        public bool? IsWatched { get; set; }

        /// <summary>
        /// label_ids array
        /// </summary>
        /// <value>label_ids array</value>
        [DataMember(Name="label_ids", EmitDefaultValue=false)]
        public List<long?> LabelIds { get; set; }

        /// <summary>
        /// Standing of the contact
        /// </summary>
        /// <value>Standing of the contact</value>
        [DataMember(Name="standing", EmitDefaultValue=false)]
        public float? Standing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationsCorporationIdContacts200Ok {\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  ContactType: ").Append(ContactType).Append("\n");
            sb.Append("  IsWatched: ").Append(IsWatched).Append("\n");
            sb.Append("  LabelIds: ").Append(LabelIds).Append("\n");
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
            return this.Equals(input as GetCorporationsCorporationIdContacts200Ok);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdContacts200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationsCorporationIdContacts200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdContacts200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.ContactType == input.ContactType ||
                    (this.ContactType != null &&
                    this.ContactType.Equals(input.ContactType))
                ) && 
                (
                    this.IsWatched == input.IsWatched ||
                    (this.IsWatched != null &&
                    this.IsWatched.Equals(input.IsWatched))
                ) && 
                (
                    this.LabelIds == input.LabelIds ||
                    this.LabelIds != null &&
                    this.LabelIds.SequenceEqual(input.LabelIds)
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
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                if (this.ContactType != null)
                    hashCode = hashCode * 59 + this.ContactType.GetHashCode();
                if (this.IsWatched != null)
                    hashCode = hashCode * 59 + this.IsWatched.GetHashCode();
                if (this.LabelIds != null)
                    hashCode = hashCode * 59 + this.LabelIds.GetHashCode();
                if (this.Standing != null)
                    hashCode = hashCode * 59 + this.Standing.GetHashCode();
                return hashCode;
            }
        }
    }

}
