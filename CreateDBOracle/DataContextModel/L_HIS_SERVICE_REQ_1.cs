namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.L_HIS_SERVICE_REQ_1")]
    public partial class L_HIS_SERVICE_REQ_1
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Required]
        [StringLength(12)]
        public string SERVICE_REQ_CODE { get; set; }

        [Required]
        [StringLength(10)]
        public string TDL_PATIENT_CODE { get; set; }

        [Required]
        [StringLength(150)]
        public string TDL_PATIENT_NAME { get; set; }

        [StringLength(100)]
        public string TDL_PATIENT_GENDER_NAME { get; set; }

        public long TDL_PATIENT_DOB { get; set; }

        [StringLength(600)]
        public string TDL_PATIENT_ADDRESS { get; set; }

        public long TREATMENT_ID { get; set; }

        public long SERVICE_REQ_STT_ID { get; set; }

        public long EXECUTE_ROOM_ID { get; set; }

        [Required]
        [StringLength(12)]
        public string TDL_TREATMENT_CODE { get; set; }

        public long INTRUCTION_TIME { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(19)]
        public string TDL_HEIN_CARD_NUMBER { get; set; }

        public short? IS_NO_EXECUTE { get; set; }

        public long INTRUCTION_DATE { get; set; }

        public long? TDL_PATIENT_TYPE_ID { get; set; }

        public short? IS_NOT_IN_DEBT { get; set; }

        public decimal? VIR_INTRUCTION_MONTH { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_PHONE { get; set; }

        [StringLength(12)]
        public string TDL_PATIENT_MOBILE { get; set; }

        [StringLength(4000)]
        public string TDL_SERVICE_IDS { get; set; }

        public long? PRIORITY { get; set; }

        public short? IS_ENOUGH_SUBCLINICAL_PRES { get; set; }

        [StringLength(4000)]
        public string SERVICE_NAMES { get; set; }
    }
}
