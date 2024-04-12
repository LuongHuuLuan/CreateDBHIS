namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.ACS_OTP")]
    public partial class ACS_OTP
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
        [StringLength(20)]
        public string OTP_CODE { get; set; }

        public short OTP_TYPE { get; set; }

        public long? EXPIRE_TIME { get; set; }

        [StringLength(50)]
        public string LOGINAME { get; set; }

        [StringLength(100)]
        public string USERNAME { get; set; }

        public long OTP_TYPE_ID { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(20)]
        public string MOBILE { get; set; }

        public decimal? VIR_EXPIRE_DATE { get; set; }

        public virtual ACS_OTP_TYPE ACS_OTP_TYPE { get; set; }
    }
}
