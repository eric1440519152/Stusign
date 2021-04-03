using System;
using System.Collections.Generic;

namespace Stusign.Models
{
    public partial class Systemset
    {
        public int Id { get; set; }
        public bool? 注册开放 { get; set; }
        public bool? 登录开放 { get; set; }
        public bool? 寻号开放 { get; set; }
        public bool? 修改开放 { get; set; }
        public bool? 打印开放 { get; set; }
        public bool? 使用验证码 { get; set; }
        public string 验证码key { get; set; }
        public string 验证码id { get; set; }

    }
}
