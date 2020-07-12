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
    public partial class GetCorporationsCorporationIdMedals200Ok :  IEquatable<GetCorporationsCorporationIdMedals200Ok>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdMedals200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationsCorporationIdMedals200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdMedals200Ok" /> class.
        /// </summary>
        /// <param name="createdAt">created_at string (required).</param>
        /// <param name="creatorId">ID of the character who created this medal (required).</param>
        /// <param name="description">description string (required).</param>
        /// <param name="medalId">medal_id integer (required).</param>
        /// <param name="title">title string (required).</param>
        public GetCorporationsCorporationIdMedals200Ok(DateTime? createdAt = default(DateTime?), int? creatorId = default(int?), string description = default(string), int? medalId = default(int?), string title = default(string))
        {
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for GetCorporationsCorporationIdMedals200Ok and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "creatorId" is required (not null)
            if (creatorId == null)
            {
                throw new InvalidDataException("creatorId is a required property for GetCorporationsCorporationIdMedals200Ok and cannot be null");
            }
            else
            {
                this.CreatorId = creatorId;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for GetCorporationsCorporationIdMedals200Ok and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "medalId" is required (not null)
            if (medalId == null)
            {
                throw new InvalidDataException("medalId is a required property for GetCorporationsCorporationIdMedals200Ok and cannot be null");
            }
            else
            {
                this.MedalId = medalId;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for GetCorporationsCorporationIdMedals200Ok and cannot be null");
            }
            else
            {
                this.Title = title;
            }
        }
        
        /// <summary>
        /// created_at string
        /// </summary>
        /// <value>created_at string</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// ID of the character who created this medal
        /// </summary>
        /// <value>ID of the character who created this medal</value>
        [DataMember(Name="creator_id", EmitDefaultValue=false)]
        public int? CreatorId { get; set; }

        /// <summary>
        /// description string
        /// </summary>
        /// <value>description string</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// medal_id integer
        /// </summary>
        /// <value>medal_id integer</value>
        [DataMember(Name="medal_id", EmitDefaultValue=false)]
        public int? MedalId { get; set; }

        /// <summary>
        /// title string
        /// </summary>
        /// <value>title string</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationsCorporationIdMedals200Ok {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MedalId: ").Append(MedalId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as GetCorporationsCorporationIdMedals200Ok);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdMedals200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationsCorporationIdMedals200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdMedals200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatorId == input.CreatorId ||
                    (this.CreatorId != null &&
                    this.CreatorId.Equals(input.CreatorId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.MedalId == input.MedalId ||
                    (this.MedalId != null &&
                    this.MedalId.Equals(input.MedalId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatorId != null)
                    hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MedalId != null)
                    hashCode = hashCode * 59 + this.MedalId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                return hashCode;
            }
        }
    }

}
