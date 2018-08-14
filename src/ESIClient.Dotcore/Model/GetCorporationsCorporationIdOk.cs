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
    public partial class GetCorporationsCorporationIdOk :  IEquatable<GetCorporationsCorporationIdOk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationsCorporationIdOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdOk" /> class.
        /// </summary>
        /// <param name="allianceId">ID of the alliance that corporation is a member of, if any.</param>
        /// <param name="ceoId">ceo_id integer (required).</param>
        /// <param name="creatorId">creator_id integer (required).</param>
        /// <param name="dateFounded">date_founded string.</param>
        /// <param name="description">description string.</param>
        /// <param name="factionId">faction_id integer.</param>
        /// <param name="homeStationId">home_station_id integer.</param>
        /// <param name="memberCount">member_count integer (required).</param>
        /// <param name="name">the full name of the corporation (required).</param>
        /// <param name="shares">shares integer.</param>
        /// <param name="taxRate">tax_rate number (required).</param>
        /// <param name="ticker">the short name of the corporation (required).</param>
        /// <param name="url">url string.</param>
        public GetCorporationsCorporationIdOk(int? allianceId = default(int?), int? ceoId = default(int?), int? creatorId = default(int?), DateTime? dateFounded = default(DateTime?), string description = default(string), int? factionId = default(int?), int? homeStationId = default(int?), int? memberCount = default(int?), string name = default(string), long? shares = default(long?), float? taxRate = default(float?), string ticker = default(string), string url = default(string))
        {
            // to ensure "ceoId" is required (not null)
            if (ceoId == null)
            {
                throw new InvalidDataException("ceoId is a required property for GetCorporationsCorporationIdOk and cannot be null");
            }
            else
            {
                this.CeoId = ceoId;
            }
            // to ensure "creatorId" is required (not null)
            if (creatorId == null)
            {
                throw new InvalidDataException("creatorId is a required property for GetCorporationsCorporationIdOk and cannot be null");
            }
            else
            {
                this.CreatorId = creatorId;
            }
            // to ensure "memberCount" is required (not null)
            if (memberCount == null)
            {
                throw new InvalidDataException("memberCount is a required property for GetCorporationsCorporationIdOk and cannot be null");
            }
            else
            {
                this.MemberCount = memberCount;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetCorporationsCorporationIdOk and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "taxRate" is required (not null)
            if (taxRate == null)
            {
                throw new InvalidDataException("taxRate is a required property for GetCorporationsCorporationIdOk and cannot be null");
            }
            else
            {
                this.TaxRate = taxRate;
            }
            // to ensure "ticker" is required (not null)
            if (ticker == null)
            {
                throw new InvalidDataException("ticker is a required property for GetCorporationsCorporationIdOk and cannot be null");
            }
            else
            {
                this.Ticker = ticker;
            }
            this.AllianceId = allianceId;
            this.DateFounded = dateFounded;
            this.Description = description;
            this.FactionId = factionId;
            this.HomeStationId = homeStationId;
            this.Shares = shares;
            this.Url = url;
        }
        
        /// <summary>
        /// ID of the alliance that corporation is a member of, if any
        /// </summary>
        /// <value>ID of the alliance that corporation is a member of, if any</value>
        [DataMember(Name="alliance_id", EmitDefaultValue=false)]
        public int? AllianceId { get; set; }

        /// <summary>
        /// ceo_id integer
        /// </summary>
        /// <value>ceo_id integer</value>
        [DataMember(Name="ceo_id", EmitDefaultValue=false)]
        public int? CeoId { get; set; }

        /// <summary>
        /// creator_id integer
        /// </summary>
        /// <value>creator_id integer</value>
        [DataMember(Name="creator_id", EmitDefaultValue=false)]
        public int? CreatorId { get; set; }

        /// <summary>
        /// date_founded string
        /// </summary>
        /// <value>date_founded string</value>
        [DataMember(Name="date_founded", EmitDefaultValue=false)]
        public DateTime? DateFounded { get; set; }

        /// <summary>
        /// description string
        /// </summary>
        /// <value>description string</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        /// <value>faction_id integer</value>
        [DataMember(Name="faction_id", EmitDefaultValue=false)]
        public int? FactionId { get; set; }

        /// <summary>
        /// home_station_id integer
        /// </summary>
        /// <value>home_station_id integer</value>
        [DataMember(Name="home_station_id", EmitDefaultValue=false)]
        public int? HomeStationId { get; set; }

        /// <summary>
        /// member_count integer
        /// </summary>
        /// <value>member_count integer</value>
        [DataMember(Name="member_count", EmitDefaultValue=false)]
        public int? MemberCount { get; set; }

        /// <summary>
        /// the full name of the corporation
        /// </summary>
        /// <value>the full name of the corporation</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// shares integer
        /// </summary>
        /// <value>shares integer</value>
        [DataMember(Name="shares", EmitDefaultValue=false)]
        public long? Shares { get; set; }

        /// <summary>
        /// tax_rate number
        /// </summary>
        /// <value>tax_rate number</value>
        [DataMember(Name="tax_rate", EmitDefaultValue=false)]
        public float? TaxRate { get; set; }

        /// <summary>
        /// the short name of the corporation
        /// </summary>
        /// <value>the short name of the corporation</value>
        [DataMember(Name="ticker", EmitDefaultValue=false)]
        public string Ticker { get; set; }

        /// <summary>
        /// url string
        /// </summary>
        /// <value>url string</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationsCorporationIdOk {\n");
            sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
            sb.Append("  CeoId: ").Append(CeoId).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  DateFounded: ").Append(DateFounded).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FactionId: ").Append(FactionId).Append("\n");
            sb.Append("  HomeStationId: ").Append(HomeStationId).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Shares: ").Append(Shares).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  Ticker: ").Append(Ticker).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as GetCorporationsCorporationIdOk);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationsCorporationIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllianceId == input.AllianceId ||
                    (this.AllianceId != null &&
                    this.AllianceId.Equals(input.AllianceId))
                ) && 
                (
                    this.CeoId == input.CeoId ||
                    (this.CeoId != null &&
                    this.CeoId.Equals(input.CeoId))
                ) && 
                (
                    this.CreatorId == input.CreatorId ||
                    (this.CreatorId != null &&
                    this.CreatorId.Equals(input.CreatorId))
                ) && 
                (
                    this.DateFounded == input.DateFounded ||
                    (this.DateFounded != null &&
                    this.DateFounded.Equals(input.DateFounded))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FactionId == input.FactionId ||
                    (this.FactionId != null &&
                    this.FactionId.Equals(input.FactionId))
                ) && 
                (
                    this.HomeStationId == input.HomeStationId ||
                    (this.HomeStationId != null &&
                    this.HomeStationId.Equals(input.HomeStationId))
                ) && 
                (
                    this.MemberCount == input.MemberCount ||
                    (this.MemberCount != null &&
                    this.MemberCount.Equals(input.MemberCount))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Shares == input.Shares ||
                    (this.Shares != null &&
                    this.Shares.Equals(input.Shares))
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && 
                (
                    this.Ticker == input.Ticker ||
                    (this.Ticker != null &&
                    this.Ticker.Equals(input.Ticker))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.AllianceId != null)
                    hashCode = hashCode * 59 + this.AllianceId.GetHashCode();
                if (this.CeoId != null)
                    hashCode = hashCode * 59 + this.CeoId.GetHashCode();
                if (this.CreatorId != null)
                    hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.DateFounded != null)
                    hashCode = hashCode * 59 + this.DateFounded.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FactionId != null)
                    hashCode = hashCode * 59 + this.FactionId.GetHashCode();
                if (this.HomeStationId != null)
                    hashCode = hashCode * 59 + this.HomeStationId.GetHashCode();
                if (this.MemberCount != null)
                    hashCode = hashCode * 59 + this.MemberCount.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Shares != null)
                    hashCode = hashCode * 59 + this.Shares.GetHashCode();
                if (this.TaxRate != null)
                    hashCode = hashCode * 59 + this.TaxRate.GetHashCode();
                if (this.Ticker != null)
                    hashCode = hashCode * 59 + this.Ticker.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }

}
