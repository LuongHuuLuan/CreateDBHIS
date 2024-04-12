namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_VAEX_VAER")]
    public partial class HIS_VAEX_VAER
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

        public long VACCINATION_EXAM_ID { get; set; }

        public long VACC_EXAM_RESULT_ID { get; set; }

        [StringLength(500)]
        public string NOTE { get; set; }

        public virtual HIS_VACC_EXAM_RESULT HIS_VACC_EXAM_RESULT { get; set; }

        public virtual HIS_VACCINATION_EXAM HIS_VACCINATION_EXAM { get; set; }
    }
}
