using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CreateDBOracle.ContextCodeFirstModels
{
    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=Entities")
        {
        }

        public virtual DbSet<SAR_FORM> SAR_FORM { get; set; }
        public virtual DbSet<SAR_FORM_DATA> SAR_FORM_DATA { get; set; }
        public virtual DbSet<SAR_FORM_FIELD> SAR_FORM_FIELD { get; set; }
        public virtual DbSet<SAR_FORM_TYPE> SAR_FORM_TYPE { get; set; }
        public virtual DbSet<SAR_PRINT> SAR_PRINT { get; set; }
        public virtual DbSet<SAR_PRINT_LOG> SAR_PRINT_LOG { get; set; }
        public virtual DbSet<SAR_PRINT_TYPE> SAR_PRINT_TYPE { get; set; }
        public virtual DbSet<SAR_PRINT_TYPE_CFG> SAR_PRINT_TYPE_CFG { get; set; }
        public virtual DbSet<SAR_REPORT> SAR_REPORT { get; set; }
        public virtual DbSet<SAR_REPORT_CALENDAR> SAR_REPORT_CALENDAR { get; set; }
        public virtual DbSet<SAR_REPORT_STT> SAR_REPORT_STT { get; set; }
        public virtual DbSet<SAR_REPORT_TEMPLATE> SAR_REPORT_TEMPLATE { get; set; }
        public virtual DbSet<SAR_REPORT_TYPE> SAR_REPORT_TYPE { get; set; }
        public virtual DbSet<SAR_REPORT_TYPE_GROUP> SAR_REPORT_TYPE_GROUP { get; set; }
        public virtual DbSet<SAR_RETY_FOFI> SAR_RETY_FOFI { get; set; }
        public virtual DbSet<SAR_USER_REPORT_TYPE> SAR_USER_REPORT_TYPE { get; set; }
        public virtual DbSet<V_SAR_FORM> V_SAR_FORM { get; set; }
        public virtual DbSet<V_SAR_PRINT_TYPE_CFG> V_SAR_PRINT_TYPE_CFG { get; set; }
        public virtual DbSet<V_SAR_REPORT> V_SAR_REPORT { get; set; }
        public virtual DbSet<V_SAR_REPORT_TEMPLATE> V_SAR_REPORT_TEMPLATE { get; set; }
        public virtual DbSet<V_SAR_RETY_FOFI> V_SAR_RETY_FOFI { get; set; }
        public virtual DbSet<V_SAR_USER_REPORT_TYPE> V_SAR_USER_REPORT_TYPE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SAR_FORM>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM>()
                .HasMany(e => e.SAR_FORM_DATA)
                .WithRequired(e => e.SAR_FORM)
                .HasForeignKey(e => e.FORM_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAR_FORM_DATA>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_DATA>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_DATA>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_DATA>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_DATA>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_DATA>()
                .Property(e => e.KEY)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_DATA>()
                .Property(e => e.VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_DATA>()
                .Property(e => e.VIR_UNIQUE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_FIELD>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_FIELD>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_FIELD>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_FIELD>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_FIELD>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_FIELD>()
                .Property(e => e.FORM_FIELD_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_FIELD>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_FIELD>()
                .HasMany(e => e.SAR_RETY_FOFI)
                .WithRequired(e => e.SAR_FORM_FIELD)
                .HasForeignKey(e => e.FORM_FIELD_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAR_FORM_TYPE>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_TYPE>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_TYPE>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_TYPE>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_TYPE>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_TYPE>()
                .Property(e => e.FORM_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_TYPE>()
                .Property(e => e.FORM_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_FORM_TYPE>()
                .HasMany(e => e.SAR_FORM)
                .WithRequired(e => e.SAR_FORM_TYPE)
                .HasForeignKey(e => e.FORM_TYPE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAR_PRINT>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT>()
                .Property(e => e.EMR_BUSINESS_CODES)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT>()
                .Property(e => e.EMR_DOCUMENT_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT>()
                .Property(e => e.EMR_DOCUMENT_GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT>()
                .Property(e => e.ADDITIONAL_INFO)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_LOG>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_LOG>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_LOG>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_LOG>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_LOG>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_LOG>()
                .Property(e => e.PRINT_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_LOG>()
                .Property(e => e.PRINT_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_LOG>()
                .Property(e => e.LOGINNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_LOG>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_LOG>()
                .Property(e => e.DATA_CONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_LOG>()
                .Property(e => e.UNIQUE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_LOG>()
                .Property(e => e.PRINT_REASON)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.PRINT_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.FILE_PATTERN)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.PRINT_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.EMR_DOCUMENT_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.BUSINESS_CODES)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.REPRINT_EXCEPTION_LOGINNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.PRINT_EXCEPTION_LOGINNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.EMR_COLUMN_MAPPING)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.DISABLE_PRINT_BY_KEY_CFG)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.GEN_SIGNATURE_BY_KEY_CFG)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .Property(e => e.EMR_DOCUMENT_GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .HasMany(e => e.SAR_PRINT)
                .WithOptional(e => e.SAR_PRINT_TYPE)
                .HasForeignKey(e => e.PRINT_TYPE_ID);

            modelBuilder.Entity<SAR_PRINT_TYPE>()
                .HasMany(e => e.SAR_PRINT_TYPE_CFG)
                .WithRequired(e => e.SAR_PRINT_TYPE)
                .HasForeignKey(e => e.PRINT_TYPE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAR_PRINT_TYPE_CFG>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE_CFG>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE_CFG>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE_CFG>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE_CFG>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE_CFG>()
                .Property(e => e.APP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE_CFG>()
                .Property(e => e.MODULE_LINK)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE_CFG>()
                .Property(e => e.CONTROL_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE_CFG>()
                .Property(e => e.CONTROL_PATH)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE_CFG>()
                .Property(e => e.BRANCH_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_PRINT_TYPE_CFG>()
                .Property(e => e.CAPTION)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.REPORT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.REPORT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.REPORT_URL)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.JSON_FILTER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.JSON_READER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.VIR_TOTAL_TIME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.VIR_QUERY_TIME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.VIR_PREPARE_DATA_TIME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.VIR_GENERATE_FILE_TIME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.REPORT_URL_PDF)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT>()
                .Property(e => e.ERROR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT>()
                .HasMany(e => e.SAR_REPORT_CALENDAR)
                .WithOptional(e => e.SAR_REPORT)
                .HasForeignKey(e => e.REPORT_ID);

            modelBuilder.Entity<SAR_REPORT_CALENDAR>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_CALENDAR>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_CALENDAR>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_CALENDAR>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_CALENDAR>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_CALENDAR>()
                .Property(e => e.REPORT_CALENDAR_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_CALENDAR>()
                .Property(e => e.FILTER_TOTAL_JSON)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_CALENDAR>()
                .HasMany(e => e.SAR_REPORT_CALENDAR1)
                .WithOptional(e => e.SAR_REPORT_CALENDAR2)
                .HasForeignKey(e => e.SOURCE_ID);

            modelBuilder.Entity<SAR_REPORT_STT>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_STT>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_STT>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_STT>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_STT>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_STT>()
                .Property(e => e.REPORT_STT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_STT>()
                .Property(e => e.REPORT_STT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_STT>()
                .HasMany(e => e.SAR_REPORT)
                .WithRequired(e => e.SAR_REPORT_STT)
                .HasForeignKey(e => e.REPORT_STT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAR_REPORT_TEMPLATE>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TEMPLATE>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TEMPLATE>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TEMPLATE>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TEMPLATE>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TEMPLATE>()
                .Property(e => e.REPORT_TEMPLATE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TEMPLATE>()
                .Property(e => e.REPORT_TEMPLATE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TEMPLATE>()
                .Property(e => e.REPORT_TEMPLATE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TEMPLATE>()
                .Property(e => e.EXTENSION_RECEIVE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TEMPLATE>()
                .Property(e => e.TUTORIAL)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TEMPLATE>()
                .HasMany(e => e.SAR_REPORT)
                .WithOptional(e => e.SAR_REPORT_TEMPLATE)
                .HasForeignKey(e => e.REPORT_TEMPLATE_ID);

            modelBuilder.Entity<SAR_REPORT_TYPE>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE>()
                .Property(e => e.REPORT_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE>()
                .Property(e => e.REPORT_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE>()
                .Property(e => e.HOUR_FROM)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE>()
                .Property(e => e.HOUR_TO)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE>()
                .Property(e => e.DLL_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE>()
                .HasMany(e => e.SAR_REPORT)
                .WithRequired(e => e.SAR_REPORT_TYPE)
                .HasForeignKey(e => e.REPORT_TYPE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAR_REPORT_TYPE>()
                .HasMany(e => e.SAR_REPORT_TEMPLATE)
                .WithRequired(e => e.SAR_REPORT_TYPE)
                .HasForeignKey(e => e.REPORT_TYPE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAR_REPORT_TYPE>()
                .HasMany(e => e.SAR_RETY_FOFI)
                .WithRequired(e => e.SAR_REPORT_TYPE)
                .HasForeignKey(e => e.REPORT_TYPE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAR_REPORT_TYPE>()
                .HasMany(e => e.SAR_USER_REPORT_TYPE)
                .WithRequired(e => e.SAR_REPORT_TYPE)
                .HasForeignKey(e => e.REPORT_TYPE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SAR_REPORT_TYPE_GROUP>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE_GROUP>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE_GROUP>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE_GROUP>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE_GROUP>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE_GROUP>()
                .Property(e => e.REPORT_TYPE_GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE_GROUP>()
                .Property(e => e.REPORT_TYPE_GROUP_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_REPORT_TYPE_GROUP>()
                .HasMany(e => e.SAR_REPORT_TYPE)
                .WithOptional(e => e.SAR_REPORT_TYPE_GROUP)
                .HasForeignKey(e => e.REPORT_TYPE_GROUP_ID);

            modelBuilder.Entity<SAR_RETY_FOFI>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_RETY_FOFI>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_RETY_FOFI>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_RETY_FOFI>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_RETY_FOFI>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_RETY_FOFI>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_RETY_FOFI>()
                .Property(e => e.JSON_OUTPUT)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_USER_REPORT_TYPE>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_USER_REPORT_TYPE>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_USER_REPORT_TYPE>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_USER_REPORT_TYPE>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_USER_REPORT_TYPE>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<SAR_USER_REPORT_TYPE>()
                .Property(e => e.LOGINNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_FORM>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_FORM>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_FORM>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_FORM>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_FORM>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_FORM>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_FORM>()
                .Property(e => e.FORM_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_FORM>()
                .Property(e => e.FORM_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_PRINT_TYPE_CFG>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_PRINT_TYPE_CFG>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_PRINT_TYPE_CFG>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_PRINT_TYPE_CFG>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_PRINT_TYPE_CFG>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_PRINT_TYPE_CFG>()
                .Property(e => e.APP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_PRINT_TYPE_CFG>()
                .Property(e => e.MODULE_LINK)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_PRINT_TYPE_CFG>()
                .Property(e => e.CONTROL_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_PRINT_TYPE_CFG>()
                .Property(e => e.CONTROL_PATH)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_PRINT_TYPE_CFG>()
                .Property(e => e.BRANCH_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_PRINT_TYPE_CFG>()
                .Property(e => e.CAPTION)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_PRINT_TYPE_CFG>()
                .Property(e => e.PRINT_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_PRINT_TYPE_CFG>()
                .Property(e => e.PRINT_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.REPORT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.REPORT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.REPORT_URL)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.JSON_FILTER)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.JSON_READER)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.VIR_TOTAL_TIME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.VIR_QUERY_TIME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.VIR_PREPARE_DATA_TIME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.VIR_GENERATE_FILE_TIME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.REPORT_URL_PDF)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.ERROR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.REPORT_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.REPORT_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.REPORT_STT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.REPORT_STT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.REPORT_TEMPLATE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.REPORT_TEMPLATE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT>()
                .Property(e => e.EXTENSION_RECEIVE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT_TEMPLATE>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT_TEMPLATE>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT_TEMPLATE>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT_TEMPLATE>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT_TEMPLATE>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT_TEMPLATE>()
                .Property(e => e.REPORT_TEMPLATE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT_TEMPLATE>()
                .Property(e => e.REPORT_TEMPLATE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT_TEMPLATE>()
                .Property(e => e.REPORT_TEMPLATE_URL)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT_TEMPLATE>()
                .Property(e => e.EXTENSION_RECEIVE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT_TEMPLATE>()
                .Property(e => e.TUTORIAL)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT_TEMPLATE>()
                .Property(e => e.REPORT_TYPE_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_REPORT_TEMPLATE>()
                .Property(e => e.REPORT_TYPE_NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_RETY_FOFI>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_RETY_FOFI>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_RETY_FOFI>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_RETY_FOFI>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_RETY_FOFI>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_RETY_FOFI>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_RETY_FOFI>()
                .Property(e => e.JSON_OUTPUT)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_RETY_FOFI>()
                .Property(e => e.REPORT_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_RETY_FOFI>()
                .Property(e => e.REPORT_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_RETY_FOFI>()
                .Property(e => e.FORM_FIELD_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_RETY_FOFI>()
                .Property(e => e.FORM_FIELD_DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_USER_REPORT_TYPE>()
                .Property(e => e.CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_USER_REPORT_TYPE>()
                .Property(e => e.MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_USER_REPORT_TYPE>()
                .Property(e => e.APP_CREATOR)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_USER_REPORT_TYPE>()
                .Property(e => e.APP_MODIFIER)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_USER_REPORT_TYPE>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_USER_REPORT_TYPE>()
                .Property(e => e.LOGINNAME)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_USER_REPORT_TYPE>()
                .Property(e => e.REPORT_TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<V_SAR_USER_REPORT_TYPE>()
                .Property(e => e.REPORT_TYPE_NAME)
                .IsUnicode(false);
        }
    }
}
