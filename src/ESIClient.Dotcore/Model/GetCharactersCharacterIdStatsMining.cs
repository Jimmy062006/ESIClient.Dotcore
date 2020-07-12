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
    /// mining object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdStatsMining :  IEquatable<GetCharactersCharacterIdStatsMining>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdStatsMining" /> class.
        /// </summary>
        /// <param name="droneMine">drone_mine integer.</param>
        /// <param name="oreArkonor">ore_arkonor integer.</param>
        /// <param name="oreBistot">ore_bistot integer.</param>
        /// <param name="oreCrokite">ore_crokite integer.</param>
        /// <param name="oreDarkOchre">ore_dark_ochre integer.</param>
        /// <param name="oreGneiss">ore_gneiss integer.</param>
        /// <param name="oreHarvestableCloud">ore_harvestable_cloud integer.</param>
        /// <param name="oreHedbergite">ore_hedbergite integer.</param>
        /// <param name="oreHemorphite">ore_hemorphite integer.</param>
        /// <param name="oreIce">ore_ice integer.</param>
        /// <param name="oreJaspet">ore_jaspet integer.</param>
        /// <param name="oreKernite">ore_kernite integer.</param>
        /// <param name="oreMercoxit">ore_mercoxit integer.</param>
        /// <param name="oreOmber">ore_omber integer.</param>
        /// <param name="orePlagioclase">ore_plagioclase integer.</param>
        /// <param name="orePyroxeres">ore_pyroxeres integer.</param>
        /// <param name="oreScordite">ore_scordite integer.</param>
        /// <param name="oreSpodumain">ore_spodumain integer.</param>
        /// <param name="oreVeldspar">ore_veldspar integer.</param>
        public GetCharactersCharacterIdStatsMining(long? droneMine = default(long?), long? oreArkonor = default(long?), long? oreBistot = default(long?), long? oreCrokite = default(long?), long? oreDarkOchre = default(long?), long? oreGneiss = default(long?), long? oreHarvestableCloud = default(long?), long? oreHedbergite = default(long?), long? oreHemorphite = default(long?), long? oreIce = default(long?), long? oreJaspet = default(long?), long? oreKernite = default(long?), long? oreMercoxit = default(long?), long? oreOmber = default(long?), long? orePlagioclase = default(long?), long? orePyroxeres = default(long?), long? oreScordite = default(long?), long? oreSpodumain = default(long?), long? oreVeldspar = default(long?))
        {
            this.DroneMine = droneMine;
            this.OreArkonor = oreArkonor;
            this.OreBistot = oreBistot;
            this.OreCrokite = oreCrokite;
            this.OreDarkOchre = oreDarkOchre;
            this.OreGneiss = oreGneiss;
            this.OreHarvestableCloud = oreHarvestableCloud;
            this.OreHedbergite = oreHedbergite;
            this.OreHemorphite = oreHemorphite;
            this.OreIce = oreIce;
            this.OreJaspet = oreJaspet;
            this.OreKernite = oreKernite;
            this.OreMercoxit = oreMercoxit;
            this.OreOmber = oreOmber;
            this.OrePlagioclase = orePlagioclase;
            this.OrePyroxeres = orePyroxeres;
            this.OreScordite = oreScordite;
            this.OreSpodumain = oreSpodumain;
            this.OreVeldspar = oreVeldspar;
        }
        
        /// <summary>
        /// drone_mine integer
        /// </summary>
        /// <value>drone_mine integer</value>
        [DataMember(Name="drone_mine", EmitDefaultValue=false)]
        public long? DroneMine { get; set; }

        /// <summary>
        /// ore_arkonor integer
        /// </summary>
        /// <value>ore_arkonor integer</value>
        [DataMember(Name="ore_arkonor", EmitDefaultValue=false)]
        public long? OreArkonor { get; set; }

        /// <summary>
        /// ore_bistot integer
        /// </summary>
        /// <value>ore_bistot integer</value>
        [DataMember(Name="ore_bistot", EmitDefaultValue=false)]
        public long? OreBistot { get; set; }

        /// <summary>
        /// ore_crokite integer
        /// </summary>
        /// <value>ore_crokite integer</value>
        [DataMember(Name="ore_crokite", EmitDefaultValue=false)]
        public long? OreCrokite { get; set; }

        /// <summary>
        /// ore_dark_ochre integer
        /// </summary>
        /// <value>ore_dark_ochre integer</value>
        [DataMember(Name="ore_dark_ochre", EmitDefaultValue=false)]
        public long? OreDarkOchre { get; set; }

        /// <summary>
        /// ore_gneiss integer
        /// </summary>
        /// <value>ore_gneiss integer</value>
        [DataMember(Name="ore_gneiss", EmitDefaultValue=false)]
        public long? OreGneiss { get; set; }

        /// <summary>
        /// ore_harvestable_cloud integer
        /// </summary>
        /// <value>ore_harvestable_cloud integer</value>
        [DataMember(Name="ore_harvestable_cloud", EmitDefaultValue=false)]
        public long? OreHarvestableCloud { get; set; }

        /// <summary>
        /// ore_hedbergite integer
        /// </summary>
        /// <value>ore_hedbergite integer</value>
        [DataMember(Name="ore_hedbergite", EmitDefaultValue=false)]
        public long? OreHedbergite { get; set; }

        /// <summary>
        /// ore_hemorphite integer
        /// </summary>
        /// <value>ore_hemorphite integer</value>
        [DataMember(Name="ore_hemorphite", EmitDefaultValue=false)]
        public long? OreHemorphite { get; set; }

        /// <summary>
        /// ore_ice integer
        /// </summary>
        /// <value>ore_ice integer</value>
        [DataMember(Name="ore_ice", EmitDefaultValue=false)]
        public long? OreIce { get; set; }

        /// <summary>
        /// ore_jaspet integer
        /// </summary>
        /// <value>ore_jaspet integer</value>
        [DataMember(Name="ore_jaspet", EmitDefaultValue=false)]
        public long? OreJaspet { get; set; }

        /// <summary>
        /// ore_kernite integer
        /// </summary>
        /// <value>ore_kernite integer</value>
        [DataMember(Name="ore_kernite", EmitDefaultValue=false)]
        public long? OreKernite { get; set; }

        /// <summary>
        /// ore_mercoxit integer
        /// </summary>
        /// <value>ore_mercoxit integer</value>
        [DataMember(Name="ore_mercoxit", EmitDefaultValue=false)]
        public long? OreMercoxit { get; set; }

        /// <summary>
        /// ore_omber integer
        /// </summary>
        /// <value>ore_omber integer</value>
        [DataMember(Name="ore_omber", EmitDefaultValue=false)]
        public long? OreOmber { get; set; }

        /// <summary>
        /// ore_plagioclase integer
        /// </summary>
        /// <value>ore_plagioclase integer</value>
        [DataMember(Name="ore_plagioclase", EmitDefaultValue=false)]
        public long? OrePlagioclase { get; set; }

        /// <summary>
        /// ore_pyroxeres integer
        /// </summary>
        /// <value>ore_pyroxeres integer</value>
        [DataMember(Name="ore_pyroxeres", EmitDefaultValue=false)]
        public long? OrePyroxeres { get; set; }

        /// <summary>
        /// ore_scordite integer
        /// </summary>
        /// <value>ore_scordite integer</value>
        [DataMember(Name="ore_scordite", EmitDefaultValue=false)]
        public long? OreScordite { get; set; }

        /// <summary>
        /// ore_spodumain integer
        /// </summary>
        /// <value>ore_spodumain integer</value>
        [DataMember(Name="ore_spodumain", EmitDefaultValue=false)]
        public long? OreSpodumain { get; set; }

        /// <summary>
        /// ore_veldspar integer
        /// </summary>
        /// <value>ore_veldspar integer</value>
        [DataMember(Name="ore_veldspar", EmitDefaultValue=false)]
        public long? OreVeldspar { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdStatsMining {\n");
            sb.Append("  DroneMine: ").Append(DroneMine).Append("\n");
            sb.Append("  OreArkonor: ").Append(OreArkonor).Append("\n");
            sb.Append("  OreBistot: ").Append(OreBistot).Append("\n");
            sb.Append("  OreCrokite: ").Append(OreCrokite).Append("\n");
            sb.Append("  OreDarkOchre: ").Append(OreDarkOchre).Append("\n");
            sb.Append("  OreGneiss: ").Append(OreGneiss).Append("\n");
            sb.Append("  OreHarvestableCloud: ").Append(OreHarvestableCloud).Append("\n");
            sb.Append("  OreHedbergite: ").Append(OreHedbergite).Append("\n");
            sb.Append("  OreHemorphite: ").Append(OreHemorphite).Append("\n");
            sb.Append("  OreIce: ").Append(OreIce).Append("\n");
            sb.Append("  OreJaspet: ").Append(OreJaspet).Append("\n");
            sb.Append("  OreKernite: ").Append(OreKernite).Append("\n");
            sb.Append("  OreMercoxit: ").Append(OreMercoxit).Append("\n");
            sb.Append("  OreOmber: ").Append(OreOmber).Append("\n");
            sb.Append("  OrePlagioclase: ").Append(OrePlagioclase).Append("\n");
            sb.Append("  OrePyroxeres: ").Append(OrePyroxeres).Append("\n");
            sb.Append("  OreScordite: ").Append(OreScordite).Append("\n");
            sb.Append("  OreSpodumain: ").Append(OreSpodumain).Append("\n");
            sb.Append("  OreVeldspar: ").Append(OreVeldspar).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdStatsMining);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdStatsMining instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdStatsMining to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdStatsMining input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DroneMine == input.DroneMine ||
                    (this.DroneMine != null &&
                    this.DroneMine.Equals(input.DroneMine))
                ) && 
                (
                    this.OreArkonor == input.OreArkonor ||
                    (this.OreArkonor != null &&
                    this.OreArkonor.Equals(input.OreArkonor))
                ) && 
                (
                    this.OreBistot == input.OreBistot ||
                    (this.OreBistot != null &&
                    this.OreBistot.Equals(input.OreBistot))
                ) && 
                (
                    this.OreCrokite == input.OreCrokite ||
                    (this.OreCrokite != null &&
                    this.OreCrokite.Equals(input.OreCrokite))
                ) && 
                (
                    this.OreDarkOchre == input.OreDarkOchre ||
                    (this.OreDarkOchre != null &&
                    this.OreDarkOchre.Equals(input.OreDarkOchre))
                ) && 
                (
                    this.OreGneiss == input.OreGneiss ||
                    (this.OreGneiss != null &&
                    this.OreGneiss.Equals(input.OreGneiss))
                ) && 
                (
                    this.OreHarvestableCloud == input.OreHarvestableCloud ||
                    (this.OreHarvestableCloud != null &&
                    this.OreHarvestableCloud.Equals(input.OreHarvestableCloud))
                ) && 
                (
                    this.OreHedbergite == input.OreHedbergite ||
                    (this.OreHedbergite != null &&
                    this.OreHedbergite.Equals(input.OreHedbergite))
                ) && 
                (
                    this.OreHemorphite == input.OreHemorphite ||
                    (this.OreHemorphite != null &&
                    this.OreHemorphite.Equals(input.OreHemorphite))
                ) && 
                (
                    this.OreIce == input.OreIce ||
                    (this.OreIce != null &&
                    this.OreIce.Equals(input.OreIce))
                ) && 
                (
                    this.OreJaspet == input.OreJaspet ||
                    (this.OreJaspet != null &&
                    this.OreJaspet.Equals(input.OreJaspet))
                ) && 
                (
                    this.OreKernite == input.OreKernite ||
                    (this.OreKernite != null &&
                    this.OreKernite.Equals(input.OreKernite))
                ) && 
                (
                    this.OreMercoxit == input.OreMercoxit ||
                    (this.OreMercoxit != null &&
                    this.OreMercoxit.Equals(input.OreMercoxit))
                ) && 
                (
                    this.OreOmber == input.OreOmber ||
                    (this.OreOmber != null &&
                    this.OreOmber.Equals(input.OreOmber))
                ) && 
                (
                    this.OrePlagioclase == input.OrePlagioclase ||
                    (this.OrePlagioclase != null &&
                    this.OrePlagioclase.Equals(input.OrePlagioclase))
                ) && 
                (
                    this.OrePyroxeres == input.OrePyroxeres ||
                    (this.OrePyroxeres != null &&
                    this.OrePyroxeres.Equals(input.OrePyroxeres))
                ) && 
                (
                    this.OreScordite == input.OreScordite ||
                    (this.OreScordite != null &&
                    this.OreScordite.Equals(input.OreScordite))
                ) && 
                (
                    this.OreSpodumain == input.OreSpodumain ||
                    (this.OreSpodumain != null &&
                    this.OreSpodumain.Equals(input.OreSpodumain))
                ) && 
                (
                    this.OreVeldspar == input.OreVeldspar ||
                    (this.OreVeldspar != null &&
                    this.OreVeldspar.Equals(input.OreVeldspar))
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
                if (this.DroneMine != null)
                    hashCode = hashCode * 59 + this.DroneMine.GetHashCode();
                if (this.OreArkonor != null)
                    hashCode = hashCode * 59 + this.OreArkonor.GetHashCode();
                if (this.OreBistot != null)
                    hashCode = hashCode * 59 + this.OreBistot.GetHashCode();
                if (this.OreCrokite != null)
                    hashCode = hashCode * 59 + this.OreCrokite.GetHashCode();
                if (this.OreDarkOchre != null)
                    hashCode = hashCode * 59 + this.OreDarkOchre.GetHashCode();
                if (this.OreGneiss != null)
                    hashCode = hashCode * 59 + this.OreGneiss.GetHashCode();
                if (this.OreHarvestableCloud != null)
                    hashCode = hashCode * 59 + this.OreHarvestableCloud.GetHashCode();
                if (this.OreHedbergite != null)
                    hashCode = hashCode * 59 + this.OreHedbergite.GetHashCode();
                if (this.OreHemorphite != null)
                    hashCode = hashCode * 59 + this.OreHemorphite.GetHashCode();
                if (this.OreIce != null)
                    hashCode = hashCode * 59 + this.OreIce.GetHashCode();
                if (this.OreJaspet != null)
                    hashCode = hashCode * 59 + this.OreJaspet.GetHashCode();
                if (this.OreKernite != null)
                    hashCode = hashCode * 59 + this.OreKernite.GetHashCode();
                if (this.OreMercoxit != null)
                    hashCode = hashCode * 59 + this.OreMercoxit.GetHashCode();
                if (this.OreOmber != null)
                    hashCode = hashCode * 59 + this.OreOmber.GetHashCode();
                if (this.OrePlagioclase != null)
                    hashCode = hashCode * 59 + this.OrePlagioclase.GetHashCode();
                if (this.OrePyroxeres != null)
                    hashCode = hashCode * 59 + this.OrePyroxeres.GetHashCode();
                if (this.OreScordite != null)
                    hashCode = hashCode * 59 + this.OreScordite.GetHashCode();
                if (this.OreSpodumain != null)
                    hashCode = hashCode * 59 + this.OreSpodumain.GetHashCode();
                if (this.OreVeldspar != null)
                    hashCode = hashCode * 59 + this.OreVeldspar.GetHashCode();
                return hashCode;
            }
        }
    }

}
