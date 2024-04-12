namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_TREATMENT_BORROW")]
    public partial class HIS_TREATMENT_BORROW
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

        public long TREATMENT_ID { get; set; }

        [StringLength(50)]
        public string BORROW_LOGINNAME { get; set; }

        [StringLength(100)]
        public string BORROW_USERNAME { get; set; }

        public long DEPARTMENT_ID { get; set; }

        public long? GIVE_TIME { get; set; }

        public long? GIVE_DATE { get; set; }

        [StringLength(50)]
        public string GIVER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string GIVER_USERNAME { get; set; }

        public long? RECEIVE_TIME { get; set; }

        public long? RECEIVE_DATE { get; set; }

        [StringLength(50)]
        public string RECEIVER_LOGINNAME { get; set; }

        [StringLength(100)]
        public string RECEIVER_USERNAME { get; set; }

        public long? APPOINTMENT_TIME { get; set; }

        public long? APPOINTMENT_DATE { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        public virtual HIS_TREATMENT HIS_TREATMENT { get; set; }
    }
}
