namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_DRUG_INTERVENTION")]
    public partial class HIS_DRUG_INTERVENTION
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

        public long SERVICE_REQ_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string SESSION_CODE { get; set; }

        public long? INTERVENTION_TIME { get; set; }

        [StringLength(50)]
        public string PHARMACIST_LOGINNAME { get; set; }

        [StringLength(100)]
        public string PHARMACIST_USERNAME { get; set; }

        public short? IS_URGENT { get; set; }

        public virtual HIS_SERVICE_REQ HIS_SERVICE_REQ { get; set; }
    }
}
