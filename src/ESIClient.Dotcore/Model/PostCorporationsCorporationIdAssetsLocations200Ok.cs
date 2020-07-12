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
    public partial class PostCorporationsCorporationIdAssetsLocations200Ok :  IEquatable<PostCorporationsCorporationIdAssetsLocations200Ok>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCorporationsCorporationIdAssetsLocations200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostCorporationsCorporationIdAssetsLocations200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCorporationsCorporationIdAssetsLocations200Ok" /> class.
        /// </summary>
        /// <param name="itemId">item_id integer (required).</param>
        /// <param name="position">position (required).</param>
        public PostCorporationsCorporationIdAssetsLocations200Ok(long? itemId = default(long?), PostCorporationsCorporationIdAssetsLocationsPosition position = default(PostCorporationsCorporationIdAssetsLocationsPosition))
        {
            // to ensure "itemId" is required (not null)
            if (itemId == null)
            {
                throw new InvalidDataException("itemId is a required property for PostCorporationsCorporationIdAssetsLocations200Ok and cannot be null");
            }
            else
            {
                this.ItemId = itemId;
            }
            // to ensure "position" is required (not null)
            if (position == null)
            {
                throw new InvalidDataException("position is a required property for PostCorporationsCorporationIdAssetsLocations200Ok and cannot be null");
            }
            else
            {
                this.Position = position;
            }
        }
        
        /// <summary>
        /// item_id integer
        /// </summary>
        /// <value>item_id integer</value>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public long? ItemId { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public PostCorporationsCorporationIdAssetsLocationsPosition Position { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostCorporationsCorporationIdAssetsLocations200Ok {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
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
            return this.Equals(input as PostCorporationsCorporationIdAssetsLocations200Ok);
        }

        /// <summary>
        /// Returns true if PostCorporationsCorporationIdAssetsLocations200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of PostCorporationsCorporationIdAssetsLocations200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostCorporationsCorporationIdAssetsLocations200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
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
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                return hashCode;
            }
        }
    }

}
