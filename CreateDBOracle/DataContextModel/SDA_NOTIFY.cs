namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.SDA_NOTIFY")]
    public partial class SDA_NOTIFY
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

        [StringLength(20)]
        public string GROUP_CODE { get; set; }

        [Required]
        [StringLength(2000)]
        public string CONTENT { get; set; }

        public long FROM_TIME { get; set; }

        public long? TO_TIME { get; set; }

        [Required]
        [StringLength(200)]
        public string TITLE { get; set; }

        [StringLength(4000)]
        public string LOGIN_NAMES { get; set; }

        [StringLength(50)]
        public string RECEIVER_LOGINNAME { get; set; }

        [StringLength(4000)]
        public string RECEIVER_LOGINNAMES { get; set; }

        [StringLength(4000)]
        public string RECEIVER_DEPARTMENT_CODES { get; set; }
    }
}
