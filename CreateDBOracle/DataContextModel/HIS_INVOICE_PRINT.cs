namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_INVOICE_PRINT")]
    public partial class HIS_INVOICE_PRINT
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

        public long INVOICE_ID { get; set; }

        public long PRINT_TIME { get; set; }

        [Required]
        [StringLength(50)]
        public string LOGINNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string USERNAME { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        public short? IS_ORIGINAL { get; set; }

        public short? IS_CANCEL { get; set; }

        public virtual HIS_INVOICE HIS_INVOICE { get; set; }
    }
}
