using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BMOD.Data.Entities
{
    public partial class BMODEntityModel : DbContext
    {
        public BMODEntityModel()
            : base("name=DefaultConnection")
        {
        }

        //public virtual DbSet<ADJUST> ADJUSTs { get; set; }
        //public virtual DbSet<Assignment> Assignments { get; set; }
        //public virtual DbSet<BillingOffice> BillingOffices { get; set; }
        public virtual DbSet<BMODWiz> BMODWizs { get; set; }
        //public virtual DbSet<CityZip> CityZips { get; set; }
        //public virtual DbSet<CommunicationLog> CommunicationLogs { get; set; }
        public virtual DbSet<Complex> Complexes { get; set; }
        public virtual DbSet<ComplexAttribute> ComplexAttributes { get; set; }
        //public virtual DbSet<ComplexEmail> ComplexEmails { get; set; }
        public virtual DbSet<ComplexManagingCompany> ComplexManagingCompanies { get; set; }
        //public virtual DbSet<CRM> CRMs { get; set; }
        //public virtual DbSet<DebrisDisposal> DebrisDisposals { get; set; }
        //public virtual DbSet<DebrisSelection> DebrisSelections { get; set; }
        //public virtual DbSet<DIVISION> DIVISIONs { get; set; }
        //public virtual DbSet<EMPLRATE> EMPLRATEs { get; set; }
        public virtual DbSet<EMPLWORK> EMPLWORKs { get; set; }
        public virtual DbSet<EMPLWORKLVL1> EMPLWORKLVL1 { get; set; }
        //public virtual DbSet<EntryType> EntryTypes { get; set; }
        //public virtual DbSet<Equipment> Equipments { get; set; }
        //public virtual DbSet<EquipmentUsed> EquipmentUseds { get; set; }
        //public virtual DbSet<form> forms { get; set; }
        //public virtual DbSet<ImageCategory> ImageCategories { get; set; }
        //public virtual DbSet<ImageCollectionImage> ImageCollectionImages { get; set; }
        //public virtual DbSet<ImageCollection> ImageCollections { get; set; }
        //public virtual DbSet<InvActivity> InvActivities { get; set; }
        //public virtual DbSet<InvActivityMaterial> InvActivityMaterials { get; set; }
        //public virtual DbSet<INVALLOW> INVALLOWs { get; set; }
        //public virtual DbSet<INVHEADER> INVHEADERs { get; set; }
        //public virtual DbSet<InvLineItem> InvLineItems { get; set; }
        //public virtual DbSet<InvLineLookup> InvLineLookups { get; set; }
        //public virtual DbSet<InvPayment> InvPayments { get; set; }
        public virtual DbSet<JobScope> JobScopes { get; set; }
        public virtual DbSet<JobSite> JobSites { get; set; }
        //public virtual DbSet<mAssignment> mAssignments { get; set; }
        public virtual DbSet<MATERIAL> MATERIALs { get; set; }
        //public virtual DbSet<messageAlert> messageAlerts { get; set; }
        //public virtual DbSet<Month> Months { get; set; }
        //public virtual DbSet<OTHCOST> OTHCOSTs { get; set; }
        //public virtual DbSet<OTHPARTY> OTHPARTies { get; set; }
        //public virtual DbSet<PAYADJMT> PAYADJMTs { get; set; }
        //public virtual DbSet<PayType> PayTypes { get; set; }
        //public virtual DbSet<permission> permissions { get; set; }
        //public virtual DbSet<PgmConstant> PgmConstants { get; set; }
        //public virtual DbSet<PhoneType> PhoneTypes { get; set; }
        //public virtual DbSet<PrimAssignment> PrimAssignments { get; set; }
        //public virtual DbSet<projAttachment> projAttachments { get; set; }
        //public virtual DbSet<projLabor> projLabors { get; set; }
        //public virtual DbSet<ProjMaterial> ProjMaterials { get; set; }
        //public virtual DbSet<projOtherCost> projOtherCosts { get; set; }
        public virtual DbSet<PropertyMgr> PropertyMgrs { get; set; }
        //public virtual DbSet<Role> Roles { get; set; }
        //public virtual DbSet<State> States { get; set; }
        //public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        //public virtual DbSet<TERM> TERMS { get; set; }
        //public virtual DbSet<TimeFactor> TimeFactors { get; set; }
        //public virtual DbSet<UserClaim> UserClaims { get; set; }
        //public virtual DbSet<UserLogin> UserLogins { get; set; }
        //public virtual DbSet<User> Users { get; set; }
        //public virtual DbSet<UserSystemStatu> UserSystemStatus { get; set; }
        //public virtual DbSet<Vendor> Vendors { get; set; }
        //public virtual DbSet<WO_Docs> WO_Docs { get; set; }
        //public virtual DbSet<WorkImage> WorkImages { get; set; }
        public virtual DbSet<WORKORDR> WORKORDRs { get; set; }
        public virtual DbSet<WORKTYPE> WORKTYPEs { get; set; }
        //public virtual DbSet<BILLTO> BILLTOes { get; set; }
        public virtual DbSet<ComplexAttribSupport> ComplexAttribSupports { get; set; }
        //public virtual DbSet<EMPLDETAIL> EMPLDETAILS { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        //public virtual DbSet<InvActivityPhrase> InvActivityPhrases { get; set; }
        //public virtual DbSet<office_emp_hrs> office_emp_hrs { get; set; }
        //public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<PropertyMgrComplex> PropertyMgrComplexes { get; set; }
        //public virtual DbSet<Temp> Temps { get; set; }
        //public virtual DbSet<tempComplex> tempComplexes { get; set; }
        public virtual DbSet<wdClass> wdClasses { get; set; }
        //public virtual DbSet<WorkCompView> WorkCompViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CommunicationLog>()
            //    .Property(e => e.cmm_time)
            //    .HasPrecision(0);

            //modelBuilder.Entity<CommunicationLog>()
            //    .Property(e => e.appttime)
            //    .HasPrecision(0);

            modelBuilder.Entity<ComplexManagingCompany>()
                .HasMany(e => e.PropertyMgrs)
                .WithOptional(e => e.ComplexManagingCompany)
                .HasForeignKey(e => e.ManagingComp)
                .WillCascadeOnDelete();

            //modelBuilder.Entity<CRM>()
            //    .Property(e => e.NOTES)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CRM>()
            //    .Property(e => e.PREFERENCES)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CRM>()
            //    .Property(e => e.INTERESTS)
            //    .IsUnicode(false);

            //modelBuilder.Entity<DebrisDisposal>()
            //    .Property(e => e.DebrisAmount)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<DebrisSelection>()
            //    .Property(e => e.DebrisAmount)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<InvActivity>()
            //    .Property(e => e.invActRV)
            //    .IsFixedLength();

            //modelBuilder.Entity<InvActivityMaterial>()
            //    .Property(e => e.invMatRV)
            //    .IsFixedLength();

            //modelBuilder.Entity<INVHEADER>()
            //    .Property(e => e.CUSTWORKORDER)
            //    .IsFixedLength();

            //modelBuilder.Entity<INVHEADER>()
            //    .Property(e => e.INVTOTAL)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<INVHEADER>()
            //    .Property(e => e.AMTDUE)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<INVHEADER>()
            //    .Property(e => e.AMTPAID)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<INVHEADER>()
            //    .Property(e => e.grandPay)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<INVHEADER>()
            //    .Property(e => e.grandTot)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<INVHEADER>()
            //    .Property(e => e.discount)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<InvLineItem>()
            //    .Property(e => e.WorkOrder)
            //    .IsFixedLength();

            //modelBuilder.Entity<InvPayment>()
            //    .Property(e => e.WorkOrder)
            //    .IsFixedLength();

            modelBuilder.Entity<JobScope>()
                .Property(e => e.WorkOrder)
                .IsFixedLength();

            //modelBuilder.Entity<mAssignment>()
            //    .Property(e => e.Status)
            //    .IsFixedLength();

            modelBuilder.Entity<MATERIAL>()
                .Property(e => e.WorkOrder)
                .IsFixedLength();

            //modelBuilder.Entity<messageAlert>()
            //    .Property(e => e.WorkOrder)
            //    .IsFixedLength();

            //modelBuilder.Entity<Month>()
            //    .Property(e => e.Month1)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OTHCOST>()
            //    .Property(e => e.WorkOrder)
            //    .IsFixedLength();

            //modelBuilder.Entity<PAYADJMT>()
            //    .Property(e => e.MILEAGERATE)
            //    .HasPrecision(9, 4);

            //modelBuilder.Entity<PAYADJMT>()
            //    .Property(e => e.PAYRATE)
            //    .HasPrecision(19, 4);

            //modelBuilder.Entity<PgmConstant>()
            //    .Property(e => e.NumericValue)
            //    .HasPrecision(9, 4);

            //modelBuilder.Entity<PrimAssignment>()
            //    .Property(e => e.PrimaryDescr)
            //    .IsUnicode(false);

            //modelBuilder.Entity<projAttachment>()
            //    .Property(e => e.ProjectNo)
            //    .IsFixedLength();

            //modelBuilder.Entity<Role>()
            //    .HasMany(e => e.Users)
            //    .WithMany(e => e.Roles)
            //    .Map(m => m.ToTable("UserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            //modelBuilder.Entity<Vendor>()
            //    .Property(e => e.VendorName)
            //    .IsUnicode(false);

            //modelBuilder.Entity<WO_Docs>()
            //    .Property(e => e.WorkOrder)
            //    .IsFixedLength();

            //modelBuilder.Entity<WorkImage>()
            //    .Property(e => e.WorkOrder)
            //    .IsFixedLength();

            //modelBuilder.Entity<InvActivityPhrase>()
            //    .Property(e => e.invPhrRV)
            //    .IsFixedLength();

            //modelBuilder.Entity<WorkCompView>()
            //    .Property(e => e.WORKORDER)
            //    .IsFixedLength();

            //modelBuilder.Entity<WorkCompView>()
            //    .Property(e => e.TimeType)
            //    .IsUnicode(false);

            //modelBuilder.Entity<WorkCompView>()
            //    .Property(e => e.Source)
            //    .IsUnicode(false);
        }
    }
}
