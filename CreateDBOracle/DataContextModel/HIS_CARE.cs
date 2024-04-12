namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_CARE")]
    public partial class HIS_CARE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_CARE()
        {
            HIS_CARE_DETAIL = new HashSet<HIS_CARE_DETAIL>();
            HIS_DHST1 = new HashSet<HIS_DHST>();
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

        public long TREATMENT_ID { get; set; }

        public long? CARE_SUM_ID { get; set; }

        public long? TRACKING_ID { get; set; }

        public long? DHST_ID { get; set; }

        public long? AWARENESS_ID { get; set; }

        public long? EXECUTE_ROOM_ID { get; set; }

        public long? EXECUTE_DEPARTMENT_ID { get; set; }

        public long? EXECUTE_TIME { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        [StringLength(200)]
        public string MUCOCUTANEOUS { get; set; }

        [StringLength(200)]
        public string URINE { get; set; }

        [StringLength(200)]
        public string DEJECTA { get; set; }

        [StringLength(200)]
        public string NUTRITION { get; set; }

        [StringLength(200)]
        public string SANITARY { get; set; }

        [StringLength(200)]
        public string TUTORIAL { get; set; }

        [StringLength(200)]
        public string EDUCATION { get; set; }

        [StringLength(100)]
        public string AWARENESS { get; set; }

        public short? HAS_TEST { get; set; }

        public short? HAS_MEDICINE { get; set; }

        public short? HAS_ADD_MEDICINE { get; set; }

        [StringLength(3000)]
        public string INSTRUCTION_DESCRIPTION { get; set; }

        [StringLength(3000)]
        public string CARE_DESCRIPTION { get; set; }

        public short? HAS_REHABILITATION { get; set; }

        public long? EXECUTE_DATE { get; set; }

        public short? ALLERGY_HISTORY { get; set; }

        public short? AWARENESS_CONDITION { get; set; }

        public short? BODY_CONDITION { get; set; }

        public decimal? HEIGHT { get; set; }

        public decimal? WEIGHT { get; set; }

        public short? MUCOCUTANEOUS_CONDITION { get; set; }

        public short? FUNCTION_CONDITION { get; set; }

        public short? SKIN_DAMAGE_CONDITION { get; set; }

        public long? PAIN_SCORE { get; set; }

        public short? CAN_ULCERS { get; set; }

        public short? RESPIRATORY_CONDITION { get; set; }

        public short? NEUROLOGICAL_CONDITION { get; set; }

        public short? DEFECATE_CONDITION { get; set; }

        public short? URINE_CONDITION { get; set; }

        public short? DIGEST_CONDITION { get; set; }

        public short? TUTORIAL_CONDITION { get; set; }

        public short? SANITARY_CONDITION { get; set; }

        public short? EDUCATION_CONDITION { get; set; }

        public short? HAS_TOPICAL_MEDICINE { get; set; }

        public short? HAS_DRINK_MEDICINE { get; set; }

        public short? HAS_INFUTION_MEDICINE { get; set; }

        public short? HAS_DIIM { get; set; }

        public short? HAS_FUEX { get; set; }

        public short? HAS_CHANGE_BANDAGE { get; set; }

        public short? HAS_CUT_SUTURE { get; set; }

        [StringLength(3000)]
        public string OTHER_CARE { get; set; }

        [StringLength(3000)]
        public string EVALUTE_CARE { get; set; }

        public virtual HIS_AWARENESS HIS_AWARENESS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CARE_DETAIL> HIS_CARE_DETAIL { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        public virtual HIS_DHST HIS_DHST { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_TRACKING HIS_TRACKING { get; set; }

        public virtual HIS_CARE_SUM HIS_CARE_SUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DHST> HIS_DHST1 { get; set; }
    }
}
