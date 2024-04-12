namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_KSK_DRIVER")]
    public partial class HIS_KSK_DRIVER
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

        [Required]
        [StringLength(30)]
        public string KSK_DRIVER_CODE { get; set; }

        public long SERVICE_REQ_ID { get; set; }

        public long TDL_TREATMENT_ID { get; set; }

        public long TDL_PATIENT_ID { get; set; }

        public long CONCLUSION_TIME { get; set; }

        [Required]
        [StringLength(20)]
        public string CONCLUSION { get; set; }

        [Required]
        [StringLength(20)]
        public string LICENSE_CLASS { get; set; }

        [StringLength(50)]
        public string CONCLUDER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string CONCLUDER_USERNAME { get; set; }

        [StringLength(250)]
        public string REASON_BAD_HEATHLY { get; set; }

        [StringLength(250)]
        public string SICK_CONDITION { get; set; }

        public decimal? CONCENTRATION { get; set; }

        public long? CONCENTRATION_TYPE { get; set; }

        public long? DRUG_TYPE { get; set; }

        public long TDL_BRANCH_ID { get; set; }

        public long SYNC_RESULT_TYPE { get; set; }

        [StringLength(4000)]
        public string SYNC_FAILD_REASON { get; set; }

        public long? SYNC_TIME { get; set; }

        public decimal? VIR_CONCLUSION_DATE { get; set; }

        [Required]
        [StringLength(5)]
        public string TDL_MEDI_ORG_CODE { get; set; }

        public long? APPOINTMENT_TIME { get; set; }

        public virtual HIS_SERVICE_REQ HIS_SERVICE_REQ { get; set; }
    }
}
