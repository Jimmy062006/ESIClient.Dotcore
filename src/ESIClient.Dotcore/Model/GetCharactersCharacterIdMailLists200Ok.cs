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
    public partial class GetCharactersCharacterIdMailLists200Ok :  IEquatable<GetCharactersCharacterIdMailLists200Ok>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdMailLists200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdMailLists200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdMailLists200Ok" /> class.
        /// </summary>
        /// <param name="mailingListId">Mailing list ID (required).</param>
        /// <param name="name">name string (required).</param>
        public GetCharactersCharacterIdMailLists200Ok(int? mailingListId = default(int?), string name = default(string))
        {
            // to ensure "mailingListId" is required (not null)
            if (mailingListId == null)
            {
                throw new InvalidDataException("mailingListId is a required property for GetCharactersCharacterIdMailLists200Ok and cannot be null");
            }
            else
            {
                this.MailingListId = mailingListId;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetCharactersCharacterIdMailLists200Ok and cannot be null");
            }
            else
            {
                this.Name = name;
            }
        }
        
        /// <summary>
        /// Mailing list ID
        /// </summary>
        /// <value>Mailing list ID</value>
        [DataMember(Name="mailing_list_id", EmitDefaultValue=false)]
        public int? MailingListId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdMailLists200Ok {\n");
            sb.Append("  MailingListId: ").Append(MailingListId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdMailLists200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdMailLists200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdMailLists200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdMailLists200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MailingListId == input.MailingListId ||
                    (this.MailingListId != null &&
                    this.MailingListId.Equals(input.MailingListId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.MailingListId != null)
                    hashCode = hashCode * 59 + this.MailingListId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }

}
