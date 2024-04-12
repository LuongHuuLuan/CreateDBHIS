namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_VACC_APPOINTMENT")]
    public partial class V_HIS_VACC_APPOINTMENT
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

        public long VACCINATION_EXAM_ID { get; set; }

        public long VACCINE_TYPE_ID { get; set; }

        public long? VACCINE_TURN { get; set; }

        [Required]
        [StringLength(20)]
        public string VACCINE_TYPE_CODE { get; set; }

        [Required]
        [StringLength(500)]
        public string VACCINE_TYPE_NAME { get; set; }
    }
}
