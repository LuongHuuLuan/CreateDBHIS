namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SDA_MODULE_FIELD")]
    public partial class SDA_MODULE_FIELD
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

        [StringLength(20)]
        public string GROUP_CODE { get; set; }

        [StringLength(200)]
        public string MODULE_LINK { get; set; }

        [Required]
        [StringLength(20)]
        public string FIELD_CODE { get; set; }

        [StringLength(100)]
        public string FIELD_NAME { get; set; }

        public long? NUM_ORDER { get; set; }

        public short? IS_VISIBLE { get; set; }
    }
}
