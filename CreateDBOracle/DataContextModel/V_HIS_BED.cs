namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_BED")]
    public partial class V_HIS_BED
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
        public string BED_CODE { get; set; }

        [Required]
        [StringLength(200)]
        public string BED_NAME { get; set; }

        public long BED_ROOM_ID { get; set; }

        public long BED_TYPE_ID { get; set; }

        public long? MAX_CAPACITY { get; set; }

        [StringLength(6)]
        public string X { get; set; }

        [StringLength(6)]
        public string Y { get; set; }

        public long? TREATMENT_ROOM_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string BED_ROOM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string BED_ROOM_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string BED_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string BED_TYPE_NAME { get; set; }

        [StringLength(20)]
        public string TREATMENT_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string TREATMENT_ROOM_NAME { get; set; }

        public long DEPARTMENT_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }
    }
}
