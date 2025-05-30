namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_ROOM")]
    public partial class HIS_ROOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_ROOM()
        {
            HIS_ACCIDENT_HURT = new HashSet<HIS_ACCIDENT_HURT>();
            HIS_ALERT = new HashSet<HIS_ALERT>();
            HIS_ANTICIPATE = new HashSet<HIS_ANTICIPATE>();
            HIS_BED_ROOM = new HashSet<HIS_BED_ROOM>();
            HIS_CARE = new HashSet<HIS_CARE>();
            HIS_CASHIER_ADD_CONFIG = new HashSet<HIS_CASHIER_ADD_CONFIG>();
            HIS_CASHIER_ADD_CONFIG1 = new HashSet<HIS_CASHIER_ADD_CONFIG>();
            HIS_CASHIER_ROOM = new HashSet<HIS_CASHIER_ROOM>();
            HIS_DATA_STORE = new HashSet<HIS_DATA_STORE>();
            HIS_DATA_STORE1 = new HashSet<HIS_DATA_STORE>();
            HIS_DESK = new HashSet<HIS_DESK>();
            HIS_DHST = new HashSet<HIS_DHST>();
            HIS_EMR_COVER_CONFIG = new HashSet<HIS_EMR_COVER_CONFIG>();
            HIS_EXAM_SCHEDULE = new HashSet<HIS_EXAM_SCHEDULE>();
            HIS_EXECUTE_ROOM = new HashSet<HIS_EXECUTE_ROOM>();
            HIS_EXP_MEST = new HashSet<HIS_EXP_MEST>();
            HIS_EXRO_ROOM = new HashSet<HIS_EXRO_ROOM>();
            HIS_HOLD_RETURN = new HashSet<HIS_HOLD_RETURN>();
            HIS_HOLD_RETURN1 = new HashSet<HIS_HOLD_RETURN>();
            HIS_HOLD_RETURN2 = new HashSet<HIS_HOLD_RETURN>();
            HIS_HORE_HANDOVER = new HashSet<HIS_HORE_HANDOVER>();
            HIS_HORE_HANDOVER1 = new HashSet<HIS_HORE_HANDOVER>();
            HIS_IMP_MEST = new HashSet<HIS_IMP_MEST>();
            HIS_IMP_MEST_PROPOSE = new HashSet<HIS_IMP_MEST_PROPOSE>();
            HIS_INFUSION_SUM = new HashSet<HIS_INFUSION_SUM>();
            HIS_KSK_SERVICE = new HashSet<HIS_KSK_SERVICE>();
            HIS_MACHINE = new HashSet<HIS_MACHINE>();
            HIS_MEDI_REACT_SUM = new HashSet<HIS_MEDI_REACT_SUM>();
            HIS_MEDI_RECORD = new HashSet<HIS_MEDI_RECORD>();
            HIS_MEDI_STOCK = new HashSet<HIS_MEDI_STOCK>();
            HIS_MEDICINE_TYPE_ROOM = new HashSet<HIS_MEDICINE_TYPE_ROOM>();
            HIS_MEST_ROOM = new HashSet<HIS_MEST_ROOM>();
            HIS_PATIENT = new HashSet<HIS_PATIENT>();
            HIS_PATIENT_TYPE_ROOM = new HashSet<HIS_PATIENT_TYPE_ROOM>();
            HIS_RATION_SUM = new HashSet<HIS_RATION_SUM>();
            HIS_RECEPTION_ROOM = new HashSet<HIS_RECEPTION_ROOM>();
            HIS_REFECTORY = new HashSet<HIS_REFECTORY>();
            HIS_ROOM_SARO = new HashSet<HIS_ROOM_SARO>();
            HIS_ROOM_TIME = new HashSet<HIS_ROOM_TIME>();
            HIS_SAMPLE_ROOM = new HashSet<HIS_SAMPLE_ROOM>();
            HIS_SERE_SERV_TEMP = new HashSet<HIS_SERE_SERV_TEMP>();
            HIS_SERV_SEGR = new HashSet<HIS_SERV_SEGR>();
            HIS_SERVICE_NUM_ORDER = new HashSet<HIS_SERVICE_NUM_ORDER>();
            HIS_SERVICE_REQ = new HashSet<HIS_SERVICE_REQ>();
            HIS_SERVICE_REQ1 = new HashSet<HIS_SERVICE_REQ>();
            HIS_SERVICE_ROOM = new HashSet<HIS_SERVICE_ROOM>();
            HIS_STATION = new HashSet<HIS_STATION>();
            HIS_SUBCLINICAL_RS_ADD = new HashSet<HIS_SUBCLINICAL_RS_ADD>();
            HIS_SUBCLINICAL_RS_ADD1 = new HashSet<HIS_SUBCLINICAL_RS_ADD>();
            HIS_SUBCLINICAL_RS_ADD2 = new HashSet<HIS_SUBCLINICAL_RS_ADD>();
            HIS_TRACKING = new HashSet<HIS_TRACKING>();
            HIS_TRANSACTION = new HashSet<HIS_TRANSACTION>();
            HIS_TRANSFUSION_SUM = new HashSet<HIS_TRANSFUSION_SUM>();
            HIS_TREATMENT = new HashSet<HIS_TREATMENT>();
            HIS_TREATMENT1 = new HashSet<HIS_TREATMENT>();
            HIS_TREATMENT2 = new HashSet<HIS_TREATMENT>();
            HIS_USER_ROOM = new HashSet<HIS_USER_ROOM>();
            HIS_VACCINATION_EXAM = new HashSet<HIS_VACCINATION_EXAM>();
            HIS_VACCINATION_EXAM1 = new HashSet<HIS_VACCINATION_EXAM>();
            HIS_VACCINATION = new HashSet<HIS_VACCINATION>();
            HIS_VACCINATION1 = new HashSet<HIS_VACCINATION>();
            HIS_VITAMIN_A = new HashSet<HIS_VITAMIN_A>();
            HIS_VITAMIN_A1 = new HashSet<HIS_VITAMIN_A>();
        }

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

        public long ROOM_TYPE_ID { get; set; }

        public long DEPARTMENT_ID { get; set; }

        public long? ROOM_GROUP_ID { get; set; }

        [StringLength(10)]
        public string ORDER_ISSUE_CODE { get; set; }

        [StringLength(10)]
        public string G_CODE { get; set; }

        public long? HOLD_ORDER { get; set; }

        public short? IS_PAUSE { get; set; }

        public short? IS_AUTO_SHOW_REQUEST { get; set; }

        public short? IS_USE_KIOSK { get; set; }

        public short? IS_RESTRICT_MEDICINE_TYPE { get; set; }

        public short? IS_RESTRICT_EXECUTE_ROOM { get; set; }

        public short? IS_RESTRICT_TIME { get; set; }

        public short? IS_RESTRICT_PATIENT_TYPE { get; set; }

        public long? SPECIALITY_ID { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }

        [StringLength(50)]
        public string RESPONSIBLE_LOGINNAME { get; set; }

        [StringLength(100)]
        public string RESPONSIBLE_USERNAME { get; set; }

        public short? IS_RESTRICT_REQ_SERVICE { get; set; }

        public short? IS_ALLOW_NO_ICD { get; set; }

        public long? AREA_ID { get; set; }

        [StringLength(200)]
        public string SCREEN_SAVER_MODULE_LINK { get; set; }

        public long? DEPOSIT_ACCOUNT_BOOK_ID { get; set; }

        public long? DEFAULT_CASHIER_ROOM_ID { get; set; }

        public long? RESPONSIBLE_TIME { get; set; }

        [StringLength(1000)]
        public string WORKING_LOGINNAME { get; set; }

        [StringLength(4000)]
        public string WORKING_USERNAME { get; set; }

        [StringLength(50)]
        public string BHYT_CODE { get; set; }

        public short? IS_BLOCK_NUM_ORDER { get; set; }

        [StringLength(100)]
        public string DEFAULT_DRUG_STORE_IDS { get; set; }

        public long? DEFAULT_SERVICE_ID { get; set; }

        [StringLength(500)]
        public string JSON_PRINT_ID { get; set; }

        public long? BILL_ACCOUNT_BOOK_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ACCIDENT_HURT> HIS_ACCIDENT_HURT { get; set; }

        public virtual HIS_ACCOUNT_BOOK HIS_ACCOUNT_BOOK { get; set; }

        public virtual HIS_ACCOUNT_BOOK HIS_ACCOUNT_BOOK1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ALERT> HIS_ALERT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ANTICIPATE> HIS_ANTICIPATE { get; set; }

        public virtual HIS_AREA HIS_AREA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_BED_ROOM> HIS_BED_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CARE> HIS_CARE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CASHIER_ADD_CONFIG> HIS_CASHIER_ADD_CONFIG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CASHIER_ADD_CONFIG> HIS_CASHIER_ADD_CONFIG1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_CASHIER_ROOM> HIS_CASHIER_ROOM { get; set; }

        public virtual HIS_CASHIER_ROOM HIS_CASHIER_ROOM1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DATA_STORE> HIS_DATA_STORE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DATA_STORE> HIS_DATA_STORE1 { get; set; }

        public virtual HIS_DEPARTMENT HIS_DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DESK> HIS_DESK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_DHST> HIS_DHST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EMR_COVER_CONFIG> HIS_EMR_COVER_CONFIG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXAM_SCHEDULE> HIS_EXAM_SCHEDULE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXECUTE_ROOM> HIS_EXECUTE_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXP_MEST> HIS_EXP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_EXRO_ROOM> HIS_EXRO_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_HOLD_RETURN> HIS_HOLD_RETURN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_HOLD_RETURN> HIS_HOLD_RETURN1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_HOLD_RETURN> HIS_HOLD_RETURN2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_HORE_HANDOVER> HIS_HORE_HANDOVER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_HORE_HANDOVER> HIS_HORE_HANDOVER1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST> HIS_IMP_MEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_IMP_MEST_PROPOSE> HIS_IMP_MEST_PROPOSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_INFUSION_SUM> HIS_INFUSION_SUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_KSK_SERVICE> HIS_KSK_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MACHINE> HIS_MACHINE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_REACT_SUM> HIS_MEDI_REACT_SUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_RECORD> HIS_MEDI_RECORD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDI_STOCK> HIS_MEDI_STOCK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEDICINE_TYPE_ROOM> HIS_MEDICINE_TYPE_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_MEST_ROOM> HIS_MEST_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT> HIS_PATIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_PATIENT_TYPE_ROOM> HIS_PATIENT_TYPE_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_RATION_SUM> HIS_RATION_SUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_RECEPTION_ROOM> HIS_RECEPTION_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_REFECTORY> HIS_REFECTORY { get; set; }

        public virtual HIS_ROOM_TYPE HIS_ROOM_TYPE { get; set; }

        public virtual HIS_ROOM_GROUP HIS_ROOM_GROUP { get; set; }

        public virtual HIS_SPECIALITY HIS_SPECIALITY { get; set; }

        public virtual HIS_SERVICE HIS_SERVICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ROOM_SARO> HIS_ROOM_SARO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_ROOM_TIME> HIS_ROOM_TIME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SAMPLE_ROOM> HIS_SAMPLE_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_TEMP> HIS_SERE_SERV_TEMP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERV_SEGR> HIS_SERV_SEGR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_NUM_ORDER> HIS_SERVICE_NUM_ORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ> HIS_SERVICE_REQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_REQ> HIS_SERVICE_REQ1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERVICE_ROOM> HIS_SERVICE_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_STATION> HIS_STATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SUBCLINICAL_RS_ADD> HIS_SUBCLINICAL_RS_ADD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SUBCLINICAL_RS_ADD> HIS_SUBCLINICAL_RS_ADD1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SUBCLINICAL_RS_ADD> HIS_SUBCLINICAL_RS_ADD2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TRACKING> HIS_TRACKING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TRANSACTION> HIS_TRANSACTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TRANSFUSION_SUM> HIS_TRANSFUSION_SUM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT> HIS_TREATMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT> HIS_TREATMENT1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_TREATMENT> HIS_TREATMENT2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_USER_ROOM> HIS_USER_ROOM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION_EXAM> HIS_VACCINATION_EXAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION_EXAM> HIS_VACCINATION_EXAM1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION> HIS_VACCINATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VACCINATION> HIS_VACCINATION1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VITAMIN_A> HIS_VITAMIN_A { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_VITAMIN_A> HIS_VITAMIN_A1 { get; set; }
    }
}
