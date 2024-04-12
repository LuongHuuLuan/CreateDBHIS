namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_EMPLOYEE")]
    public partial class V_HIS_EMPLOYEE
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
        [StringLength(50)]
        public string LOGINNAME { get; set; }

        [StringLength(50)]
        public string DIPLOMA { get; set; }

        public short? IS_DOCTOR { get; set; }

        public short? IS_ADMIN { get; set; }

        public long? MEDICINE_TYPE_RANK { get; set; }

        public long? MAX_BHYT_SERVICE_REQ_PER_DAY { get; set; }

        [StringLength(50)]
        public string ACCOUNT_NUMBER { get; set; }

        [StringLength(200)]
        public string BANK { get; set; }

        public long? DEPARTMENT_ID { get; set; }

        [StringLength(100)]
        public string DEFAULT_MEDI_STOCK_IDS { get; set; }

        public short? ALLOW_UPDATE_OTHER_SCLINICAL { get; set; }

        public short? IS_NURSE { get; set; }

        [StringLength(100)]
        public string ERX_LOGINNAME { get; set; }

        [StringLength(400)]
        public string ERX_PASSWORD { get; set; }

        public long? DOB { get; set; }

        [StringLength(100)]
        public string TITLE { get; set; }

        public long? MAX_SERVICE_REQ_PER_DAY { get; set; }

        public short? IS_SERVICE_REQ_EXAM { get; set; }

        [StringLength(100)]
        public string TDL_USERNAME { get; set; }

        [StringLength(100)]
        public string TDL_EMAIL { get; set; }

        [StringLength(20)]
        public string TDL_MOBILE { get; set; }

        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }
    }
}
