namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SAR_PRINT")]
    public partial class SAR_PRINT
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

        [StringLength(500)]
        public string TITLE { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        public byte[] CONTENT { get; set; }

        [StringLength(2000)]
        public string EMR_BUSINESS_CODES { get; set; }

        [StringLength(2)]
        public string EMR_DOCUMENT_TYPE_CODE { get; set; }

        public long? PRINT_TYPE_ID { get; set; }

        [StringLength(20)]
        public string EMR_DOCUMENT_GROUP_CODE { get; set; }

        [StringLength(2000)]
        public string ADDITIONAL_INFO { get; set; }

        public virtual SAR_PRINT_TYPE SAR_PRINT_TYPE { get; set; }
    }
}
