namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_SERE_SERV_EXT")]
    public partial class HIS_SERE_SERV_EXT
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

        public long SERE_SERV_ID { get; set; }

        [StringLength(4000)]
        public string CONCLUDE { get; set; }

        [StringLength(3000)]
        public string NOTE { get; set; }

        [StringLength(200)]
        public string JSON_PRINT_ID { get; set; }

        [StringLength(20)]
        public string DESCRIPTION_SAR_PRINT_ID { get; set; }

        [StringLength(500)]
        public string BED_CODE_LIST { get; set; }

        [StringLength(100)]
        public string MACHINE_CODE { get; set; }

        public long? MACHINE_ID { get; set; }

        public long? NUMBER_OF_FILM { get; set; }

        public long? BEGIN_TIME { get; set; }

        public long? END_TIME { get; set; }

        public long? TDL_SERVICE_REQ_ID { get; set; }

        public long? TDL_TREATMENT_ID { get; set; }

        [StringLength(3000)]
        public string INSTRUCTION_NOTE { get; set; }

        [StringLength(200)]
        public string JSON_FORM_ID { get; set; }

        public short? IS_GATHER_DATA { get; set; }

        public short? IS_FEE { get; set; }

        [StringLength(100)]
        public string DOC_PROTECTED_LOCATION { get; set; }

        public long? FILM_SIZE_ID { get; set; }

        public long? BED_LOG_ID { get; set; }

        [StringLength(2)]
        public string BACTERIAL_CULTIVATION_RESULT { get; set; }

        public long? NUMBER_OF_FAIL_FILM { get; set; }

        [StringLength(100)]
        public string SUBCLINICAL_PRES_USERNAME { get; set; }

        [StringLength(50)]
        public string SUBCLINICAL_PRES_LOGINNAME { get; set; }

        [StringLength(100)]
        public string SUBCLINICAL_RESULT_USERNAME { get; set; }

        [StringLength(50)]
        public string SUBCLINICAL_RESULT_LOGINNAME { get; set; }

        [StringLength(2000)]
        public string MICROCOPY_RESULT { get; set; }

        [StringLength(50)]
        public string IMPLANTION_RESULT { get; set; }

        [StringLength(100)]
        public string SUBCLINICAL_NURSE_USERNAME { get; set; }

        [StringLength(50)]
        public string SUBCLINICAL_NURSE_LOGINNAME { get; set; }

        [StringLength(20)]
        public string XML_DESCRIPTION_LOCATION { get; set; }

        public long? SAMPLE_TIME { get; set; }

        public long? SUBCLINICAL_PRES_ID { get; set; }

        [StringLength(4000)]
        public string DESCRIPTION_BK { get; set; }

        public string DESCRIPTION { get; set; }

        public virtual HIS_BED_LOG HIS_BED_LOG { get; set; }

        public virtual HIS_FILM_SIZE HIS_FILM_SIZE { get; set; }

        public virtual HIS_MACHINE HIS_MACHINE { get; set; }

        public virtual HIS_SERVICE_REQ HIS_SERVICE_REQ { get; set; }
    }
}
