namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.L_HIS_TREATMENT_1")]
    public partial class L_HIS_TREATMENT_1
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public short? IS_ACTIVE { get; set; }

        public short? IS_DELETE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string TREATMENT_CODE { get; set; }

        public short? IS_PAUSE { get; set; }

        public long? CLINICAL_IN_TIME { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string TDL_PATIENT_FIRST_NAME { get; set; }

        [StringLength(70)]
        public string TDL_PATIENT_LAST_NAME { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_PATIENT_DOB { get; set; }

        [StringLength(20)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        [StringLength(6)]
        public string TDL_HEIN_MEDI_ORG_CODE { get; set; }

        public long? TDL_TREATMENT_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IN_TIME { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IN_DATE { get; set; }

        public long? LAST_DEPARTMENT_ID { get; set; }

        public long? BED_ROOM_ID { get; set; }

        public long? BED_ID { get; set; }

        [StringLength(20)]
        public string BED_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string BED_ROOM_NAME { get; set; }

        [StringLength(10)]
        public string BED_CODE { get; set; }

        [StringLength(200)]
        public string BED_NAME { get; set; }

        public decimal? TOTAL_BILL_AMOUNT { get; set; }

        public decimal? TOTAL_BILL_OTHER_AMOUNT { get; set; }

        public decimal? TOTAL_BILL_TRANSFER_AMOUNT { get; set; }

        public decimal? TOTAL_BILL_EXEMPTION { get; set; }

        public decimal? TOTAL_BILL_FUND { get; set; }

        public decimal? TOTAL_DEPOSIT_AMOUNT { get; set; }

        public decimal? TOTAL_REPAY_AMOUNT { get; set; }

        public decimal? TOTAL_PRICE { get; set; }

        public decimal? TOTAL_HEIN_PRICE { get; set; }

        public decimal? TOTAL_PATIENT_PRICE { get; set; }

        public decimal? TOTAL_DISCOUNT { get; set; }

        public decimal? REMAIN_AMOUNT { get; set; }
    }
}
