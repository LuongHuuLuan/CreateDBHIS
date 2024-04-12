namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_ALERT")]
    public partial class HIS_ALERT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_ALERT()
        {
            HIS_REJECT_ALERT = new HashSet<HIS_REJECT_ALERT>();
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

        public long ROOM_ID { get; set; }

        public long DEPARTMENT_ID { get; set; }

        [StringLength(200)]
        public string TITLE { get; set; }

        [StringLength(4000)]
        public string CONTENT { get; set; }

        [Required]
        [StringLength(1000)]
        public string RECEIVE_DEPARTMENT_IDS { get; set; }

        [StringLength(50)]
        public string RECEIVER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string RECEIVER_USERNAME { get; set; }

        public long? RECEIVE_TIME { get; set; }

        public virtual HIS_ROOM HIS_ROOM { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_REJECT_ALERT> HIS_REJECT_ALERT { get; set; }
    }
}
