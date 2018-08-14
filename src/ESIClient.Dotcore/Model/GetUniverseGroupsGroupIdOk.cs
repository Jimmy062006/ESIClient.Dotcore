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
    public partial class GetUniverseGroupsGroupIdOk :  IEquatable<GetUniverseGroupsGroupIdOk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseGroupsGroupIdOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetUniverseGroupsGroupIdOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseGroupsGroupIdOk" /> class.
        /// </summary>
        /// <param name="categoryId">category_id integer (required).</param>
        /// <param name="groupId">group_id integer (required).</param>
        /// <param name="name">name string (required).</param>
        /// <param name="published">published boolean (required).</param>
        /// <param name="types">types array (required).</param>
        public GetUniverseGroupsGroupIdOk(int? categoryId = default(int?), int? groupId = default(int?), string name = default(string), bool? published = default(bool?), List<int?> types = default(List<int?>))
        {
            // to ensure "categoryId" is required (not null)
            if (categoryId == null)
            {
                throw new InvalidDataException("categoryId is a required property for GetUniverseGroupsGroupIdOk and cannot be null");
            }
            else
            {
                this.CategoryId = categoryId;
            }
            // to ensure "groupId" is required (not null)
            if (groupId == null)
            {
                throw new InvalidDataException("groupId is a required property for GetUniverseGroupsGroupIdOk and cannot be null");
            }
            else
            {
                this.GroupId = groupId;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetUniverseGroupsGroupIdOk and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "published" is required (not null)
            if (published == null)
            {
                throw new InvalidDataException("published is a required property for GetUniverseGroupsGroupIdOk and cannot be null");
            }
            else
            {
                this.Published = published;
            }
            // to ensure "types" is required (not null)
            if (types == null)
            {
                throw new InvalidDataException("types is a required property for GetUniverseGroupsGroupIdOk and cannot be null");
            }
            else
            {
                this.Types = types;
            }
        }
        
        /// <summary>
        /// category_id integer
        /// </summary>
        /// <value>category_id integer</value>
        [DataMember(Name="category_id", EmitDefaultValue=false)]
        public int? CategoryId { get; set; }

        /// <summary>
        /// group_id integer
        /// </summary>
        /// <value>group_id integer</value>
        [DataMember(Name="group_id", EmitDefaultValue=false)]
        public int? GroupId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// published boolean
        /// </summary>
        /// <value>published boolean</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }

        /// <summary>
        /// types array
        /// </summary>
        /// <value>types array</value>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<int?> Types { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUniverseGroupsGroupIdOk {\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
            return this.Equals(input as GetUniverseGroupsGroupIdOk);
        }

        /// <summary>
        /// Returns true if GetUniverseGroupsGroupIdOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUniverseGroupsGroupIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUniverseGroupsGroupIdOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Published == input.Published ||
                    (this.Published != null &&
                    this.Published.Equals(input.Published))
                ) && 
                (
                    this.Types == input.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(input.Types)
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
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Published != null)
                    hashCode = hashCode * 59 + this.Published.GetHashCode();
                if (this.Types != null)
                    hashCode = hashCode * 59 + this.Types.GetHashCode();
                return hashCode;
            }
        }
    }

}
