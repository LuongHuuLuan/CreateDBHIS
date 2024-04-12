namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_BLOOD_ABO")]
    public partial class HIS_BLOOD_ABO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_BLOOD_ABO()
        {
            HIS_BLOOD = new HashSet<HIS_BLOOD>();
            HIS_BLOOD_GIVER = new HashSet<HIS_BLOOD_GIVER>();
            HIS_EXP_MEST_BLTY_REQ = new HashSet<HIS_EXP_MEST_BLTY_REQ>();
            HIS_SERE_SERV_PTTT = new HashSet<HIS_SERE_SERV_PTTT>();
            HIS_SERE_SERV_PTTT_TEMP = new HashSet<HIS_SERE_SERV_PTTT_TEMP>();
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
        [StringLength(2)]
        public string BLOOD_ABO_CODE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BLOOD> HIS_BLOOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BLOOD_GIVER> HIS_BLOOD_GIVER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST_BLTY_REQ> HIS_EXP_MEST_BLTY_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_PTTT> HIS_SERE_SERV_PTTT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_PTTT_TEMP> HIS_SERE_SERV_PTTT_TEMP { get; set; }
    }
}
