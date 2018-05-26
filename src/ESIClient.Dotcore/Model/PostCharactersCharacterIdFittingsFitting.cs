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
    /// fitting object
    /// </summary>
    [DataContract]
    public partial class PostCharactersCharacterIdFittingsFitting :  IEquatable<PostCharactersCharacterIdFittingsFitting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCharactersCharacterIdFittingsFitting" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostCharactersCharacterIdFittingsFitting() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCharactersCharacterIdFittingsFitting" /> class.
        /// </summary>
        /// <param name="description">description string (required).</param>
        /// <param name="items">items array (required).</param>
        /// <param name="name">name string (required).</param>
        /// <param name="shipTypeId">ship_type_id integer (required).</param>
        public PostCharactersCharacterIdFittingsFitting(string description = default(string), List<PostCharactersCharacterIdFittingsItem> items = default(List<PostCharactersCharacterIdFittingsItem>), string name = default(string), int? shipTypeId = default(int?))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for PostCharactersCharacterIdFittingsFitting and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new InvalidDataException("items is a required property for PostCharactersCharacterIdFittingsFitting and cannot be null");
            }
            else
            {
                this.Items = items;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PostCharactersCharacterIdFittingsFitting and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "shipTypeId" is required (not null)
            if (shipTypeId == null)
            {
                throw new InvalidDataException("shipTypeId is a required property for PostCharactersCharacterIdFittingsFitting and cannot be null");
            }
            else
            {
                this.ShipTypeId = shipTypeId;
            }
        }
        
        /// <summary>
        /// description string
        /// </summary>
        /// <value>description string</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// items array
        /// </summary>
        /// <value>items array</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<PostCharactersCharacterIdFittingsItem> Items { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        /// <value>ship_type_id integer</value>
        [DataMember(Name="ship_type_id", EmitDefaultValue=false)]
        public int? ShipTypeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostCharactersCharacterIdFittingsFitting {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShipTypeId: ").Append(ShipTypeId).Append("\n");
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
            return this.Equals(input as PostCharactersCharacterIdFittingsFitting);
        }

        /// <summary>
        /// Returns true if PostCharactersCharacterIdFittingsFitting instances are equal
        /// </summary>
        /// <param name="input">Instance of PostCharactersCharacterIdFittingsFitting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostCharactersCharacterIdFittingsFitting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ShipTypeId == input.ShipTypeId ||
                    (this.ShipTypeId != null &&
                    this.ShipTypeId.Equals(input.ShipTypeId))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ShipTypeId != null)
                    hashCode = hashCode * 59 + this.ShipTypeId.GetHashCode();
                return hashCode;
            }
        }
    }

}