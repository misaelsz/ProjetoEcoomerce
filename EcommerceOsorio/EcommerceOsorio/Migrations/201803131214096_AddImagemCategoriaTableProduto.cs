namespace EcommerceOsorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    /// <summary>
    /// Nessa migração foi adicionado o campo 
    /// imagem e categoria na classe produto
    /// </summary>
    public partial class AddImagemCategoriaTableProduto : DbMigration
    {

        public override void Up()
        {
            AddColumn("dbo.Produtos", "ProdutoImagem", c => c.String());
            AddColumn("dbo.Produtos", "ProdutoCategoria_CategoriaId", c => c.Int());
            CreateIndex("dbo.Produtos", "ProdutoCategoria_CategoriaId");
            AddForeignKey("dbo.Produtos", "ProdutoCategoria_CategoriaId", "dbo.Categorias", "CategoriaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtos", "ProdutoCategoria_CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Produtos", new[] { "ProdutoCategoria_CategoriaId" });
            DropColumn("dbo.Produtos", "ProdutoCategoria_CategoriaId");
            DropColumn("dbo.Produtos", "ProdutoImagem");
        }
    }
}
