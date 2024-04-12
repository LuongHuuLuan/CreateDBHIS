namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_EXME_REASON_CFG")]
    public partial class HIS_EXME_REASON_CFG
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

        public long EXP_MEST_REASON_ID { get; set; }

        public long PATIENT_CLASSIFY_ID { get; set; }

        public long TREATMENT_TYPE_ID { get; set; }

        public long? PATIENT_TYPE_ID { get; set; }

        public long? OTHER_PAY_SOURCE_ID { get; set; }

        public virtual HIS_EXP_MEST_REASON HIS_EXP_MEST_REASON { get; set; }

        public virtual HIS_PATIENT_CLASSIFY HIS_PATIENT_CLASSIFY { get; set; }

        public virtual HIS_TREATMENT_TYPE HIS_TREATMENT_TYPE { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE { get; set; }

        public virtual HIS_OTHER_PAY_SOURCE HIS_OTHER_PAY_SOURCE { get; set; }
    }
}
