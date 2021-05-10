using Stusign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aliyun.Acs.Core.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Templating;

namespace Stusign.Libraries
{
    /// <summary>
    /// 系统设置类
    /// </summary>
    public class SystemOptions
    {
        private readonly StusignContext _context;
        private Models.Systemset System { get; set; }
        public bool 登陆开放 { get; set; }
        public bool 注册开放 { get; set; }
        public bool 寻号开放 { get; set; }
        public bool 修改开放 { get; set; }
        public bool 打印开放 { get; set; }
        public bool 使用验证码 { get; set; }
        public string 验证码id { get; set; }
        public string 验证码key { get; set; }
        public SystemOptions(StusignContext _context)
        {
            this._context = _context;
            System = this._context.Systemset.First();

            登陆开放 = (bool)System.登录开放;
            注册开放 = (bool)System.注册开放;
            寻号开放 = (bool)System.寻号开放;
            修改开放 = (bool)System.修改开放;
            打印开放 =(bool)System.打印开放;
            使用验证码 = (bool)System.使用验证码;
            验证码id = System.验证码id;
            验证码key = System.验证码key;
        }
        public void UpdateOptions()
        {
            System.登录开放 = 登陆开放;
            System.注册开放 = 注册开放;
            System.寻号开放 = 寻号开放;
            System.修改开放 = 修改开放;
            System.打印开放 = 打印开放;
            System.使用验证码 = 使用验证码;
            System.验证码id = 验证码id;
            System.验证码key = 验证码key;
            this._context.SaveChanges();
        }
        /// <summary>
        /// 判断指定UID的用户是否为锁定状态
        /// </summary>
        /// <param name="uid">用户编号</param>
        /// <returns>如果为True为锁定，False为未锁定</returns>
        public bool IsLocked(int uid)
        { 
            var 操作状态 = "";
            var 修改开放 = false;
            try
            {
                操作状态 = _context.Stuinfo.AsNoTracking().First(e => e.编号 == uid).操作状态;
                修改开放 = (bool) System.修改开放;
            }
            catch(Exception e)
            {
                操作状态 = "0";
                修改开放 = false;
            }

            if ((操作状态 == "2" && !修改开放) || 操作状态 == "0")
                return true;
            else
                return false;
        }

        public string GetState(int uid)
        {
            
            Stuinfo stuinfo = _context.Stuinfo.AsNoTracking().First(e => e.编号 == uid);

            string state;
            var 操作状态 = "";
            var 打印开放 = false;
            var 修改开放 = false;
            var 卡片打印 = false;
            var 是否入围 = false;


            操作状态 = stuinfo.操作状态;
            卡片打印 = (bool) stuinfo.卡片打印;
            打印开放 = (bool)  System.打印开放;
            修改开放 = (bool)  System.修改开放;
            是否入围 = (bool) stuinfo.审核结果;


            if (卡片打印)
                state = "已打印";
            else if (是否入围 && 打印开放)
                state = "待打印";
            else if ((操作状态 == "2" && !(bool) 修改开放) || 操作状态 == "0")
                state = "已锁定";
            else
                state = "未锁定";

            return state;
        }
    }
}
