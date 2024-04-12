namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_REGISTER_REQ")]
    public partial class HIS_REGISTER_REQ
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

        public long REGISTER_GATE_ID { get; set; }

        public long REGISTER_TIME { get; set; }

        public long NUM_ORDER { get; set; }

        public long? PATIENT_ID { get; set; }

        [StringLength(50)]
        public string CARD_CODE { get; set; }

        [StringLength(40)]
        public string SERVICE_CODE { get; set; }

        public short? IS_UPDATE_FROM { get; set; }

        public long? REGISTER_DATE { get; set; }

        public long? CALL_TIME { get; set; }

        [StringLength(50)]
        public string CALL_PLACE { get; set; }

        public long? VIR_CALL_DATE { get; set; }

        public virtual HIS_PATIENT HIS_PATIENT { get; set; }

        public virtual HIS_REGISTER_GATE HIS_REGISTER_GATE { get; set; }
    }
}
