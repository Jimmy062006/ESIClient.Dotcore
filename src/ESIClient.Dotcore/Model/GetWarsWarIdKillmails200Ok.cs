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
    public partial class GetWarsWarIdKillmails200Ok :  IEquatable<GetWarsWarIdKillmails200Ok>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWarsWarIdKillmails200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetWarsWarIdKillmails200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWarsWarIdKillmails200Ok" /> class.
        /// </summary>
        /// <param name="killmailHash">A hash of this killmail (required).</param>
        /// <param name="killmailId">ID of this killmail (required).</param>
        public GetWarsWarIdKillmails200Ok(string killmailHash = default(string), int? killmailId = default(int?))
        {
            // to ensure "killmailHash" is required (not null)
            if (killmailHash == null)
            {
                throw new InvalidDataException("killmailHash is a required property for GetWarsWarIdKillmails200Ok and cannot be null");
            }
            else
            {
                this.KillmailHash = killmailHash;
            }
            // to ensure "killmailId" is required (not null)
            if (killmailId == null)
            {
                throw new InvalidDataException("killmailId is a required property for GetWarsWarIdKillmails200Ok and cannot be null");
            }
            else
            {
                this.KillmailId = killmailId;
            }
        }
        
        /// <summary>
        /// A hash of this killmail
        /// </summary>
        /// <value>A hash of this killmail</value>
        [DataMember(Name="killmail_hash", EmitDefaultValue=false)]
        public string KillmailHash { get; set; }

        /// <summary>
        /// ID of this killmail
        /// </summary>
        /// <value>ID of this killmail</value>
        [DataMember(Name="killmail_id", EmitDefaultValue=false)]
        public int? KillmailId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetWarsWarIdKillmails200Ok {\n");
            sb.Append("  KillmailHash: ").Append(KillmailHash).Append("\n");
            sb.Append("  KillmailId: ").Append(KillmailId).Append("\n");
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
            return this.Equals(input as GetWarsWarIdKillmails200Ok);
        }

        /// <summary>
        /// Returns true if GetWarsWarIdKillmails200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetWarsWarIdKillmails200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetWarsWarIdKillmails200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KillmailHash == input.KillmailHash ||
                    (this.KillmailHash != null &&
                    this.KillmailHash.Equals(input.KillmailHash))
                ) && 
                (
                    this.KillmailId == input.KillmailId ||
                    (this.KillmailId != null &&
                    this.KillmailId.Equals(input.KillmailId))
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
                if (this.KillmailHash != null)
                    hashCode = hashCode * 59 + this.KillmailHash.GetHashCode();
                if (this.KillmailId != null)
                    hashCode = hashCode * 59 + this.KillmailId.GetHashCode();
                return hashCode;
            }
        }
    }

}
