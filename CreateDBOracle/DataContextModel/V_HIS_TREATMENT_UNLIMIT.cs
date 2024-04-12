namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_TREATMENT_UNLIMIT")]
    public partial class V_HIS_TREATMENT_UNLIMIT
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
        public long UNLIMIT_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string REQ_LOGINNAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string REQ_USERNAME { get; set; }

        [StringLength(500)]
        public string UNLIMIT_REASON { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TREATMENT_ID { get; set; }

        [StringLength(2)]
        public string UNLIMIT_TYPE_CODE { get; set; }

        [StringLength(200)]
        public string UNLIMIT_TYPE_NAME { get; set; }
    }
}
