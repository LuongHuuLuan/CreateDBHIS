namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_REFECTORY")]
    public partial class V_HIS_REFECTORY
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
        [StringLength(10)]
        public string REFECTORY_CODE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string REFECTORY_NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ROOM_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long DEPARTMENT_ID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ROOM_TYPE_ID { get; set; }

        public short? IS_PAUSE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string G_CODE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string BRANCH_CODE { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string BRANCH_NAME { get; set; }
    }
}
