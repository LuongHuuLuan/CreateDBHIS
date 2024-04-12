namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERE_SERV_RATION")]
    public partial class HIS_SERE_SERV_RATION
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

        public long SERVICE_ID { get; set; }

        public long SERVICE_REQ_ID { get; set; }

        public long PATIENT_TYPE_ID { get; set; }

        public decimal AMOUNT { get; set; }

        public decimal PRICE { get; set; }

        public decimal? DISCOUNT { get; set; }

        public decimal? VAT_RATIO { get; set; }

        [StringLength(500)]
        public string INSTRUCTION_NOTE { get; set; }

        public long? OTHER_PAY_SOURCE_ID { get; set; }

        public long? PRIMARY_PATIENT_TYPE_ID { get; set; }

        public decimal? ACTUAL_PRICE { get; set; }

        public virtual HIS_OTHER_PAY_SOURCE HIS_OTHER_PAY_SOURCE { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE { get; set; }

        public virtual HIS_PATIENT_TYPE HIS_PATIENT_TYPE1 { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }

        public virtual HIS_SERVICE_REQ HIS_SERVICE_REQ { get; set; }
    }
}
