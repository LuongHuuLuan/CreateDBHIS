namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERE_SERV_TEMP")]
    public partial class V_HIS_SERE_SERV_TEMP
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
        public string SERE_SERV_TEMP_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string SERE_SERV_TEMP_NAME { get; set; }

        public byte[] DESCRIPTION { get; set; }

        [StringLength(1000)]
        public string CONCLUDE { get; set; }

        public long? SERVICE_ID { get; set; }

        public long? SERVICE_TYPE_ID { get; set; }

        public long? GENDER_ID { get; set; }

        [StringLength(1000)]
        public string NOTE { get; set; }

        [StringLength(4000)]
        public string DESCRIPTION_TEXT { get; set; }

        [StringLength(4000)]
        public string SERVICE_IDS { get; set; }

        [StringLength(2000)]
        public string EMR_BUSINESS_CODES { get; set; }

        [StringLength(2)]
        public string EMR_DOCUMENT_TYPE_CODE { get; set; }

        public short? IS_AUTO_CHOOSE_BUSINESS { get; set; }

        [StringLength(6)]
        public string EMR_DOCUMENT_GROUP_CODE { get; set; }

        [Required]
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string SERVICE_NAME { get; set; }
    }
}
