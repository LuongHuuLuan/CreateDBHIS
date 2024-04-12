namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_REHA_TRAIN_TYPE")]
    public partial class HIS_REHA_TRAIN_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_REHA_TRAIN_TYPE()
        {
            HIS_REST_RETR_TYPE = new HashSet<HIS_REST_RETR_TYPE>();
            HIS_SERE_SERV_REHA = new HashSet<HIS_SERE_SERV_REHA>();
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
        public string REHA_TRAIN_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string REHA_TRAIN_TYPE_NAME { get; set; }

        public long REHA_TRAIN_UNIT_ID { get; set; }

        public virtual HIS_REHA_TRAIN_UNIT HIS_REHA_TRAIN_UNIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_REST_RETR_TYPE> HIS_REST_RETR_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_REHA> HIS_SERE_SERV_REHA { get; set; }
    }
}
