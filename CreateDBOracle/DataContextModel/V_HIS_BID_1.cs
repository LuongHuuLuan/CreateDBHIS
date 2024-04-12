namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_BID_1")]
    public partial class V_HIS_BID_1
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
        [StringLength(30)]
        public string BID_NUMBER { get; set; }

        [Required]
        [StringLength(500)]
        public string BID_NAME { get; set; }

        public long? BID_TYPE_ID { get; set; }

        [StringLength(20)]
        public string BID_YEAR { get; set; }

        public long? VALID_FROM_TIME { get; set; }

        public long? VALID_TO_TIME { get; set; }

        [StringLength(4000)]
        public string ALLOW_UPDATE_LOGINNAMES { get; set; }

        public long? APPROVAL_TIME { get; set; }

        [StringLength(50)]
        public string APPROVAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string APPROVAL_USERNAME { get; set; }

        [StringLength(50)]
        public string BID_EXTRA_CODE { get; set; }

        public long? BID_FORM_ID { get; set; }

        [StringLength(2)]
        public string BID_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string BID_TYPE_NAME { get; set; }

        public decimal? MATERIAL_TYPE_COUNT { get; set; }

        public decimal? MEDICINE_TYPE_COUNT { get; set; }

        public decimal? BLOOD_TYPE_COUNT { get; set; }

        [StringLength(4000)]
        public string SUPPLIER_IDS { get; set; }
    }
}
