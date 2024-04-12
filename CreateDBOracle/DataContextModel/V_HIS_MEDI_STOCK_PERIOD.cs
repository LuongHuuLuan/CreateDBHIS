namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEDI_STOCK_PERIOD")]
    public partial class V_HIS_MEDI_STOCK_PERIOD
    {
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
        [StringLength(100)]
        public string MEDI_STOCK_PERIOD_NAME { get; set; }

        public long MEDI_STOCK_ID { get; set; }

        public long? PREVIOUS_ID { get; set; }

        public long? COUNT_MEDICINE_TYPE { get; set; }

        public long? COUNT_MATERIAL_TYPE { get; set; }

        public long? COUNT_IMP_MEST { get; set; }

        public long? COUNT_EXP_MEST { get; set; }

        public long? TO_TIME { get; set; }

        public short? IS_APPROVE { get; set; }

        public short? IS_AUTO_PERIOD { get; set; }

        [Required]
        [StringLength(20)]
        public string MEDI_STOCK_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string MEDI_STOCK_NAME { get; set; }
    }
}
