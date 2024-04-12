namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_EQUIPMENT_SET_MATY")]
    public partial class V_HIS_EQUIPMENT_SET_MATY
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
        public long MATERIAL_TYPE_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal AMOUNT { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long EQUIPMENT_SET_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(25)]
        public string MATERIAL_TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(500)]
        public string MATERIAL_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_ID { get; set; }

        public long? NUM_ORDER { get; set; }

        public long? MANUFACTURER_ID { get; set; }

        [StringLength(100)]
        public string NATIONAL_NAME { get; set; }

        [StringLength(300)]
        public string PACKING_TYPE_NAME { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SERVICE_UNIT_ID { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(3)]
        public string SERVICE_UNIT_CODE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string SERVICE_UNIT_NAME { get; set; }
    }
}
