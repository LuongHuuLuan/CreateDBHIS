namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_EMTE_MEDICINE_TYPE")]
    public partial class V_HIS_EMTE_MEDICINE_TYPE
    {
        [Key]
        [Column(Order = 0)]
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

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EXP_MEST_TEMPLATE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        public long? MEDICINE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        public long? SERVICE_UNIT_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal AMOUNT { get; set; }

        [StringLength(2000)]
        public string TUTORIAL { get; set; }

        public short? IS_EXPEND { get; set; }

        public short? IS_OUT_MEDI_STOCK { get; set; }

        public long? HTU_ID { get; set; }

        public long? DAY_COUNT { get; set; }

        [StringLength(10)]
        public string MORNING { get; set; }

        [StringLength(10)]
        public string NOON { get; set; }

        [StringLength(10)]
        public string AFTERNOON { get; set; }

        [StringLength(10)]
        public string EVENING { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string EXP_MEST_TEMPLATE_CODE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string EXP_MEST_TEMPLATE_NAME { get; set; }

        public long? REMEDY_COUNT { get; set; }

        public short? PRESCRIPTION_TYPE_ID { get; set; }

        [StringLength(25)]
        public string MEDICINE_TYPE_CODE { get; set; }

        public long? SERVICE_ID { get; set; }

        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        public decimal? CONVERT_RATIO { get; set; }

        [StringLength(3)]
        public string CONVERT_UNIT_CODE { get; set; }

        [StringLength(100)]
        public string CONVERT_UNIT_NAME { get; set; }
    }
}
