namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEDI_CONTRACT_METY_1")]
    public partial class V_HIS_MEDI_CONTRACT_METY_1
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

        public long MEDICINE_TYPE_ID { get; set; }

        public long? BID_MEDICINE_TYPE_ID { get; set; }

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

        [StringLength(500)]
        public string MEDICINE_REGISTER_NUMBER { get; set; }

        public long? YEAR_LIFESPAN { get; set; }

        public long? MONTH_LIFESPAN { get; set; }

        public long? DAY_LIFESPAN { get; set; }

        public decimal? CONTRACT_PRICE { get; set; }

        public long? IMP_EXPIRED_DATE { get; set; }

        public long? HOUR_LIFESPAN { get; set; }

        [StringLength(1000)]
        public string ACTIVE_INGR_BHYT_NAME { get; set; }

        public long? MEDICINE_USE_FORM_ID { get; set; }

        [StringLength(100)]
        public string DOSAGE_FORM { get; set; }

        public decimal? VIR_CONTRACT_PRICE { get; set; }

        public decimal? VIR_BID_MEDICINE_TYPE_ID { get; set; }

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

        [StringLength(50)]
        public string BID_NUM_ORDER { get; set; }

        [StringLength(4)]
        public string BID_PACKAGE_CODE { get; set; }
    }
}
