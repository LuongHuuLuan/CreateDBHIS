namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEDI_REACT")]
    public partial class V_HIS_MEDI_REACT
    {
        [Key]
        [Column(Order = 0)]
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

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MEDI_REACT_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        [Key]
        [Column(Order = 3)]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        [StringLength(100)]
        public string PACKAGE_NUMBER { get; set; }

        public long? EXPIRED_DATE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string MEDI_REACT_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string MEDI_REACT_TYPE_NAME { get; set; }

        public long? MEDICINE_TYPE_ID { get; set; }

        public long? BID_ID { get; set; }

        [StringLength(25)]
        public string MEDICINE_TYPE_CODE { get; set; }

        [StringLength(1000)]
        public string NATIONAL_NAME { get; set; }

        public long? SERVICE_ID { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        public long? SERVICE_UNIT_ID { get; set; }

        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }

        [StringLength(6)]
        public string MANUFACTURER_CODE { get; set; }

        [StringLength(1000)]
        public string MANUFACTURER_NAME { get; set; }
    }
}
