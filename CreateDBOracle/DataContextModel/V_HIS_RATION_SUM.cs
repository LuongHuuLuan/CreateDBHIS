namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_RATION_SUM")]
    public partial class V_HIS_RATION_SUM
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
        [StringLength(6)]
        public string RATION_SUM_CODE { get; set; }

        public long ROOM_ID { get; set; }

        public long DEPARTMENT_ID { get; set; }

        public long RATION_SUM_STT_ID { get; set; }

        [StringLength(50)]
        public string REQ_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQ_USERNAME { get; set; }

        [StringLength(50)]
        public string APPROVAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string APPROVAL_USERNAME { get; set; }

        public long? APPROVAL_TIME { get; set; }

        public long? APPROVAL_DATE { get; set; }

        public long? REQ_TIME { get; set; }

        public long? REQ_DATE { get; set; }

        public long? MAX_INTRUCTION_DATE { get; set; }

        [StringLength(20)]
        public string ROOM_CODE { get; set; }

        [StringLength(100)]
        public string ROOM_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [Required]
        [StringLength(2)]
        public string RATION_SUM_STT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string RATION_SUM_STT_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string REQ_DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string REQ_DEPARTMENT_NAME { get; set; }
    }
}
