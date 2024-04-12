namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_CARE_TEMP_DETAIL")]
    public partial class HIS_CARE_TEMP_DETAIL
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

        public long CARE_TEMP_ID { get; set; }

        public long CARE_TYPE_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string CONTENT { get; set; }

        public virtual HIS_CARE_TEMP HIS_CARE_TEMP { get; set; }

        public virtual HIS_CARE_TYPE HIS_CARE_TYPE { get; set; }
    }
}
