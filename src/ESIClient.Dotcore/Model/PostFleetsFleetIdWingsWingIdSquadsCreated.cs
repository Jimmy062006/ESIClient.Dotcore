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
    /// 201 created object
    /// </summary>
    [DataContract]
    public partial class PostFleetsFleetIdWingsWingIdSquadsCreated :  IEquatable<PostFleetsFleetIdWingsWingIdSquadsCreated>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostFleetsFleetIdWingsWingIdSquadsCreated" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostFleetsFleetIdWingsWingIdSquadsCreated() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostFleetsFleetIdWingsWingIdSquadsCreated" /> class.
        /// </summary>
        /// <param name="squadId">The squad_id of the newly created squad (required).</param>
        public PostFleetsFleetIdWingsWingIdSquadsCreated(long? squadId = default(long?))
        {
            // to ensure "squadId" is required (not null)
            if (squadId == null)
            {
                throw new InvalidDataException("squadId is a required property for PostFleetsFleetIdWingsWingIdSquadsCreated and cannot be null");
            }
            else
            {
                this.SquadId = squadId;
            }
        }
        
        /// <summary>
        /// The squad_id of the newly created squad
        /// </summary>
        /// <value>The squad_id of the newly created squad</value>
        [DataMember(Name="squad_id", EmitDefaultValue=false)]
        public long? SquadId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostFleetsFleetIdWingsWingIdSquadsCreated {\n");
            sb.Append("  SquadId: ").Append(SquadId).Append("\n");
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
            return this.Equals(input as PostFleetsFleetIdWingsWingIdSquadsCreated);
        }

        /// <summary>
        /// Returns true if PostFleetsFleetIdWingsWingIdSquadsCreated instances are equal
        /// </summary>
        /// <param name="input">Instance of PostFleetsFleetIdWingsWingIdSquadsCreated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostFleetsFleetIdWingsWingIdSquadsCreated input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SquadId == input.SquadId ||
                    (this.SquadId != null &&
                    this.SquadId.Equals(input.SquadId))
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
                if (this.SquadId != null)
                    hashCode = hashCode * 59 + this.SquadId.GetHashCode();
                return hashCode;
            }
        }
    }

}
