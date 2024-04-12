namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_ANTIBIOTIC_MICROBI")]
    public partial class HIS_ANTIBIOTIC_MICROBI
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
        [StringLength(500)]
        public string SPECIMENS { get; set; }

        public long? IMPLANTION_TIME { get; set; }

        public long? RESULT_TIME { get; set; }

        [StringLength(1000)]
        public string RESULT { get; set; }

        public long ANTIBIOTIC_REQUEST_ID { get; set; }

        public virtual HIS_ANTIBIOTIC_REQUEST HIS_ANTIBIOTIC_REQUEST { get; set; }
    }
}
