namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_DEBT_GOODS")]
    public partial class HIS_DEBT_GOODS
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

        public long DEBT_ID { get; set; }

        [StringLength(100)]
        public string GOODS_UNIT_NAME { get; set; }

        [Required]
        [StringLength(500)]
        public string GOODS_NAME { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal PRICE { get; set; }

        public decimal? DISCOUNT { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        public decimal? VAT_RATIO { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public long? EXPIRED_DATE { get; set; }

        [StringLength(100)]
        public string NATIONAL_NAME { get; set; }

        [StringLength(1000)]
        public string CONCENTRA { get; set; }

        [StringLength(1000)]
        public string MANUFACTURER_NAME { get; set; }

        public long? MATERIAL_TYPE_ID { get; set; }

        public long? MEDICINE_TYPE_ID { get; set; }

        public long? NONE_MEDI_SERVICE_ID { get; set; }

        public long? SERVICE_UNIT_ID { get; set; }

        public virtual HIS_TRANSACTION HIS_TRANSACTION { get; set; }

        public virtual HIS_SERVICE_UNIT HIS_SERVICE_UNIT { get; set; }

        public virtual HIS_MEDICINE_TYPE HIS_MEDICINE_TYPE { get; set; }

        public virtual HIS_MATERIAL_TYPE HIS_MATERIAL_TYPE { get; set; }

        public virtual HIS_NONE_MEDI_SERVICE HIS_NONE_MEDI_SERVICE { get; set; }
    }
}
