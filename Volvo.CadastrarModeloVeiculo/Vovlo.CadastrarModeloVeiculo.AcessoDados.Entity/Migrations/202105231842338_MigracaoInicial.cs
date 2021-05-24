namespace Vovlo.CadastrarModeloVeiculo.AcessoDados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MODELOVEICULO",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MODELO = c.String(nullable: false, maxLength: 15),
                        ANOFABRICACAO = c.String(nullable: false, maxLength: 7),
                        ANOMODELO = c.String(maxLength: 7),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MODELOVEICULO");
        }
    }
}
