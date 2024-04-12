namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERVICE_ROOM")]
    public partial class V_HIS_SERVICE_ROOM
    {
        [Key]
        [Column(Order = 0)]
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

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ROOM_ID { get; set; }

        public short? IS_EXECUTE { get; set; }

        public short? IS_REQUEST { get; set; }

        public short? IS_PRIORITY { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_TYPE_ID { get; set; }

        public short? IS_LEAF { get; set; }

        public long? PARENT_ID { get; set; }

        public short? IS_MULTI_REQUEST { get; set; }

        [StringLength(3)]
        public string SPECIALITY_CODE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(2)]
        public string SERVICE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string SERVICE_TYPE_NAME { get; set; }

        [StringLength(20)]
        public string ROOM_CODE { get; set; }

        [StringLength(100)]
        public string ROOM_NAME { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(2)]
        public string ROOM_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ROOM_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string ROOM_TYPE_NAME { get; set; }

        public short? IS_PAUSE { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long DEPARTMENT_ID { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BRANCH_ID { get; set; }
    }
}
