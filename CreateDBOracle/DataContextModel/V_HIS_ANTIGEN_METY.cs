namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_ANTIGEN_METY")]
    public partial class V_HIS_ANTIGEN_METY
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
        public long ANTIGEN_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MEDICINE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string ANTIGEN_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string ANTIGEN_NAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(25)]
        public string MEDICINE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        public short? IS_LEAF { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        [StringLength(500)]
        public string ACTIVE_INGR_BHYT_CODE { get; set; }

        [StringLength(1000)]
        public string ACTIVE_INGR_BHYT_NAME { get; set; }

        [StringLength(500)]
        public string REGISTER_NUMBER { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TDL_SERVICE_UNIT_ID { get; set; }

        [StringLength(1000)]
        public string NATIONAL_NAME { get; set; }

        [StringLength(2000)]
        public string TUTORIAL { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        [StringLength(200)]
        public string MEDICINE_TYPE_PROPRIETARY_NAME { get; set; }

        [StringLength(300)]
        public string PACKING_TYPE_NAME { get; set; }

        public short? IS_VITAMIN_A { get; set; }

        public short? IS_VACCINE { get; set; }

        public short? IS_TCMR { get; set; }
    }
}
