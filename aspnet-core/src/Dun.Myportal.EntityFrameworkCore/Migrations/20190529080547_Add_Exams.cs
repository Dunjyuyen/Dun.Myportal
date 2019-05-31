using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dun.Myportal.Migrations
{
    public partial class Add_Exams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: false),
                    level = table.Column<int>(nullable: false),
                    IsAction = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamLevel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamTypes", x => x.Id);
                });
            
            migrationBuilder.CreateTable(
                name: "ExamQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TypeId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    LevelId = table.Column<int>(nullable: false),
                    Desc = table.Column<string>(nullable: true),
                    Option_1 = table.Column<string>(nullable: true),
                    Option_2 = table.Column<string>(nullable: true),
                    Option_3 = table.Column<string>(nullable: true),
                    Option_4 = table.Column<string>(nullable: true),
                    Option_5 = table.Column<string>(nullable: true),
                    Option_6 = table.Column<string>(nullable: true),
                    Option_7 = table.Column<string>(nullable: true),
                    Option_8 = table.Column<string>(nullable: true),
                    Option_9 = table.Column<string>(nullable: true),
                    Option_10 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamQuestions_ExamGroup_GroupId",
                        column: x => x.GroupId,
                        principalTable: "ExamGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamQuestions_ExamLevel_LevelId",
                        column: x => x.LevelId,
                        principalTable: "ExamLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamQuestions_ExamTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ExamTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            
            migrationBuilder.CreateTable(
                name: "ExamUserErrors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<long>(nullable: false),
                    ExamQuestionId = table.Column<int>(nullable: false),
                    ErrorAnswer = table.Column<string>(nullable: true),
                    ErrorDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamUserErrors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamUserErrors_ExamQuestions_ExamQuestionId",
                        column: x => x.ExamQuestionId,
                        principalTable: "ExamQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamUserErrors_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });


            

            migrationBuilder.CreateIndex(
                name: "IX_ExamQuestions_GroupId",
                table: "ExamQuestions",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamQuestions_LevelId",
                table: "ExamQuestions",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamQuestions_TypeId",
                table: "ExamQuestions",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamUserErrors_ExamQuestionId",
                table: "ExamUserErrors",
                column: "ExamQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamUserErrors_UserId",
                table: "ExamUserErrors",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropTable(
                name: "ExamUserErrors");

            migrationBuilder.DropTable(
                name: "ExamQuestions");

            migrationBuilder.DropTable(
                name: "ExamGroup");

            migrationBuilder.DropTable(
                name: "ExamLevel");

            migrationBuilder.DropTable(
                name: "ExamTypes");
        }
    }
}
