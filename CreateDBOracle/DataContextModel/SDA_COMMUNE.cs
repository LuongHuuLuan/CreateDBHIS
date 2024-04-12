namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SDA_COMMUNE")]
    public partial class SDA_COMMUNE
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
        [StringLength(6)]
        public string COMMUNE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string COMMUNE_NAME { get; set; }

        [StringLength(20)]
        public string INITIAL_NAME { get; set; }

        public long DISTRICT_ID { get; set; }

        [StringLength(10)]
        public string SEARCH_CODE { get; set; }

        public virtual SDA_DISTRICT SDA_DISTRICT { get; set; }
    }
}
