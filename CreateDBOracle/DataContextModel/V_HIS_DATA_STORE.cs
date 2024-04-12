namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_DATA_STORE")]
    public partial class V_HIS_DATA_STORE
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
        public string DATA_STORE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DATA_STORE_NAME { get; set; }

        public long ROOM_ID { get; set; }

        public long? PARENT_ID { get; set; }

        public long? STORED_DEPARTMENT_ID { get; set; }

        public long? STORED_ROOM_ID { get; set; }

        [StringLength(50)]
        public string TREATMENT_END_TYPE_IDS { get; set; }

        [StringLength(50)]
        public string TREATMENT_TYPE_IDS { get; set; }

        public long DEPARTMENT_ID { get; set; }

        public long ROOM_TYPE_ID { get; set; }

        public short? IS_PAUSE { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        [Required]
        [StringLength(2)]
        public string ROOM_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string ROOM_TYPE_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string G_CODE { get; set; }

        public long BRANCH_ID { get; set; }

        [StringLength(10)]
        public string PARENT_CODE { get; set; }

        [StringLength(100)]
        public string PARENT_NAME { get; set; }

        [StringLength(20)]
        public string STORED_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string STORED_ROOM_NAME { get; set; }

        [StringLength(20)]
        public string STORED_DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string STORED_DEPARTMENT_NAME { get; set; }

        public decimal? TREATMENT_COUNT { get; set; }
    }
}
