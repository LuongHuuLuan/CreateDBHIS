namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEDI_RECORD_BORROW")]
    public partial class V_HIS_MEDI_RECORD_BORROW
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
        public long MEDI_RECORD_ID { get; set; }

        [StringLength(50)]
        public string BORROW_LOGINNAME { get; set; }

        [StringLength(100)]
        public string BORROW_USERNAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long DEPARTMENT_ID { get; set; }

        public long? GIVE_TIME { get; set; }

        public long? GIVE_DATE { get; set; }

        [StringLength(50)]
        public string GIVER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string GIVER_USERNAME { get; set; }

        public long? RECEIVE_TIME { get; set; }

        public long? RECEIVE_DATE { get; set; }

        [StringLength(50)]
        public string RECEIVER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string RECEIVER_USERNAME { get; set; }

        public long? APPOINTMENT_TIME { get; set; }

        public long? APPOINTMENT_DATE { get; set; }

        public decimal? VIR_GIVE_MONTH { get; set; }

        public decimal? VIR_RECEIVE_MONTH { get; set; }

        public decimal? VIR_APPOINTMENT_MONTH { get; set; }

        [StringLength(20)]
        public string BORROW_PHONE { get; set; }

        [StringLength(20)]
        public string STORE_CODE { get; set; }

        public long? DATA_STORE_ID { get; set; }

        public long? STORE_TIME { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PATIENT_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string PATIENT_CODE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string FIRST_NAME { get; set; }

        [StringLength(70)]
        public string LAST_NAME { get; set; }

        [StringLength(101)]
        public string VIR_PATIENT_NAME { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long DOB { get; set; }

        public short? IS_HAS_NOT_DAY_DOB { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [StringLength(10)]
        public string DATA_STORE_CODE { get; set; }

        [StringLength(100)]
        public string DATA_STORE_NAME { get; set; }

        [StringLength(4000)]
        public string TREATMENT_CODE { get; set; }
    }
}
