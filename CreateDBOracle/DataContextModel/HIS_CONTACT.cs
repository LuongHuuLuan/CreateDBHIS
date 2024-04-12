namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_CONTACT")]
    public partial class HIS_CONTACT
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

        public long CONTACT_TIME { get; set; }

        public long CONTACT_POINT1_ID { get; set; }

        public long CONTACT_POINT2_ID { get; set; }

        [StringLength(1000)]
        public string CONTACT_PLACE { get; set; }

        public virtual HIS_CONTACT_POINT HIS_CONTACT_POINT { get; set; }

        public virtual HIS_CONTACT_POINT HIS_CONTACT_POINT1 { get; set; }
    }
}
