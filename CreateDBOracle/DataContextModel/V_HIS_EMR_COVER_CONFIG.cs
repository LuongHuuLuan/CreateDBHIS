namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_EMR_COVER_CONFIG")]
    public partial class V_HIS_EMR_COVER_CONFIG
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

        public long? DEPARTMENT_ID { get; set; }

        public long? ROOM_ID { get; set; }

        public long TREATMENT_TYPE_ID { get; set; }

        public long EMR_COVER_TYPE_ID { get; set; }

        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [StringLength(20)]
        public string ROOM_CODE { get; set; }

        [StringLength(100)]
        public string ROOM_NAME { get; set; }

        [Required]
        [StringLength(2)]
        public string TREATMENT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string TREATMENT_TYPE_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string EMR_COVER_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string EMR_COVER_TYPE_NAME { get; set; }
    }
}
