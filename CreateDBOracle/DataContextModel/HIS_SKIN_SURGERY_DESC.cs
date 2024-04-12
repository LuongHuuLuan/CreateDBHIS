namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SKIN_SURGERY_DESC")]
    public partial class HIS_SKIN_SURGERY_DESC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_SKIN_SURGERY_DESC()
        {
            HIS_SERE_SERV_PTTT = new HashSet<HIS_SERE_SERV_PTTT>();
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

        [StringLength(500)]
        public string DAMAGE { get; set; }

        [StringLength(500)]
        public string DAMAGE_POSITION { get; set; }

        public long? DAMAGE_AMOUNT { get; set; }

        public long? DAMAGE_TREAT_CUTTING_TYPE { get; set; }

        public long? DAMAGE_TREAT_SHAPING_TYPE { get; set; }

        public long? DAMAGE_TREAT_CLOSING_TYPE { get; set; }

        [StringLength(500)]
        public string DAMAGE_TREAT_OTHER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_PTTT> HIS_SERE_SERV_PTTT { get; set; }
    }
}
