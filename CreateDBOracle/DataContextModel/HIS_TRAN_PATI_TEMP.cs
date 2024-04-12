namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_TRAN_PATI_TEMP")]
    public partial class HIS_TRAN_PATI_TEMP
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
        [StringLength(20)]
        public string TRAN_PATI_TEMP_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string TRAN_PATI_TEMP_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string MEDI_ORG_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string MEDI_ORG_NAME { get; set; }

        public long TRAN_PATI_REASON_ID { get; set; }

        public long TRAN_PATI_FORM_ID { get; set; }

        public long? TRAN_PATI_TECH_ID { get; set; }

        public short? IS_PUBLIC { get; set; }

        [StringLength(3000)]
        public string TREATMENT_DIRECTION { get; set; }

        [StringLength(3000)]
        public string TREATMENT_METHOD { get; set; }

        [StringLength(3000)]
        public string PATIENT_CONDITION { get; set; }

        [StringLength(3000)]
        public string USED_MEDICINE { get; set; }

        [StringLength(3000)]
        public string TRANSPORT_VEHICLE { get; set; }

        [StringLength(3000)]
        public string TRANSPORTER { get; set; }

        public virtual HIS_TRAN_PATI_FORM HIS_TRAN_PATI_FORM { get; set; }

        public virtual HIS_TRAN_PATI_REASON HIS_TRAN_PATI_REASON { get; set; }

        public virtual HIS_TRAN_PATI_TECH HIS_TRAN_PATI_TECH { get; set; }
    }
}
