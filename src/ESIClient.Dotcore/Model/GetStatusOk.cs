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
    public partial class GetStatusOk :  IEquatable<GetStatusOk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatusOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetStatusOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatusOk" /> class.
        /// </summary>
        /// <param name="players">Current online player count (required).</param>
        /// <param name="serverVersion">Running version as string (required).</param>
        /// <param name="startTime">Server start timestamp (required).</param>
        /// <param name="vip">If the server is in VIP mode.</param>
        public GetStatusOk(int? players = default(int?), string serverVersion = default(string), DateTime? startTime = default(DateTime?), bool? vip = default(bool?))
        {
            // to ensure "players" is required (not null)
            if (players == null)
            {
                throw new InvalidDataException("players is a required property for GetStatusOk and cannot be null");
            }
            else
            {
                this.Players = players;
            }
            // to ensure "serverVersion" is required (not null)
            if (serverVersion == null)
            {
                throw new InvalidDataException("serverVersion is a required property for GetStatusOk and cannot be null");
            }
            else
            {
                this.ServerVersion = serverVersion;
            }
            // to ensure "startTime" is required (not null)
            if (startTime == null)
            {
                throw new InvalidDataException("startTime is a required property for GetStatusOk and cannot be null");
            }
            else
            {
                this.StartTime = startTime;
            }
            this.Vip = vip;
        }
        
        /// <summary>
        /// Current online player count
        /// </summary>
        /// <value>Current online player count</value>
        [DataMember(Name="players", EmitDefaultValue=false)]
        public int? Players { get; set; }

        /// <summary>
        /// Running version as string
        /// </summary>
        /// <value>Running version as string</value>
        [DataMember(Name="server_version", EmitDefaultValue=false)]
        public string ServerVersion { get; set; }

        /// <summary>
        /// Server start timestamp
        /// </summary>
        /// <value>Server start timestamp</value>
        [DataMember(Name="start_time", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// If the server is in VIP mode
        /// </summary>
        /// <value>If the server is in VIP mode</value>
        [DataMember(Name="vip", EmitDefaultValue=false)]
        public bool? Vip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetStatusOk {\n");
            sb.Append("  Players: ").Append(Players).Append("\n");
            sb.Append("  ServerVersion: ").Append(ServerVersion).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Vip: ").Append(Vip).Append("\n");
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
            return this.Equals(input as GetStatusOk);
        }

        /// <summary>
        /// Returns true if GetStatusOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetStatusOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetStatusOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Players == input.Players ||
                    (this.Players != null &&
                    this.Players.Equals(input.Players))
                ) && 
                (
                    this.ServerVersion == input.ServerVersion ||
                    (this.ServerVersion != null &&
                    this.ServerVersion.Equals(input.ServerVersion))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Vip == input.Vip ||
                    (this.Vip != null &&
                    this.Vip.Equals(input.Vip))
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
                if (this.Players != null)
                    hashCode = hashCode * 59 + this.Players.GetHashCode();
                if (this.ServerVersion != null)
                    hashCode = hashCode * 59 + this.ServerVersion.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Vip != null)
                    hashCode = hashCode * 59 + this.Vip.GetHashCode();
                return hashCode;
            }
        }
    }

}
