namespace AutoDealership.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedTypeOfUserId : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.VehicleReservations", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VehicleReservations", "UserId", c => c.Int(nullable: false));
        }
    }
}
