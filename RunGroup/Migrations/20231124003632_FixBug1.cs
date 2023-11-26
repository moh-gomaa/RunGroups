using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RunGroup.Migrations
{
    public partial class FixBug1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Addresses_AddressID",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Addresses_AddressID",
                table: "Races");

            migrationBuilder.RenameColumn(
                name: "AddressID",
                table: "Races",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Races_AddressID",
                table: "Races",
                newName: "IX_Races_AddressId");

            migrationBuilder.RenameColumn(
                name: "AddressID",
                table: "Clubs",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Clubs_AddressID",
                table: "Clubs",
                newName: "IX_Clubs_AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Addresses_AddressId",
                table: "Clubs",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Addresses_AddressId",
                table: "Races",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Addresses_AddressId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Addresses_AddressId",
                table: "Races");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Races",
                newName: "AddressID");

            migrationBuilder.RenameIndex(
                name: "IX_Races_AddressId",
                table: "Races",
                newName: "IX_Races_AddressID");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Clubs",
                newName: "AddressID");

            migrationBuilder.RenameIndex(
                name: "IX_Clubs_AddressId",
                table: "Clubs",
                newName: "IX_Clubs_AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Addresses_AddressID",
                table: "Clubs",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Addresses_AddressID",
                table: "Races",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
