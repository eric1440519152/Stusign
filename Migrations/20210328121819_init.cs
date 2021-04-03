using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stusign.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "stuinfo",
                columns: table => new
                {
                    身份证号 = table.Column<string>(maxLength: 18, nullable: false),
                    编号 = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    姓名 = table.Column<string>(maxLength: 8, nullable: true),
                    头像文件 = table.Column<string>(nullable: true),
                    性别 = table.Column<string>(maxLength: 2, nullable: true),
                    出生年月 = table.Column<string>(maxLength: 20, nullable: true),
                    全国学籍号 = table.Column<string>(maxLength: 19, nullable: true),
                    毕业学校 = table.Column<string>(maxLength: 50, nullable: true),
                    报读校区 = table.Column<string>(maxLength: 1, nullable: true),
                    生源地 = table.Column<string>(maxLength: 12, nullable: true),
                    户口所在地 = table.Column<string>(maxLength: 50, nullable: true),
                    学生实际住址 = table.Column<string>(maxLength: 100, nullable: true),
                    五市三好 = table.Column<string>(maxLength: 1, nullable: true),
                    五县三好 = table.Column<string>(maxLength: 1, nullable: true),
                    五校三好 = table.Column<string>(maxLength: 1, nullable: true),
                    五市优干 = table.Column<string>(maxLength: 1, nullable: true),
                    五县优干 = table.Column<string>(maxLength: 1, nullable: true),
                    五校优干 = table.Column<string>(maxLength: 1, nullable: true),
                    五市优少 = table.Column<string>(maxLength: 1, nullable: true),
                    五县优少 = table.Column<string>(maxLength: 1, nullable: true),
                    五校优少 = table.Column<string>(maxLength: 1, nullable: true),
                    六市三好 = table.Column<string>(maxLength: 1, nullable: true),
                    六县三好 = table.Column<string>(maxLength: 1, nullable: true),
                    六校三好 = table.Column<string>(maxLength: 1, nullable: true),
                    六市优干 = table.Column<string>(maxLength: 1, nullable: true),
                    六县优干 = table.Column<string>(maxLength: 1, nullable: true),
                    六校优干 = table.Column<string>(maxLength: 1, nullable: true),
                    六市优少 = table.Column<string>(maxLength: 1, nullable: true),
                    六县优少 = table.Column<string>(maxLength: 1, nullable: true),
                    六校优少 = table.Column<string>(maxLength: 1, nullable: true),
                    其它获奖次数一 = table.Column<string>(maxLength: 2, nullable: true),
                    其它获奖次数二 = table.Column<string>(maxLength: 100, nullable: true),
                    材料等级 = table.Column<string>(maxLength: 1, nullable: true),
                    五上思品 = table.Column<string>(maxLength: 3, nullable: true),
                    五上语文 = table.Column<string>(maxLength: 3, nullable: true),
                    五上数学 = table.Column<string>(maxLength: 3, nullable: true),
                    五上英语 = table.Column<string>(maxLength: 3, nullable: true),
                    五上体育 = table.Column<string>(maxLength: 3, nullable: true),
                    五下思品 = table.Column<string>(maxLength: 3, nullable: true),
                    五下语文 = table.Column<string>(maxLength: 3, nullable: true),
                    五下数学 = table.Column<string>(maxLength: 3, nullable: true),
                    五下英语 = table.Column<string>(maxLength: 3, nullable: true),
                    五下体育 = table.Column<string>(maxLength: 3, nullable: true),
                    六上思品 = table.Column<string>(maxLength: 3, nullable: true),
                    六上语文 = table.Column<string>(maxLength: 3, nullable: true),
                    六上数学 = table.Column<string>(maxLength: 3, nullable: true),
                    六上英语 = table.Column<string>(maxLength: 3, nullable: true),
                    六上体育 = table.Column<string>(maxLength: 3, nullable: true),
                    父亲姓名 = table.Column<string>(maxLength: 8, nullable: true),
                    父亲学历 = table.Column<string>(maxLength: 8, nullable: true),
                    父亲电话 = table.Column<string>(maxLength: 11, nullable: true),
                    父亲职务 = table.Column<string>(maxLength: 11, nullable: true),
                    父亲工作单位 = table.Column<string>(maxLength: 100, nullable: true),
                    母亲姓名 = table.Column<string>(maxLength: 8, nullable: true),
                    母亲学历 = table.Column<string>(maxLength: 8, nullable: true),
                    母亲电话 = table.Column<string>(maxLength: 11, nullable: true),
                    母亲职务 = table.Column<string>(maxLength: 11, nullable: true),
                    母亲工作单位 = table.Column<string>(maxLength: 80, nullable: true),
                    住宅电话 = table.Column<string>(maxLength: 11, nullable: true),
                    登记时间 = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    登记地址 = table.Column<string>(maxLength: 20, nullable: true),
                    操作状态 = table.Column<string>(maxLength: 10, nullable: true),
                    操作人员 = table.Column<string>(maxLength: 10, nullable: true),
                    学生组别 = table.Column<string>(maxLength: 1, nullable: true),
                    门检时间 = table.Column<DateTime>(type: "datetime", nullable: true),
                    审核位置 = table.Column<string>(maxLength: 10, nullable: true),
                    审核人员 = table.Column<string>(maxLength: 10, nullable: true),
                    考场编号 = table.Column<string>(maxLength: 10, nullable: true),
                    活动位置 = table.Column<string>(maxLength: 10, nullable: true),
                    入围方式 = table.Column<string>(maxLength: 10, nullable: true),
                    审核结果 = table.Column<bool>(nullable: true),
                    卡片打印 = table.Column<bool>(nullable: true),
                    打印人员 = table.Column<string>(maxLength: 20, nullable: true),
                    打印时间 = table.Column<DateTime>(type: "datetime", nullable: true),
                    开放状态 = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    查询次数 = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stuinfo", x => x.身份证号);
                });

            migrationBuilder.CreateTable(
                name: "systemset",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    注册开放 = table.Column<bool>(nullable: true),
                    登录开放 = table.Column<bool>(nullable: true),
                    寻号开放 = table.Column<bool>(nullable: true),
                    修改开放 = table.Column<bool>(nullable: true),
                    打印开放 = table.Column<bool>(nullable: true),
                    使用验证码 = table.Column<bool>(nullable: true),
                    验证码KEY = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    验证码ID = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_systemset", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stuinfo");

            migrationBuilder.DropTable(
                name: "systemset");
        }
    }
}
