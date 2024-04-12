namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.ACS_AUTHEN_REQUEST")]
    public partial class ACS_AUTHEN_REQUEST
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

        public long AUTHOR_SYSTEM_ID { get; set; }

        public long? REQUEST_TIME { get; set; }

        public short? IS_ISSUED_TOKEN { get; set; }

        [StringLength(100)]
        public string REQUEST_USERNAME { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(20)]
        public string MOBILE { get; set; }

        [StringLength(50)]
        public string AUTHENTICATION_CODE { get; set; }

        [StringLength(500)]
        public string ADDITIONAL_INFO { get; set; }

        [StringLength(50)]
        public string TDL_AUTHOR_SYSTEM_CODE { get; set; }
    }
}
