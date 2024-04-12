namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_REGISTER_GATE")]
    public partial class V_HIS_REGISTER_GATE
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
        [StringLength(2)]
        public string REGISTER_GATE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string REGISTER_GATE_NAME { get; set; }

        public short? IS_RESET_AFTER_NOON { get; set; }

        public long? WAITING_LIMIT { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        public long? HOUR_FROM { get; set; }

        public long? MINUTE_FROM { get; set; }

        public long? HOUR_TO { get; set; }

        public long? MINUTE_TO { get; set; }

        public long? CURRENT_ISSUED_NUMBER { get; set; }

        public long? CURRENT_CALLED_NUMBER { get; set; }

        public long? ISSUED_NUMBER_DATE { get; set; }

        public long? PRIORITY { get; set; }

        [StringLength(20)]
        public string FORMAT { get; set; }

        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }
    }
}
