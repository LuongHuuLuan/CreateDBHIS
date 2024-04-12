namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEDI_CONTRACT_MATY")]
    public partial class V_HIS_MEDI_CONTRACT_MATY
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long? CREATE_TIME { get; set; }

        public long? MODIFY_TIME { get; set; }

        [StringLength(50)]
        public string CREATOR { get; set; }

        [StringLength(50)]
        public string MODIFIER { get; set; }

        [StringLength(50)]
        public string APP_CREATOR { get; set; }

        [StringLength(50)]
        public string APP_MODIFIER { get; set; }

        public short? IS_ACTIVE { get; set; }

        public short? IS_DELETE { get; set; }

        [StringLength(50)]
        public string GROUP_CODE { get; set; }

        public long MEDICAL_CONTRACT_ID { get; set; }

        public long MATERIAL_TYPE_ID { get; set; }

        public long? BID_MATERIAL_TYPE_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal? IMP_PRICE { get; set; }

        public decimal? IMP_VAT_RATIO { get; set; }

        public decimal? INTERNAL_PRICE { get; set; }

        public long? EXPIRED_DATE { get; set; }

        [StringLength(1000)]
        public string NATIONAL_NAME { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        public long? YEAR_LIFESPAN { get; set; }

        public long? MONTH_LIFESPAN { get; set; }

        public long? DAY_LIFESPAN { get; set; }

        public decimal? CONTRACT_PRICE { get; set; }

        public long? IMP_EXPIRED_DATE { get; set; }

        public long? HOUR_LIFESPAN { get; set; }

        public decimal? VIR_CONTRACT_PRICE { get; set; }

        public decimal? VIR_BID_MATERIAL_TYPE_ID { get; set; }

        [StringLength(30)]
        public string BID_NUMBER { get; set; }

        [StringLength(2)]
        public string BID_GROUP_CODE { get; set; }

        [StringLength(4000)]
        public string NOTE { get; set; }

        [StringLength(30)]
        public string VIR_BID_NUMBER { get; set; }

        [StringLength(18)]
        public string VIR_BID_GROUP_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string MEDICAL_CONTRACT_CODE { get; set; }

        public long SUPPLIER_ID { get; set; }

        public long? BID_ID { get; set; }

        [Required]
        [StringLength(25)]
        public string MATERIAL_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string MATERIAL_TYPE_NAME { get; set; }

        public long SERVICE_ID { get; set; }

        public long TDL_SERVICE_UNIT_ID { get; set; }

        [StringLength(50)]
        public string BID_NUM_ORDER { get; set; }

        [StringLength(4)]
        public string BID_PACKAGE_CODE { get; set; }

        [StringLength(6)]
        public string MANUFACTURER_CODE { get; set; }

        [StringLength(1000)]
        public string MANUFACTURER_NAME { get; set; }

        public decimal? IN_AMOUNT { get; set; }
    }
}
