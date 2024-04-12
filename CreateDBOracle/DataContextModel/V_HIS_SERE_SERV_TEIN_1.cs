namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_SERE_SERV_TEIN_1")]
    public partial class V_HIS_SERE_SERV_TEIN_1
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

        public long SERE_SERV_ID { get; set; }

        public long? TEST_INDEX_ID { get; set; }

        [StringLength(1000)]
        public string VALUE { get; set; }

        [StringLength(2)]
        public string RESULT_CODE { get; set; }

        [StringLength(200)]
        public string DESCRIPTION { get; set; }

        public long? TDL_TREATMENT_ID { get; set; }

        public long? MACHINE_ID { get; set; }

        [StringLength(50)]
        public string BACTERIUM_CODE { get; set; }

        [StringLength(200)]
        public string BACTERIUM_NAME { get; set; }

        [StringLength(500)]
        public string BACTERIUM_NOTE { get; set; }

        [StringLength(20)]
        public string BACTERIUM_AMOUNT { get; set; }

        [StringLength(20)]
        public string BACTERIUM_DENSITY { get; set; }

        [StringLength(50)]
        public string ANTIBIOTIC_RESISTANCE_CODE { get; set; }

        [StringLength(200)]
        public string ANTIBIOTIC_RESISTANCE_NAME { get; set; }

        [StringLength(10)]
        public string SRI_CODE { get; set; }

        [StringLength(500)]
        public string NOTE { get; set; }

        [StringLength(500)]
        public string LEAVEN { get; set; }

        public long? EXP_MEST_ID { get; set; }

        public long? TDL_SERVICE_REQ_ID { get; set; }

        [StringLength(1000)]
        public string OLD_VALUE { get; set; }

        [StringLength(1000)]
        public string RESULT_DESCRIPTION { get; set; }

        public long SERVICE_ID { get; set; }

        public long TDL_INTRUCTION_TIME { get; set; }
    }
}
