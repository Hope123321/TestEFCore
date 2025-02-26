using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TestEFCore.Service.Models;

public partial class RdErpV1Context : DbContext
{
    public RdErpV1Context()
    {
    }

    public RdErpV1Context(DbContextOptions<RdErpV1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ComClaDatum> ComClaData { get; set; }

    public virtual DbSet<ComClaType> ComClaTypes { get; set; }

    public virtual DbSet<ComSeqDatum> ComSeqData { get; set; }

    public virtual DbSet<ContCharge> ContCharges { get; set; }

    public virtual DbSet<ContTime> ContTimes { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<CoreApilog> CoreApilogs { get; set; }

    public virtual DbSet<CoreApisysLog> CoreApisysLogs { get; set; }

    public virtual DbSet<CsOpsDocCla> CsOpsDocClas { get; set; }

    public virtual DbSet<CsOpsDocTop> CsOpsDocTops { get; set; }

    public virtual DbSet<CsQuoDocDet> CsQuoDocDets { get; set; }

    public virtual DbSet<CsQuoDocTop> CsQuoDocTops { get; set; }

    public virtual DbSet<CsReqDocTop> CsReqDocTops { get; set; }

    public virtual DbSet<CustBranch> CustBranches { get; set; }

    public virtual DbSet<CustCompany> CustCompanies { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<ShiftSchMdTop> ShiftSchMdTops { get; set; }

    public virtual DbSet<ShiftSchRec> ShiftSchRecs { get; set; }

    public virtual DbSet<ShiftSchSet> ShiftSchSets { get; set; }

    public virtual DbSet<ShiftSchType> ShiftSchTypes { get; set; }

    public virtual DbSet<SysFunction> SysFunctions { get; set; }

    public virtual DbSet<SysGroupDet> SysGroupDets { get; set; }

    public virtual DbSet<SysGroupTop> SysGroupTops { get; set; }

    public virtual DbSet<SysLocale> SysLocales { get; set; }

    public virtual DbSet<SysLocaleDatum> SysLocaleData { get; set; }

    public virtual DbSet<SysMenu> SysMenus { get; set; }

    public virtual DbSet<SysNotice> SysNotices { get; set; }

    public virtual DbSet<SysNoticeList> SysNoticeLists { get; set; }

    public virtual DbSet<SysNoticeRead> SysNoticeReads { get; set; }

    public virtual DbSet<SysSetDet> SysSetDets { get; set; }

    public virtual DbSet<SysSetTop> SysSetTops { get; set; }

    public virtual DbSet<SysUseLimit> SysUseLimits { get; set; }

    public virtual DbSet<SysUseLog> SysUseLogs { get; set; }

    public virtual DbSet<SysUser> SysUsers { get; set; }

    public virtual DbSet<SysUserMenu> SysUserMenus { get; set; }

    public virtual DbSet<WebApiset> WebApisets { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection")??"");
    ////optionsBuilder.UseSqlServer("Server=192.168.0.26\\SQL2022;Database=RD_ERP_V1;TrustServerCertificate=True;MultipleActiveResultSets=true;User ID=RTXSTD;Password=Retex16031227");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ComClaDatum>(entity =>
        {
            entity.HasKey(e => new { e.ComNo, e.ClaTyNo, e.ClaNo });

            entity.ToTable(tb => tb.HasComment("共用分類資料"));

            entity.Property(e => e.ComNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("共用代碼 CSOPS=客戶服務");
            entity.Property(e => e.ClaTyNo)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("類別代碼 FK:COMCLATYPE.CLATYNO");
            entity.Property(e => e.ClaNo)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("分類代碼");
            entity.Property(e => e.ClaNa)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("分類名稱");
            entity.Property(e => e.PclaNo)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("上層分類代碼 FK:COMCLADATA.CLANO")
                .HasColumnName("PClaNo");
        });

        modelBuilder.Entity<ComClaType>(entity =>
        {
            entity.HasKey(e => new { e.ComNo, e.ClaTyNo });

            entity.ToTable("ComClaType", tb => tb.HasComment("共用分類類別"));

            entity.Property(e => e.ComNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("共用代碼 CSOPS=客戶服務");
            entity.Property(e => e.ClaTyNo)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("類別代碼 01/02../10");
            entity.Property(e => e.ClaTyNa)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("類別名稱");
            entity.Property(e => e.IsMust).HasComment("必要分類");
            entity.Property(e => e.IsUse).HasComment("是否啟用");
            entity.Property(e => e.PclaTyNo)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("上層分類 FK:COMCLATYPE.CLATYNO")
                .HasColumnName("PClaTyNo");
        });

        modelBuilder.Entity<ComSeqDatum>(entity =>
        {
            entity.HasKey(e => new { e.SeqType, e.SeqDate });

            entity.ToTable(tb => tb.HasComment("共用編號資料"));

            entity.Property(e => e.SeqType)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("編號類別");
            entity.Property(e => e.SeqDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("編號日期");
            entity.Property(e => e.SeqNo).HasComment("最大編號");
        });

        modelBuilder.Entity<ContCharge>(entity =>
        {
            entity.HasKey(e => new { e.ContNo, e.ChgType });

            entity.ToTable("ContCharge", tb => tb.HasComment("合約資料計費"));

            entity.Property(e => e.ContNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("合約編號 FK:CONTRACT.CONTNO");
            entity.Property(e => e.ChgType)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("計費類別 C=客製增修/S=客服維運");
            entity.Property(e => e.ChgPrc)
                .HasComment("計費單價")
                .HasColumnType("decimal(14, 4)");
            entity.Property(e => e.ChgUnit)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("計費單位 H=人時/D=人日");
        });

        modelBuilder.Entity<ContTime>(entity =>
        {
            entity.HasKey(e => new { e.ContNo, e.TimeType });

            entity.ToTable("ContTime", tb => tb.HasComment("合約資料時段"));

            entity.Property(e => e.ContNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("合約編號 FK:CONTRACT.CONTNO");
            entity.Property(e => e.TimeType)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("時段類別 W=平日/H=假日");
            entity.Property(e => e.EdTime)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasComment("結束時間 HH:MM");
            entity.Property(e => e.StTime)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasComment("起始時間 HH:MM");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.ContNo);

            entity.ToTable("Contract", tb => tb.HasComment("合約資料"));

            entity.Property(e => e.ContNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("合約編號");
            entity.Property(e => e.Amount)
                .HasComment("合約金額")
                .HasColumnType("decimal(14, 4)");
            entity.Property(e => e.BuyDay).HasComment("增購人日");
            entity.Property(e => e.CauseNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("原案合約 FK:CONTACT.CONTNO");
            entity.Property(e => e.ContDay).HasComment("合約人日");
            entity.Property(e => e.ContNa)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("合約名稱");
            entity.Property(e => e.ContRem)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("合約備註");
            entity.Property(e => e.ContType)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("合約類別 C=新案/S=維護");
            entity.Property(e => e.CustNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("客戶編號 FK:CUSTOMER.CUSTNO");
            entity.Property(e => e.DocFile)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("電子文檔 實體檔案儲存，僅記錄檔名(含副檔名)");
            entity.Property(e => e.EdDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("結束日期");
            entity.Property(e => e.OpsRate)
                .HasComment("維護費率")
                .HasColumnType("decimal(5, 2)");
            entity.Property(e => e.StDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("起始日期");
            entity.Property(e => e.StopDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("終止日期");
        });

        modelBuilder.Entity<CoreApilog>(entity =>
        {
            entity.HasKey(e => new { e.LogNo, e.Token });

            entity.ToTable("CoreAPILog", tb => tb.HasComment("CoreAPI傳輸記錄"));

            entity.Property(e => e.LogNo)
                .ValueGeneratedOnAdd()
                .HasComment("記錄序號");
            entity.Property(e => e.Token)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("連線識別碼 FK:COREAPISET.TOKEN");
            entity.Property(e => e.Apimethod)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("API方法 參考API規格說明文件")
                .HasColumnName("APIMethod");
            entity.Property(e => e.LogDateTime)
                .HasComment("記錄時間")
                .HasColumnType("datetime");
            entity.Property(e => e.LogIp)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("記錄來源")
                .HasColumnName("LogIP");
            entity.Property(e => e.Request)
                .HasMaxLength(4000)
                .HasDefaultValueSql("('')")
                .HasComment("要求資料 存放要求JSON資料內容(明文)");
            entity.Property(e => e.Response)
                .HasMaxLength(4000)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Signature)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Timestamp).HasComment("時間戳記");
        });

        modelBuilder.Entity<CoreApisysLog>(entity =>
        {
            entity.HasKey(e => new { e.LogNo, e.Token });

            entity.ToTable("CoreAPISysLog", tb => tb.HasComment("CoreAPI傳輸記錄"));

            entity.Property(e => e.LogNo)
                .ValueGeneratedOnAdd()
                .HasComment("記錄序號");
            entity.Property(e => e.Token)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("連線識別碼 FK:COREAPISET.TOKEN");
            entity.Property(e => e.Apimethod)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("API方法 參考API規格說明文件")
                .HasColumnName("APIMethod");
            entity.Property(e => e.LogDateTime)
                .HasComment("記錄時間")
                .HasColumnType("datetime");
            entity.Property(e => e.LogIp)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("記錄來源")
                .HasColumnName("LogIP");
            entity.Property(e => e.Request)
                .HasMaxLength(4000)
                .HasDefaultValueSql("('')")
                .HasComment("要求資料 存放要求JSON資料內容(明文)");
            entity.Property(e => e.Signature)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Timestamp).HasComment("時間戳記");
        });

        modelBuilder.Entity<CsOpsDocCla>(entity =>
        {
            entity.HasKey(e => e.OpsNo);

            entity.ToTable("CsOpsDocCla", tb => tb.HasComment("服務單據記錄"));

            entity.Property(e => e.OpsNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("服務單號 FK:CSOPSDOCTOP.OPSNO");
            entity.Property(e => e.Cno01)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("分類階層01")
                .HasColumnName("CNo01");
            entity.Property(e => e.Cno02)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("分類階層02")
                .HasColumnName("CNo02");
            entity.Property(e => e.Cno03)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("分類階層03")
                .HasColumnName("CNo03");
            entity.Property(e => e.Cno04)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("分類階層04")
                .HasColumnName("CNo04");
            entity.Property(e => e.Cno05)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("分類階層05")
                .HasColumnName("CNo05");
            entity.Property(e => e.Cno06)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("分類階層06")
                .HasColumnName("CNo06");
            entity.Property(e => e.Cno07)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("分類階層07")
                .HasColumnName("CNo07");
            entity.Property(e => e.Cno08)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("分類階層08")
                .HasColumnName("CNo08");
            entity.Property(e => e.Cno09)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("分類階層09")
                .HasColumnName("CNo09");
            entity.Property(e => e.Cno10)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("分類階層10")
                .HasColumnName("CNo10");
        });

        modelBuilder.Entity<CsOpsDocTop>(entity =>
        {
            entity.HasKey(e => e.OpsNo);

            entity.ToTable("CsOpsDocTop", tb => tb.HasComment("服務單據記錄"));

            entity.Property(e => e.OpsNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("服務單號");
            entity.Property(e => e.CloseDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("結案日期");
            entity.Property(e => e.CloseTime)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasComment("結案時間 HH:MM");
            entity.Property(e => e.CloseUser)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("結案人員 FK:SYSUSER.USERNO");
            entity.Property(e => e.ContName)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("聯絡人員");
            entity.Property(e => e.ContTel)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("聯絡電話");
            entity.Property(e => e.CustBraNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("單位編號 FK:CUSTBRANCH.CUSTBRANO");
            entity.Property(e => e.CustNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("客戶編號 FK:CUSTOMER.CUSTNO");
            entity.Property(e => e.OpsDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("服務日期");
            entity.Property(e => e.OpsDesc)
                .HasMaxLength(2000)
                .HasDefaultValueSql("('')")
                .HasComment("服務說明");
            entity.Property(e => e.OpsHour)
                .HasComment("服務工時")
                .HasColumnType("decimal(5, 2)");
            entity.Property(e => e.OpsRem)
                .HasMaxLength(2000)
                .HasDefaultValueSql("('')")
                .HasComment("服務備註");
            entity.Property(e => e.OpsStatus)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("服務狀態 C.待處理/P.處理中/Y.已結案");
            entity.Property(e => e.OpsTime)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasComment("服務時間 HH:MM");
            entity.Property(e => e.OpsUser)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("服務人員 FK:SYSUSER.USERNO");
            entity.Property(e => e.ProcDesc)
                .HasMaxLength(2000)
                .HasDefaultValueSql("('')")
                .HasComment("處理說明");
            entity.Property(e => e.TimeType)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("時段類別 W=平日/H=假日");
        });

        modelBuilder.Entity<CsQuoDocDet>(entity =>
        {
            entity.HasKey(e => new { e.QuoNo, e.ItemOrd });

            entity.ToTable("CsQuoDocDet", tb => tb.HasComment("報價單據明細"));

            entity.Property(e => e.QuoNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("報價單號 FK:CSQUODOCTOP.QUONO");
            entity.Property(e => e.ItemOrd).HasComment("項次");
            entity.Property(e => e.Prc)
                .HasComment("單價")
                .HasColumnType("decimal(14, 4)");
            entity.Property(e => e.Qty)
                .HasComment("數量")
                .HasColumnType("decimal(5, 2)");
            entity.Property(e => e.QuoItem)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasComment("報價項目");
        });

        modelBuilder.Entity<CsQuoDocTop>(entity =>
        {
            entity.HasKey(e => e.QuoNo);

            entity.ToTable("CsQuoDocTop", tb => tb.HasComment("報價單據記錄"));

            entity.Property(e => e.QuoNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("報價單號");
            entity.Property(e => e.CompNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("客戶統編 FK:CUSTCOMPANY.COMPNO");
            entity.Property(e => e.ContEmail)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("聯絡信箱");
            entity.Property(e => e.ContName)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("聯絡人員");
            entity.Property(e => e.ContTel)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("聯絡電話");
            entity.Property(e => e.DocFile)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("電子文檔 實體檔案儲存，僅記錄檔名(含副檔名)");
            entity.Property(e => e.DocRem)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("單據備註");
            entity.Property(e => e.LinkDocNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("關聯單號 依QUOTYPE關聯不同資料表");
            entity.Property(e => e.QuoAmt)
                .HasComment("報價金額")
                .HasColumnType("decimal(14, 4)");
            entity.Property(e => e.QuoDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("報價日期");
            entity.Property(e => e.QuoNa)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("報價名稱");
            entity.Property(e => e.QuoRem)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasComment("報價備註");
            entity.Property(e => e.QuoStatus)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("報價狀態 Q=報價/S=簽回/D=作廢");
            entity.Property(e => e.QuoType)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("報價類別 R=客製增修/H=硬體採購/F=設備維修");
            entity.Property(e => e.QuoUser)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("承辦人員 FK:SYSUSER.USERNO");
            entity.Property(e => e.Tel)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("承辦電話");
        });

        modelBuilder.Entity<CsReqDocTop>(entity =>
        {
            entity.HasKey(e => e.ReqNo);

            entity.ToTable("CsReqDocTop", tb => tb.HasComment("需求單據記錄"));

            entity.Property(e => e.ReqNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("需求單號");
            entity.Property(e => e.AccDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("驗收日期");
            entity.Property(e => e.CfmDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("確認日期");
            entity.Property(e => e.ContNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("合約編號 FK:CONTRACT.CONTNO");
            entity.Property(e => e.CustNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("客戶編號 FK:CUSTOMER.CUSTNO");
            entity.Property(e => e.DevUser)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("開發人員 FK:SYSUSER.USERNO");
            entity.Property(e => e.DlvDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("交測日期");
            entity.Property(e => e.DocFile)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("電子文檔 實體檔案儲存，僅記錄檔名(含副檔名)");
            entity.Property(e => e.EstDate)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("預計完成日");
            entity.Property(e => e.EstDesc)
                .HasMaxLength(1000)
                .HasDefaultValueSql("('')")
                .HasComment("評估說明");
            entity.Property(e => e.EstPrc)
                .HasComment("評估單價 可利用合約自動帶入")
                .HasColumnType("decimal(14, 4)");
            entity.Property(e => e.EstQty)
                .HasComment("評估數量")
                .HasColumnType("decimal(5, 2)");
            entity.Property(e => e.EstUnit)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("評估單位 H=人時/D=人日");
            entity.Property(e => e.EstUser)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("評估人員 FK:SYSUSER.USERNO");
            entity.Property(e => e.ExeStatus)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("執行狀態 RA=待評估/CF=待確認/SA=待派工/PG=執行中/TS=交測中/OK=已驗收");
            entity.Property(e => e.InvAmt)
                .HasComment("請款金額")
                .HasColumnType("decimal(14, 4)");
            entity.Property(e => e.InvDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("發票日期");
            entity.Property(e => e.InvNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("發票號碼");
            entity.Property(e => e.InvRem)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("請款備註");
            entity.Property(e => e.InvStatus)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("請款狀態 N.無須請款/W.等待請款/Y.完成請款");
            entity.Property(e => e.InvType)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("請款類別 N=合約範圍不計費/Y=報價收費或合約人日折抵");
            entity.Property(e => e.OpsUser)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("客服人員 FK:SYSUSER.USERNO");
            entity.Property(e => e.ReqDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("申請日期");
            entity.Property(e => e.ReqDesc)
                .HasMaxLength(1000)
                .HasDefaultValueSql("('')")
                .HasComment("需求說明");
            entity.Property(e => e.ReqNa)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("需求名稱");
            entity.Property(e => e.ReqRem)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasComment("需求備註");
            entity.Property(e => e.ReqStatus)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("需求狀態 A=申請/Y=確認/F=結案/C=取消/D=作廢");
            entity.Property(e => e.ReqUser)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("申請人員");
        });

        modelBuilder.Entity<CustBranch>(entity =>
        {
            entity.HasKey(e => new { e.CustNo, e.CustBraNo });

            entity.ToTable("CustBranch", tb => tb.HasComment("客戶資料單位"));

            entity.Property(e => e.CustNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("客戶編號 FK:CUSTOMER.CUSTNO");
            entity.Property(e => e.CustBraNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("單位編號");
            entity.Property(e => e.ContAddr)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("聯絡地址");
            entity.Property(e => e.ContEmail)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("電子郵件");
            entity.Property(e => e.ContMobile)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("行動電話");
            entity.Property(e => e.ContName)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("聯絡人員");
            entity.Property(e => e.ContTel)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("聯絡電話");
            entity.Property(e => e.CustBraNa)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("單位名稱");
            entity.Property(e => e.CustBraRem)
                .HasMaxLength(1000)
                .HasDefaultValueSql("('')")
                .HasComment("單位備註");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasColumnName("IP");
            entity.Property(e => e.IsStop).HasComment("是否停用 0=啟用/1=停用");
            entity.Property(e => e.Remote)
                .HasMaxLength(1000)
                .HasDefaultValueSql("('')")
                .HasComment("連線方式");
        });

        modelBuilder.Entity<CustCompany>(entity =>
        {
            entity.HasKey(e => new { e.CustNo, e.CompNo });

            entity.ToTable("CustCompany", tb => tb.HasComment("客戶資料公司"));

            entity.Property(e => e.CustNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("客戶編號 FK:CUSTOMER.CUSTNO");
            entity.Property(e => e.CompNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("公司統編");
            entity.Property(e => e.CompAddr)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("公司地址");
            entity.Property(e => e.CompFax)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("公司傳真");
            entity.Property(e => e.CompNa)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("公司名稱");
            entity.Property(e => e.CompOwner)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("負責人");
            entity.Property(e => e.CompRem)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasComment("公司備註");
            entity.Property(e => e.CompTel)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("公司電話");
            entity.Property(e => e.ContEmail)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("電子郵件");
            entity.Property(e => e.ContMobile)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("行動電話");
            entity.Property(e => e.ContName)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("聯絡人員");
            entity.Property(e => e.ContTel)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("聯絡電話");
            entity.Property(e => e.IsStop).HasComment("是否停用 0=啟用/1=停用");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustNo);

            entity.ToTable("Customer", tb => tb.HasComment("客戶資料"));

            entity.Property(e => e.CustNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("客戶編號");
            entity.Property(e => e.CustDev1)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("研發人員1 FK:SYSUSER.USERNO");
            entity.Property(e => e.CustDev2)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("研發人員2 FK:SYSUSER.USERNO");
            entity.Property(e => e.CustNa)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("客戶名稱");
            entity.Property(e => e.CustOps1)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("客服人員1 FK:SYSUSER.USERNO");
            entity.Property(e => e.CustOps2)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("客服人員2 FK:SYSUSER.USERNO");
            entity.Property(e => e.CustRem)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasComment("客戶備註");
            entity.Property(e => e.IsStop).HasComment("是否停用 0=啟用/1=停用");
            entity.Property(e => e.OnlineDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("上線日期");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmpNo);

            entity.ToTable("Employee", tb => tb.HasComment("員工資料"));

            entity.Property(e => e.EmpNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("員工編號");
            entity.Property(e => e.Addr)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("地址");
            entity.Property(e => e.Birthday)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("生日");
            entity.Property(e => e.DataStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.EffDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("到職日期");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("電子郵件");
            entity.Property(e => e.EmpCardNo)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')")
                .HasComment("員工卡號");
            entity.Property(e => e.EmpId)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("身份證字號");
            entity.Property(e => e.EmpNa)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("員工姓名");
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("員工狀態 OK:正常/ED:停用/LV:離職");
            entity.Property(e => e.ExtDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("離職日期");
            entity.Property(e => e.IsEcrSales).HasComment("前台售貨員旗標");
            entity.Property(e => e.IsEmpSales).HasComment("業務員旗標");
            entity.Property(e => e.LoginShop)
                .HasMaxLength(4000)
                .HasDefaultValueSql("('')")
                .HasComment("可簽到門市");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("行動電話");
            entity.Property(e => e.Tel1)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("電話一");
            entity.Property(e => e.Tel2)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("電話二");
            entity.Property(e => e.Title)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("職稱");
            entity.Property(e => e.UpdVip)
                .HasComment("自動更新會員")
                .HasColumnName("Upd_Vip");
            entity.Property(e => e.VipNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("會員編號");
            entity.Property(e => e.VipTyNo)
                .HasMaxLength(4)
                .HasDefaultValueSql("('')")
                .HasComment("會員型別");
        });

        modelBuilder.Entity<ShiftSchMdTop>(entity =>
        {
            entity.HasKey(e => e.SchMdNo);

            entity.ToTable("ShiftSchMdTop", tb => tb.HasComment("值機調整記錄"));

            entity.Property(e => e.SchMdNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("調整單號");
            entity.Property(e => e.ApplyDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("申請日期");
            entity.Property(e => e.ApplyTime)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasComment("申請時間 HH:MM");
            entity.Property(e => e.ApplyUser)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("申請人員 FK:SYSUSER.USERNO");
            entity.Property(e => e.MdEdDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("調整結束日期");
            entity.Property(e => e.MdShiftColor)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MdShiftUser)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("調整值機人員 FK:SYSUSER.USERNO");
            entity.Property(e => e.MdStDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("調整起始日期");
            entity.Property(e => e.MdStatus)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("調整狀態 A=申請中/S=已簽核/D=已撤銷");
            entity.Property(e => e.Rem)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("備註");
            entity.Property(e => e.SignDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("簽核日期");
            entity.Property(e => e.SignTime)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasComment("簽核時間 HH:MM");
            entity.Property(e => e.SignUser)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("簽核人員 FK:SYSUSER.USERNO");
        });

        modelBuilder.Entity<ShiftSchRec>(entity =>
        {
            entity.HasKey(e => new { e.Year, e.ShiftDate });

            entity.ToTable("ShiftSchRec", tb => tb.HasComment("值機排班記錄"));

            entity.Property(e => e.Year).HasComment("年份");
            entity.Property(e => e.ShiftDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("值機日期");
            entity.Property(e => e.CloseStatus)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("結算狀態 CF=已確認/S=已簽核/CL=已結算");
            entity.Property(e => e.ShiftUser)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("值機人員 FK:SYSUSER.USERNO");
            entity.Property(e => e.TextColor)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("文字顏色");
            entity.Property(e => e.UpdateTime)
                .HasMaxLength(16)
                .HasDefaultValueSql("('')")
                .HasComment("更新時間 YYYY/MM/DD HH:MM");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("更新人員 FK:SYSUSER.USERNO");
        });

        modelBuilder.Entity<ShiftSchSet>(entity =>
        {
            entity.HasKey(e => new { e.Year, e.HldDate });

            entity.ToTable("ShiftSchSet", tb => tb.HasComment("值機假日設定"));

            entity.Property(e => e.Year).HasComment("年份");
            entity.Property(e => e.HldDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("假日日期");
            entity.Property(e => e.HldName)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("假日名稱");
            entity.Property(e => e.ShiftTyNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("值機類別 FK:SHIFTSCHTYPE.SHIFTTYNO");
            entity.Property(e => e.TextColor)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("文字顏色");
        });

        modelBuilder.Entity<ShiftSchType>(entity =>
        {
            entity.HasKey(e => e.ShiftTyNo);

            entity.ToTable("ShiftSchType", tb => tb.HasComment("值機類別設定"));

            entity.Property(e => e.ShiftTyNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("類別代碼");
            entity.Property(e => e.BackColor)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("日曆底色");
            entity.Property(e => e.EdTime)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasComment("結束時間 HH:MM");
            entity.Property(e => e.IsUse).HasComment("是否啟用 1=啟用/0=停用");
            entity.Property(e => e.PayRate)
                .HasComment("值機費倍率")
                .HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ShiftHour)
                .HasComment("值機時數")
                .HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ShiftTyNa)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("類別名稱");
            entity.Property(e => e.StTime)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasComment("起始時間 HH:MM");
        });

        modelBuilder.Entity<SysFunction>(entity =>
        {
            entity.HasKey(e => new { e.SysType, e.MenuNo, e.FuncNo });

            entity.ToTable("SysFunction", tb => tb.HasComment("系統功能權限"));

            entity.Property(e => e.SysType)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("系統類別 FK:SYSMENU.SYSTYPE");
            entity.Property(e => e.MenuNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("功能編號 FK:SYSMENU.MENUNO");
            entity.Property(e => e.FuncNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("操作編號");
            entity.Property(e => e.FuncNa)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("操作名稱");
            entity.Property(e => e.FuncSort).HasComment("功能編號");
        });

        modelBuilder.Entity<SysGroupDet>(entity =>
        {
            entity.HasKey(e => new { e.GrpNo, e.UserNo });

            entity.ToTable("SysGroupDet", tb => tb.HasComment("系統群組明細"));

            entity.Property(e => e.GrpNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("群組編號 FK:SYSGROUPTOP.GRPNO");
            entity.Property(e => e.UserNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("帳號編號");
        });

        modelBuilder.Entity<SysGroupTop>(entity =>
        {
            entity.HasKey(e => e.GrpNo);

            entity.ToTable("SysGroupTop", tb => tb.HasComment("系統群組資料"));

            entity.Property(e => e.GrpNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("群組編號");
            entity.Property(e => e.GrpNa)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("群組名稱");
            entity.Property(e => e.GrpRem)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("群組備註");
        });

        modelBuilder.Entity<SysLocale>(entity =>
        {
            entity.HasKey(e => e.LocaleNo);

            entity.Property(e => e.LocaleNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LocaleNa).HasMaxLength(100);
            entity.Property(e => e.Rem).HasMaxLength(200);
        });

        modelBuilder.Entity<SysLocaleDatum>(entity =>
        {
            entity.HasKey(e => new { e.LocaleNo, e.MenuNo, e.DisplayKey });

            entity.Property(e => e.LocaleNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MenuNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DisplayKey).HasMaxLength(100);
            entity.Property(e => e.DisplayValue).HasMaxLength(1000);
            entity.Property(e => e.Rem).HasMaxLength(500);
        });

        modelBuilder.Entity<SysMenu>(entity =>
        {
            entity.HasKey(e => new { e.SysType, e.ListNo });

            entity.ToTable("SysMenu", tb => tb.HasComment("系統功能選單"));

            entity.Property(e => e.SysType)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasComment("系統類別");
            entity.Property(e => e.ListNo).HasComment("排序編號");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("功能圖示路徑");
            entity.Property(e => e.MenuDesc)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("功能說明");
            entity.Property(e => e.MenuNa)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("功能名稱");
            entity.Property(e => e.MenuNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("功能編號");
            entity.Property(e => e.MenuType)
                .HasMaxLength(1)
                .HasDefaultValueSql("('')")
                .HasComment("功能類別 F:目錄/P:程式");
            entity.Property(e => e.ParentNo).HasComment("上層編號 MENUTYPE必須為F");
        });

        modelBuilder.Entity<SysNotice>(entity =>
        {
            entity.HasKey(e => e.NtcNo);

            entity.ToTable("SysNotice", tb => tb.HasComment("總部公告"));

            entity.Property(e => e.NtcNo).HasComment("公告編號 自動編號");
            entity.Property(e => e.Content)
                .HasDefaultValueSql("('')")
                .HasComment("公告內容")
                .HasColumnType("ntext");
            entity.Property(e => e.DataStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.NtcDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("公告日期");
            entity.Property(e => e.NtcEmpNa)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("公告人員");
            entity.Property(e => e.NtcLevel)
                .HasMaxLength(1)
                .HasDefaultValueSql("('')")
                .HasComment("等級類別 S:極重要/A:重要/B:普通/C:一般");
            entity.Property(e => e.NtcStatus)
                .IsRequired()
                .HasDefaultValueSql("('0')")
                .HasComment("公告/不公告");
            entity.Property(e => e.NtcType)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("公告主旨");
        });

        modelBuilder.Entity<SysNoticeList>(entity =>
        {
            entity.HasKey(e => new { e.NtcNo, e.RecvNo }).HasName("PK_SysNoticeList_1");

            entity.ToTable("SysNoticeList", tb => tb.HasComment("公告收文單位清單"));

            entity.Property(e => e.NtcNo).HasComment("公告編號");
            entity.Property(e => e.RecvNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("單位代碼");
            entity.Property(e => e.DataStamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<SysNoticeRead>(entity =>
        {
            entity.HasKey(e => new { e.NtcNo, e.EmpNo });

            entity.ToTable("SysNoticeRead", tb => tb.HasComment("總部公告讀取記錄"));

            entity.Property(e => e.NtcNo).HasComment("公告編號 FK:SYSNOTICE.NTCNO");
            entity.Property(e => e.EmpNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("讀取員工");
            entity.Property(e => e.ReadDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("讀取日期");
            entity.Property(e => e.ReadTime)
                .HasMaxLength(8)
                .HasDefaultValueSql("('')")
                .HasComment("讀取時間 24H");
            entity.Property(e => e.ShopNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("員工所屬店櫃");
        });

        modelBuilder.Entity<SysSetDet>(entity =>
        {
            entity.HasKey(e => new { e.SetTopNo, e.SetNo });

            entity.ToTable("SysSetDet", tb => tb.HasComment("系統參數明細"));

            entity.Property(e => e.SetTopNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("群組編號 FK:SYSSETTOP.SETTOPNO");
            entity.Property(e => e.SetNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("參數編號");
            entity.Property(e => e.DataType)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("參數資料型態");
            entity.Property(e => e.IsSetEdit).HasComment("設定旗標");
            entity.Property(e => e.IsSetShow).HasComment("可視旗標");
            entity.Property(e => e.ListItem)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')")
                .HasComment("集合內容");
            entity.Property(e => e.MaxLength).HasComment("參數最大長度");
            entity.Property(e => e.MaxValue).HasComment("數值型態最大值");
            entity.Property(e => e.MinValue).HasComment("數值型態最小值");
            entity.Property(e => e.SetNa)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("參數名稱");
            entity.Property(e => e.SetRem)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasComment("參數說明");
            entity.Property(e => e.SetSort).HasComment("參數排序");
            entity.Property(e => e.SetValue)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasComment("參數值");
        });

        modelBuilder.Entity<SysSetTop>(entity =>
        {
            entity.HasKey(e => e.SetTopNo);

            entity.ToTable("SysSetTop", tb => tb.HasComment("系統參數群組"));

            entity.Property(e => e.SetTopNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("群組編號");
            entity.Property(e => e.SetTopNa)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("群組名稱");
            entity.Property(e => e.SetTopRem)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("群組說明");
            entity.Property(e => e.SetTopSort).HasComment("群組排序");
        });

        modelBuilder.Entity<SysUseLimit>(entity =>
        {
            entity.HasKey(e => new { e.UlType, e.UlNo, e.SysType, e.MenuNo, e.FuncNo });

            entity.ToTable("SysUseLimit", tb => tb.HasComment("系統使用權限"));

            entity.Property(e => e.UlType)
                .HasMaxLength(1)
                .HasDefaultValueSql("('')")
                .HasComment("權限類型 U:帳號/G:群組");
            entity.Property(e => e.UlNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("權限編號");
            entity.Property(e => e.SysType)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasComment("系統類別 FK:SYSMENU.SYSTYPE");
            entity.Property(e => e.MenuNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("功能編號 FK:SYSMENU.MENUNO");
            entity.Property(e => e.FuncNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("操作編號 FK:SYSFUNCTION.FUNCNO");
            entity.Property(e => e.UlLimit).HasComment("權限旗標 1:可使用/0:不控管/-1:禁用");
        });

        modelBuilder.Entity<SysUseLog>(entity =>
        {
            entity.HasKey(e => e.LogNo);

            entity.ToTable("SysUseLog", tb => tb.HasComment("系統使用記錄"));

            entity.Property(e => e.LogNo).HasComment("記錄編號");
            entity.Property(e => e.FuncNa)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("操作名稱");
            entity.Property(e => e.LogDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("記錄日期");
            entity.Property(e => e.LogIp)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("來源位置");
            entity.Property(e => e.LogPk)
                .HasMaxLength(4000)
                .HasDefaultValueSql("('')")
                .HasComment("記錄主鍵值 記錄操作異動資料主鍵值");
            entity.Property(e => e.LogRem)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')")
                .HasComment("記錄備註");
            entity.Property(e => e.LogTime)
                .HasMaxLength(8)
                .HasDefaultValueSql("('')")
                .HasComment("記錄時間");
            entity.Property(e => e.LogType)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("記錄類型 IO:登入登出/PW:密碼/AT:操作");
            entity.Property(e => e.MenuNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("功能編號 FK:SYSMENU.MENUNO");
            entity.Property(e => e.SysType)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasComment("系統類別 FK:SYSMENU.SYSTYPE");
            entity.Property(e => e.UserNa)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("帳號名稱");
        });

        modelBuilder.Entity<SysUser>(entity =>
        {
            entity.HasKey(e => e.UserNo);

            entity.ToTable("SysUser", tb => tb.HasComment("系統帳號資料"));

            entity.Property(e => e.UserNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("帳號編號 英文不區分大小寫");
            entity.Property(e => e.Avatar)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.EcrPwd)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("前台登入密碼 SHA256(英文全部大寫)");
            entity.Property(e => e.EmpNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("員工編號 FK:EMPLOYEE.EMPNO");
            entity.Property(e => e.IsEcrCashier).HasComment("前台使用旗標");
            entity.Property(e => e.IsWebUser).HasComment("後台使用旗標");
            entity.Property(e => e.PwdChgDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("密碼變更日期");
            entity.Property(e => e.PwdEffDate)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("密碼有效日期");
            entity.Property(e => e.PwdErrTime)
                .HasComment("密碼錯誤時間")
                .HasColumnType("datetime");
            entity.Property(e => e.PwdError).HasComment("密碼輸入錯誤");
            entity.Property(e => e.ShopNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("店櫃編號 FK:SHOP.SHOPNO");
            entity.Property(e => e.UserNa)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("帳號名稱");
            entity.Property(e => e.UserPwd)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("帳號密碼 SHA256(英文區分大小寫)");
            entity.Property(e => e.UserStatus)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("帳號狀態 OK:正常/ED:停用/LC:鎖定");
        });

        modelBuilder.Entity<SysUserMenu>(entity =>
        {
            entity.HasKey(e => new { e.UserNo, e.SysType, e.MenuNo });

            entity.ToTable("SysUserMenu", tb => tb.HasComment("使用者常用功能"));

            entity.Property(e => e.UserNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("使用者編號 FK:SYSUSER.USERNO");
            entity.Property(e => e.SysType)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')")
                .HasComment("系統類別 FK:SYSMENU.SYSTYPE");
            entity.Property(e => e.MenuNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("功能編號 FK:SYSMENU.MENUNO");
            entity.Property(e => e.MenuSort).HasComment("功能排序");
        });

        modelBuilder.Entity<WebApiset>(entity =>
        {
            entity.HasKey(e => e.Token);

            entity.ToTable("WebAPISet", tb => tb.HasComment("程式介面連線設定"));

            entity.Property(e => e.Token)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("連線識別碼");
            entity.Property(e => e.Apiiv)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("IV")
                .HasColumnName("APIIV");
            entity.Property(e => e.Apikey)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasComment("Key")
                .HasColumnName("APIKey");
            entity.Property(e => e.ApisaltKey)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasComment("SaltKey")
                .HasColumnName("APISaltKey");
            entity.Property(e => e.BindingType)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')")
                .HasComment("會員綁定模式 Y=註記且對照型別/N=註記不對照型別");
            entity.Property(e => e.CreditCard)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DefRegMdNo)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("會員新增模式 M10=單筆消費滿額");
            entity.Property(e => e.DefShopNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("會員申辦店櫃");
            entity.Property(e => e.DefVpTyNo)
                .HasMaxLength(4)
                .HasDefaultValueSql("('')")
                .HasComment("會員新增型別");
            entity.Property(e => e.EncodingType)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("簽章加密類型 SHA256/SHA512(預設)");
            entity.Property(e => e.GdsQtyType)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("庫存計算類型 Q=即時庫存表/S=標準推算(預設)");
            entity.Property(e => e.SysBraNo)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')")
                .HasComment("品牌代碼");
            entity.Property(e => e.SysType)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasComment("系統類型 EC=網購平台/APP=行動裝置/POS=收銀系統/LINE=LINE@/MMS=點餐平台");
            entity.Property(e => e.VipStamp).HasComment("會員批次戳記 儲存會員批次查詢最後戳記");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
