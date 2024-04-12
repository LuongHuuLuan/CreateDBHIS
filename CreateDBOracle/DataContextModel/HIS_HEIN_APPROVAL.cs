namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_HEIN_APPROVAL")]
    public partial class HIS_HEIN_APPROVAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_HEIN_APPROVAL()
        {
            HIS_SERE_SERV = new HashSet<HIS_SERE_SERV>();
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
        [StringLength(12)]
        public string HEIN_APPROVAL_CODE { get; set; }

        public long TREATMENT_ID { get; set; }

        public long TREATMENT_TYPE_ID { get; set; }

        public long CASHIER_ROOM_ID { get; set; }

        [StringLength(50)]
        public string EXECUTE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string EXECUTE_USERNAME { get; set; }

        public long? EXECUTE_TIME { get; set; }

        [StringLength(1000)]
        public string XML_URL { get; set; }

        [Required]
        [StringLength(2)]
        public string LEVEL_CODE { get; set; }

        [Required]
        [StringLength(2)]
        public string RIGHT_ROUTE_CODE { get; set; }

        [StringLength(2)]
        public string RIGHT_ROUTE_TYPE_CODE { get; set; }

        [StringLength(2)]
        public string LIVE_AREA_CODE { get; set; }

        [Required]
        [StringLength(6)]
        public string HEIN_MEDI_ORG_CODE { get; set; }

        [StringLength(500)]
        public string HEIN_MEDI_ORG_NAME { get; set; }

        [StringLength(2)]
        public string HAS_BIRTH_CERTIFICATE { get; set; }

        [Required]
        [StringLength(15)]
        public string HEIN_CARD_NUMBER { get; set; }

        public long HEIN_CARD_FROM_TIME { get; set; }

        public long HEIN_CARD_TO_TIME { get; set; }

        [Required]
        [StringLength(500)]
        public string ADDRESS { get; set; }

        [StringLength(2)]
        public string JOIN_5_YEAR { get; set; }

        [StringLength(2)]
        public string PAID_6_MONTH { get; set; }

        public long? FREE_CO_PAID_TIME { get; set; }

        public long? JOIN_5_YEAR_TIME { get; set; }

        public virtual HIS_CASHIER_ROOM HIS_CASHIER_ROOM { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }

        public virtual HIS_TREATMENT_TYPE HIS_TREATMENT_TYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV> HIS_SERE_SERV { get; set; }
    }
}
