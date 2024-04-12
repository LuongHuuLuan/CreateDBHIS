namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_CONTACT_POINT")]
    public partial class V_HIS_CONTACT_POINT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [StringLength(50)]
        public string CREATOR { get; set; }

        public long? CREATE_TIME { get; set; }

        [StringLength(50)]
        public string MODIFIER { get; set; }

        public long? MODIFY_TIME { get; set; }

        public long? CONTACT_LEVEL { get; set; }

        public long? PATIENT_ID { get; set; }

        public long? EMPLOYEE_ID { get; set; }

        public long CONTACT_TYPE { get; set; }

        [StringLength(4000)]
        public string NOTE { get; set; }

        public short? TEST_RESULT_1 { get; set; }

        public short? TEST_RESULT_2 { get; set; }

        public short? TEST_RESULT_3 { get; set; }

        [StringLength(500)]
        public string CONTACT_POINT_OTHER_TYPE_NAME { get; set; }

        [StringLength(30)]
        public string FIRST_NAME { get; set; }

        [StringLength(70)]
        public string LAST_NAME { get; set; }

        [StringLength(101)]
        public string FULL_NAME { get; set; }

        public long? GENDER_ID { get; set; }

        public decimal? DOB { get; set; }

        [StringLength(506)]
        public string VIR_ADDRESS { get; set; }

        [StringLength(12)]
        public string PHONE { get; set; }

        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        public decimal? DEPARTMENT_ID { get; set; }

        [StringLength(10)]
        public string PATIENT_CODE { get; set; }

        [StringLength(50)]
        public string LOGINNAME { get; set; }
    }
}
