namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_TEST_INDEX")]
    public partial class V_HIS_TEST_INDEX
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
        public string TEST_INDEX_CODE { get; set; }

        [Required]
        [StringLength(300)]
        public string TEST_INDEX_NAME { get; set; }

        public long TEST_SERVICE_TYPE_ID { get; set; }

        public long? TEST_INDEX_UNIT_ID { get; set; }

        public long? NUM_ORDER { get; set; }

        [StringLength(100)]
        public string DEFAULT_VALUE { get; set; }

        [StringLength(20)]
        public string BHYT_CODE { get; set; }

        [StringLength(300)]
        public string BHYT_NAME { get; set; }

        public short? IS_NOT_SHOW_SERVICE { get; set; }

        public short? IS_IMPORTANT { get; set; }

        public long? TEST_INDEX_GROUP_ID { get; set; }

        public short? IS_TO_CALCULATE_EGFR { get; set; }

        public decimal? NORMATION_AMOUNT { get; set; }

        public long? MATERIAL_TYPE_ID { get; set; }

        public short? IS_BLOOD_ABO { get; set; }

        public short? IS_BLOOD_RH { get; set; }

        public short? IS_HBSAG { get; set; }

        public short? IS_HCV { get; set; }

        public short? IS_HIV { get; set; }

        public short? IS_TEST_HARMONY_BLOOD { get; set; }

        public decimal? CONVERT_RATIO_MLCT { get; set; }

        [StringLength(500)]
        public string RESULT_BLOOD_A { get; set; }

        [StringLength(500)]
        public string RESULT_BLOOD_B { get; set; }

        [StringLength(500)]
        public string RESULT_BLOOD_AB { get; set; }

        [StringLength(500)]
        public string RESULT_BLOOD_O { get; set; }

        [StringLength(500)]
        public string RESULT_BLOOD_RH_PLUS { get; set; }

        [StringLength(500)]
        public string RESULT_BLOOD_RH_MINUS { get; set; }

        [StringLength(2)]
        public string TEST_INDEX_UNIT_CODE { get; set; }

        [StringLength(100)]
        public string TEST_INDEX_UNIT_NAME { get; set; }

        [StringLength(20)]
        public string TEST_INDEX_UNIT_SYMBOL { get; set; }

        [Required]
        [StringLength(25)]
        public string SERVICE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string SERVICE_NAME { get; set; }

        [StringLength(6)]
        public string TEST_INDEX_GROUP_CODE { get; set; }

        [StringLength(100)]
        public string TEST_INDEX_GROUP_NAME { get; set; }

        [StringLength(25)]
        public string MATERIAL_TYPE_CODE { get; set; }

        [StringLength(500)]
        public string MATERIAL_TYPE_NAME { get; set; }

        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }
    }
}
