namespace LTQL_1721050304.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_ble_LH : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHoc304",
                c => new
                    {
                        Malop = c.Int(nullable: false, identity: true),
                        TenLop = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Malop);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LopHoc304");
        }
    }
}
