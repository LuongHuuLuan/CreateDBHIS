namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.ACS_TOKEN")]
    public partial class ACS_TOKEN
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
        [StringLength(2500)]
        public string TOKEN_CODE { get; set; }

        [Required]
        [StringLength(200)]
        public string RENEW_CODE { get; set; }

        public long EXPIRE_TIME { get; set; }

        [StringLength(20)]
        public string APP_VERSION { get; set; }

        [StringLength(1000)]
        public string MACHINE_NAME { get; set; }

        public long? LAST_ACCESS_TIME { get; set; }

        public long LOGIN_TIME { get; set; }

        [Required]
        [StringLength(20)]
        public string LOGIN_ADDRESS { get; set; }

        [Required]
        [StringLength(50)]
        public string LOGIN_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string USER_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string APPLICATION_CODE { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(20)]
        public string MOBILE { get; set; }

        [StringLength(50)]
        public string AUTHENTICATION_CODE { get; set; }

        [StringLength(50)]
        public string AUTHOR_SYSTEM_CODE { get; set; }
    }
}
