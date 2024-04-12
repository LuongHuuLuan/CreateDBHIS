namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_DHST")]
    public partial class HIS_DHST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_DHST()
        {
            HIS_ANTIBIOTIC_REQUEST = new HashSet<HIS_ANTIBIOTIC_REQUEST>();
            HIS_CARE = new HashSet<HIS_CARE>();
            HIS_KSK_GENERAL = new HashSet<HIS_KSK_GENERAL>();
            HIS_KSK_OCCUPATIONAL = new HashSet<HIS_KSK_OCCUPATIONAL>();
            HIS_SERVICE_REQ = new HashSet<HIS_SERVICE_REQ>();
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

        public long? DHST_SUM_ID { get; set; }

        public long? TRACKING_ID { get; set; }

        public long? CARE_ID { get; set; }

        public long? EXECUTE_ROOM_ID { get; set; }

        public long? EXECUTE_DEPARTMENT_ID { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        public long? EXECUTE_TIME { get; set; }

        public decimal? TEMPERATURE { get; set; }

        public decimal? BREATH_RATE { get; set; }

        public decimal? WEIGHT { get; set; }

        public decimal? HEIGHT { get; set; }

        public decimal? CHEST { get; set; }

        public decimal? BELLY { get; set; }

        public long? BLOOD_PRESSURE_MAX { get; set; }

        public long? BLOOD_PRESSURE_MIN { get; set; }

        public long? PULSE { get; set; }

        public decimal? VIR_BMI { get; set; }

        public decimal? VIR_BODY_SURFACE_AREA { get; set; }

        public decimal? SPO2 { get; set; }

        public decimal? CAPILLARY_BLOOD_GLUCOSE { get; set; }

        [StringLength(4000)]
        public string NOTE { get; set; }

        public short? INFUTION_INTO { get; set; }

        public short? INFUTION_OUT { get; set; }

        public long? VACCINATION_EXAM_ID { get; set; }

        public decimal? URINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTIBIOTIC_REQUEST> HIS_ANTIBIOTIC_REQUEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CARE> HIS_CARE { get; set; }

        public virtual HIS_CARE HIS_CARE1 { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        public virtual HIS_VACCINATION_EXAM HIS_VACCINATION_EXAM { get; set; }

        public virtual HIS_TRACKING HIS_TRACKING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_GENERAL> HIS_KSK_GENERAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_OCCUPATIONAL> HIS_KSK_OCCUPATIONAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ> HIS_SERVICE_REQ { get; set; }
    }
}
