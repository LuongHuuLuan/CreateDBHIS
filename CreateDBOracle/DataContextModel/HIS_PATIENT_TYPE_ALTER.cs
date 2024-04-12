namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_PATIENT_TYPE_ALTER")]
    public partial class HIS_PATIENT_TYPE_ALTER
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

        public long DEPARTMENT_TRAN_ID { get; set; }

        public long TREATMENT_TYPE_ID { get; set; }

        public long PATIENT_TYPE_ID { get; set; }

        public long LOG_TIME { get; set; }

        public long TREATMENT_ID { get; set; }

        public long TDL_PATIENT_ID { get; set; }

        public long? EXECUTE_ROOM_ID { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        [StringLength(2)]
        public string LEVEL_CODE { get; set; }

        [StringLength(2)]
        public string RIGHT_ROUTE_CODE { get; set; }

        [StringLength(2)]
        public string RIGHT_ROUTE_TYPE_CODE { get; set; }

        [StringLength(2)]
        public string LIVE_AREA_CODE { get; set; }

        [StringLength(6)]
        public string HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(500)]
        public string HEIN_MEDI_ORG_NAME { get; set; }

        [StringLength(2)]
        public string HAS_BIRTH_CERTIFICATE { get; set; }

        [StringLength(15)]
        public string HEIN_CARD_NUMBER { get; set; }

        public long? HEIN_CARD_FROM_TIME { get; set; }

        public long? HEIN_CARD_TO_TIME { get; set; }

        [StringLength(500)]
        public string ADDRESS { get; set; }

        [StringLength(20)]
        public string HNCODE { get; set; }

        [StringLength(2)]
        public string JOIN_5_YEAR { get; set; }

        [StringLength(2)]
        public string PAID_6_MONTH { get; set; }

        public short? IS_NO_CHECK_EXPIRE { get; set; }

        public long? FREE_CO_PAID_TIME { get; set; }

        public short? IS_TEMP_QN { get; set; }

        [StringLength(500)]
        public string BHYT_URL { get; set; }

        public long? KSK_CONTRACT_ID { get; set; }

        public long? JOIN_5_YEAR_TIME { get; set; }

        public long? PRIMARY_PATIENT_TYPE_ID { get; set; }

        public long? HEIN_CARD_TO_TIME_TMP { get; set; }

        public short? HAS_WORKING_LETTER { get; set; }

        public short? HAS_ABSENT_LETTER { get; set; }

        public short? IS_TT46 { get; set; }

        [StringLength(500)]
        public string TT46_NOTE { get; set; }

        [StringLength(50)]
        public string GUARANTEE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string GUARANTEE_USERNAME { get; set; }

        [StringLength(500)]
        public string GUARANTEE_REASON { get; set; }

        public virtual HIS_DEPARTMENT_TRAN HIS_DEPARTMENT_TRAN { get; set; }

        public virtual HIS_KSK_CONTRACT HIS_KSK_CONTRACT { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE1 { get; set; }

        public virtual HIS_TREATMENT_TYPE HIS_TREATMENT_TYPE { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }
    }
}
