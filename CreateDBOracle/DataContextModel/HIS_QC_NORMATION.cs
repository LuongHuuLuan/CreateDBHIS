namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_QC_NORMATION")]
    public partial class HIS_QC_NORMATION
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

        public virtual HIS_MACHINE HIS_MACHINE { get; set; }

        public virtual HIS_MATERIAL_TYPE HIS_MATERIAL_TYPE { get; set; }

        public virtual HIS_QC_TYPE HIS_QC_TYPE { get; set; }
    }
}
