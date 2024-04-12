namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_IMP_MEST_PROPOSE")]
    public partial class V_HIS_IMP_MEST_PROPOSE
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
        [StringLength(8)]
        public string IMP_MEST_PROPOSE_CODE { get; set; }

        [Required]
        [StringLength(50)]
        public string PROPOSE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string PROPOSE_USERNAME { get; set; }

        public long SUPPLIER_ID { get; set; }

        public long PROPOSE_ROOM_ID { get; set; }

        public long PROPOSE_DEPARTMENT_ID { get; set; }

        public long? MEDICAL_CONTRACT_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string SUPPLIER_CODE { get; set; }

        [Required]
        [StringLength(1000)]
        public string SUPPLIER_NAME { get; set; }

        public long? VALID_TO_DATE { get; set; }

        public long? VALID_FROM_DATE { get; set; }

        [StringLength(500)]
        public string VENTURE_AGREENING { get; set; }

        public long? BID_ID { get; set; }

        public long? DOCUMENT_SUPPLIER_ID { get; set; }

        [StringLength(200)]
        public string MEDICAL_CONTRACT_NAME { get; set; }

        [StringLength(50)]
        public string MEDICAL_CONTRACT_CODE { get; set; }

        [StringLength(30)]
        public string BID_NUMBER { get; set; }

        [StringLength(500)]
        public string BID_NAME { get; set; }

        [StringLength(10)]
        public string DOCUMENT_SUPPLIER_CODE { get; set; }

        [StringLength(1000)]
        public string DOCUMENT_SUPPLIER_NAME { get; set; }

        public decimal? TOTAL_PAY { get; set; }

        public decimal? PAYED { get; set; }
    }
}
