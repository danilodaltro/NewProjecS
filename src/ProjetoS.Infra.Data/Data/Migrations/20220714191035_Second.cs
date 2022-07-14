using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoS.Infra.Data.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Cidade_Id_Cidade",
                schema: "dbo",
                table: "Pessoa");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Cidade_Id_Cidade",
                schema: "dbo",
                table: "Pessoa",
                column: "Id_Cidade",
                principalSchema: "dbo",
                principalTable: "Cidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Cidade_Id_Cidade",
                schema: "dbo",
                table: "Pessoa");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Cidade_Id_Cidade",
                schema: "dbo",
                table: "Pessoa",
                column: "Id_Cidade",
                principalSchema: "dbo",
                principalTable: "Cidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
