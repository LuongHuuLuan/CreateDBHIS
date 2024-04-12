namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_HIV_TREATMENT")]
    public partial class HIS_HIV_TREATMENT
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

        public short? HIV_PATIENT_TYPE { get; set; }

        [StringLength(18)]
        public string HIV_PATIENT_STATUS { get; set; }

        public short? HIV_TREATMENT_REASON { get; set; }

        public long? HIV_INFECTION_DATE { get; set; }

        public long? ARV_PATIENT_BEGIN { get; set; }

        [StringLength(200)]
        public string BEGIN_REGIMEN_HIV_CODE { get; set; }

        public short? BEGIN_REGIMEN_LEVEL { get; set; }

        [StringLength(200)]
        public string REGIMEN_HIV_CODE { get; set; }

        public short? REGIMEN_LEVEL { get; set; }

        public short? TUBERCULOSIS_TREATMENT_TYPE { get; set; }

        public short? TUBERCULOSIS_REGIMEN { get; set; }

        public long? TUBERCULOSIS_TREATMENT_BEGIN { get; set; }

        public long? TUBERCULOSIS_TREATMENT_END { get; set; }

        public long? DATE_OF_PREGNANCY { get; set; }

        public long? CTX_TREATMENT_BEGIN { get; set; }

        public short? TEST_PCR_TIMES { get; set; }

        public long? TEST_PCR_DATE { get; set; }

        public long? TEST_PCR_RESULT_DATE { get; set; }

        public short? TEST_PCR_RESULT { get; set; }

        public short? TEST_PCR_RNA_REASON { get; set; }

        public long? TEST_PCR_RNA_DATE { get; set; }

        public short? TEST_PCR_RNA_RESULT { get; set; }

        public long? TEST_PCR_RNA_RESULT_DATE { get; set; }

        public short? HIV_TREATMENT_CODE { get; set; }

        public long? ARV_TREATMEN_BEGIN { get; set; }

        public long? ARV_TREATMEN_END { get; set; }

        public short? PRESCRIPTION_ARV_DAY { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }
    }
}
