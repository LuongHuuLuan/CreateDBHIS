namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_ANTICIPATE")]
    public partial class V_HIS_ANTICIPATE
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
        public string ANTICIPATE_CODE { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        [StringLength(50)]
        public string REQUEST_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQUEST_USERNAME { get; set; }

        public long? REQUEST_ROOM_ID { get; set; }

        public long? REQUEST_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string USE_TIME { get; set; }

        [StringLength(20)]
        public string REQUEST_DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string REQUEST_DEPARTMENT_NAME { get; set; }

        [StringLength(20)]
        public string REQUEST_ROOM_CODE { get; set; }

        [StringLength(100)]
        public string REQUEST_ROOM_NAME { get; set; }

        [StringLength(2)]
        public string REQUEST_ROOM_TYPE_CODE { get; set; }

        [StringLength(100)]
        public string REQUEST_ROOM_TYPE_NAME { get; set; }
    }
}
