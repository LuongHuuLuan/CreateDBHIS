namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_ACIN_INTERACTIVE")]
    public partial class V_HIS_ACIN_INTERACTIVE
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

        public long ACTIVE_INGREDIENT_ID { get; set; }

        public long CONFLICT_ID { get; set; }

        [StringLength(4000)]
        public string DESCRIPTION { get; set; }

        [StringLength(4000)]
        public string INSTRUCTION { get; set; }

        [StringLength(1000)]
        public string CONSEQUENCE { get; set; }

        [StringLength(1000)]
        public string MECHANISM { get; set; }

        public long? INTERACTIVE_GRADE_ID { get; set; }

        [Required]
        [StringLength(15)]
        public string ACTIVE_INGREDIENT_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string ACTIVE_INGREDIENT_NAME { get; set; }

        [Required]
        [StringLength(15)]
        public string CONFLICT_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string CONFLICT_NAME { get; set; }

        public long? INTERACTIVE_GRADE { get; set; }

        [StringLength(100)]
        public string INTERACTIVE_GRADE_NAME { get; set; }
    }
}
