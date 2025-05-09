namespace ValidarParentesisBalanceados_Exam_JairPerez.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ValidationRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InputString = c.String(nullable: false),
                        IsValid = c.Boolean(nullable: false),
                        RequestDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ValidationRequests");
        }
    }
}
