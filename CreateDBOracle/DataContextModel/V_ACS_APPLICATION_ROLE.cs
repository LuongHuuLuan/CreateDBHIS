namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_ACS_APPLICATION_ROLE")]
    public partial class V_ACS_APPLICATION_ROLE
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

        public long APPLICATION_ID { get; set; }

        public long ROLE_ID { get; set; }

        [Required]
        [StringLength(3)]
        public string APPLICATION_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string APPLICATION_NAME { get; set; }

        [Required]
        [StringLength(8)]
        public string ROLE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string ROLE_NAME { get; set; }
    }
}
