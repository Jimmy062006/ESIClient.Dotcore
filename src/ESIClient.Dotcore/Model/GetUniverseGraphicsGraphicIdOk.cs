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
    public partial class GetUniverseGraphicsGraphicIdOk :  IEquatable<GetUniverseGraphicsGraphicIdOk>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseGraphicsGraphicIdOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetUniverseGraphicsGraphicIdOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseGraphicsGraphicIdOk" /> class.
        /// </summary>
        /// <param name="collisionFile">collision_file string.</param>
        /// <param name="graphicFile">graphic_file string.</param>
        /// <param name="graphicId">graphic_id integer (required).</param>
        /// <param name="iconFolder">icon_folder string.</param>
        /// <param name="sofDna">sof_dna string.</param>
        /// <param name="sofFationName">sof_fation_name string.</param>
        /// <param name="sofHullName">sof_hull_name string.</param>
        /// <param name="sofRaceName">sof_race_name string.</param>
        public GetUniverseGraphicsGraphicIdOk(string collisionFile = default(string), string graphicFile = default(string), int? graphicId = default(int?), string iconFolder = default(string), string sofDna = default(string), string sofFationName = default(string), string sofHullName = default(string), string sofRaceName = default(string))
        {
            // to ensure "graphicId" is required (not null)
            if (graphicId == null)
            {
                throw new InvalidDataException("graphicId is a required property for GetUniverseGraphicsGraphicIdOk and cannot be null");
            }
            else
            {
                this.GraphicId = graphicId;
            }
            this.CollisionFile = collisionFile;
            this.GraphicFile = graphicFile;
            this.IconFolder = iconFolder;
            this.SofDna = sofDna;
            this.SofFationName = sofFationName;
            this.SofHullName = sofHullName;
            this.SofRaceName = sofRaceName;
        }
        
        /// <summary>
        /// collision_file string
        /// </summary>
        /// <value>collision_file string</value>
        [DataMember(Name="collision_file", EmitDefaultValue=false)]
        public string CollisionFile { get; set; }

        /// <summary>
        /// graphic_file string
        /// </summary>
        /// <value>graphic_file string</value>
        [DataMember(Name="graphic_file", EmitDefaultValue=false)]
        public string GraphicFile { get; set; }

        /// <summary>
        /// graphic_id integer
        /// </summary>
        /// <value>graphic_id integer</value>
        [DataMember(Name="graphic_id", EmitDefaultValue=false)]
        public int? GraphicId { get; set; }

        /// <summary>
        /// icon_folder string
        /// </summary>
        /// <value>icon_folder string</value>
        [DataMember(Name="icon_folder", EmitDefaultValue=false)]
        public string IconFolder { get; set; }

        /// <summary>
        /// sof_dna string
        /// </summary>
        /// <value>sof_dna string</value>
        [DataMember(Name="sof_dna", EmitDefaultValue=false)]
        public string SofDna { get; set; }

        /// <summary>
        /// sof_fation_name string
        /// </summary>
        /// <value>sof_fation_name string</value>
        [DataMember(Name="sof_fation_name", EmitDefaultValue=false)]
        public string SofFationName { get; set; }

        /// <summary>
        /// sof_hull_name string
        /// </summary>
        /// <value>sof_hull_name string</value>
        [DataMember(Name="sof_hull_name", EmitDefaultValue=false)]
        public string SofHullName { get; set; }

        /// <summary>
        /// sof_race_name string
        /// </summary>
        /// <value>sof_race_name string</value>
        [DataMember(Name="sof_race_name", EmitDefaultValue=false)]
        public string SofRaceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUniverseGraphicsGraphicIdOk {\n");
            sb.Append("  CollisionFile: ").Append(CollisionFile).Append("\n");
            sb.Append("  GraphicFile: ").Append(GraphicFile).Append("\n");
            sb.Append("  GraphicId: ").Append(GraphicId).Append("\n");
            sb.Append("  IconFolder: ").Append(IconFolder).Append("\n");
            sb.Append("  SofDna: ").Append(SofDna).Append("\n");
            sb.Append("  SofFationName: ").Append(SofFationName).Append("\n");
            sb.Append("  SofHullName: ").Append(SofHullName).Append("\n");
            sb.Append("  SofRaceName: ").Append(SofRaceName).Append("\n");
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
            return this.Equals(input as GetUniverseGraphicsGraphicIdOk);
        }

        /// <summary>
        /// Returns true if GetUniverseGraphicsGraphicIdOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUniverseGraphicsGraphicIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUniverseGraphicsGraphicIdOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CollisionFile == input.CollisionFile ||
                    (this.CollisionFile != null &&
                    this.CollisionFile.Equals(input.CollisionFile))
                ) && 
                (
                    this.GraphicFile == input.GraphicFile ||
                    (this.GraphicFile != null &&
                    this.GraphicFile.Equals(input.GraphicFile))
                ) && 
                (
                    this.GraphicId == input.GraphicId ||
                    (this.GraphicId != null &&
                    this.GraphicId.Equals(input.GraphicId))
                ) && 
                (
                    this.IconFolder == input.IconFolder ||
                    (this.IconFolder != null &&
                    this.IconFolder.Equals(input.IconFolder))
                ) && 
                (
                    this.SofDna == input.SofDna ||
                    (this.SofDna != null &&
                    this.SofDna.Equals(input.SofDna))
                ) && 
                (
                    this.SofFationName == input.SofFationName ||
                    (this.SofFationName != null &&
                    this.SofFationName.Equals(input.SofFationName))
                ) && 
                (
                    this.SofHullName == input.SofHullName ||
                    (this.SofHullName != null &&
                    this.SofHullName.Equals(input.SofHullName))
                ) && 
                (
                    this.SofRaceName == input.SofRaceName ||
                    (this.SofRaceName != null &&
                    this.SofRaceName.Equals(input.SofRaceName))
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
                if (this.CollisionFile != null)
                    hashCode = hashCode * 59 + this.CollisionFile.GetHashCode();
                if (this.GraphicFile != null)
                    hashCode = hashCode * 59 + this.GraphicFile.GetHashCode();
                if (this.GraphicId != null)
                    hashCode = hashCode * 59 + this.GraphicId.GetHashCode();
                if (this.IconFolder != null)
                    hashCode = hashCode * 59 + this.IconFolder.GetHashCode();
                if (this.SofDna != null)
                    hashCode = hashCode * 59 + this.SofDna.GetHashCode();
                if (this.SofFationName != null)
                    hashCode = hashCode * 59 + this.SofFationName.GetHashCode();
                if (this.SofHullName != null)
                    hashCode = hashCode * 59 + this.SofHullName.GetHashCode();
                if (this.SofRaceName != null)
                    hashCode = hashCode * 59 + this.SofRaceName.GetHashCode();
                return hashCode;
            }
        }
    }

}
