namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERVICE_PATY")]
    public partial class HIS_SERVICE_PATY
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

        public long SERVICE_ID { get; set; }

        public long PATIENT_TYPE_ID { get; set; }

        public decimal PRICE { get; set; }

        public decimal VAT_RATIO { get; set; }

        public long? PRIORITY { get; set; }

        public long? FROM_TIME { get; set; }

        public long? TO_TIME { get; set; }

        public long? TREATMENT_FROM_TIME { get; set; }

        public long? TREATMENT_TO_TIME { get; set; }

        public long BRANCH_ID { get; set; }

        public long? INTRUCTION_NUMBER_FROM { get; set; }

        public long? INTRUCTION_NUMBER_TO { get; set; }

        [StringLength(4000)]
        public string REQUEST_ROOM_IDS { get; set; }

        public decimal? OVERTIME_PRICE { get; set; }

        [StringLength(4000)]
        public string EXECUTE_ROOM_IDS { get; set; }

        public short? DAY_FROM { get; set; }

        public short? DAY_TO { get; set; }

        [StringLength(4)]
        public string HOUR_FROM { get; set; }

        [StringLength(4)]
        public string HOUR_TO { get; set; }

        [StringLength(4000)]
        public string REQUEST_DEPARMENT_IDS { get; set; }

        public long? INSTR_NUM_BY_TYPE_FROM { get; set; }

        public long? INSTR_NUM_BY_TYPE_TO { get; set; }

        public long? PACKAGE_ID { get; set; }

        public long? SERVICE_CONDITION_ID { get; set; }

        public long? PATIENT_CLASSIFY_ID { get; set; }

        public decimal? ACTUAL_PRICE { get; set; }

        public long? RATION_TIME_ID { get; set; }

        public virtual HIS_BRANCH HIS_BRANCH { get; set; }

        public virtual HIS_PACKAGE HIS_PACKAGE { get; set; }

        public virtual HIS_PATIENT_CLASSIFY HIS_PATIENT_CLASSIFY { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE { get; set; }

        public virtual HIS_RATION_TIME HIS_RATION_TIME { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }

        public virtual HIS_SERVICE_CONDITION HIS_SERVICE_CONDITION { get; set; }
    }
}
