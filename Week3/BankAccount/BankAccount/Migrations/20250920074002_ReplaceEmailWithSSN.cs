using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankAccount.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceEmailWithSSN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountHolder",
                keyColumn: "AccountHolderId",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "AccountHolder",
                newName: "SSN");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SSN",
                table: "AccountHolder",
                newName: "Email");

            migrationBuilder.InsertData(
                table: "AccountHolder",
                columns: new[] { "AccountHolderId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 10, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@example.com", "John", "Doe", "123-456-7890" });
        }
    }
}
