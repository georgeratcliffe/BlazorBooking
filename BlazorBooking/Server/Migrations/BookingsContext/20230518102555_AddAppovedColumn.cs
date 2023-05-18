using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorBooking.Server.Migrations.BookingsContext
{
    /// <inheritdoc />
    public partial class AddAppovedColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "Bookings",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approved",
                table: "Bookings");
        }
    }
}
