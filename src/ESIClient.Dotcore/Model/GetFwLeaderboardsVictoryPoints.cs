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
    /// Top 4 rankings of factions by victory points from yesterday, last week and in total
    /// </summary>
    [DataContract]
    public partial class GetFwLeaderboardsVictoryPoints :  IEquatable<GetFwLeaderboardsVictoryPoints>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFwLeaderboardsVictoryPoints" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetFwLeaderboardsVictoryPoints() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFwLeaderboardsVictoryPoints" /> class.
        /// </summary>
        /// <param name="activeTotal">Top 4 ranking of factions active in faction warfare by total victory points. A faction is considered \&quot;active\&quot; if they have participated in faction warfare in the past 14 days. (required).</param>
        /// <param name="lastWeek">Top 4 ranking of factions by victory points in the past week (required).</param>
        /// <param name="yesterday">Top 4 ranking of factions by victory points in the past day (required).</param>
        public GetFwLeaderboardsVictoryPoints(List<GetFwLeaderboardsActiveTotalActiveTotal1> activeTotal = default(List<GetFwLeaderboardsActiveTotalActiveTotal1>), List<GetFwLeaderboardsLastWeekLastWeek1> lastWeek = default(List<GetFwLeaderboardsLastWeekLastWeek1>), List<GetFwLeaderboardsYesterdayYesterday1> yesterday = default(List<GetFwLeaderboardsYesterdayYesterday1>))
        {
            // to ensure "activeTotal" is required (not null)
            if (activeTotal == null)
            {
                throw new InvalidDataException("activeTotal is a required property for GetFwLeaderboardsVictoryPoints and cannot be null");
            }
            else
            {
                this.ActiveTotal = activeTotal;
            }
            // to ensure "lastWeek" is required (not null)
            if (lastWeek == null)
            {
                throw new InvalidDataException("lastWeek is a required property for GetFwLeaderboardsVictoryPoints and cannot be null");
            }
            else
            {
                this.LastWeek = lastWeek;
            }
            // to ensure "yesterday" is required (not null)
            if (yesterday == null)
            {
                throw new InvalidDataException("yesterday is a required property for GetFwLeaderboardsVictoryPoints and cannot be null");
            }
            else
            {
                this.Yesterday = yesterday;
            }
        }
        
        /// <summary>
        /// Top 4 ranking of factions active in faction warfare by total victory points. A faction is considered \&quot;active\&quot; if they have participated in faction warfare in the past 14 days.
        /// </summary>
        /// <value>Top 4 ranking of factions active in faction warfare by total victory points. A faction is considered \&quot;active\&quot; if they have participated in faction warfare in the past 14 days.</value>
        [DataMember(Name="active_total", EmitDefaultValue=false)]
        public List<GetFwLeaderboardsActiveTotalActiveTotal1> ActiveTotal { get; set; }

        /// <summary>
        /// Top 4 ranking of factions by victory points in the past week
        /// </summary>
        /// <value>Top 4 ranking of factions by victory points in the past week</value>
        [DataMember(Name="last_week", EmitDefaultValue=false)]
        public List<GetFwLeaderboardsLastWeekLastWeek1> LastWeek { get; set; }

        /// <summary>
        /// Top 4 ranking of factions by victory points in the past day
        /// </summary>
        /// <value>Top 4 ranking of factions by victory points in the past day</value>
        [DataMember(Name="yesterday", EmitDefaultValue=false)]
        public List<GetFwLeaderboardsYesterdayYesterday1> Yesterday { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFwLeaderboardsVictoryPoints {\n");
            sb.Append("  ActiveTotal: ").Append(ActiveTotal).Append("\n");
            sb.Append("  LastWeek: ").Append(LastWeek).Append("\n");
            sb.Append("  Yesterday: ").Append(Yesterday).Append("\n");
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
            return this.Equals(input as GetFwLeaderboardsVictoryPoints);
        }

        /// <summary>
        /// Returns true if GetFwLeaderboardsVictoryPoints instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFwLeaderboardsVictoryPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFwLeaderboardsVictoryPoints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActiveTotal == input.ActiveTotal ||
                    this.ActiveTotal != null &&
                    this.ActiveTotal.SequenceEqual(input.ActiveTotal)
                ) && 
                (
                    this.LastWeek == input.LastWeek ||
                    this.LastWeek != null &&
                    this.LastWeek.SequenceEqual(input.LastWeek)
                ) && 
                (
                    this.Yesterday == input.Yesterday ||
                    this.Yesterday != null &&
                    this.Yesterday.SequenceEqual(input.Yesterday)
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
                if (this.ActiveTotal != null)
                    hashCode = hashCode * 59 + this.ActiveTotal.GetHashCode();
                if (this.LastWeek != null)
                    hashCode = hashCode * 59 + this.LastWeek.GetHashCode();
                if (this.Yesterday != null)
                    hashCode = hashCode * 59 + this.Yesterday.GetHashCode();
                return hashCode;
            }
        }
    }

}
