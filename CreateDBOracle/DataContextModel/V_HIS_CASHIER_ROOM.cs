namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_CASHIER_ROOM")]
    public partial class V_HIS_CASHIER_ROOM
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
        public string CASHIER_ROOM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string CASHIER_ROOM_NAME { get; set; }

        public long ROOM_ID { get; set; }

        [StringLength(10)]
        public string EINVOICE_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string EINVOICE_ROOM_NAME { get; set; }

        public long DEPARTMENT_ID { get; set; }

        public long ROOM_TYPE_ID { get; set; }

        public short? IS_PAUSE { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        public long? AREA_ID { get; set; }

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

        [StringLength(2)]
        public string AREA_CODE { get; set; }

        [StringLength(100)]
        public string AREA_NAME { get; set; }
    }
}
