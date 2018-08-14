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
    public partial class GetCorporationsCorporationIdIconsOk :  IEquatable<GetCorporationsCorporationIdIconsOk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdIconsOk" /> class.
        /// </summary>
        /// <param name="px128x128">px128x128 string.</param>
        /// <param name="px256x256">px256x256 string.</param>
        /// <param name="px64x64">px64x64 string.</param>
        public GetCorporationsCorporationIdIconsOk(string px128x128 = default(string), string px256x256 = default(string), string px64x64 = default(string))
        {
            this.Px128x128 = px128x128;
            this.Px256x256 = px256x256;
            this.Px64x64 = px64x64;
        }
        
        /// <summary>
        /// px128x128 string
        /// </summary>
        /// <value>px128x128 string</value>
        [DataMember(Name="px128x128", EmitDefaultValue=false)]
        public string Px128x128 { get; set; }

        /// <summary>
        /// px256x256 string
        /// </summary>
        /// <value>px256x256 string</value>
        [DataMember(Name="px256x256", EmitDefaultValue=false)]
        public string Px256x256 { get; set; }

        /// <summary>
        /// px64x64 string
        /// </summary>
        /// <value>px64x64 string</value>
        [DataMember(Name="px64x64", EmitDefaultValue=false)]
        public string Px64x64 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationsCorporationIdIconsOk {\n");
            sb.Append("  Px128x128: ").Append(Px128x128).Append("\n");
            sb.Append("  Px256x256: ").Append(Px256x256).Append("\n");
            sb.Append("  Px64x64: ").Append(Px64x64).Append("\n");
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
            return this.Equals(input as GetCorporationsCorporationIdIconsOk);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdIconsOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationsCorporationIdIconsOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdIconsOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Px128x128 == input.Px128x128 ||
                    (this.Px128x128 != null &&
                    this.Px128x128.Equals(input.Px128x128))
                ) && 
                (
                    this.Px256x256 == input.Px256x256 ||
                    (this.Px256x256 != null &&
                    this.Px256x256.Equals(input.Px256x256))
                ) && 
                (
                    this.Px64x64 == input.Px64x64 ||
                    (this.Px64x64 != null &&
                    this.Px64x64.Equals(input.Px64x64))
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
                if (this.Px128x128 != null)
                    hashCode = hashCode * 59 + this.Px128x128.GetHashCode();
                if (this.Px256x256 != null)
                    hashCode = hashCode * 59 + this.Px256x256.GetHashCode();
                if (this.Px64x64 != null)
                    hashCode = hashCode * 59 + this.Px64x64.GetHashCode();
                return hashCode;
            }
        }
    }

}
