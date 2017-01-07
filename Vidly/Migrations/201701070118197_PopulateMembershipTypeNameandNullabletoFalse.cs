namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeNameandNullabletoFalse : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set Name= 'Pay As You Go'  where Id = 1");
            Sql("Update MembershipTypes Set Name= 'Monthly'  where Id = 2");
            Sql("Update MembershipTypes Set Name = 'Half Yearly'  where Id = 3");
            Sql("Update MembershipTypes Set Name= 'Annual'  where Id = 4");
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false,maxLength: 255));
        }
        
        public override void Down()
        {
        }
    }
}
