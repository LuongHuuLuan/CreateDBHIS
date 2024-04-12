namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_TREATMENT_UNLIMIT")]
    public partial class HIS_TREATMENT_UNLIMIT
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

        public long UNLIMIT_TYPE_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string REQ_LOGINNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string REQ_USERNAME { get; set; }

        [StringLength(500)]
        public string UNLIMIT_REASON { get; set; }

        public long TREATMENT_ID { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        public virtual HIS_UNLIMIT_TYPE HIS_UNLIMIT_TYPE { get; set; }
    }
}
