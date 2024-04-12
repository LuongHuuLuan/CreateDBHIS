namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_FORM_TYPE_CFG_DATA")]
    public partial class V_HIS_FORM_TYPE_CFG_DATA
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
        public long FORM_TYPE_CFG_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string FORM_TYPE_CODE { get; set; }

        [StringLength(500)]
        public string VALUE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string FORM_TYPE_CFG_CODE { get; set; }

        [StringLength(100)]
        public string DESCRIPTION { get; set; }
    }
}
