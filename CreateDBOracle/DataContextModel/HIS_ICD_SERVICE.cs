namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_ICD_SERVICE")]
    public partial class HIS_ICD_SERVICE
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
        public string ICD_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string ICD_NAME { get; set; }

        public long ICD_ID__DELETE { get; set; }

        public long? SERVICE_ID { get; set; }

        public long? ACTIVE_INGREDIENT_ID { get; set; }

        public short? IS_INDICATION { get; set; }

        public short? IS_CONTRAINDICATION { get; set; }

        [StringLength(4000)]
        public string CONTRAINDICATION_CONTENT { get; set; }

        public short? IS_WARNING { get; set; }

        public long? MIN_DURATION { get; set; }

        public virtual HIS_ACTIVE_INGREDIENT HIS_ACTIVE_INGREDIENT { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }
    }
}
