namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SDA_TRANSLATE")]
    public partial class SDA_TRANSLATE
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

        public long LANGUAGE_ID { get; set; }

        [Required]
        [StringLength(6)]
        public string SCHEMA { get; set; }

        [Required]
        [StringLength(30)]
        public string TABLE_NAME { get; set; }

        [Required]
        [StringLength(500)]
        public string FIND_DATA_CODE_ONE { get; set; }

        [StringLength(50)]
        public string FIND_COLUMN_NAME_ONE { get; set; }

        [StringLength(500)]
        public string FIND_DATA_CODE_TWO { get; set; }

        [StringLength(50)]
        public string FIND_COLUMN_NAME_TWO { get; set; }

        [StringLength(50)]
        public string UPDATE_COLUMN_NAME { get; set; }

        [StringLength(500)]
        public string UPDATE_DATA_VALUE { get; set; }

        public virtual SDA_LANGUAGE SDA_LANGUAGE { get; set; }
    }
}
