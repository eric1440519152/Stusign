using Stusign.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Stusign.Libraries;


namespace Stusign.ViewModels.Home
{
    public class IndexViewModel
    {
        [ReadOnly(true)]
        public int 编号 { get; set; }
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
        [MaxLength(20,ErrorMessage = "长度过长")]
        public string 兴趣爱好 { get; set; }
        [MaxLength(120,ErrorMessage = "长度过长")]
        public string 县级以上荣誉 { get; set; }
        public string 父亲职业类别 { get; set; }
        public string 母亲职业类别 { get; set; }

        
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

        [ReadOnly(true)]
        public string 错误信息 { get; set; }
        [ReadOnly(true)]
        public string 提示信息 { get; set; }
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
            stuinfo.母亲职业类别 = 母亲职业类别;
            stuinfo.父亲职业类别 = 父亲职业类别;
            stuinfo.兴趣爱好 = 兴趣爱好;
            stuinfo.县级以上荣誉 = 县级以上荣誉;
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
            母亲职业类别 = stuinfo.母亲职业类别;
            父亲职业类别 = stuinfo.父亲职业类别;
            兴趣爱好 = stuinfo.兴趣爱好;
            县级以上荣誉 = stuinfo.县级以上荣誉;
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
