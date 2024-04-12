namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_PATIENT_TYPE")]
    public partial class HIS_PATIENT_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_PATIENT_TYPE()
        {
            HIS_APPOINTMENT_SERV = new HashSet<HIS_APPOINTMENT_SERV>();
            HIS_AREA = new HashSet<HIS_AREA>();
            HIS_BED_LOG = new HashSet<HIS_BED_LOG>();
            HIS_BED_LOG1 = new HashSet<HIS_BED_LOG>();
            HIS_DEPARTMENT = new HashSet<HIS_DEPARTMENT>();
            HIS_EXME_REASON_CFG = new HashSet<HIS_EXME_REASON_CFG>();
            HIS_EXP_MEST_BLOOD = new HashSet<HIS_EXP_MEST_BLOOD>();
            HIS_EXP_MEST_BLTY_REQ = new HashSet<HIS_EXP_MEST_BLTY_REQ>();
            HIS_EXP_MEST_MATERIAL = new HashSet<HIS_EXP_MEST_MATERIAL>();
            HIS_EXP_MEST_MEDICINE = new HashSet<HIS_EXP_MEST_MEDICINE>();
            HIS_MATERIAL_PATY = new HashSet<HIS_MATERIAL_PATY>();
            HIS_MEDICINE_PATY = new HashSet<HIS_MEDICINE_PATY>();
            HIS_MEST_PATIENT_TYPE = new HashSet<HIS_MEST_PATIENT_TYPE>();
            HIS_MEST_PATY_TRTY = new HashSet<HIS_MEST_PATY_TRTY>();
            HIS_PATIENT_TYPE_ALLOW = new HashSet<HIS_PATIENT_TYPE_ALLOW>();
            HIS_PATIENT_TYPE_ALLOW1 = new HashSet<HIS_PATIENT_TYPE_ALLOW>();
            HIS_PATIENT_TYPE_ALTER = new HashSet<HIS_PATIENT_TYPE_ALTER>();
            HIS_PATIENT_TYPE_ALTER1 = new HashSet<HIS_PATIENT_TYPE_ALTER>();
            HIS_PATIENT_TYPE1 = new HashSet<HIS_PATIENT_TYPE>();
            HIS_PATIENT_TYPE_ROOM = new HashSet<HIS_PATIENT_TYPE_ROOM>();
            HIS_PATIENT_TYPE_SUB = new HashSet<HIS_PATIENT_TYPE_SUB>();
            HIS_RATION_SCHEDULE = new HashSet<HIS_RATION_SCHEDULE>();
            HIS_SERE_SERV = new HashSet<HIS_SERE_SERV>();
            HIS_SERE_SERV1 = new HashSet<HIS_SERE_SERV>();
            HIS_SERE_SERV_RATION = new HashSet<HIS_SERE_SERV_RATION>();
            HIS_SERE_SERV_RATION1 = new HashSet<HIS_SERE_SERV_RATION>();
            HIS_SERVICE_CHANGE_REQ = new HashSet<HIS_SERVICE_CHANGE_REQ>();
            HIS_SERVICE_CHANGE_REQ1 = new HashSet<HIS_SERVICE_CHANGE_REQ>();
            HIS_SERVICE = new HashSet<HIS_SERVICE>();
            HIS_SERVICE1 = new HashSet<HIS_SERVICE>();
            HIS_SERVICE_PATY = new HashSet<HIS_SERVICE_PATY>();
            HIS_VACCINATION_EXAM = new HashSet<HIS_VACCINATION_EXAM>();
            HIS_VACCINATION = new HashSet<HIS_VACCINATION>();
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
        [StringLength(6)]
        public string PATIENT_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string PATIENT_TYPE_NAME { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        public short? IS_COPAYMENT { get; set; }

        public short? PRIORITY { get; set; }

        public short? IS_NOT_USE_FOR_PATIENT { get; set; }

        public short? IS_NOT_USE_FOR_PAYMENT { get; set; }

        public short? IS_ADDITION { get; set; }

        public short? IS_SHOWING_OUT_STOCK_BY_DEF { get; set; }

        public short? IS_NOT_REQUIRE_FEE { get; set; }

        public short? IS_NOT_FOR_KIOSK { get; set; }

        public long? BASE_PATIENT_TYPE_ID { get; set; }

        [StringLength(200)]
        public string INHERIT_PATIENT_TYPE_IDS { get; set; }

        [StringLength(100)]
        public string OTHER_PAY_SOURCE_IDS { get; set; }

        public short? IS_CHECK_FEE_WHEN_ASSIGN { get; set; }

        public long? OTHER_PAY_SOURCE_ID { get; set; }

        public short? IS_CHECK_FEE_WHEN_PRES { get; set; }

        public short? IS_NOT_SERVICE_BILL { get; set; }

        public short? IS_NOT_CHECK_FEE_WHEN_EXP_PRES { get; set; }

        public short? IS_FOR_SALE_EXP { get; set; }

        public short? MUST_BE_GUARANTEED { get; set; }

        public short? IS_CHECK_FINISH_CLS_WHEN_PRES { get; set; }

        public short? IS_RATION { get; set; }

        public short? IS_ADDITION_REQUIRED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_APPOINTMENT_SERV> HIS_APPOINTMENT_SERV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_AREA> HIS_AREA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BED_LOG> HIS_BED_LOG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BED_LOG> HIS_BED_LOG1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DEPARTMENT> HIS_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXME_REASON_CFG> HIS_EXME_REASON_CFG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_BLOOD> HIS_EXP_MEST_BLOOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_BLTY_REQ> HIS_EXP_MEST_BLTY_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_MATERIAL> HIS_EXP_MEST_MATERIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_MEDICINE> HIS_EXP_MEST_MEDICINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MATERIAL_PATY> HIS_MATERIAL_PATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_PATY> HIS_MEDICINE_PATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PATIENT_TYPE> HIS_MEST_PATIENT_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_PATY_TRTY> HIS_MEST_PATY_TRTY { get; set; }

        public virtual HIS_OTHER_PAY_SOURCE HIS_OTHER_PAY_SOURCE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_TYPE_ALLOW> HIS_PATIENT_TYPE_ALLOW { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_TYPE_ALLOW> HIS_PATIENT_TYPE_ALLOW1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_TYPE_ALTER> HIS_PATIENT_TYPE_ALTER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_TYPE_ALTER> HIS_PATIENT_TYPE_ALTER1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_TYPE> HIS_PATIENT_TYPE1 { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_TYPE_ROOM> HIS_PATIENT_TYPE_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_TYPE_SUB> HIS_PATIENT_TYPE_SUB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_RATION_SCHEDULE> HIS_RATION_SCHEDULE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV> HIS_SERE_SERV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV> HIS_SERE_SERV1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_RATION> HIS_SERE_SERV_RATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_RATION> HIS_SERE_SERV_RATION1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_CHANGE_REQ> HIS_SERVICE_CHANGE_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_CHANGE_REQ> HIS_SERVICE_CHANGE_REQ1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE> HIS_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE> HIS_SERVICE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_PATY> HIS_SERVICE_PATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION_EXAM> HIS_VACCINATION_EXAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION> HIS_VACCINATION { get; set; }
    }
}
