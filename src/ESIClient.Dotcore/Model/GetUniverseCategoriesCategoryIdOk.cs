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
    public partial class GetUniverseCategoriesCategoryIdOk :  IEquatable<GetUniverseCategoriesCategoryIdOk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseCategoriesCategoryIdOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetUniverseCategoriesCategoryIdOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseCategoriesCategoryIdOk" /> class.
        /// </summary>
        /// <param name="categoryId">category_id integer (required).</param>
        /// <param name="groups">groups array (required).</param>
        /// <param name="name">name string (required).</param>
        /// <param name="published">published boolean (required).</param>
        public GetUniverseCategoriesCategoryIdOk(int? categoryId = default(int?), List<int?> groups = default(List<int?>), string name = default(string), bool? published = default(bool?))
        {
            // to ensure "categoryId" is required (not null)
            if (categoryId == null)
            {
                throw new InvalidDataException("categoryId is a required property for GetUniverseCategoriesCategoryIdOk and cannot be null");
            }
            else
            {
                this.CategoryId = categoryId;
            }
            // to ensure "groups" is required (not null)
            if (groups == null)
            {
                throw new InvalidDataException("groups is a required property for GetUniverseCategoriesCategoryIdOk and cannot be null");
            }
            else
            {
                this.Groups = groups;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetUniverseCategoriesCategoryIdOk and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "published" is required (not null)
            if (published == null)
            {
                throw new InvalidDataException("published is a required property for GetUniverseCategoriesCategoryIdOk and cannot be null");
            }
            else
            {
                this.Published = published;
            }
        }
        
        /// <summary>
        /// category_id integer
        /// </summary>
        /// <value>category_id integer</value>
        [DataMember(Name="category_id", EmitDefaultValue=false)]
        public int? CategoryId { get; set; }

        /// <summary>
        /// groups array
        /// </summary>
        /// <value>groups array</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<int?> Groups { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUniverseCategoriesCategoryIdOk {\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
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
            return this.Equals(input as GetUniverseCategoriesCategoryIdOk);
        }

        /// <summary>
        /// Returns true if GetUniverseCategoriesCategoryIdOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUniverseCategoriesCategoryIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUniverseCategoriesCategoryIdOk input)
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
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
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
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Published != null)
                    hashCode = hashCode * 59 + this.Published.GetHashCode();
                return hashCode;
            }
        }
    }

}
