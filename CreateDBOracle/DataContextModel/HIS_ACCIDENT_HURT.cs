namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_ACCIDENT_HURT")]
    public partial class HIS_ACCIDENT_HURT
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

        [StringLength(200)]
        public string CONTENT { get; set; }

        public long ACCIDENT_HURT_TYPE_ID { get; set; }

        public long? ACCIDENT_BODY_PART_ID { get; set; }

        public long? ACCIDENT_LOCATION_ID { get; set; }

        public long? ACCIDENT_POISON_ID { get; set; }

        public long? ACCIDENT_VEHICLE_ID { get; set; }

        public long? ACCIDENT_HELMET_ID { get; set; }

        public long? ACCIDENT_RESULT_ID { get; set; }

        public long? ACCIDENT_CARE_ID { get; set; }

        public long? ACCIDENT_TIME { get; set; }

        public short? IS_USE_ALCOHOL { get; set; }

        public long? EXECUTE_ROOM_ID { get; set; }

        public long? EXECUTE_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        [StringLength(2000)]
        public string STATUS_IN { get; set; }

        [StringLength(2000)]
        public string STATUS_OUT { get; set; }

        [StringLength(4000)]
        public string TREATMENT_INFO { get; set; }

        public short? ALCOHOL_TEST_RESULT { get; set; }

        public short? NARCOTICS_TEST_RESULT { get; set; }

        [StringLength(10)]
        public string ISSUE_NUMBER { get; set; }

        [StringLength(50)]
        public string SEEDING_ISSUED_CODE { get; set; }

        [StringLength(61)]
        public string VIR_ISSUE_NUMBER { get; set; }

        [StringLength(10)]
        public string ACCIDENT_HURT_ICD_CODE { get; set; }

        [StringLength(500)]
        public string ACCIDENT_HURT_ICD_NAME { get; set; }

        [StringLength(500)]
        public string ACCIDENT_HURT_ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ACCIDENT_HURT_ICD_TEXT { get; set; }

        public virtual HIS_ACCIDENT_BODY_PART HIS_ACCIDENT_BODY_PART { get; set; }

        public virtual HIS_ACCIDENT_CARE HIS_ACCIDENT_CARE { get; set; }

        public virtual HIS_ACCIDENT_HELMET HIS_ACCIDENT_HELMET { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_ACCIDENT_HURT_TYPE HIS_ACCIDENT_HURT_TYPE { get; set; }

        public virtual HIS_ACCIDENT_LOCATION HIS_ACCIDENT_LOCATION { get; set; }

        public virtual HIS_ACCIDENT_POISON HIS_ACCIDENT_POISON { get; set; }

        public virtual HIS_ACCIDENT_VEHICLE HIS_ACCIDENT_VEHICLE { get; set; }

        public virtual HIS_ACCIDENT_RESULT HIS_ACCIDENT_RESULT { get; set; }
    }
}
