namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_ALLERGENIC")]
    public partial class HIS_ALLERGENIC
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

        [StringLength(500)]
        public string ALLERGENIC_NAME { get; set; }

        public long ALLERGY_CARD_ID { get; set; }

        public short? IS_DOUBT { get; set; }

        public short? IS_SURE { get; set; }

        [StringLength(500)]
        public string CLINICAL_EXPRESSION { get; set; }

        public long? MEDICINE_TYPE_ID { get; set; }

        public long TDL_PATIENT_ID { get; set; }

        public virtual HIS_ALLERGY_CARD HIS_ALLERGY_CARD { get; set; }

        public virtual HIS_MEDICINE_TYPE HIS_MEDICINE_TYPE { get; set; }
    }
}
