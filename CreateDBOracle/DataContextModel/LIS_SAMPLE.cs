namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.LIS_SAMPLE")]
    public partial class LIS_SAMPLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LIS_SAMPLE()
        {
            LIS_SAMPLE_SERVICE = new HashSet<LIS_SAMPLE_SERVICE>();
        }

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

        [StringLength(10)]
        public string SAMPLE_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string SAMPLE_ROOM_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string EXECUTE_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string EXECUTE_ROOM_NAME { get; set; }

        [StringLength(15)]
        public string BARCODE { get; set; }

        [StringLength(12)]
        public string SERVICE_REQ_CODE { get; set; }

        [StringLength(30)]
        public string FIRST_NAME { get; set; }

        [StringLength(70)]
        public string LAST_NAME { get; set; }

        [StringLength(10)]
        public string PATIENT_CODE { get; set; }

        public long SAMPLE_STT_ID { get; set; }

        [StringLength(2)]
        public string GENDER_CODE { get; set; }

        public long? DOB { get; set; }

        public long? RESULT_TIME { get; set; }

        public long? BARCODE_TIME { get; set; }

        [StringLength(47)]
        public string VIR_DATE_BARCODE { get; set; }

        [StringLength(10)]
        public string REQUEST_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string REQUEST_ROOM_NAME { get; set; }

        public short? IS_NOT_USE_BARCODE { get; set; }

        public long? NUM_ORDER { get; set; }

        public long? SAMPLE_TIME { get; set; }

        public long? APPOINTMENT_TIME { get; set; }

        public long? INTRUCTION_TIME { get; set; }

        [StringLength(50)]
        public string SAMPLE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string SAMPLE_USERNAME { get; set; }

        public long? APPROVAL_TIME { get; set; }

        [StringLength(50)]
        public string APPROVAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string APPROVAL_USERNAME { get; set; }

        [StringLength(12)]
        public string TREATMENT_CODE { get; set; }

        [StringLength(10)]
        public string REQUEST_DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string REQUEST_DEPARTMENT_NAME { get; set; }

        [StringLength(100)]
        public string REJECT_REASON { get; set; }

        public long? SAMPLE_TYPE_ID { get; set; }

        public long? SAMPLE_CONDITION_ID { get; set; }

        [StringLength(50)]
        public string REQUEST_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQUEST_USERNAME { get; set; }

        public long? SAMPLE_ORDER { get; set; }

        public short? IS_SAMPLE_ORDER_REQUEST { get; set; }

        public long? CALL_SAMPLE_ORDER { get; set; }

        [StringLength(500)]
        public string ADDRESS { get; set; }

        public short? IS_ANTIBIOTIC_RESISTANCE { get; set; }

        [StringLength(20)]
        public string KSK_CONTRACT_CODE { get; set; }

        public virtual LIS_SAMPLE_STT LIS_SAMPLE_STT { get; set; }

        public virtual LIS_SAMPLE_TYPE LIS_SAMPLE_TYPE { get; set; }

        public virtual LIS_SAMPLE_CONDITION LIS_SAMPLE_CONDITION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIS_SAMPLE_SERVICE> LIS_SAMPLE_SERVICE { get; set; }
    }
}
