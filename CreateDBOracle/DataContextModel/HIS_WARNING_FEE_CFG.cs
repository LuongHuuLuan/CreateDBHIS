namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_WARNING_FEE_CFG")]
    public partial class HIS_WARNING_FEE_CFG
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
        [StringLength(100)]
        public string WARNING_FEE_CFG_NAME { get; set; }

        public long? PATIENT_TYPE_ID { get; set; }

        public long? TREATMENT_TYPE_ID { get; set; }

        public short? IS_RIGHT_MEDI_ORG { get; set; }

        public decimal? WARNING_PRICE { get; set; }

        [StringLength(20)]
        public string COLOR_CODE { get; set; }
    }
}
