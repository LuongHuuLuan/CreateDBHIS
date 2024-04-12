namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_MEDI_REACT")]
    public partial class HIS_MEDI_REACT
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

        public long MEDI_REACT_TYPE_ID { get; set; }

        public long MEDI_REACT_SUM_ID { get; set; }

        public long? MEDICINE_ID { get; set; }

        [StringLength(50)]
        public string REQUEST_LOGINNAME { get; set; }

        [StringLength(100)]
        public string REQUEST_USERNAME { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        public long? EXECUTE_TIME { get; set; }

        [StringLength(50)]
        public string CHECK_LOGINNAME { get; set; }

        [StringLength(100)]
        public string CHECK_USERNAME { get; set; }

        public long? CHECK_TIME { get; set; }

        [StringLength(2000)]
        public string CHECK_RESULT { get; set; }

        [Required]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public long? EXPIRED_DATE { get; set; }

        public virtual HIS_MEDI_REACT_TYPE HIS_MEDI_REACT_TYPE { get; set; }

        public virtual HIS_MEDICINE HIS_MEDICINE { get; set; }

        public virtual HIS_MEDI_REACT_SUM HIS_MEDI_REACT_SUM { get; set; }
    }
}
