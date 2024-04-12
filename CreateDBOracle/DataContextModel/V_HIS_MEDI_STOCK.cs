namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.V_HIS_MEDI_STOCK")]
    public partial class V_HIS_MEDI_STOCK
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
        [StringLength(20)]
        public string MEDI_STOCK_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string MEDI_STOCK_NAME { get; set; }

        public long ROOM_ID { get; set; }

        public long? PARENT_ID { get; set; }

        [StringLength(200)]
        public string BHYT_HEAD_CODE { get; set; }

        [StringLength(200)]
        public string NOT_IN_BHYT_HEAD_CODE { get; set; }

        public short? IS_ALLOW_IMP_SUPPLIER { get; set; }

        public short? IS_CABINET { get; set; }

        public short? IS_BUSINESS { get; set; }

        public short? IS_AUTO_CREATE_CHMS_IMP { get; set; }

        public short? IS_GOODS_RESTRICT { get; set; }

        public short? IS_ODD { get; set; }

        public short? IS_BLOOD { get; set; }

        public short? IS_SHOW_DDT { get; set; }

        public short? IS_NEW_MEDICINE { get; set; }

        public short? IS_TRADITIONAL_MEDICINE { get; set; }

        public short? IS_PLANNING_TRANS_AS_DEFAULT { get; set; }

        public short? CABINET_MANAGE_OPTION { get; set; }

        public short? IS_SHOW_INPATIENT_RETURN_PRES { get; set; }

        public short? IS_DRUG_STORE { get; set; }

        public short? IS_FOR_REJECTED_MOBA { get; set; }

        public short? IS_MOBA_CHANGE_AMOUNT { get; set; }

        [StringLength(200)]
        public string PATIENT_CLASSIFY_IDS { get; set; }

        public short? IS_SHOW_DRUG_STORE { get; set; }

        public short? IS_EXPEND { get; set; }

        public short? IS_AUTO_CREATE_REUSABLE_IMP { get; set; }

        public short? DO_NOT_IMP_MEDICINE { get; set; }

        public short? DO_NOT_IMP_MATERIAL { get; set; }

        public long DEPARTMENT_ID { get; set; }

        public long ROOM_TYPE_ID { get; set; }

        public short? IS_PAUSE { get; set; }

        [Required]
        [StringLength(2)]
        public string ROOM_TYPE_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string ROOM_TYPE_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string DEPARTMENT_CODE { get; set; }

        [Required]
        [StringLength(100)]
        public string DEPARTMENT_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string G_CODE { get; set; }

        [StringLength(20)]
        public string PARENT_CODE { get; set; }

        [StringLength(100)]
        public string PARENT_NAME { get; set; }
    }
}
