namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SUIM_SETY_SUIN")]
    public partial class V_HIS_SUIM_SETY_SUIN
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
        public long SUIM_SERVICE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SUIM_INDEX_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string SUIM_INDEX_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1000)]
        public string SUIM_INDEX_NAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        [StringLength(2)]
        public string SUIM_INDEX_UNIT_CODE { get; set; }

        [StringLength(100)]
        public string SUIM_INDEX_UNIT_NAME { get; set; }
    }
}
