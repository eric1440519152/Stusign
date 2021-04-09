using Microsoft.EntityFrameworkCore.Migrations;

namespace Stusign.Migrations
{
    public partial class Newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "其它获奖次数一",
                table: "stuinfo");

            migrationBuilder.DropColumn(
                name: "其它获奖次数二",
                table: "stuinfo");

            migrationBuilder.DropColumn(
                name: "材料等级",
                table: "stuinfo");

            migrationBuilder.AddColumn<string>(
                name: "兴趣爱好",
                table: "stuinfo",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "兴趣爱好荣誉",
                table: "stuinfo",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "学生职务",
                table: "stuinfo",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "母亲职业类别",
                table: "stuinfo",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "父亲职业类别",
                table: "stuinfo",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "兴趣爱好",
                table: "stuinfo");

            migrationBuilder.DropColumn(
                name: "兴趣爱好荣誉",
                table: "stuinfo");

            migrationBuilder.DropColumn(
                name: "学生职务",
                table: "stuinfo");

            migrationBuilder.DropColumn(
                name: "母亲职业类别",
                table: "stuinfo");

            migrationBuilder.DropColumn(
                name: "父亲职业类别",
                table: "stuinfo");

            migrationBuilder.AddColumn<string>(
                name: "其它获奖次数一",
                table: "stuinfo",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "其它获奖次数二",
                table: "stuinfo",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "材料等级",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true);
        }
    }
}
