namespace ElasticSearch.API.Models
{
    public class ProductTree
    {
        public string CustomizationTablesMaxColors { get; set; }
        public string ProdReference { get; set; }
        public string Name { get; set; }
        public string SEOName { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string SEOShortDescription { get; set; }
        public string SEOShortDescriptionCap { get; set; }
        public bool IsTextil { get; set; }
        public bool HasColors { get; set; }
        public bool HasSizes { get; set; }
        public bool HasCapacitys { get; set; }
        public string CombinedSizes { get; set; }
        public string? Gender { get; set; }
        public bool DefaultCustomizationIncludedInPrice { get; set; }
        public bool AvailableGross { get; set; }
        public int BoxLengthMM { get; set; }
        public int BoxWidthMM { get; set; }
        public int BoxHeightMM { get; set; }
        public string BoxSizeM { get; set; }
        public double BoxWeightKG { get; set; }
        public double BoxVolume { get; set; }
        public int BoxQuantity { get; set; }
        public int BoxInnerQuantity { get; set; }
        public int Multiplier { get; set; }
        public string Taric { get; set; }
        public string Type { get; set; }
        public string TypeCode { get; set; }
        public string SubType { get; set; }
        public string SubTypeCode { get; set; }
        public string MainImage { get; set; }
        public string? BoxImage { get; set; }
        public string? BagImage { get; set; }
        public string? PouchImage { get; set; }
        public string? AditionalImageList { get; set; }
        public string AllImageList { get; set; }
        public string Brand { get; set; }
        public string CountryOfOrigin { get; set; }
        public bool PvcFree { get; set; }
        public string Properties { get; set; }
        public string? ProductCare { get; set; }
        public string? Certificates { get; set; }
        public string? WeightGr { get; set; }
        public string? Composition { get; set; }
        public string? Packing { get; set; }
        public int Weight { get; set; }
        public string? Repacking { get; set; }
        public string? RefillType { get; set; }
        public string? BatteryType { get; set; }
        public string Materials { get; set; }
        public string? PaperSize { get; set; }
        public string? PaperGramage { get; set; }
        public string CapacityMah { get; set; }
        public string? CapacityGB { get; set; }
        public string? InkColor { get; set; }
        public string? OtherDetails { get; set; }
        public string KeyWords { get; set; }
        public string? RelatedReferences { get; set; }
        public string Video360 { get; set; }
        public string? VideoLink { get; set; }
        public string? VideoLinkVimeo { get; set; }
        public string? Sizes { get; set; }
        public string Capacitys { get; set; }
        public string Colors { get; set; }
        public string ProductComponents { get; set; }
        public string ProductDefaultComponent { get; set; }
        public string ProductComponentLocations { get; set; }
        public string ProductComponentDefaultLocation { get; set; }
        public string ProductComponentDefaultLocationAreaMM { get; set; }
        public string ProductComposedLocations { get; set; }
        public string CustomizationTypes { get; set; }
        public string CustomizationDefaultType { get; set; }
        public string CustomizationTables { get; set; }
        public string CustomizationDefaultTable { get; set; }
        public string CustomizationTableOptions { get; set; }
        public string CustomizationTableOptionsMaxColors { get; set; }
        public string CustomizationTableOptionsHandlingCosts { get; set; }
        public string CustomizationTableOptionsHandlingCostCodes { get; set; }
        public string CustomizationDefault { get; set; }
        public int CustomizationDefaultTableMaxColors { get; set; }
        public int CustomizationDefaultHandlingCosts { get; set; }
        public string? CustomizationDefaultHandlingCostCode { get; set; }
        public string CustomizationDefaultPrintingLines { get; set; }
        public bool IsSeasonal { get; set; }
        public string? SeasonalOccasion { get; set; }
        public string? SeasonalStartDate { get; set; }
        public string? SeasonalEndDate { get; set; }
        public string? PriceByCapacity { get; set; }
        public bool IsStockOut { get; set; }
        public bool OnlineExclusive { get; set; }
        public bool NewProduct { get; set; }
        public string? YourPrice { get; set; }
        public List<ScalePrice> ScalePrices { get; set; }
        public List<ProductOptional> ProductOptionals { get; set; }
        public List<Component> Components { get; set; }
        public string? CertificateFiles { get; set; }
        public string Catalogs { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool NoReplenishment { get; set; }
    }

    public class ScalePrice
    {
        public int MinQt { get; set; }
        public double Price { get; set; }
        public string? Sla { get; set; }
    }

    public class ProductOptional
    {
        public string Sku { get; set; }
        public string ColorDesc1 { get; set; }
        public string ColorHex1 { get; set; }
        public string ColorCode { get; set; }
        public string OptionalImage1 { get; set; }
        public string OptionalImage2 { get; set; }
        public string WebSku { get; set; }
        public string? SizeLengthCM { get; set; }
        public string? SizeWidthCM { get; set; }
        public bool LastSale { get; set; }
    }

    public class Component
    {
        public string Name { get; set; }
        public bool Default { get; set; }
        public List<ComponentImage> ComponentImages { get; set; }
        public List<Location> Locations { get; set; }
        public int ComponentID { get; set; }
    }

    public class ComponentImage
    {
        public string MainImage { get; set; }
        public string ColorCode { get; set; }
    }

    public class Location
    {
        public string Name { get; set; }
        public bool Default { get; set; }
        public List<LocationImage> LocationImages { get; set; }
        public List<CustomizationArea> CustomizationAreas { get; set; }
        public int LocationID { get; set; }
    }

    public class LocationImage
    {
        public string MainImage { get; set; }
        public string ColorCode { get; set; }
    }

    public class CustomizationArea
    {
        public string AreaName { get; set; }
        public int WidthMM { get; set; }
        public int HeightMM { get; set; }
        public bool Default { get; set; }
        public List<ProductCustomizationTable> ProductCustomizationTables { get; set; }
    }

    public class ProductCustomizationTable
    {
        public string CustomizationTypeName { get; set; }
        public string TableCode { get; set; }
        public bool PriceByColor { get; set; }
        public int HandlingCost { get; set; }
        public string? HandlingCostCode { get; set; }
        public int MaxColors { get; set; }
        public string MainImage { get; set; }
        public bool AllowFullColor { get; set; }
        public bool Default { get; set; }
        public List<ProductCustomizationTableOption> ProductCustomizationTableOptions { get; set; }
        public int ComponentType { get; set; }
        public int LocationType { get; set; }
    }

    public class ProductCustomizationTableOption
    {
        public string TableCodeOption { get; set; }
        public int Colors { get; set; }
        public string AreaCM { get; set; }
        public string AreaCM2 { get; set; }
        public bool Default { get; set; }
        public string ServiceCode { get; set; }
        public List<ScalePrice> ScalePrices { get; set; }
    }
}
