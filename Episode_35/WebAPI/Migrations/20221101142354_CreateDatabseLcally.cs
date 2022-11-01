using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazingChat.WebAPI.Migrations
{
    public partial class CreateDatabseLcally : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    log_id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    log_level = table.Column<string>(type: "TEXT", nullable: true),
                    source = table.Column<string>(type: "TEXT", nullable: true),
                    exception_message = table.Column<string>(type: "TEXT", nullable: true),
                    stack_trace = table.Column<string>(type: "TEXT", nullable: true),
                    created_date = table.Column<string>(type: "TEXT", nullable: true),
                    user_id = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.log_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    user_id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    email_address = table.Column<string>(type: "TEXT", nullable: false),
                    password = table.Column<string>(type: "TEXT", nullable: false),
                    source = table.Column<string>(type: "TEXT", nullable: false),
                    first_name = table.Column<string>(type: "TEXT", nullable: true),
                    last_name = table.Column<string>(type: "TEXT", nullable: true),
                    profile_picture_url = table.Column<string>(type: "TEXT", nullable: true),
                    date_of_birth = table.Column<byte[]>(type: "DATETIME", nullable: true),
                    about_me = table.Column<string>(type: "TEXT", nullable: true),
                    notifications = table.Column<long>(type: "INTEGER", nullable: true),
                    dark_theme = table.Column<long>(type: "INTEGER", nullable: true),
                    created_date = table.Column<byte[]>(type: "DATE", nullable: true),
                    profile_pic_data_url = table.Column<string>(type: "TEXT", nullable: true),
                    role = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "ChatHistory",
                columns: table => new
                {
                    chat_history_id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    from_user_id = table.Column<long>(type: "INT", nullable: false),
                    to_user_id = table.Column<long>(type: "INT", nullable: false),
                    message = table.Column<string>(type: "TEXT", nullable: false),
                    created_date = table.Column<byte[]>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatHistory", x => x.chat_history_id);
                    table.ForeignKey(
                        name: "FK_ChatHistory_Users_from_user_id",
                        column: x => x.from_user_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChatHistory_Users_to_user_id",
                        column: x => x.to_user_id,
                        principalTable: "Users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChatHistory_from_user_id",
                table: "ChatHistory",
                column: "from_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_ChatHistory_to_user_id",
                table: "ChatHistory",
                column: "to_user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatHistory");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
