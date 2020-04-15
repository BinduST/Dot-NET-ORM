using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetorm.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agent",
                columns: table => new
                {
                    agent_code = table.Column<Guid>(nullable: false),
                    agent_name = table.Column<string>(nullable: true),
                    working_area = table.Column<string>(nullable: true),
                    commission = table.Column<int>(nullable: false),
                    phone_no = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent", x => x.agent_code);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    cust_code = table.Column<Guid>(nullable: false),
                    cust_name = table.Column<string>(nullable: true),
                    cust_city = table.Column<string>(nullable: true),
                    working_area = table.Column<int>(nullable: false),
                    cust_country = table.Column<string>(nullable: true),
                    grade = table.Column<int>(nullable: false),
                    opening_amt = table.Column<int>(nullable: false),
                    receive_amt = table.Column<int>(nullable: false),
                    payment_amt = table.Column<int>(nullable: false),
                    outstanding_amt = table.Column<int>(nullable: false),
                    phone_no = table.Column<string>(nullable: true),
                    agent_code = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.cust_code);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ord_num = table.Column<Guid>(nullable: false),
                    ord_amount = table.Column<int>(nullable: false),
                    advance_amount = table.Column<int>(nullable: false),
                    ord_date = table.Column<DateTime>(nullable: false),
                    cust_code = table.Column<Guid>(nullable: false),
                    agent_code = table.Column<Guid>(nullable: false),
                    ord_description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ord_num);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agent");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
