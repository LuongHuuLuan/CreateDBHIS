namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.TYT_GDSK")]
    public partial class TYT_GDSK
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
        [StringLength(6)]
        public string BRANCH_CODE { get; set; }

        public long? GDSK_TIME { get; set; }

        [StringLength(100)]
        public string GDSK_PLACE { get; set; }

        [StringLength(2000)]
        public string CONTENT { get; set; }

        [StringLength(500)]
        public string FORM { get; set; }

        [StringLength(500)]
        public string TARGET { get; set; }

        public long? AUDIENCE_COUNT { get; set; }

        [StringLength(500)]
        public string MEDIA { get; set; }

        [StringLength(500)]
        public string AMOUNT_OF_TIME { get; set; }

        [StringLength(100)]
        public string EXECUTE_NAME { get; set; }

        [StringLength(100)]
        public string NOTE { get; set; }
    }
}
