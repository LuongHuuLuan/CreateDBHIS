namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SDA_METADATA")]
    public partial class SDA_METADATA
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

        [Required]
        [StringLength(6)]
        public string SCHEMA_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string TABLE_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string COLUMN_NAME { get; set; }

        [StringLength(100)]
        public string METADATA_NAME { get; set; }

        [StringLength(108)]
        public string VIR_KEY { get; set; }

        [StringLength(500)]
        public string DATA_TYPE { get; set; }
    }
}
