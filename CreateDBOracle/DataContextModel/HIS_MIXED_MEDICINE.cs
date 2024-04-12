namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MIXED_MEDICINE")]
    public partial class HIS_MIXED_MEDICINE
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

        public long? MEDICINE_ID { get; set; }

        public long INFUSION_ID { get; set; }

        public long? MEDICINE_TYPE_ID { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        [Required]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        public decimal? VOLUME { get; set; }

        public decimal? AMOUNT { get; set; }

        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        public virtual HIS_INFUSION HIS_INFUSION { get; set; }

        public virtual HIS_MEDICINE HIS_MEDICINE { get; set; }

        public virtual HIS_MEDICINE_TYPE HIS_MEDICINE_TYPE { get; set; }
    }
}
