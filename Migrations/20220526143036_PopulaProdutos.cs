using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTreinamento.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "VALUES('Coca-Cola Diet','Refrigerante de Cola 350ml','5.45','cocacola.jpg',50,now(),1)");

            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "VALUES('Hamburger','Hamburger','8.50','hamburger.jpg',10,now(),2)");

            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "VALUES('Pudim','Pudim de leite consensado 100g','6.75','pudim.jpg',20,now(),3)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Produtos");
        }
    }
}