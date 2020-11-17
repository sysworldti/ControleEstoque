namespace ControleEstoque.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class obrigatoriedade_campo_email : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Email", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Email", c => c.String(maxLength: 100));
        }
    }
}
