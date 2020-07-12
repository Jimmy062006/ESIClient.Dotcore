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
    /// active_total object
    /// </summary>
    [DataContract]
    public partial class GetFwLeaderboardsCharactersActiveTotalActiveTotal1 :  IEquatable<GetFwLeaderboardsCharactersActiveTotalActiveTotal1>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFwLeaderboardsCharactersActiveTotalActiveTotal1" /> class.
        /// </summary>
        /// <param name="amount">Amount of victory points.</param>
        /// <param name="characterId">character_id integer.</param>
        public GetFwLeaderboardsCharactersActiveTotalActiveTotal1(int? amount = default(int?), int? characterId = default(int?))
        {
            this.Amount = amount;
            this.CharacterId = characterId;
        }
        
        /// <summary>
        /// Amount of victory points
        /// </summary>
        /// <value>Amount of victory points</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// character_id integer
        /// </summary>
        /// <value>character_id integer</value>
        [DataMember(Name="character_id", EmitDefaultValue=false)]
        public int? CharacterId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFwLeaderboardsCharactersActiveTotalActiveTotal1 {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
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
            return this.Equals(input as GetFwLeaderboardsCharactersActiveTotalActiveTotal1);
        }

        /// <summary>
        /// Returns true if GetFwLeaderboardsCharactersActiveTotalActiveTotal1 instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFwLeaderboardsCharactersActiveTotalActiveTotal1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFwLeaderboardsCharactersActiveTotalActiveTotal1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.CharacterId == input.CharacterId ||
                    (this.CharacterId != null &&
                    this.CharacterId.Equals(input.CharacterId))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.CharacterId != null)
                    hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
                return hashCode;
            }
        }
    }

}
