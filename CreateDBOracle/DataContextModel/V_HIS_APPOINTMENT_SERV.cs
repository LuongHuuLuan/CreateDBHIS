namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_APPOINTMENT_SERV")]
    public partial class V_HIS_APPOINTMENT_SERV
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

        public long TREATMENT_ID { get; set; }

        public long SERVICE_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public long? TDL_PATIENT_ID { get; set; }

        public long? TDL_APPOINTMENT_TIME { get; set; }

        public long? PATIENT_TYPE_ID { get; set; }

        [Required]
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        public long SERVICE_TYPE_ID { get; set; }

        [Required]
        [StringLength(2)]
        public string SERVICE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }
    }
}
