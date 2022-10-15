using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace monolithic.Migrations
{
    public partial class DeleteTenantTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_post_tenant_type_TenantTypeId",
                table: "post");

            migrationBuilder.DropTable(
                name: "tenant_type");

            migrationBuilder.DropIndex(
                name: "IX_post_TenantTypeId",
                table: "post");

            migrationBuilder.DropColumn(
                name: "TenantTypeId",
                table: "post");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenantTypeId",
                table: "post",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tenant_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    display_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slug = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tenant_type", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_post_TenantTypeId",
                table: "post",
                column: "TenantTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_post_tenant_type_TenantTypeId",
                table: "post",
                column: "TenantTypeId",
                principalTable: "tenant_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
