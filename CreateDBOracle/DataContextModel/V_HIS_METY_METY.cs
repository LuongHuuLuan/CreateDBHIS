namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_METY_METY")]
    public partial class V_HIS_METY_METY
    {
        [Key]
        [Column(Order = 0)]
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

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PREPARATION_MEDICINE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal PREPARATION_AMOUNT { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long METY_PRODUCT_ID { get; set; }

        public long? MEDICINE_TYPE_ID_BK { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MEDICINE_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal PRODUCT_AMOUNT { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(25)]
        public string MEDICINE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(500)]
        public string MEDICINE_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(25)]
        public string PREPARATION_MEDICINE_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(500)]
        public string PREPARATION_MEDICINE_TYPE_NAME { get; set; }
    }
}
