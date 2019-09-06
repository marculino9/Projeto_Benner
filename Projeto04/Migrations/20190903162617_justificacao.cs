using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto02.Migrations
{
    public partial class justificacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Justificacao",
                table: "SolicitacaoLicencas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Justificacao",
                table: "SolicitacaoLicencas");
        }
    }
}
