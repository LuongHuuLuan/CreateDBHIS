namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.ACS_ACTIVITY_LOG")]
    public partial class ACS_ACTIVITY_LOG
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
        public string LOGINNAME { get; set; }

        [StringLength(3)]
        public string APPLICATION_CODE { get; set; }

        public long ACTIVITY_TYPE_ID { get; set; }

        public long ACTIVITY_TIME { get; set; }

        [StringLength(100)]
        public string IP_ADDRESS { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string USERNAME { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(20)]
        public string MOBILE { get; set; }

        public decimal? VIR_ACTIVITY_DATE { get; set; }

        public decimal? VIR_ACTIVITY_MONTH { get; set; }

        public virtual ACS_ACTIVITY_TYPE ACS_ACTIVITY_TYPE { get; set; }
    }
}
