namespace CreateDBOracle.ContextCodeFirstModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_SAR_RETY_FOFI")]
    public partial class V_SAR_RETY_FOFI
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

        public long REPORT_TYPE_ID { get; set; }

        public long FORM_FIELD_ID { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        [StringLength(4000)]
        public string JSON_OUTPUT { get; set; }

        public short? IS_REQUIRE { get; set; }

        public short? WIDTH_RATIO { get; set; }

        public long? HEIGHT { get; set; }

        public long? ROW_COUNT { get; set; }

        public long? COLUMN_COUNT { get; set; }

        public long? ROW_INDEX { get; set; }

        [Required]
        [StringLength(10)]
        public string REPORT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string REPORT_TYPE_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string FORM_FIELD_CODE { get; set; }

        [StringLength(4000)]
        public string FORM_FIELD_DESCRIPTION { get; set; }
    }
}
