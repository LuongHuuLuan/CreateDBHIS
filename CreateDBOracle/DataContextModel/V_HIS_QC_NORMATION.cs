namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_QC_NORMATION")]
    public partial class V_HIS_QC_NORMATION
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

        public long MATERIAL_TYPE_ID { get; set; }

        public long MACHINE_ID { get; set; }

        public long QC_TYPE_ID { get; set; }

        public decimal AMOUNT { get; set; }

        [Required]
        [StringLength(10)]
        public string QC_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string QC_TYPE_NAME { get; set; }

        [Required]
        [StringLength(25)]
        public string MATERIAL_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string MATERIAL_TYPE_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string MACHINE_CODE { get; set; }

        [StringLength(200)]
        public string MACHINE_NAME { get; set; }
    }
}
