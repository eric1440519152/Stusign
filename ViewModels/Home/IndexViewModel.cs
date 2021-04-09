using Stusign.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Stusign.Libraries;


namespace Stusign.ViewModels.Home
{
    public class IndexViewModel
    {
        [ReadOnly(true)]
        public short 编号 { get; set; }
        public string 头像文件 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [MaxLength(4,ErrorMessage = "请输入正确的名字")]
        public string 姓名 { get; set; }
        [ReadOnly(true)]
        public string 身份证号 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        public string 全国学籍号 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        public string 毕业学校 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        public string 报读校区 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-N]+$",ErrorMessage = "该项必填")]
        public string 生源地 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        public string 户口所在地 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        public string 学生实际住址 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 五市三好 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 五县三好 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 五校三好 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 五市优干 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 五县优干 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 五校优干 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 五市优少 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 五县优少 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 五校优少 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 六市三好 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 六县三好 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 六校三好 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 六市优干 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 六县优干 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 六校优干 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 六市优少 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 六县优少 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [Range(0,9,ErrorMessage = "范围异常")]
        public string 六校优少 { get; set; }
        public string 兴趣爱好 { get; set; }
        public string 兴趣爱好荣誉 { get; set; }
        public string 学生职务 { get; set; }
        public string 父亲职业类别 { get; set; }
        public string 母亲职业类别 { get; set; }

        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-D]+$",ErrorMessage = "限填A B C D")]
        public string 五上思品 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-D]+$",ErrorMessage = "限填A B C D")]
        public string 五上语文 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-D]+$",ErrorMessage = "限填A B C D")]
        public string 五上数学 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-D]+$",ErrorMessage = "限填A B C D")]
        public string 五上英语 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-D]+$",ErrorMessage = "限填A B C D")]
        public string 五上体育 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-D]+$",ErrorMessage = "限填A B C D")]
        public string 五下思品 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-D]+$",ErrorMessage = "限填A B C D")]
        public string 五下语文 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-D]+$",ErrorMessage = "限填A B C D")]
        public string 五下数学 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-D]+$",ErrorMessage = "限填A B C D")]
        public string 五下英语 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-D]+$",ErrorMessage = "限填A B C D")]
        public string 五下体育 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-D]+$",ErrorMessage = "限填A B C D")]
        public string 六上思品 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-D]+$",ErrorMessage = "限填A B C D")]
        public string 六上语文 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-D]+$",ErrorMessage = "限填A B C D")]
        public string 六上数学 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-D]+$",ErrorMessage = "限填A B C D")]
        public string 六上英语 { get; set; }
        [Required(ErrorMessage = "该项必填")]
        [RegularExpression(@"^[A-D]+$",ErrorMessage = "限填A B C D")]
        public string 六上体育 { get; set; }
        public string 父亲姓名 { get; set; }
        public string 父亲学历 { get; set; }
        [RegularExpression(@"^1[3456789]\d{9}$",ErrorMessage = "手机号格式错误")]
        public string 父亲电话 { get; set; }
        public string 父亲职务 { get; set; }
        public string 父亲工作单位 { get; set; }
        public string 母亲姓名 { get; set; }
        public string 母亲学历 { get; set; }
        [RegularExpression(@"^1[3456789]\d{9}$",ErrorMessage = "手机号格式错误")]
        public string 母亲电话 { get; set; }
        public string 母亲职务 { get; set; }
        public string 母亲工作单位 { get; set; }
        public string 住宅电话 { get; set; }
        [ReadOnly(true)]
        public string 信息状态 { get; set; }


        public Stuinfo To(Stuinfo stuinfo)
        {
            //stuinfo.编号 = 编号;
            //stuinfo.头像文件 = 头像文件;
            stuinfo.姓名 = 姓名;
            //stuinfo.身份证号 = 身份证号;
            stuinfo.全国学籍号 = 全国学籍号;
            stuinfo.毕业学校 = 毕业学校;
            stuinfo.报读校区 = 报读校区;
            stuinfo.生源地 = 生源地;
            stuinfo.户口所在地 = 户口所在地;
            stuinfo.学生实际住址 = 学生实际住址;
            stuinfo.五市三好 = 五市三好;
            stuinfo.五县三好 = 五县三好;
            stuinfo.五校三好 = 五校三好;
            stuinfo.五市优干 = 五市优干;
            stuinfo.五县优干 = 五县优干;
            stuinfo.五校优干 = 五校优干;
            stuinfo.五市优少 = 五市优少;
            stuinfo.五县优少 = 五县优少;
            stuinfo.五校优少 = 五校优少;
            stuinfo.六市三好 = 六市三好;
            stuinfo.六县三好 = 六县三好;
            stuinfo.六校三好 = 六校三好;
            stuinfo.六市优干 = 六市优干;
            stuinfo.六县优干 = 六县优干;
            stuinfo.六校优干 = 六校优干;
            stuinfo.六市优少 = 六市优少;
            stuinfo.六县优少 = 六县优少;
            stuinfo.六校优少 = 六校优少;
            stuinfo.母亲职业类别 = 母亲职业类别;
            stuinfo.父亲职业类别 = 父亲职业类别;
            stuinfo.学生职务 = 学生职务;
            stuinfo.兴趣爱好 = 兴趣爱好;
            stuinfo.兴趣爱好荣誉 = 兴趣爱好荣誉;
            stuinfo.五上思品 = 五上思品;
            stuinfo.五上语文 = 五上语文;
            stuinfo.五上数学 = 五上数学;
            stuinfo.五上英语 = 五上英语;
            stuinfo.五上体育 = 五上体育;
            stuinfo.五下思品 = 五下思品;
            stuinfo.五下语文 = 五下语文;
            stuinfo.五下数学 = 五下数学;
            stuinfo.五下英语 = 五下英语;
            stuinfo.五下体育 = 五下体育;
            stuinfo.六上思品 = 六上思品;
            stuinfo.六上语文 = 六上语文;
            stuinfo.六上数学 = 六上数学;
            stuinfo.六上英语 = 六上英语;
            stuinfo.六上体育 = 六上体育;
            stuinfo.父亲姓名 = 父亲姓名;
            stuinfo.父亲学历 = 父亲学历;
            stuinfo.父亲电话 = 父亲电话;
            stuinfo.父亲职务 = 父亲职务;
            stuinfo.父亲工作单位 = 父亲工作单位;
            stuinfo.母亲姓名 = 母亲姓名;
            stuinfo.母亲学历 = 母亲学历;
            stuinfo.母亲电话 = 母亲电话;
            stuinfo.母亲职务 = 母亲职务;
            stuinfo.母亲工作单位 = 母亲工作单位;
            stuinfo.住宅电话 = 住宅电话;

            return stuinfo;
        }

        public void From(Stuinfo stuinfo,SystemOptions systemOptions)
        {
            string state = systemOptions.GetState(stuinfo.编号);

            编号 = stuinfo.编号;
            头像文件 = stuinfo.头像文件;
            姓名 = stuinfo.姓名;
            身份证号 = stuinfo.身份证号;
            全国学籍号 = stuinfo.全国学籍号;
            毕业学校 = stuinfo.毕业学校;
            报读校区 = stuinfo.报读校区;
            生源地 = stuinfo.生源地;
            户口所在地 = stuinfo.户口所在地;
            学生实际住址 = stuinfo.学生实际住址;
            五市三好 = stuinfo.五市三好;
            五县三好 = stuinfo.五县三好;
            五校三好 = stuinfo.五校三好;
            五市优干 = stuinfo.五市优干;
            五县优干 = stuinfo.五县优干;
            五校优干 = stuinfo.五校优干;
            五市优少 = stuinfo.五市优少;
            五县优少 = stuinfo.五县优少;
            五校优少 = stuinfo.五校优少;
            六市三好 = stuinfo.六市三好;
            六县三好 = stuinfo.六县三好;
            六校三好 = stuinfo.六校三好;
            六市优干 = stuinfo.六市优干;
            六县优干 = stuinfo.六县优干;
            六校优干 = stuinfo.六校优干;
            六市优少 = stuinfo.六市优少;
            六县优少 = stuinfo.六县优少;
            六校优少 = stuinfo.六校优少;
            母亲职业类别 = stuinfo.母亲职业类别;
            父亲职业类别 = stuinfo.父亲职业类别;
            学生职务 = stuinfo.学生职务;
            兴趣爱好 = stuinfo.兴趣爱好;
            兴趣爱好荣誉 = stuinfo.兴趣爱好荣誉;
            五上思品 = stuinfo.五上思品;
            五上语文 = stuinfo.五上语文;
            五上数学 = stuinfo.五上数学;
            五上英语 = stuinfo.五上英语;
            五上体育 = stuinfo.五上体育;
            五下思品 = stuinfo.五下思品;
            五下语文 = stuinfo.五下语文;
            五下数学 = stuinfo.五下数学;
            五下英语 = stuinfo.五下英语;
            五下体育 = stuinfo.五下体育;
            六上思品 = stuinfo.六上思品;
            六上语文 = stuinfo.六上语文;
            六上数学 = stuinfo.六上数学;
            六上英语 = stuinfo.六上英语;
            六上体育 = stuinfo.六上体育;
            父亲姓名 = stuinfo.父亲姓名;
            父亲学历 = stuinfo.父亲学历;
            父亲电话 = stuinfo.父亲电话;
            父亲职务 = stuinfo.父亲职务;
            父亲工作单位 = stuinfo.父亲工作单位;
            母亲姓名 = stuinfo.母亲姓名;
            母亲学历 = stuinfo.母亲学历;
            母亲电话 = stuinfo.母亲电话;
            母亲职务 = stuinfo.母亲职务;
            母亲工作单位 = stuinfo.母亲工作单位;
            住宅电话 = stuinfo.住宅电话;
            信息状态 = state;
        }
    }
}
