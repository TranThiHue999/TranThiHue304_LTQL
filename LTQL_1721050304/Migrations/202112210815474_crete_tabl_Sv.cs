namespace LTQL_1721050304.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class crete_tabl_Sv : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TTHSinhVien304",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 20),
                        HoTen = c.String(maxLength: 50),
                        MaLop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSinhVien)
                .ForeignKey("dbo.LopHoc304", t => t.MaLop, cascadeDelete: true)
                .Index(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TTHSinhVien304", "MaLop", "dbo.LopHoc304");
            DropIndex("dbo.TTHSinhVien304", new[] { "MaLop" });
            DropTable("dbo.TTHSinhVien304");
        }
    }
}
