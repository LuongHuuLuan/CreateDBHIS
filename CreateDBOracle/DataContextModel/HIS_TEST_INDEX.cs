namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_TEST_INDEX")]
    public partial class HIS_TEST_INDEX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_TEST_INDEX()
        {
            HIS_SERE_SERV_TEIN = new HashSet<HIS_SERE_SERV_TEIN>();
            HIS_TEST_INDEX_RANGE = new HashSet<HIS_TEST_INDEX_RANGE>();
        }

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

        public virtual HIS_MATERIAL_TYPE HIS_MATERIAL_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_TEIN> HIS_SERE_SERV_TEIN { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }

        public virtual HIS_TEST_INDEX_UNIT HIS_TEST_INDEX_UNIT { get; set; }

        public virtual HIS_TEST_INDEX_GROUP HIS_TEST_INDEX_GROUP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TEST_INDEX_RANGE> HIS_TEST_INDEX_RANGE { get; set; }
    }
}
