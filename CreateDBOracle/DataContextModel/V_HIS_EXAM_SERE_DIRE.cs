namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_EXAM_SERE_DIRE")]
    public partial class V_HIS_EXAM_SERE_DIRE
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
        public long DISEASE_RELATION_ID { get; set; }

        public long? MONTH_COUNT { get; set; }

        [StringLength(100)]
        public string DESCRIPTION { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_REQ_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string DISEASE_RELATION_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string DISEASE_RELATION_NAME { get; set; }
    }
}
