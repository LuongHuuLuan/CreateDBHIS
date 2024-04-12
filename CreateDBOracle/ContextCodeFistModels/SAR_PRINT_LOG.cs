namespace CreateDBOracle.ContextCodeFirstModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SAR_PRINT_LOG")]
    public partial class SAR_PRINT_LOG
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
        public string PRINT_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string PRINT_TYPE_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string LOGINNAME { get; set; }

        [StringLength(20)]
        public string IP { get; set; }

        public long? PRINT_TIME { get; set; }

        [StringLength(2000)]
        public string DATA_CONTENT { get; set; }

        [Required]
        [StringLength(4000)]
        public string UNIQUE_CODE { get; set; }

        public long NUM_ORDER { get; set; }

        [StringLength(4000)]
        public string PRINT_REASON { get; set; }
    }
}
