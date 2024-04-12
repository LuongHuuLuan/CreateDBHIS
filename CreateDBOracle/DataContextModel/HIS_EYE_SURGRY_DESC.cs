namespace CreateDBOracle.DataContextModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SAR_RS.HIS_EYE_SURGRY_DESC")]
    public partial class HIS_EYE_SURGRY_DESC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HIS_EYE_SURGRY_DESC()
        {
            HIS_SERE_SERV_PTTT = new HashSet<HIS_SERE_SERV_PTTT>();
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

        public long LOAI_PT_MAT { get; set; }

        public long? CHAN_DOAN { get; set; }

        [StringLength(2000)]
        public string NGUYEN_NHAN { get; set; }

        public long? GIAI_DOAN_BENH { get; set; }

        public long? MAT_PHAU_THUAT { get; set; }

        public long? PP_PHAU_THUAT { get; set; }

        public short? PP_PT_CAT_MONG_MAT { get; set; }

        public long? PP_VO_CAM { get; set; }

        [StringLength(500)]
        public string THUOC_TE { get; set; }

        public long? CO_DINH_NHAN_CAU { get; set; }

        [StringLength(50)]
        public string TAO_VAT_KM_KINH_TUYEN { get; set; }

        public long? TAO_VAT_KM_VI_TRI { get; set; }

        public long? TINH_TRANG_BAO_TENON { get; set; }

        public long? TINH_TRANG_T3 { get; set; }

        public short? UC_CHE_TAO_XO { get; set; }

        public long? UC_CHE_TAO_XO_TT_BS { get; set; }

        [StringLength(500)]
        public string UC_CHE_TAO_XO_TT_BS_KHAC { get; set; }

        public long? UC_CHE_TAO_XO_VITRI { get; set; }

        [StringLength(100)]
        public string UC_CHE_TAO_XO_THOIGIAN { get; set; }

        public short? LANG_BOT_BAO_TENON { get; set; }

        [StringLength(100)]
        public string VAT_CM_HINHDANG { get; set; }

        public decimal? VAT_CM_KICHTHUOC { get; set; }

        public short? CHOC_TP { get; set; }

        public long? CAT_MAU_BE { get; set; }

        public short? CAT_MONG_MAT { get; set; }

        public decimal? KHAU_NAP_CM_SO_MUI { get; set; }

        public short? KHAU_NAP_CM_CHIRUT { get; set; }

        [StringLength(100)]
        public string KHAU_NAP_CM_LOAICHI { get; set; }

        public long? TAI_TAO_TP { get; set; }

        public long? KHAU_KM { get; set; }

        public decimal? KHAU_KM_SOMUI { get; set; }

        public long? KHAU_KM_LOAICHI { get; set; }

        [StringLength(50)]
        public string KHAU_KM_LOAICHI_BS { get; set; }

        public long? MO_KM_RIA { get; set; }

        [StringLength(50)]
        public string MO_KM_RIA_KINH_TUYEN { get; set; }

        public long? MO_VAO_TP { get; set; }

        [StringLength(50)]
        public string MO_VAO_TP_KINH_TUYEN { get; set; }

        public decimal? MO_VAO_TP_KICH_THUOC { get; set; }

        public short? MO_VAO_TP_RACH_PHU { get; set; }

        public short? NHUOM_BAO { get; set; }

        public long? LOAI_MO_BAO { get; set; }

        public short? TACH_NHAN { get; set; }

        public long? XOAY_NHAN { get; set; }

        public short? DAY_NHAN { get; set; }

        public long? CACH_DAY_NHAN { get; set; }

        public decimal? TAN_NHAN_NANG_LUONG { get; set; }

        public decimal? TAN_NHAN_LUC_HUT { get; set; }

        [StringLength(20)]
        public string TAN_NHAN_TOC_DO_DC { get; set; }

        public long? HUT_CHAT_T3 { get; set; }

        public long? DAT_IOL_LOAI { get; set; }

        public long? DAT_IOL_CACH_THUC { get; set; }

        public long? RACH_BAO_SAU { get; set; }

        [StringLength(100)]
        public string RACH_BAO_SAU_VI_TRI { get; set; }

        public decimal? RACH_BAO_SAU_KICH_THUOC { get; set; }

        public short? CAT_BAO_SAU { get; set; }

        public long? CAT_BAO_SAU_CACH_THUC { get; set; }

        public short? CAT_MONG_MAT_NGOAI_VI { get; set; }

        [StringLength(100)]
        public string CAT_MONG_MAT_NGOAI_VI_VITRI { get; set; }

        public long? PHUC_HOI_VET_MO { get; set; }

        public short? DAT_VANH_MI { get; set; }

        public short? TIEM_LIDOCANIE_THAN_MONG { get; set; }

        public short? CAT_DAU_MONG { get; set; }

        public short? PHAN_TICH_THAN_MONG { get; set; }

        public short? DOT_CAM_MAU { get; set; }

        public short? GOT_GIAC_MAC_DAU_MONG { get; set; }

        public long? LAY_MANH_KM_SAT_RIA { get; set; }

        [StringLength(20)]
        public string LAY_MANH_KM_SAT_RIA_KT { get; set; }

        public short? LAY_MANH_MANG_OI { get; set; }

        [StringLength(20)]
        public string LAY_MANH_MANG_OI_KT { get; set; }

        public long? KHAU_MANH_GHEP_CHI { get; set; }

        public decimal? KHAU_MANH_GHEP_CHI_SO_MUI { get; set; }

        public short? KHAU_KM_CHE_PHAN_CAT_KM { get; set; }

        public decimal? KHAU_KM_CHE_PHAN_CAT_KM_SO_MUI { get; set; }

        public long? BIEN_CHUNG { get; set; }

        [StringLength(4000)]
        public string XU_TRI_BIEN_CHUNG { get; set; }

        public short? TIEM_MAT { get; set; }

        public long? TIEM_MAT_TT_BO_SUNG { get; set; }

        [StringLength(500)]
        public string TIEM_MAT_THUOC { get; set; }

        public long? TRA_MAT { get; set; }

        [StringLength(500)]
        public string TRA_MAT_THUOC { get; set; }

        public short? TRA_MAT_BANG_EP { get; set; }

        [StringLength(500)]
        public string TRA_MAT_BANG_TT { get; set; }

        [StringLength(4000)]
        public string DIEN_BIEN_KHAC { get; set; }

        public short? CHAN_DOAN_SUP_MI_MT { get; set; }

        public long? CHAN_DOAN_SUP_MI_MT_DO { get; set; }

        public short? CHAN_DOAN_SUP_MI_MP { get; set; }

        public long? CHAN_DOAN_SUP_MI_MP_DO { get; set; }

        public short? PP_PT_CO_NANG_MI { get; set; }

        public long? PP_PT_TREO_MI_CO_TRAN { get; set; }

        public long? VI_TRI_DUONG_RACH { get; set; }

        [StringLength(500)]
        public string THUOC_TE_TAI_CHO { get; set; }

        public short? PHAU_TICH_DA_DU { get; set; }

        public short? CAT_CO_VONG_MI { get; set; }

        public short? TACH_CO_NANG_MI_KHOI_KM { get; set; }

        public long? CAT_NGAN_CO_NANG_MI { get; set; }

        public short? GAP_CO_NANG_MI { get; set; }

        public long? GAP_CO_NANG_MI_KHOANG { get; set; }

        public short? TREO_MI_CO_TRAN { get; set; }

        public long? TREO_MI_CO_TRAN_LOAI { get; set; }

        public short? KHAU_CO_DINH_CO_NANG_MI { get; set; }

        public short? LUON_CHI_HINH_NGU_GIAC { get; set; }

        [StringLength(100)]
        public string KHAU_DA_MI_TAO_MI_CHI { get; set; }

        public long? CHAN_DOAN_DUT_LE_QUAN { get; set; }

        public long? DUT_LE_QUAN_GIO_THU { get; set; }

        public long? PP_PHAU_THUAT_LE_QUAN { get; set; }

        public long? PHAU_THUAT_LAN_THU { get; set; }

        public short? PP_VO_CAM_DUOI_HOC { get; set; }

        public short? PP_VO_CAM_MUI { get; set; }

        public short? PP_VO_CAM_VUNG_TUI_LE { get; set; }

        public short? PP_VO_CAM_THE0_VET_RACH_MI { get; set; }

        public short? LAY_DI_VAT { get; set; }

        public short? LE_QUAN_LANH_DUT { get; set; }

        public short? TIM_DAU_DUT_NGOAI { get; set; }

        public short? TIM_DAU_DUT_TRONG { get; set; }

        public long? DAU_DUT_TRONG_VITRI { get; set; }

        public long? DAT_LE_QUAN { get; set; }

        [StringLength(100)]
        public string CHI_NOI_2_DAU_LE_QUAN { get; set; }

        public short? TAI_TAO_MI_KET_MAC { get; set; }

        public short? TAI_TAO_MI_MO_DUOI_DA { get; set; }

        public short? TAI_TAO_MI_DA { get; set; }

        public long? CO_DINH_ONG_SILICON { get; set; }

        [StringLength(100)]
        public string NYLON_CO_DINH_ONG_SILICON { get; set; }

        public long? CHAN_DOAN_NGHI_NGO_GLOCOM { get; set; }

        public long? CHAN_DOAN_GLOCOM { get; set; }

        public long? LASER_YAG_NANG_LUONG { get; set; }

        [StringLength(20)]
        public string LASER_YAG_NANG_LUONG_KHAC { get; set; }

        public long? LASER_YAG_DIEM_NO { get; set; }

        public decimal? VI_TRI_CAT_MONG_CHU_BIEN { get; set; }

        public long? CD_DUC_BAO_SAU_SAU_MO_TTT { get; set; }

        public long? HINH_DANG_MO_BAO_SAU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HIS_SERE_SERV_PTTT> HIS_SERE_SERV_PTTT { get; set; }
    }
}
