namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_PATIENT_PROGRAM")]
    public partial class V_HIS_PATIENT_PROGRAM
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
        public long PATIENT_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PROGRAM_ID { get; set; }

        [StringLength(12)]
        public string PATIENT_PROGRAM_CODE { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string PATIENT_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string FIRST_NAME { get; set; }

        [StringLength(70)]
        public string LAST_NAME { get; set; }

        [StringLength(101)]
        public string VIR_PATIENT_NAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long DOB { get; set; }

        [StringLength(506)]
        public string VIR_ADDRESS { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long GENDER_ID { get; set; }

        [StringLength(100)]
        public string NATIONAL_NAME { get; set; }

        [StringLength(100)]
        public string ETHNIC_NAME { get; set; }

        [StringLength(100)]
        public string RELIGION_NAME { get; set; }

        [StringLength(100)]
        public string PROVINCE_NAME { get; set; }

        [StringLength(100)]
        public string DISTRICT_NAME { get; set; }

        [StringLength(100)]
        public string COMMUNE_NAME { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        [StringLength(12)]
        public string PHONE { get; set; }

        [StringLength(500)]
        public string WORK_PLACE { get; set; }

        [StringLength(20)]
        public string PATIENT_STORE_CODE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(2)]
        public string GENDER_CODE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(100)]
        public string GENDER_NAME { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(6)]
        public string PROGRAM_CODE { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string PROGRAM_NAME { get; set; }

        public long? DATA_STORE_ID { get; set; }
    }
}
