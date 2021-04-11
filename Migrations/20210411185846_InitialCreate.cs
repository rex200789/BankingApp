using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    ACCOUNT_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ACCOUNT_NAME = table.Column<string>(type: "TEXT", nullable: false),
                    ACCOUNT_BALANCE = table.Column<decimal>(type: "TEXT", nullable: false),
                    ACTIVE = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ACCOUNT_ID);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TRANSACTION_ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FROM_ACCOUNT_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    TO_ACCOUNT_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    TRANACTION_TIMESTAMP = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AMOUNT = table.Column<decimal>(type: "TEXT", nullable: false),
                    FROM_ACCOUNT_BALANCE = table.Column<decimal>(type: "TEXT", nullable: false),
                    TO_ACCOUNT_BALANCE = table.Column<decimal>(type: "TEXT", nullable: false),
                    FROM_ACCOUNT_NAME = table.Column<string>(type: "TEXT", nullable: true),
                    TO_ACCOUNT_NAME = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TRANSACTION_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
