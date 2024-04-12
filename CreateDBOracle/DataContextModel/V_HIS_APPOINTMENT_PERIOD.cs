namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_APPOINTMENT_PERIOD")]
    public partial class V_HIS_APPOINTMENT_PERIOD
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

        public long? FROM_HOUR { get; set; }

        public long? FROM_MINUTE { get; set; }

        public long? TO_HOUR { get; set; }

        public long? TO_MINUTE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BRANCH_ID { get; set; }

        public long? MAXIMUM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string BRANCH_NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string BRANCH_CODE { get; set; }
    }
}
