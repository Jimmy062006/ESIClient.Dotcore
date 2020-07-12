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
    public partial class GetCorporationsCorporationIdContractsContractIdBids200Ok :  IEquatable<GetCorporationsCorporationIdContractsContractIdBids200Ok>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdContractsContractIdBids200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationsCorporationIdContractsContractIdBids200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdContractsContractIdBids200Ok" /> class.
        /// </summary>
        /// <param name="amount">The amount bid, in ISK (required).</param>
        /// <param name="bidId">Unique ID for the bid (required).</param>
        /// <param name="bidderId">Character ID of the bidder (required).</param>
        /// <param name="dateBid">Datetime when the bid was placed (required).</param>
        public GetCorporationsCorporationIdContractsContractIdBids200Ok(float? amount = default(float?), int? bidId = default(int?), int? bidderId = default(int?), DateTime? dateBid = default(DateTime?))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for GetCorporationsCorporationIdContractsContractIdBids200Ok and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "bidId" is required (not null)
            if (bidId == null)
            {
                throw new InvalidDataException("bidId is a required property for GetCorporationsCorporationIdContractsContractIdBids200Ok and cannot be null");
            }
            else
            {
                this.BidId = bidId;
            }
            // to ensure "bidderId" is required (not null)
            if (bidderId == null)
            {
                throw new InvalidDataException("bidderId is a required property for GetCorporationsCorporationIdContractsContractIdBids200Ok and cannot be null");
            }
            else
            {
                this.BidderId = bidderId;
            }
            // to ensure "dateBid" is required (not null)
            if (dateBid == null)
            {
                throw new InvalidDataException("dateBid is a required property for GetCorporationsCorporationIdContractsContractIdBids200Ok and cannot be null");
            }
            else
            {
                this.DateBid = dateBid;
            }
        }
        
        /// <summary>
        /// The amount bid, in ISK
        /// </summary>
        /// <value>The amount bid, in ISK</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public float? Amount { get; set; }

        /// <summary>
        /// Unique ID for the bid
        /// </summary>
        /// <value>Unique ID for the bid</value>
        [DataMember(Name="bid_id", EmitDefaultValue=false)]
        public int? BidId { get; set; }

        /// <summary>
        /// Character ID of the bidder
        /// </summary>
        /// <value>Character ID of the bidder</value>
        [DataMember(Name="bidder_id", EmitDefaultValue=false)]
        public int? BidderId { get; set; }

        /// <summary>
        /// Datetime when the bid was placed
        /// </summary>
        /// <value>Datetime when the bid was placed</value>
        [DataMember(Name="date_bid", EmitDefaultValue=false)]
        public DateTime? DateBid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationsCorporationIdContractsContractIdBids200Ok {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BidId: ").Append(BidId).Append("\n");
            sb.Append("  BidderId: ").Append(BidderId).Append("\n");
            sb.Append("  DateBid: ").Append(DateBid).Append("\n");
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
            return this.Equals(input as GetCorporationsCorporationIdContractsContractIdBids200Ok);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdContractsContractIdBids200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationsCorporationIdContractsContractIdBids200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdContractsContractIdBids200Ok input)
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
                    this.BidId == input.BidId ||
                    (this.BidId != null &&
                    this.BidId.Equals(input.BidId))
                ) && 
                (
                    this.BidderId == input.BidderId ||
                    (this.BidderId != null &&
                    this.BidderId.Equals(input.BidderId))
                ) && 
                (
                    this.DateBid == input.DateBid ||
                    (this.DateBid != null &&
                    this.DateBid.Equals(input.DateBid))
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
                if (this.BidId != null)
                    hashCode = hashCode * 59 + this.BidId.GetHashCode();
                if (this.BidderId != null)
                    hashCode = hashCode * 59 + this.BidderId.GetHashCode();
                if (this.DateBid != null)
                    hashCode = hashCode * 59 + this.DateBid.GetHashCode();
                return hashCode;
            }
        }
    }

}
