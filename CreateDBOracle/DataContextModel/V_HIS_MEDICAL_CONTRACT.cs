namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEDICAL_CONTRACT")]
    public partial class V_HIS_MEDICAL_CONTRACT
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
        [StringLength(50)]
        public string MEDICAL_CONTRACT_CODE { get; set; }

        [StringLength(200)]
        public string MEDICAL_CONTRACT_NAME { get; set; }

        public long SUPPLIER_ID { get; set; }

        public long? DOCUMENT_SUPPLIER_ID { get; set; }

        public long? BID_ID { get; set; }

        [StringLength(500)]
        public string VENTURE_AGREENING { get; set; }

        public long? VALID_FROM_DATE { get; set; }

        public long? VALID_TO_DATE { get; set; }

        [StringLength(4000)]
        public string NOTE { get; set; }

        public decimal? VIR_CREATE_DATE { get; set; }

        [Required]
        [StringLength(10)]
        public string SUPPLIER_CODE { get; set; }

        [Required]
        [StringLength(1000)]
        public string SUPPLIER_NAME { get; set; }

        [StringLength(10)]
        public string DOCUMENT_SUPPLIER_CODE { get; set; }

        [StringLength(1000)]
        public string DOCUMENT_SUPPLIER_NAME { get; set; }

        [StringLength(30)]
        public string BID_NUMBER { get; set; }

        [StringLength(20)]
        public string BID_YEAR { get; set; }

        [StringLength(500)]
        public string BID_NAME { get; set; }

        [StringLength(4000)]
        public string ALLOW_UPDATE_LOGINNAMES { get; set; }

        public decimal? MATERIAL_TYPE_COUNT { get; set; }

        public decimal? MEDICINE_TYPE_COUNT { get; set; }
    }
}
