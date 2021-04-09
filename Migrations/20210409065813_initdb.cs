using Microsoft.EntityFrameworkCore.Migrations;

namespace Stusign.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "报读校区",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "B",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "六校优干",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "六校优少",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "六校三好",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "六市优干",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "六市优少",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "六市三好",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "六县优干",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "六县优少",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "六县三好",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "五校优干",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "五校优少",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "五校三好",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "五市优干",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "五市优少",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "五市三好",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "五县优干",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "五县优少",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "五县三好",
                table: "stuinfo",
                maxLength: 1,
                nullable: true,
                defaultValue: "0",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "报读校区",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "B");

            migrationBuilder.AlterColumn<string>(
                name: "六校优干",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "六校优少",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "六校三好",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "六市优干",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "六市优少",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "六市三好",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "六县优干",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "六县优少",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "六县三好",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "五校优干",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "五校优少",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "五校三好",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "五市优干",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "五市优少",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "五市三好",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "五县优干",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "五县优少",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");

            migrationBuilder.AlterColumn<string>(
                name: "五县三好",
                table: "stuinfo",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "0");
        }
    }
}
