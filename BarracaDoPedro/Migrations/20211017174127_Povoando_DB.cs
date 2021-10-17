using Microsoft.EntityFrameworkCore.Migrations;

namespace BarracaDoPedro.Migrations
{
    public partial class Povoando_DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produto(Nome,Descricao,Imagem, Estoque,Valor) VALUES('Abobora','Fonte de vitaminas A, B e C','www',1,7.25)") ;
            migrationBuilder.Sql("INSERT INTO Produto(Nome,Descricao,Imagem, Estoque,Valor) VALUES('Ovos','Dúzia de ovos fonte de proteína e fresquinhos','www',1,9.50)");
            migrationBuilder.Sql("INSERT INTO Produto(Nome,Descricao,Imagem, Estoque,Valor) VALUES('Ovos','Meia-dúzia de ovos fonte perfeita de proteína e fresquinhos','www',1,4.25)");
            migrationBuilder.Sql("INSERT INTO Produto(Nome,Descricao,Imagem, Estoque,Valor) VALUES('Coco','Coco da Bahia a melhor forma de se refrescar com saúde e sabor','www',1,3.00)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produto");

        }
    }
}
