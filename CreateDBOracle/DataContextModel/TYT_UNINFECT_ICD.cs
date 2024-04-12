namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.TYT_UNINFECT_ICD")]
    public partial class TYT_UNINFECT_ICD
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
        public string UNINFECT_ICD_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string UNINFECT_ICD_NAME { get; set; }

        public long UNINFECT_ICD_GROUP_ID { get; set; }

        public virtual TYT_UNINFECT_ICD_GROUP TYT_UNINFECT_ICD_GROUP { get; set; }
    }
}
