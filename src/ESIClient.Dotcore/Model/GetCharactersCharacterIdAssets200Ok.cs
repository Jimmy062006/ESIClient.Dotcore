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
    public partial class GetCharactersCharacterIdAssets200Ok :  IEquatable<GetCharactersCharacterIdAssets200Ok>
    {
        /// <summary>
        /// location_flag string
        /// </summary>
        /// <value>location_flag string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LocationFlagEnum
        {
            
            /// <summary>
            /// Enum AssetSafety for value: AssetSafety
            /// </summary>
            [EnumMember(Value = "AssetSafety")]
            AssetSafety = 1,
            
            /// <summary>
            /// Enum AutoFit for value: AutoFit
            /// </summary>
            [EnumMember(Value = "AutoFit")]
            AutoFit = 2,
            
            /// <summary>
            /// Enum BoosterBay for value: BoosterBay
            /// </summary>
            [EnumMember(Value = "BoosterBay")]
            BoosterBay = 3,
            
            /// <summary>
            /// Enum Cargo for value: Cargo
            /// </summary>
            [EnumMember(Value = "Cargo")]
            Cargo = 4,
            
            /// <summary>
            /// Enum CorpseBay for value: CorpseBay
            /// </summary>
            [EnumMember(Value = "CorpseBay")]
            CorpseBay = 5,
            
            /// <summary>
            /// Enum Deliveries for value: Deliveries
            /// </summary>
            [EnumMember(Value = "Deliveries")]
            Deliveries = 6,
            
            /// <summary>
            /// Enum DroneBay for value: DroneBay
            /// </summary>
            [EnumMember(Value = "DroneBay")]
            DroneBay = 7,
            
            /// <summary>
            /// Enum FighterBay for value: FighterBay
            /// </summary>
            [EnumMember(Value = "FighterBay")]
            FighterBay = 8,
            
            /// <summary>
            /// Enum FighterTube0 for value: FighterTube0
            /// </summary>
            [EnumMember(Value = "FighterTube0")]
            FighterTube0 = 9,
            
            /// <summary>
            /// Enum FighterTube1 for value: FighterTube1
            /// </summary>
            [EnumMember(Value = "FighterTube1")]
            FighterTube1 = 10,
            
            /// <summary>
            /// Enum FighterTube2 for value: FighterTube2
            /// </summary>
            [EnumMember(Value = "FighterTube2")]
            FighterTube2 = 11,
            
            /// <summary>
            /// Enum FighterTube3 for value: FighterTube3
            /// </summary>
            [EnumMember(Value = "FighterTube3")]
            FighterTube3 = 12,
            
            /// <summary>
            /// Enum FighterTube4 for value: FighterTube4
            /// </summary>
            [EnumMember(Value = "FighterTube4")]
            FighterTube4 = 13,
            
            /// <summary>
            /// Enum FleetHangar for value: FleetHangar
            /// </summary>
            [EnumMember(Value = "FleetHangar")]
            FleetHangar = 14,
            
            /// <summary>
            /// Enum Hangar for value: Hangar
            /// </summary>
            [EnumMember(Value = "Hangar")]
            Hangar = 15,
            
            /// <summary>
            /// Enum HangarAll for value: HangarAll
            /// </summary>
            [EnumMember(Value = "HangarAll")]
            HangarAll = 16,
            
            /// <summary>
            /// Enum HiSlot0 for value: HiSlot0
            /// </summary>
            [EnumMember(Value = "HiSlot0")]
            HiSlot0 = 17,
            
            /// <summary>
            /// Enum HiSlot1 for value: HiSlot1
            /// </summary>
            [EnumMember(Value = "HiSlot1")]
            HiSlot1 = 18,
            
            /// <summary>
            /// Enum HiSlot2 for value: HiSlot2
            /// </summary>
            [EnumMember(Value = "HiSlot2")]
            HiSlot2 = 19,
            
            /// <summary>
            /// Enum HiSlot3 for value: HiSlot3
            /// </summary>
            [EnumMember(Value = "HiSlot3")]
            HiSlot3 = 20,
            
            /// <summary>
            /// Enum HiSlot4 for value: HiSlot4
            /// </summary>
            [EnumMember(Value = "HiSlot4")]
            HiSlot4 = 21,
            
            /// <summary>
            /// Enum HiSlot5 for value: HiSlot5
            /// </summary>
            [EnumMember(Value = "HiSlot5")]
            HiSlot5 = 22,
            
            /// <summary>
            /// Enum HiSlot6 for value: HiSlot6
            /// </summary>
            [EnumMember(Value = "HiSlot6")]
            HiSlot6 = 23,
            
            /// <summary>
            /// Enum HiSlot7 for value: HiSlot7
            /// </summary>
            [EnumMember(Value = "HiSlot7")]
            HiSlot7 = 24,
            
            /// <summary>
            /// Enum HiddenModifiers for value: HiddenModifiers
            /// </summary>
            [EnumMember(Value = "HiddenModifiers")]
            HiddenModifiers = 25,
            
            /// <summary>
            /// Enum Implant for value: Implant
            /// </summary>
            [EnumMember(Value = "Implant")]
            Implant = 26,
            
            /// <summary>
            /// Enum LoSlot0 for value: LoSlot0
            /// </summary>
            [EnumMember(Value = "LoSlot0")]
            LoSlot0 = 27,
            
            /// <summary>
            /// Enum LoSlot1 for value: LoSlot1
            /// </summary>
            [EnumMember(Value = "LoSlot1")]
            LoSlot1 = 28,
            
            /// <summary>
            /// Enum LoSlot2 for value: LoSlot2
            /// </summary>
            [EnumMember(Value = "LoSlot2")]
            LoSlot2 = 29,
            
            /// <summary>
            /// Enum LoSlot3 for value: LoSlot3
            /// </summary>
            [EnumMember(Value = "LoSlot3")]
            LoSlot3 = 30,
            
            /// <summary>
            /// Enum LoSlot4 for value: LoSlot4
            /// </summary>
            [EnumMember(Value = "LoSlot4")]
            LoSlot4 = 31,
            
            /// <summary>
            /// Enum LoSlot5 for value: LoSlot5
            /// </summary>
            [EnumMember(Value = "LoSlot5")]
            LoSlot5 = 32,
            
            /// <summary>
            /// Enum LoSlot6 for value: LoSlot6
            /// </summary>
            [EnumMember(Value = "LoSlot6")]
            LoSlot6 = 33,
            
            /// <summary>
            /// Enum LoSlot7 for value: LoSlot7
            /// </summary>
            [EnumMember(Value = "LoSlot7")]
            LoSlot7 = 34,
            
            /// <summary>
            /// Enum Locked for value: Locked
            /// </summary>
            [EnumMember(Value = "Locked")]
            Locked = 35,
            
            /// <summary>
            /// Enum MedSlot0 for value: MedSlot0
            /// </summary>
            [EnumMember(Value = "MedSlot0")]
            MedSlot0 = 36,
            
            /// <summary>
            /// Enum MedSlot1 for value: MedSlot1
            /// </summary>
            [EnumMember(Value = "MedSlot1")]
            MedSlot1 = 37,
            
            /// <summary>
            /// Enum MedSlot2 for value: MedSlot2
            /// </summary>
            [EnumMember(Value = "MedSlot2")]
            MedSlot2 = 38,
            
            /// <summary>
            /// Enum MedSlot3 for value: MedSlot3
            /// </summary>
            [EnumMember(Value = "MedSlot3")]
            MedSlot3 = 39,
            
            /// <summary>
            /// Enum MedSlot4 for value: MedSlot4
            /// </summary>
            [EnumMember(Value = "MedSlot4")]
            MedSlot4 = 40,
            
            /// <summary>
            /// Enum MedSlot5 for value: MedSlot5
            /// </summary>
            [EnumMember(Value = "MedSlot5")]
            MedSlot5 = 41,
            
            /// <summary>
            /// Enum MedSlot6 for value: MedSlot6
            /// </summary>
            [EnumMember(Value = "MedSlot6")]
            MedSlot6 = 42,
            
            /// <summary>
            /// Enum MedSlot7 for value: MedSlot7
            /// </summary>
            [EnumMember(Value = "MedSlot7")]
            MedSlot7 = 43,
            
            /// <summary>
            /// Enum QuafeBay for value: QuafeBay
            /// </summary>
            [EnumMember(Value = "QuafeBay")]
            QuafeBay = 44,
            
            /// <summary>
            /// Enum RigSlot0 for value: RigSlot0
            /// </summary>
            [EnumMember(Value = "RigSlot0")]
            RigSlot0 = 45,
            
            /// <summary>
            /// Enum RigSlot1 for value: RigSlot1
            /// </summary>
            [EnumMember(Value = "RigSlot1")]
            RigSlot1 = 46,
            
            /// <summary>
            /// Enum RigSlot2 for value: RigSlot2
            /// </summary>
            [EnumMember(Value = "RigSlot2")]
            RigSlot2 = 47,
            
            /// <summary>
            /// Enum RigSlot3 for value: RigSlot3
            /// </summary>
            [EnumMember(Value = "RigSlot3")]
            RigSlot3 = 48,
            
            /// <summary>
            /// Enum RigSlot4 for value: RigSlot4
            /// </summary>
            [EnumMember(Value = "RigSlot4")]
            RigSlot4 = 49,
            
            /// <summary>
            /// Enum RigSlot5 for value: RigSlot5
            /// </summary>
            [EnumMember(Value = "RigSlot5")]
            RigSlot5 = 50,
            
            /// <summary>
            /// Enum RigSlot6 for value: RigSlot6
            /// </summary>
            [EnumMember(Value = "RigSlot6")]
            RigSlot6 = 51,
            
            /// <summary>
            /// Enum RigSlot7 for value: RigSlot7
            /// </summary>
            [EnumMember(Value = "RigSlot7")]
            RigSlot7 = 52,
            
            /// <summary>
            /// Enum ShipHangar for value: ShipHangar
            /// </summary>
            [EnumMember(Value = "ShipHangar")]
            ShipHangar = 53,
            
            /// <summary>
            /// Enum Skill for value: Skill
            /// </summary>
            [EnumMember(Value = "Skill")]
            Skill = 54,
            
            /// <summary>
            /// Enum SpecializedAmmoHold for value: SpecializedAmmoHold
            /// </summary>
            [EnumMember(Value = "SpecializedAmmoHold")]
            SpecializedAmmoHold = 55,
            
            /// <summary>
            /// Enum SpecializedCommandCenterHold for value: SpecializedCommandCenterHold
            /// </summary>
            [EnumMember(Value = "SpecializedCommandCenterHold")]
            SpecializedCommandCenterHold = 56,
            
            /// <summary>
            /// Enum SpecializedFuelBay for value: SpecializedFuelBay
            /// </summary>
            [EnumMember(Value = "SpecializedFuelBay")]
            SpecializedFuelBay = 57,
            
            /// <summary>
            /// Enum SpecializedGasHold for value: SpecializedGasHold
            /// </summary>
            [EnumMember(Value = "SpecializedGasHold")]
            SpecializedGasHold = 58,
            
            /// <summary>
            /// Enum SpecializedIndustrialShipHold for value: SpecializedIndustrialShipHold
            /// </summary>
            [EnumMember(Value = "SpecializedIndustrialShipHold")]
            SpecializedIndustrialShipHold = 59,
            
            /// <summary>
            /// Enum SpecializedLargeShipHold for value: SpecializedLargeShipHold
            /// </summary>
            [EnumMember(Value = "SpecializedLargeShipHold")]
            SpecializedLargeShipHold = 60,
            
            /// <summary>
            /// Enum SpecializedMaterialBay for value: SpecializedMaterialBay
            /// </summary>
            [EnumMember(Value = "SpecializedMaterialBay")]
            SpecializedMaterialBay = 61,
            
            /// <summary>
            /// Enum SpecializedMediumShipHold for value: SpecializedMediumShipHold
            /// </summary>
            [EnumMember(Value = "SpecializedMediumShipHold")]
            SpecializedMediumShipHold = 62,
            
            /// <summary>
            /// Enum SpecializedMineralHold for value: SpecializedMineralHold
            /// </summary>
            [EnumMember(Value = "SpecializedMineralHold")]
            SpecializedMineralHold = 63,
            
            /// <summary>
            /// Enum SpecializedOreHold for value: SpecializedOreHold
            /// </summary>
            [EnumMember(Value = "SpecializedOreHold")]
            SpecializedOreHold = 64,
            
            /// <summary>
            /// Enum SpecializedPlanetaryCommoditiesHold for value: SpecializedPlanetaryCommoditiesHold
            /// </summary>
            [EnumMember(Value = "SpecializedPlanetaryCommoditiesHold")]
            SpecializedPlanetaryCommoditiesHold = 65,
            
            /// <summary>
            /// Enum SpecializedSalvageHold for value: SpecializedSalvageHold
            /// </summary>
            [EnumMember(Value = "SpecializedSalvageHold")]
            SpecializedSalvageHold = 66,
            
            /// <summary>
            /// Enum SpecializedShipHold for value: SpecializedShipHold
            /// </summary>
            [EnumMember(Value = "SpecializedShipHold")]
            SpecializedShipHold = 67,
            
            /// <summary>
            /// Enum SpecializedSmallShipHold for value: SpecializedSmallShipHold
            /// </summary>
            [EnumMember(Value = "SpecializedSmallShipHold")]
            SpecializedSmallShipHold = 68,
            
            /// <summary>
            /// Enum SubSystemBay for value: SubSystemBay
            /// </summary>
            [EnumMember(Value = "SubSystemBay")]
            SubSystemBay = 69,
            
            /// <summary>
            /// Enum SubSystemSlot0 for value: SubSystemSlot0
            /// </summary>
            [EnumMember(Value = "SubSystemSlot0")]
            SubSystemSlot0 = 70,
            
            /// <summary>
            /// Enum SubSystemSlot1 for value: SubSystemSlot1
            /// </summary>
            [EnumMember(Value = "SubSystemSlot1")]
            SubSystemSlot1 = 71,
            
            /// <summary>
            /// Enum SubSystemSlot2 for value: SubSystemSlot2
            /// </summary>
            [EnumMember(Value = "SubSystemSlot2")]
            SubSystemSlot2 = 72,
            
            /// <summary>
            /// Enum SubSystemSlot3 for value: SubSystemSlot3
            /// </summary>
            [EnumMember(Value = "SubSystemSlot3")]
            SubSystemSlot3 = 73,
            
            /// <summary>
            /// Enum SubSystemSlot4 for value: SubSystemSlot4
            /// </summary>
            [EnumMember(Value = "SubSystemSlot4")]
            SubSystemSlot4 = 74,
            
            /// <summary>
            /// Enum SubSystemSlot5 for value: SubSystemSlot5
            /// </summary>
            [EnumMember(Value = "SubSystemSlot5")]
            SubSystemSlot5 = 75,
            
            /// <summary>
            /// Enum SubSystemSlot6 for value: SubSystemSlot6
            /// </summary>
            [EnumMember(Value = "SubSystemSlot6")]
            SubSystemSlot6 = 76,
            
            /// <summary>
            /// Enum SubSystemSlot7 for value: SubSystemSlot7
            /// </summary>
            [EnumMember(Value = "SubSystemSlot7")]
            SubSystemSlot7 = 77,
            
            /// <summary>
            /// Enum Unlocked for value: Unlocked
            /// </summary>
            [EnumMember(Value = "Unlocked")]
            Unlocked = 78,
            
            /// <summary>
            /// Enum Wardrobe for value: Wardrobe
            /// </summary>
            [EnumMember(Value = "Wardrobe")]
            Wardrobe = 79
        }

        /// <summary>
        /// location_flag string
        /// </summary>
        /// <value>location_flag string</value>
        [DataMember(Name="location_flag", EmitDefaultValue=false)]
        public LocationFlagEnum LocationFlag { get; set; }
        /// <summary>
        /// location_type string
        /// </summary>
        /// <value>location_type string</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LocationTypeEnum
        {
            
            /// <summary>
            /// Enum Station for value: station
            /// </summary>
            [EnumMember(Value = "station")]
            Station = 1,
            
            /// <summary>
            /// Enum Solarsystem for value: solar_system
            /// </summary>
            [EnumMember(Value = "solar_system")]
            Solarsystem = 2,
            
            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 3
        }

        /// <summary>
        /// location_type string
        /// </summary>
        /// <value>location_type string</value>
        [DataMember(Name="location_type", EmitDefaultValue=false)]
        public LocationTypeEnum LocationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdAssets200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdAssets200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdAssets200Ok" /> class.
        /// </summary>
        /// <param name="isBlueprintCopy">is_blueprint_copy boolean.</param>
        /// <param name="isSingleton">is_singleton boolean (required).</param>
        /// <param name="itemId">item_id integer (required).</param>
        /// <param name="locationFlag">location_flag string (required).</param>
        /// <param name="locationId">location_id integer (required).</param>
        /// <param name="locationType">location_type string (required).</param>
        /// <param name="quantity">quantity integer (required).</param>
        /// <param name="typeId">type_id integer (required).</param>
        public GetCharactersCharacterIdAssets200Ok(bool? isBlueprintCopy = default(bool?), bool? isSingleton = default(bool?), long? itemId = default(long?), LocationFlagEnum locationFlag = default(LocationFlagEnum), long? locationId = default(long?), LocationTypeEnum locationType = default(LocationTypeEnum), int? quantity = default(int?), int? typeId = default(int?))
        {
            // to ensure "isSingleton" is required (not null)
            if (isSingleton == null)
            {
                throw new InvalidDataException("isSingleton is a required property for GetCharactersCharacterIdAssets200Ok and cannot be null");
            }
            else
            {
                this.IsSingleton = isSingleton;
            }
            // to ensure "itemId" is required (not null)
            if (itemId == null)
            {
                throw new InvalidDataException("itemId is a required property for GetCharactersCharacterIdAssets200Ok and cannot be null");
            }
            else
            {
                this.ItemId = itemId;
            }
            // to ensure "locationFlag" is required (not null)
            if (locationFlag == null)
            {
                throw new InvalidDataException("locationFlag is a required property for GetCharactersCharacterIdAssets200Ok and cannot be null");
            }
            else
            {
                this.LocationFlag = locationFlag;
            }
            // to ensure "locationId" is required (not null)
            if (locationId == null)
            {
                throw new InvalidDataException("locationId is a required property for GetCharactersCharacterIdAssets200Ok and cannot be null");
            }
            else
            {
                this.LocationId = locationId;
            }
            // to ensure "locationType" is required (not null)
            if (locationType == null)
            {
                throw new InvalidDataException("locationType is a required property for GetCharactersCharacterIdAssets200Ok and cannot be null");
            }
            else
            {
                this.LocationType = locationType;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for GetCharactersCharacterIdAssets200Ok and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            // to ensure "typeId" is required (not null)
            if (typeId == null)
            {
                throw new InvalidDataException("typeId is a required property for GetCharactersCharacterIdAssets200Ok and cannot be null");
            }
            else
            {
                this.TypeId = typeId;
            }
            this.IsBlueprintCopy = isBlueprintCopy;
        }
        
        /// <summary>
        /// is_blueprint_copy boolean
        /// </summary>
        /// <value>is_blueprint_copy boolean</value>
        [DataMember(Name="is_blueprint_copy", EmitDefaultValue=false)]
        public bool? IsBlueprintCopy { get; set; }

        /// <summary>
        /// is_singleton boolean
        /// </summary>
        /// <value>is_singleton boolean</value>
        [DataMember(Name="is_singleton", EmitDefaultValue=false)]
        public bool? IsSingleton { get; set; }

        /// <summary>
        /// item_id integer
        /// </summary>
        /// <value>item_id integer</value>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public long? ItemId { get; set; }


        /// <summary>
        /// location_id integer
        /// </summary>
        /// <value>location_id integer</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public long? LocationId { get; set; }


        /// <summary>
        /// quantity integer
        /// </summary>
        /// <value>quantity integer</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        /// <value>type_id integer</value>
        [DataMember(Name="type_id", EmitDefaultValue=false)]
        public int? TypeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdAssets200Ok {\n");
            sb.Append("  IsBlueprintCopy: ").Append(IsBlueprintCopy).Append("\n");
            sb.Append("  IsSingleton: ").Append(IsSingleton).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  LocationFlag: ").Append(LocationFlag).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  LocationType: ").Append(LocationType).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdAssets200Ok);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdAssets200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdAssets200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdAssets200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsBlueprintCopy == input.IsBlueprintCopy ||
                    (this.IsBlueprintCopy != null &&
                    this.IsBlueprintCopy.Equals(input.IsBlueprintCopy))
                ) && 
                (
                    this.IsSingleton == input.IsSingleton ||
                    (this.IsSingleton != null &&
                    this.IsSingleton.Equals(input.IsSingleton))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.LocationFlag == input.LocationFlag ||
                    (this.LocationFlag != null &&
                    this.LocationFlag.Equals(input.LocationFlag))
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.LocationType == input.LocationType ||
                    (this.LocationType != null &&
                    this.LocationType.Equals(input.LocationType))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
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
                if (this.IsBlueprintCopy != null)
                    hashCode = hashCode * 59 + this.IsBlueprintCopy.GetHashCode();
                if (this.IsSingleton != null)
                    hashCode = hashCode * 59 + this.IsSingleton.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.LocationFlag != null)
                    hashCode = hashCode * 59 + this.LocationFlag.GetHashCode();
                if (this.LocationId != null)
                    hashCode = hashCode * 59 + this.LocationId.GetHashCode();
                if (this.LocationType != null)
                    hashCode = hashCode * 59 + this.LocationType.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.TypeId != null)
                    hashCode = hashCode * 59 + this.TypeId.GetHashCode();
                return hashCode;
            }
        }
    }

}
