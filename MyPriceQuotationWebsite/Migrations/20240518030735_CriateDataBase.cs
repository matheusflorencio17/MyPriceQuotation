using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPriceQuotationWebsite.Migrations
{
    /// <inheritdoc />
    public partial class CriateDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Quotation",
                table: "Quotation");

            migrationBuilder.RenameTable(
                name: "Quotation",
                newName: "quotation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_quotation",
                table: "quotation",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_quotation",
                table: "quotation");

            migrationBuilder.RenameTable(
                name: "quotation",
                newName: "Quotation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quotation",
                table: "Quotation",
                column: "Id");
        }
    }
}
