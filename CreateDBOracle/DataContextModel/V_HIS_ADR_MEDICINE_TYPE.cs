namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_ADR_MEDICINE_TYPE")]
    public partial class V_HIS_ADR_MEDICINE_TYPE
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
        public long MEDICINE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ADR_ID { get; set; }

        public short? IS_ADR { get; set; }

        public long? START_TIME { get; set; }

        public long? FINISH_TIME { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public decimal? ONCE_TUTORIAL { get; set; }

        [StringLength(100)]
        public string NUMBER_USE { get; set; }

        [StringLength(500)]
        public string REASON { get; set; }

        public long? IMPROVE_TYPE_ID { get; set; }

        public long? REAPPEAR_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string ADR_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ADR_TIME { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(25)]
        public string MEDICINE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_SERVICE_UNIT_ID { get; set; }

        public long? MEDICINE_USE_FORM_ID { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Key]
        [Column(Order = 9)]
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
    }
}
