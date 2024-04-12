namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_ANTICIPATE_METY")]
    public partial class V_HIS_ANTICIPATE_METY
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

        public long ANTICIPATE_ID { get; set; }

        public long MEDICINE_TYPE_ID { get; set; }

        public long? SUPPLIER_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal? IMP_PRICE { get; set; }

        public long? BID_ID { get; set; }

        [Required]
        [StringLength(25)]
        public string MEDICINE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        public long SERVICE_ID { get; set; }

        public long? NUM_ORDER { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        [StringLength(200)]
        public string MEDICINE_TYPE_PROPRIETARY_NAME { get; set; }

        public long? MEDICINE_USE_FORM_ID { get; set; }

        [StringLength(1000)]
        public string NATIONAL_NAME { get; set; }

        [StringLength(300)]
        public string PACKING_TYPE_NAME { get; set; }

        public long? MEDICINE_LINE_ID { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        [StringLength(20)]
        public string TCY_NUM_ORDER { get; set; }

        [StringLength(50)]
        public string BYT_NUM_ORDER { get; set; }

        [StringLength(500)]
        public string REGISTER_NUMBER { get; set; }

        public short? IS_STAR_MARK { get; set; }

        [StringLength(500)]
        public string ACTIVE_INGR_BHYT_CODE { get; set; }

        [StringLength(1000)]
        public string ACTIVE_INGR_BHYT_NAME { get; set; }

        public long? MEDICINE_GROUP_ID { get; set; }

        public long SERVICE_UNIT_ID { get; set; }

        [Required]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [StringLength(6)]
        public string MANUFACTURER_CODE { get; set; }

        [StringLength(1000)]
        public string MANUFACTURER_NAME { get; set; }

        [StringLength(6)]
        public string MEDICINE_USE_FORM_CODE { get; set; }

        [StringLength(100)]
        public string MEDICINE_USE_FORM_NAME { get; set; }

        [StringLength(10)]
        public string SUPPLIER_CODE { get; set; }

        [StringLength(1000)]
        public string SUPPLIER_NAME { get; set; }

        [StringLength(500)]
        public string BID_NAME { get; set; }

        [StringLength(30)]
        public string BID_NUMBER { get; set; }

        public long? VALID_FROM_TIME { get; set; }

        [StringLength(50)]
        public string BID_NUM_ORDER { get; set; }

        [StringLength(100)]
        public string HEIN_SERVICE_BHYT_CODE { get; set; }

        [StringLength(500)]
        public string HEIN_SERVICE_BHYT_NAME { get; set; }
    }
}
