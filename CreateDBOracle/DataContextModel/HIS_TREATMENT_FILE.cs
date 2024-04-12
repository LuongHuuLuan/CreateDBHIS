namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_TREATMENT_FILE")]
    public partial class HIS_TREATMENT_FILE
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

        [StringLength(500)]
        public string FILE_NAME { get; set; }

        [StringLength(4000)]
        public string FILE_URLS { get; set; }

        [StringLength(2000)]
        public string DESCRIPTION { get; set; }

        public long TREATMENT_ID { get; set; }

        public long FILE_TYPE_ID { get; set; }

        public virtual HIS_FILE_TYPE HIS_FILE_TYPE { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }
    }
}
