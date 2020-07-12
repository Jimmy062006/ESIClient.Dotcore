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
    /// character_id and response of an attendee
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdCalendarEventIdAttendees200Ok :  IEquatable<GetCharactersCharacterIdCalendarEventIdAttendees200Ok>
    {
        /// <summary>
        /// event_response string
        /// </summary>
        /// <value>event_response string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventResponseEnum
        {
            
            /// <summary>
            /// Enum Declined for value: declined
            /// </summary>
            [EnumMember(Value = "declined")]
            Declined = 1,
            
            /// <summary>
            /// Enum Notresponded for value: not_responded
            /// </summary>
            [EnumMember(Value = "not_responded")]
            Notresponded = 2,
            
            /// <summary>
            /// Enum Accepted for value: accepted
            /// </summary>
            [EnumMember(Value = "accepted")]
            Accepted = 3,
            
            /// <summary>
            /// Enum Tentative for value: tentative
            /// </summary>
            [EnumMember(Value = "tentative")]
            Tentative = 4
        }

        /// <summary>
        /// event_response string
        /// </summary>
        /// <value>event_response string</value>
        [DataMember(Name="event_response", EmitDefaultValue=false)]
        public EventResponseEnum? EventResponse { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdCalendarEventIdAttendees200Ok" /> class.
        /// </summary>
        /// <param name="characterId">character_id integer.</param>
        /// <param name="eventResponse">event_response string.</param>
        public GetCharactersCharacterIdCalendarEventIdAttendees200Ok(int? characterId = default(int?), EventResponseEnum? eventResponse = default(EventResponseEnum?))
        {
            this.CharacterId = characterId;
            this.EventResponse = eventResponse;
        }
        
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
            sb.Append("class GetCharactersCharacterIdCalendarEventIdAttendees200Ok {\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
            sb.Append("  EventResponse: ").Append(EventResponse).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdCalendarEventIdAttendees200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdCalendarEventIdAttendees200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdCalendarEventIdAttendees200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdCalendarEventIdAttendees200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CharacterId == input.CharacterId ||
                    (this.CharacterId != null &&
                    this.CharacterId.Equals(input.CharacterId))
                ) && 
                (
                    this.EventResponse == input.EventResponse ||
                    (this.EventResponse != null &&
                    this.EventResponse.Equals(input.EventResponse))
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
                if (this.CharacterId != null)
                    hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
                if (this.EventResponse != null)
                    hashCode = hashCode * 59 + this.EventResponse.GetHashCode();
                return hashCode;
            }
        }
    }

}
