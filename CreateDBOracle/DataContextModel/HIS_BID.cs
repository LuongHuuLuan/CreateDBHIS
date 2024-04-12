namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_BID")]
    public partial class HIS_BID
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_BID()
        {
            HIS_ANTICIPATE_BLTY = new HashSet<HIS_ANTICIPATE_BLTY>();
            HIS_ANTICIPATE_MATY = new HashSet<HIS_ANTICIPATE_MATY>();
            HIS_ANTICIPATE_METY = new HashSet<HIS_ANTICIPATE_METY>();
            HIS_BID_BLOOD_TYPE = new HashSet<HIS_BID_BLOOD_TYPE>();
            HIS_BID_MATERIAL_TYPE = new HashSet<HIS_BID_MATERIAL_TYPE>();
            HIS_BID_MEDICINE_TYPE = new HashSet<HIS_BID_MEDICINE_TYPE>();
            HIS_BLOOD = new HashSet<HIS_BLOOD>();
            HIS_MATERIAL = new HashSet<HIS_MATERIAL>();
            HIS_MEDICAL_CONTRACT = new HashSet<HIS_MEDICAL_CONTRACT>();
            HIS_MEDICINE = new HashSet<HIS_MEDICINE>();
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
        [StringLength(30)]
        public string BID_NUMBER { get; set; }

        [Required]
        [StringLength(500)]
        public string BID_NAME { get; set; }

        public long? BID_TYPE_ID { get; set; }

        [StringLength(20)]
        public string BID_YEAR { get; set; }

        public long? VALID_FROM_TIME { get; set; }

        public long? VALID_TO_TIME { get; set; }

        [StringLength(4000)]
        public string ALLOW_UPDATE_LOGINNAMES { get; set; }

        public long? APPROVAL_TIME { get; set; }

        [StringLength(50)]
        public string APPROVAL_LOGINNAME { get; set; }

        [StringLength(100)]
        public string APPROVAL_USERNAME { get; set; }

        [StringLength(50)]
        public string BID_EXTRA_CODE { get; set; }

        public long? BID_FORM_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTICIPATE_BLTY> HIS_ANTICIPATE_BLTY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTICIPATE_MATY> HIS_ANTICIPATE_MATY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTICIPATE_METY> HIS_ANTICIPATE_METY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BID_BLOOD_TYPE> HIS_BID_BLOOD_TYPE { get; set; }

        public virtual HIS_BID_TYPE HIS_BID_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BID_MATERIAL_TYPE> HIS_BID_MATERIAL_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BID_MEDICINE_TYPE> HIS_BID_MEDICINE_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BLOOD> HIS_BLOOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MATERIAL> HIS_MATERIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICAL_CONTRACT> HIS_MEDICAL_CONTRACT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE> HIS_MEDICINE { get; set; }
    }
}
