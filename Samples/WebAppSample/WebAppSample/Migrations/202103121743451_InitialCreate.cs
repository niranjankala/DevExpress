namespace WebAppSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BMODWiz",
                c => new
                    {
                        ChkID = c.Int(nullable: false, identity: true),
                        WorkOrder = c.String(nullable: false, maxLength: 6),
                        WOStarted = c.Boolean(),
                        WoStartedRecordDate = c.DateTime(),
                        woStartedUpdateDate = c.DateTime(),
                        woStartedUpdateBy = c.String(maxLength: 200),
                        APTaken = c.Boolean(),
                        APRecordDate = c.DateTime(),
                        APUpdateDate = c.DateTime(),
                        APUpdateBy = c.String(maxLength: 200),
                        Inspected = c.Boolean(),
                        InspectedRecordDate = c.DateTime(),
                        InspectedUpdateDate = c.DateTime(),
                        InspectedUpdateBy = c.String(maxLength: 200),
                        BPTaken = c.Boolean(),
                        BPTakenRecordDate = c.DateTime(),
                        BPTakenUpdateDate = c.DateTime(),
                        BPTakenUpdateBy = c.String(maxLength: 200),
                        AfterPic = c.Boolean(),
                        AfterPicRecordDate = c.DateTime(),
                        AfterPicUpdateDate = c.DateTime(),
                        AfterPicUpdateBy = c.String(maxLength: 200),
                        SiteCleaned = c.Boolean(),
                        SiteCleanedRecordDate = c.DateTime(),
                        SiteCleanedUpdateDate = c.DateTime(),
                        SiteCleanedUpdateBy = c.String(maxLength: 200),
                        WorkPerformed = c.Boolean(),
                        WorkPerformedRecordDate = c.DateTime(),
                        WorkPerformedUpdateDate = c.DateTime(),
                        WorkPerformedUpdateBy = c.String(maxLength: 200),
                        NTR = c.Boolean(),
                        NTRRecordDate = c.DateTime(),
                        NTRUpdateDate = c.DateTime(),
                        NTRUpdateBy = c.String(maxLength: 200),
                        StockUsed = c.Boolean(),
                        StockUsedRecordDate = c.DateTime(),
                        StockUsedUpdateDate = c.DateTime(),
                        StockUsedUpdateBy = c.String(maxLength: 200),
                        Receipts = c.Boolean(),
                        ReceiptsRecordDate = c.DateTime(),
                        ReceiptsUpdateDate = c.DateTime(),
                        ReceiptsUpdateBy = c.String(maxLength: 200),
                        Debris = c.Boolean(),
                        DebrisRecordDate = c.DateTime(),
                        DebrisUpdateDate = c.DateTime(),
                        DebrisUpdateBy = c.String(maxLength: 200),
                        EquipmentUsed = c.Boolean(),
                        EquipmentUsedRecordDate = c.DateTime(),
                        EquipmentUsedUpdateDate = c.DateTime(),
                        EquipmentUsedUpdateBy = c.String(maxLength: 200),
                        WrapUp = c.Boolean(),
                        WrapUpRecordDate = c.DateTime(),
                        WrapUpUpdateDate = c.DateTime(),
                        WrapUpUpdateBy = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ChkID);
            
            CreateTable(
                "dbo.Complex",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 5),
                        Complex = c.String(maxLength: 120),
                        City = c.String(maxLength: 120),
                        State = c.String(maxLength: 8),
                        ZipCode = c.String(maxLength: 40),
                        Location = c.String(),
                        BillOfficeCode = c.Int(),
                        ReferenceCode = c.String(maxLength: 80),
                        WorkOrderRequired = c.Boolean(nullable: false),
                        NotToExceed = c.Double(),
                        SplitterPageRequired = c.Boolean(nullable: false),
                        SplitterPageLocation = c.String(maxLength: 200),
                        Comment = c.String(),
                        Inactive = c.String(maxLength: 1),
                        recorddate = c.DateTime(),
                        updatedate = c.DateTime(),
                        updateby = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.PropertyMgrComplex",
                c => new
                    {
                        MGRPropID = c.Int(nullable: false),
                        ManagerID = c.Int(nullable: false),
                        ComplexCode = c.String(nullable: false, maxLength: 5),
                        recorddate = c.DateTime(),
                        updatedate = c.DateTime(),
                        updateby = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => new { t.MGRPropID, t.ManagerID, t.ComplexCode })
                .ForeignKey("dbo.Complex", t => t.ComplexCode, cascadeDelete: true)
                .ForeignKey("dbo.PropertyMgr", t => t.ManagerID, cascadeDelete: true)
                .Index(t => t.ManagerID)
                .Index(t => t.ComplexCode);
            
            CreateTable(
                "dbo.PropertyMgr",
                c => new
                    {
                        ManagerID = c.Int(nullable: false, identity: true),
                        UserTitle = c.String(maxLength: 200),
                        LastName = c.String(maxLength: 80),
                        FirstName = c.String(maxLength: 80),
                        EmailAddress = c.String(maxLength: 400),
                        Inactive = c.Boolean(),
                        PrimPhone = c.String(maxLength: 80),
                        AltPhone = c.String(maxLength: 80),
                        RelStart = c.DateTime(storeType: "date"),
                        Comment = c.String(),
                        recorddate = c.DateTime(),
                        updatedate = c.DateTime(),
                        updateby = c.String(maxLength: 200),
                        Bday = c.DateTime(nullable: false),
                        Xmas = c.Boolean(nullable: false),
                        EmailInvoice = c.Boolean(nullable: false),
                        ManagingComp = c.String(maxLength: 35),
                    })
                .PrimaryKey(t => t.ManagerID)
                .ForeignKey("dbo.ComplexManagingCompany", t => t.ManagingComp, cascadeDelete: true)
                .Index(t => t.ManagingComp);
            
            CreateTable(
                "dbo.ComplexManagingCompany",
                c => new
                    {
                        ManagingCompany = c.String(nullable: false, maxLength: 35),
                        Inactive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ManagingCompany);
            
            CreateTable(
                "dbo.EMPLWORKLVL1",
                c => new
                    {
                        EMPLWORKLVL1id = c.Long(nullable: false, identity: true),
                        NodeID = c.Int(nullable: false),
                        LVL1DESCRIPTION = c.String(nullable: false, maxLength: 50),
                        ParentID = c.Int(nullable: false),
                        SeqNo = c.Int(),
                        Active = c.Boolean(nullable: false),
                        recorddate = c.DateTime(),
                        updatedate = c.DateTime(),
                        updateby = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.EMPLWORKLVL1id);
            
            CreateTable(
                "dbo.EMPLWORK",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DATE = c.DateTime(),
                        DATEIN = c.DateTime(),
                        WHOWORKED = c.String(maxLength: 24),
                        WorkOrder = c.String(maxLength: 6),
                        WKTIME_IN = c.DateTime(),
                        TIMEOFF = c.Double(),
                        WKTIME_OUT = c.DateTime(),
                        TOTTIME = c.Double(),
                        AMOUNT = c.Double(),
                        WORKTYPE = c.String(maxLength: 4),
                        DIDWHAT = c.String(),
                        OWKTIME_IN = c.DateTime(),
                        OWKTIME_OUT = c.DateTime(),
                        OTIMEOFF = c.Double(),
                        OTOTTIME = c.Double(),
                        RWorkClass = c.String(maxLength: 20),
                        OWorkClass = c.String(maxLength: 20),
                        DOUBLETIME = c.Boolean(),
                        PAYWEEK_DATE = c.DateTime(),
                        emp_rate = c.Double(),
                        oamount = c.Double(),
                        ramount = c.Double(),
                        EmployeeFactor = c.Int(),
                        recorddate = c.DateTime(),
                        updatedate = c.DateTime(),
                        updateby = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.JobScope",
                c => new
                    {
                        ScopeID = c.Int(nullable: false, identity: true),
                        WorkOrder = c.String(maxLength: 6, fixedLength: true),
                        Assignment = c.String(maxLength: 200),
                        EmployeeCode = c.String(maxLength: 80),
                        ScopeDescription = c.String(),
                        ScopeDate = c.DateTime(storeType: "date"),
                        PrintScope = c.Boolean(),
                        ScopeCompleted = c.Boolean(),
                        TargetCompDate = c.DateTime(storeType: "date"),
                        ApptDate = c.DateTime(),
                        RECORDDATE = c.DateTime(),
                        UPDATEDATE = c.DateTime(),
                        UPDATEBY = c.String(maxLength: 200),
                        SeqNo = c.Int(),
                    })
                .PrimaryKey(t => t.ScopeID);
            
            CreateTable(
                "dbo.JobSite",
                c => new
                    {
                        JobSiteNo = c.String(nullable: false, maxLength: 40),
                        Code = c.String(maxLength: 5),
                        WorkOrderRequired = c.Boolean(nullable: false),
                        NotToExceed = c.Double(),
                        LastName = c.String(maxLength: 60),
                        FirstName = c.String(maxLength: 60),
                        Address1 = c.String(maxLength: 100),
                        Address2 = c.String(maxLength: 100),
                        City = c.String(maxLength: 60),
                        State = c.String(maxLength: 4),
                        ZipCode = c.String(maxLength: 20),
                        HomePhone = c.String(maxLength: 100),
                        BusPhone = c.String(maxLength: 100),
                        FaxPhone = c.String(maxLength: 100),
                        OtherPhone = c.String(maxLength: 100),
                        Comment = c.String(),
                        BillOfficeCode = c.Int(),
                        OthPhType1 = c.String(maxLength: 100),
                        OthPhType2 = c.String(maxLength: 100),
                        OthPhType3 = c.String(maxLength: 100),
                        OthPhType4 = c.String(maxLength: 100),
                        recorddate = c.DateTime(),
                        updatedate = c.DateTime(),
                        updateby = c.String(maxLength: 100),
                        TenantLastName = c.String(maxLength: 60),
                        TenantFirstName = c.String(maxLength: 60),
                        TenantHomePhone = c.String(maxLength: 100),
                        TenantMobilePhone = c.String(maxLength: 100),
                        TenantWorkPhone = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.JobSiteNo);
            
            CreateTable(
                "dbo.MATERIAL",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        WorkOrder = c.String(maxLength: 6, fixedLength: true),
                        DATE = c.DateTime(),
                        ITEM = c.String(),
                        TOTAL = c.Double(),
                        RECEIPTNO = c.String(maxLength: 64),
                        PictureTaken = c.Boolean(nullable: false),
                        VENDOR = c.String(maxLength: 120),
                        Cleanup = c.Boolean(nullable: false),
                        COMMENT = c.String(),
                        EMPNUM = c.String(maxLength: 48),
                        recorddate = c.DateTime(),
                        updatedate = c.DateTime(),
                        updateby = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        WorkOrder = c.String(nullable: false, maxLength: 6),
                        DateLogged = c.DateTime(),
                        EmpNum = c.String(maxLength: 12),
                        recorddate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        Updateby = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.TeamId);
            
            CreateTable(
                "dbo.wdClass",
                c => new
                    {
                        WorkClassID = c.Int(nullable: false),
                        WorkClassDescription = c.String(nullable: false, maxLength: 20),
                        IsActive = c.Boolean(nullable: false),
                        SeqNo = c.Int(),
                        RecordDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        Updateby = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => new { t.WorkClassID, t.WorkClassDescription, t.IsActive });
            
            CreateTable(
                "dbo.WORKORDR",
                c => new
                    {
                        WORKORDER = c.String(nullable: false, maxLength: 6),
                        DATELOGGED = c.DateTime(),
                        CALLINNAME = c.String(maxLength: 52),
                        COMPLETE = c.Boolean(nullable: false),
                        COMPDATE = c.DateTime(nullable: false),
                        JOBSITENO = c.String(maxLength: 40),
                        Tenant = c.String(maxLength: 52),
                        BtCode = c.Short(),
                        WODESCRIP = c.String(),
                        FOUNDWHAT = c.String(),
                        COMMENT = c.String(),
                        InvNotReq = c.Boolean(nullable: false),
                        EstMat = c.Double(),
                        EstEmp = c.Double(),
                        EstOth = c.Double(),
                        CUSTOMER = c.String(maxLength: 100),
                        noEmpCost = c.Boolean(),
                        noMatCost = c.Boolean(),
                        noOthCost = c.Boolean(),
                        BusPhone = c.String(maxLength: 100),
                        HomePhone = c.String(maxLength: 100),
                        FaxPhone = c.String(maxLength: 100),
                        OtherPhone = c.String(maxLength: 100),
                        othPhoneType1 = c.String(maxLength: 100),
                        othPhoneType2 = c.String(maxLength: 100),
                        othPhoneType3 = c.String(maxLength: 100),
                        othPhoneType4 = c.String(maxLength: 100),
                        CUSTWORKORDER = c.String(maxLength: 60),
                        WorkOrderRequired = c.Boolean(nullable: false),
                        IsVoid = c.Boolean(),
                        NotToExceed = c.Double(),
                        recorddate = c.DateTime(),
                        updatedate = c.DateTime(),
                        updateby = c.String(maxLength: 100),
                        FieldSubmitted = c.Boolean(nullable: false),
                        OfficeApproved = c.Boolean(nullable: false),
                        TeamAssigned = c.Int(),
                        FieldNotes = c.String(),
                        FieldRecorddate = c.DateTime(),
                        FieldUpdatedate = c.DateTime(),
                        FieldUpdateby = c.String(maxLength: 100),
                        TenantLastName = c.String(maxLength: 60),
                        TenantFirstName = c.String(maxLength: 60),
                        TenantHomePhone = c.String(maxLength: 100),
                        TenantMobilePhone = c.String(maxLength: 100),
                        TenantWorkPhone = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.WORKORDER);
            
            CreateTable(
                "dbo.WORKTYPE",
                c => new
                    {
                        ABREVIATE = c.String(nullable: false, maxLength: 2),
                        WORKTYPE = c.String(maxLength: 40),
                        IsActive = c.Boolean(nullable: false),
                        RecordDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ABREVIATE);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PropertyMgrComplex", "ManagerID", "dbo.PropertyMgr");
            DropForeignKey("dbo.PropertyMgr", "ManagingComp", "dbo.ComplexManagingCompany");
            DropForeignKey("dbo.PropertyMgrComplex", "ComplexCode", "dbo.Complex");
            DropIndex("dbo.PropertyMgr", new[] { "ManagingComp" });
            DropIndex("dbo.PropertyMgrComplex", new[] { "ComplexCode" });
            DropIndex("dbo.PropertyMgrComplex", new[] { "ManagerID" });
            DropTable("dbo.WORKTYPE");
            DropTable("dbo.WORKORDR");
            DropTable("dbo.wdClass");
            DropTable("dbo.Team");
            DropTable("dbo.MATERIAL");
            DropTable("dbo.JobSite");
            DropTable("dbo.JobScope");
            DropTable("dbo.EMPLWORK");
            DropTable("dbo.EMPLWORKLVL1");
            DropTable("dbo.ComplexManagingCompany");
            DropTable("dbo.PropertyMgr");
            DropTable("dbo.PropertyMgrComplex");
            DropTable("dbo.Complex");
            DropTable("dbo.BMODWiz");
        }
    }
}
