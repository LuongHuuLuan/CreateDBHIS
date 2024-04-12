namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_HORE_HANDOVER")]
    public partial class V_HIS_HORE_HANDOVER
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
        [StringLength(8)]
        public string HORE_HANDOVER_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long HORE_HANDOVER_STT_ID { get; set; }

        [StringLength(50)]
        public string SEND_LOGINNAME { get; set; }

        [StringLength(100)]
        public string SEND_USERNAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SEND_ROOM_ID { get; set; }

        [StringLength(50)]
        public string RECEIVE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string RECEIVE_USERNAME { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long RECEIVE_ROOM_ID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string HORE_HANDOVER_STT_CODE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string HORE_HANDOVER_STT_NAME { get; set; }

        [StringLength(20)]
        public string SEND_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string SEND_ROOM_NAME { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SEND_DEPARTMENT_ID { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string SEND_DEPARTMENT_CODE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string SEND_DEPARTMENT_NAME { get; set; }

        [StringLength(20)]
        public string RECEIVE_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string RECEIVE_ROOM_NAME { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long RECEIVE_DEPARTMENT_ID { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(20)]
        public string RECEIVE_DEPARTMENT_CODE { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(100)]
        public string RECEIVE_DEPARTMENT_NAME { get; set; }
    }
}
