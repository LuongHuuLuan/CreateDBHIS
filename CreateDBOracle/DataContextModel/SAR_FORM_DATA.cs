namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SAR_FORM_DATA")]
    public partial class SAR_FORM_DATA
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

        public long FORM_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string KEY { get; set; }

        [Required]
        [StringLength(4000)]
        public string VALUE { get; set; }

        [StringLength(186)]
        public string VIR_UNIQUE { get; set; }

        public virtual SAR_FORM SAR_FORM { get; set; }
    }
}
