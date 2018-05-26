/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.8.2
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
    /// label object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdMailLabelsLabel :  IEquatable<GetCharactersCharacterIdMailLabelsLabel>
    {
        /// <summary>
        /// color string
        /// </summary>
        /// <value>color string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColorEnum
        {
            
            /// <summary>
            /// Enum _0000fe for value: #0000fe
            /// </summary>
            [EnumMember(Value = "#0000fe")]
            _0000fe = 1,
            
            /// <summary>
            /// Enum _006634 for value: #006634
            /// </summary>
            [EnumMember(Value = "#006634")]
            _006634 = 2,
            
            /// <summary>
            /// Enum _0099ff for value: #0099ff
            /// </summary>
            [EnumMember(Value = "#0099ff")]
            _0099ff = 3,
            
            /// <summary>
            /// Enum _00ff33 for value: #00ff33
            /// </summary>
            [EnumMember(Value = "#00ff33")]
            _00ff33 = 4,
            
            /// <summary>
            /// Enum _01ffff for value: #01ffff
            /// </summary>
            [EnumMember(Value = "#01ffff")]
            _01ffff = 5,
            
            /// <summary>
            /// Enum _349800 for value: #349800
            /// </summary>
            [EnumMember(Value = "#349800")]
            _349800 = 6,
            
            /// <summary>
            /// Enum _660066 for value: #660066
            /// </summary>
            [EnumMember(Value = "#660066")]
            _660066 = 7,
            
            /// <summary>
            /// Enum _666666 for value: #666666
            /// </summary>
            [EnumMember(Value = "#666666")]
            _666666 = 8,
            
            /// <summary>
            /// Enum _999999 for value: #999999
            /// </summary>
            [EnumMember(Value = "#999999")]
            _999999 = 9,
            
            /// <summary>
            /// Enum _99ffff for value: #99ffff
            /// </summary>
            [EnumMember(Value = "#99ffff")]
            _99ffff = 10,
            
            /// <summary>
            /// Enum _9a0000 for value: #9a0000
            /// </summary>
            [EnumMember(Value = "#9a0000")]
            _9a0000 = 11,
            
            /// <summary>
            /// Enum Ccff9a for value: #ccff9a
            /// </summary>
            [EnumMember(Value = "#ccff9a")]
            Ccff9a = 12,
            
            /// <summary>
            /// Enum E6e6e6 for value: #e6e6e6
            /// </summary>
            [EnumMember(Value = "#e6e6e6")]
            E6e6e6 = 13,
            
            /// <summary>
            /// Enum Fe0000 for value: #fe0000
            /// </summary>
            [EnumMember(Value = "#fe0000")]
            Fe0000 = 14,
            
            /// <summary>
            /// Enum Ff6600 for value: #ff6600
            /// </summary>
            [EnumMember(Value = "#ff6600")]
            Ff6600 = 15,
            
            /// <summary>
            /// Enum Ffff01 for value: #ffff01
            /// </summary>
            [EnumMember(Value = "#ffff01")]
            Ffff01 = 16,
            
            /// <summary>
            /// Enum Ffffcd for value: #ffffcd
            /// </summary>
            [EnumMember(Value = "#ffffcd")]
            Ffffcd = 17,
            
            /// <summary>
            /// Enum Ffffff for value: #ffffff
            /// </summary>
            [EnumMember(Value = "#ffffff")]
            Ffffff = 18
        }

        /// <summary>
        /// color string
        /// </summary>
        /// <value>color string</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public ColorEnum? Color { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdMailLabelsLabel" /> class.
        /// </summary>
        /// <param name="color">color string (default to ColorEnum.Ffffff).</param>
        /// <param name="labelId">label_id integer.</param>
        /// <param name="name">name string.</param>
        /// <param name="unreadCount">unread_count integer.</param>
        public GetCharactersCharacterIdMailLabelsLabel(ColorEnum? color = ColorEnum.Ffffff, int? labelId = default(int?), string name = default(string), int? unreadCount = default(int?))
        {
            // use default value if no "color" provided
            if (color == null)
            {
                this.Color = ColorEnum.Ffffff;
            }
            else
            {
                this.Color = color;
            }
            this.LabelId = labelId;
            this.Name = name;
            this.UnreadCount = unreadCount;
        }
        

        /// <summary>
        /// label_id integer
        /// </summary>
        /// <value>label_id integer</value>
        [DataMember(Name="label_id", EmitDefaultValue=false)]
        public int? LabelId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// unread_count integer
        /// </summary>
        /// <value>unread_count integer</value>
        [DataMember(Name="unread_count", EmitDefaultValue=false)]
        public int? UnreadCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdMailLabelsLabel {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  LabelId: ").Append(LabelId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UnreadCount: ").Append(UnreadCount).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdMailLabelsLabel);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdMailLabelsLabel instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdMailLabelsLabel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdMailLabelsLabel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.LabelId == input.LabelId ||
                    (this.LabelId != null &&
                    this.LabelId.Equals(input.LabelId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.UnreadCount == input.UnreadCount ||
                    (this.UnreadCount != null &&
                    this.UnreadCount.Equals(input.UnreadCount))
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
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.LabelId != null)
                    hashCode = hashCode * 59 + this.LabelId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.UnreadCount != null)
                    hashCode = hashCode * 59 + this.UnreadCount.GetHashCode();
                return hashCode;
            }
        }
    }

}