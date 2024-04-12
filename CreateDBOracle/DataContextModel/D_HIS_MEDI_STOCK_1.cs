namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.D_HIS_MEDI_STOCK_1")]
    public partial class D_HIS_MEDI_STOCK_1
    {
        public long? ID { get; set; }

        public short? IS_ACTIVE { get; set; }

        [StringLength(25)]
        public string MEDICINE_TYPE_CODE { get; set; }

        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        public long? SERVICE_ID { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        public decimal? ALERT_MIN_IN_STOCK { get; set; }

        public decimal? MEDICINE_USE_FORM_ID { get; set; }

        [StringLength(2000)]
        public string TUTORIAL { get; set; }

        [StringLength(1000)]
        public string NATIONAL_NAME { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        public decimal? USE_ON_DAY { get; set; }

        public decimal? IS_STAR_MARK { get; set; }

        [StringLength(500)]
        public string ACTIVE_INGR_BHYT_CODE { get; set; }

        [StringLength(1000)]
        public string ACTIVE_INGR_BHYT_NAME { get; set; }

        public decimal? ALERT_MAX_IN_TREATMENT { get; set; }

        public decimal? IS_STENT { get; set; }

        public decimal? ALERT_MAX_IN_PRESCRIPTION { get; set; }

        public decimal? IS_VACCINE { get; set; }

        public decimal? RANK { get; set; }

        public decimal? IMP_PRICE { get; set; }

        public decimal? IMP_VAT_RATIO { get; set; }

        public decimal? IS_REUSABLE { get; set; }

        public decimal? LAST_EXP_PRICE { get; set; }

        public decimal? LAST_EXP_VAT_RATIO { get; set; }

        [StringLength(4000)]
        public string CONTRAINDICATION { get; set; }

        public decimal? MATERIAL_TYPE_MAP_ID { get; set; }

        public long? PARENT_ID { get; set; }

        [StringLength(6)]
        public string MANUFACTURER_CODE { get; set; }

        [StringLength(1000)]
        public string MANUFACTURER_NAME { get; set; }

        [StringLength(20)]
        public string MEDI_STOCK_CODE { get; set; }

        [StringLength(100)]
        public string MEDI_STOCK_NAME { get; set; }

        public decimal? AMOUNT { get; set; }

        public long? MEDI_STOCK_ID { get; set; }

        public decimal? SERVICE_TYPE_ID { get; set; }

        public decimal? IS_CHEMICAL_SUBSTANCE { get; set; }

        public short? IS_AUTO_EXPEND { get; set; }

        [StringLength(25)]
        public string PARENT_CODE { get; set; }

        [StringLength(500)]
        public string PARENT_NAME { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_UNIT_ID { get; set; }

        public long? HEIN_SERVICE_TYPE_ID { get; set; }

        public short? IS_OUT_PARENT_FEE { get; set; }

        public long? GENDER_ID { get; set; }

        public long? OTHER_PAY_SOURCE_ID { get; set; }

        [StringLength(200)]
        public string OTHER_PAY_SOURCE_ICDS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        public decimal? CONVERT_RATIO { get; set; }

        [StringLength(3)]
        public string CONVERT_UNIT_CODE { get; set; }

        [StringLength(100)]
        public string CONVERT_UNIT_NAME { get; set; }
    }
}
