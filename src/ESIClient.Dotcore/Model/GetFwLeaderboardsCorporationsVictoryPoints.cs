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
    /// Top 10 rankings of corporations by victory points from yesterday, last week and in total
    /// </summary>
    [DataContract]
    public partial class GetFwLeaderboardsCorporationsVictoryPoints :  IEquatable<GetFwLeaderboardsCorporationsVictoryPoints>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFwLeaderboardsCorporationsVictoryPoints" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetFwLeaderboardsCorporationsVictoryPoints() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFwLeaderboardsCorporationsVictoryPoints" /> class.
        /// </summary>
        /// <param name="activeTotal">Top 10 ranking of corporations active in faction warfare by total victory points. A corporation is considered \&quot;active\&quot; if they have participated in faction warfare in the past 14 days. (required).</param>
        /// <param name="lastWeek">Top 10 ranking of corporations by victory points in the past week (required).</param>
        /// <param name="yesterday">Top 10 ranking of corporations by victory points in the past day (required).</param>
        public GetFwLeaderboardsCorporationsVictoryPoints(List<GetFwLeaderboardsCorporationsActiveTotalActiveTotal1> activeTotal = default(List<GetFwLeaderboardsCorporationsActiveTotalActiveTotal1>), List<GetFwLeaderboardsCorporationsLastWeekLastWeek1> lastWeek = default(List<GetFwLeaderboardsCorporationsLastWeekLastWeek1>), List<GetFwLeaderboardsCorporationsYesterdayYesterday1> yesterday = default(List<GetFwLeaderboardsCorporationsYesterdayYesterday1>))
        {
            // to ensure "activeTotal" is required (not null)
            if (activeTotal == null)
            {
                throw new InvalidDataException("activeTotal is a required property for GetFwLeaderboardsCorporationsVictoryPoints and cannot be null");
            }
            else
            {
                this.ActiveTotal = activeTotal;
            }
            // to ensure "lastWeek" is required (not null)
            if (lastWeek == null)
            {
                throw new InvalidDataException("lastWeek is a required property for GetFwLeaderboardsCorporationsVictoryPoints and cannot be null");
            }
            else
            {
                this.LastWeek = lastWeek;
            }
            // to ensure "yesterday" is required (not null)
            if (yesterday == null)
            {
                throw new InvalidDataException("yesterday is a required property for GetFwLeaderboardsCorporationsVictoryPoints and cannot be null");
            }
            else
            {
                this.Yesterday = yesterday;
            }
        }
        
        /// <summary>
        /// Top 10 ranking of corporations active in faction warfare by total victory points. A corporation is considered \&quot;active\&quot; if they have participated in faction warfare in the past 14 days.
        /// </summary>
        /// <value>Top 10 ranking of corporations active in faction warfare by total victory points. A corporation is considered \&quot;active\&quot; if they have participated in faction warfare in the past 14 days.</value>
        [DataMember(Name="active_total", EmitDefaultValue=false)]
        public List<GetFwLeaderboardsCorporationsActiveTotalActiveTotal1> ActiveTotal { get; set; }

        /// <summary>
        /// Top 10 ranking of corporations by victory points in the past week
        /// </summary>
        /// <value>Top 10 ranking of corporations by victory points in the past week</value>
        [DataMember(Name="last_week", EmitDefaultValue=false)]
        public List<GetFwLeaderboardsCorporationsLastWeekLastWeek1> LastWeek { get; set; }

        /// <summary>
        /// Top 10 ranking of corporations by victory points in the past day
        /// </summary>
        /// <value>Top 10 ranking of corporations by victory points in the past day</value>
        [DataMember(Name="yesterday", EmitDefaultValue=false)]
        public List<GetFwLeaderboardsCorporationsYesterdayYesterday1> Yesterday { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFwLeaderboardsCorporationsVictoryPoints {\n");
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
            return this.Equals(input as GetFwLeaderboardsCorporationsVictoryPoints);
        }

        /// <summary>
        /// Returns true if GetFwLeaderboardsCorporationsVictoryPoints instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFwLeaderboardsCorporationsVictoryPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFwLeaderboardsCorporationsVictoryPoints input)
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
