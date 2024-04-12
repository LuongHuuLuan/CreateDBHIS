namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_DEPOSIT_REQ")]
    public partial class HIS_DEPOSIT_REQ
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
        [StringLength(8)]
        public string DEPOSIT_REQ_CODE { get; set; }

        public long TREATMENT_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public long REQUEST_ROOM_ID { get; set; }

        public long REQUEST_DEPARTMENT_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string REQUEST_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQUEST_USERNAME { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        public long? DEPOSIT_ID { get; set; }

        public long? TRANS_REQ_ID { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        public virtual HIS_TRANSACTION HIS_TRANSACTION { get; set; }
    }
}
