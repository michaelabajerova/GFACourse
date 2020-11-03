using Microsoft.EntityFrameworkCore.Migrations;

namespace ListingToDoDb.Migrations
{
    public partial class initialversion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssigneesID",
                table: "Todos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Assignee",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignee", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AssigneesID",
                table: "Todos",
                column: "AssigneesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Assignee_AssigneesID",
                table: "Todos",
                column: "AssigneesID",
                principalTable: "Assignee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Assignee_AssigneesID",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Assignee");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AssigneesID",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "AssigneesID",
                table: "Todos");
        }
    }
}
