namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_RECEPTION_ROOM")]
    public partial class V_HIS_RECEPTION_ROOM
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
        [StringLength(20)]
        public string RECEPTION_ROOM_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string RECEPTION_ROOM_NAME { get; set; }

        public long ROOM_ID { get; set; }

        [StringLength(50)]
        public string PATIENT_TYPE_IDS { get; set; }

        public long DEPARTMENT_ID { get; set; }

        public long ROOM_TYPE_ID { get; set; }

        public short? IS_PAUSE { get; set; }

        public short? IS_RESTRICT_EXECUTE_ROOM { get; set; }

        public long? AREA_ID { get; set; }

        public short? IS_ALLOW_NO_ICD { get; set; }

        public long? DEFAULT_CASHIER_ROOM_ID { get; set; }

        public long? DEPOSIT_ACCOUNT_BOOK_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string G_CODE { get; set; }

        [Required]
        [StringLength(20)]
        public string BRANCH_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string BRANCH_NAME { get; set; }

        [StringLength(2)]
        public string AREA_CODE { get; set; }

        [StringLength(100)]
        public string AREA_NAME { get; set; }
    }
}
