using Microsoft.EntityFrameworkCore.Migrations;

namespace Stusign.Migrations
{
    public partial class setdef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "操作状态",
                table: "stuinfo",
                maxLength: 10,
                nullable: true,
                defaultValue: "2",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "审核结果",
                table: "stuinfo",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "操作状态",
                table: "stuinfo",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValue: "2");

            migrationBuilder.AlterColumn<bool>(
                name: "审核结果",
                table: "stuinfo",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldNullable: true,
                oldDefaultValue: true);
        }
    }
}
