namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_DEATH_CERT_BOOK")]
    public partial class V_HIS_DEATH_CERT_BOOK
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
        [StringLength(10)]
        public string DEATH_CERT_BOOK_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DEATH_CERT_BOOK_NAME { get; set; }

        public long TOTAL { get; set; }

        public long FROM_NUM_ORDER { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        public long? BRANCH_ID { get; set; }

        [StringLength(20)]
        public string BRANCH_CODE { get; set; }

        [StringLength(100)]
        public string BRANCH_NAME { get; set; }

        public decimal? CURRENT_DEATH_CERT_NUM { get; set; }
    }
}
