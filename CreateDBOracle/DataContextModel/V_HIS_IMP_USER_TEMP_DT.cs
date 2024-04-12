namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_IMP_USER_TEMP_DT")]
    public partial class V_HIS_IMP_USER_TEMP_DT
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
        public long IMP_USER_TEMP_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string LOGINNAME { get; set; }

        [StringLength(100)]
        public string USERNAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EXECUTE_ROLE_ID { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string EXECUTE_ROLE_CODE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(200)]
        public string EXECUTE_ROLE_NAME { get; set; }
    }
}
