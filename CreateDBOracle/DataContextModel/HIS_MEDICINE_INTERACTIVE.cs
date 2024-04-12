namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MEDICINE_INTERACTIVE")]
    public partial class HIS_MEDICINE_INTERACTIVE
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
        [StringLength(50)]
        public string REQUEST_LOGINNAME { get; set; }

        public long REQUEST_DEPARTMENT_ID { get; set; }

        public long TREATMENT_ID { get; set; }

        [StringLength(10)]
        public string ICD_CAUSE_CODE { get; set; }

        [StringLength(500)]
        public string ICD_CAUSE_NAME { get; set; }

        [StringLength(10)]
        public string ICD_CODE { get; set; }

        [StringLength(500)]
        public string ICD_NAME { get; set; }

        [StringLength(500)]
        public string ICD_SUB_CODE { get; set; }

        [StringLength(4000)]
        public string ICD_TEXT { get; set; }

        public long MEDICINE_TYPE_ID1 { get; set; }

        public long MEDICINE_TYPE_ID2 { get; set; }

        public long INTERACTIVE_GRADE_ID { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_INTERACTIVE_GRADE HIS_INTERACTIVE_GRADE { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        public virtual HIS_MEDICINE_TYPE HIS_MEDICINE_TYPE { get; set; }

        public virtual HIS_MEDICINE_TYPE HIS_MEDICINE_TYPE1 { get; set; }
    }
}
