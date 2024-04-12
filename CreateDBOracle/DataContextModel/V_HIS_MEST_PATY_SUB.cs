namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEST_PATY_SUB")]
    public partial class V_HIS_MEST_PATY_SUB
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
        public long MEDI_STOCK_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PATIENT_TYPE_SUB_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string MEDI_STOCK_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string MEDI_STOCK_NAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string PATIENT_TYPE_SUB_CODE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string PATIENT_TYPE_SUB_NAME { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PATIENT_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(6)]
        public string PATIENT_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string PATIENT_TYPE_NAME { get; set; }
    }
}
