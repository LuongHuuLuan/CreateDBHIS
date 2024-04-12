namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_SDA_GROUP")]
    public partial class V_SDA_GROUP
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

        [StringLength(10)]
        public string GROUP_CODE { get; set; }

        [Required]
        [StringLength(10)]
        public string G_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string GROUP_NAME { get; set; }

        public long? GROUP_TYPE_ID { get; set; }

        public long? PARENT_ID { get; set; }

        [StringLength(2000)]
        public string CODE_PATH { get; set; }

        [StringLength(2000)]
        public string ID_PATH { get; set; }

        [StringLength(10)]
        public string PARENT_CODE { get; set; }

        [StringLength(100)]
        public string PARENT_NAME { get; set; }

        [StringLength(2000)]
        public string PARENT_ID_PATH { get; set; }

        [StringLength(2000)]
        public string PARENT_CODE_PATH { get; set; }

        [StringLength(3)]
        public string GROUP_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string GROUP_TYPE_NAME { get; set; }
    }
}
