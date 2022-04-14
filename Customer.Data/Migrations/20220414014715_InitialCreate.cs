using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Customer.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ms_org_directorate",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    code_findim = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ms_org_directorate", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ms_org_division",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_directorate = table.Column<int>(type: "integer", nullable: false),
                    code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    code_findim = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ms_org_division", x => x.id);
                    table.ForeignKey(
                        name: "FK_ms_org_division_ms_org_directorate_id_directorate",
                        column: x => x.id_directorate,
                        principalTable: "ms_org_directorate",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ms_account_manager",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "text", nullable: false),
                    fullname = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    id_team_leader = table.Column<int>(type: "integer", nullable: false),
                    id_directorate = table.Column<int>(type: "integer", nullable: false),
                    id_division = table.Column<int>(type: "integer", nullable: false),
                    created_datetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    updated_datetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    created_by = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    last_updated_by = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ms_account_manager", x => x.id);
                    table.ForeignKey(
                        name: "FK_ms_account_manager_ms_account_manager_id_team_leader",
                        column: x => x.id_team_leader,
                        principalTable: "ms_account_manager",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ms_account_manager_ms_org_directorate_id_directorate",
                        column: x => x.id_directorate,
                        principalTable: "ms_org_directorate",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ms_account_manager_ms_org_division_id_division",
                        column: x => x.id_division,
                        principalTable: "ms_org_division",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ms_account_manager_id_directorate",
                table: "ms_account_manager",
                column: "id_directorate");

            migrationBuilder.CreateIndex(
                name: "IX_ms_account_manager_id_division",
                table: "ms_account_manager",
                column: "id_division");

            migrationBuilder.CreateIndex(
                name: "IX_ms_account_manager_id_team_leader",
                table: "ms_account_manager",
                column: "id_team_leader");

            migrationBuilder.CreateIndex(
                name: "IX_ms_org_division_id_directorate",
                table: "ms_org_division",
                column: "id_directorate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ms_account_manager");

            migrationBuilder.DropTable(
                name: "ms_org_division");

            migrationBuilder.DropTable(
                name: "ms_org_directorate");
        }
    }
}
