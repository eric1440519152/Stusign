using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Newtonsoft.Json;
using Stusign.Libraries;
using Stusign.Models;

namespace Stusign.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly StusignContext _context;
        private readonly DbSet<Stuinfo> _stuinfo;
        private readonly SystemOptions _systemOptions;
        private readonly reCAPTCHA reCaptcha;

        public AccountController(SystemOptions systemOptions,UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager,StusignContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _stuinfo = _context.Stuinfo;
            _systemOptions = systemOptions;
        }

        public IActionResult Index(string error = "")
        {
            _signInManager.SignOutAsync();

            ViewBag.error = error;
            ViewBag.openLogin = _systemOptions.登陆开放;
            ViewBag.openRegister = _systemOptions.注册开放;
            ViewBag.openReCaptcha = _systemOptions.使用验证码;
            ViewBag.reCaptchaID = _systemOptions.验证码id;
            ViewBag.openForgetUID = _systemOptions.寻号开放;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ServiceFilter(typeof(reCaptchaValid))]
        public async Task<IActionResult> LoginInAction(string username, string password, string AntiforgeryField)
        {
            var user = await _userManager.FindByNameAsync(username);
            object resp;

            var _status = "Failure";
            var _message = "未知错误";
            var _url = "/";
            var _withError = true;
            var _actionName = "ShowError";

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(username, password, false, false);
                if (result.Succeeded)
                {
                    //登陆成功
                    //创建返回Json
                    _status = "Succeeded";
                    _message = "登陆成功";
                    _actionName = "Redirect";
                }
                else
                    _message = "密码错误或您已被禁止登陆";
            }
            else
                _message = "登记编号未注册";

            

            return Json( new
            {
                ActionName = "LoginIn",
                Result = new
                {
                    Status = _status,
                    Message = _message
                },
                Post = new
                {
                    Username = username,
                    AntiforgeryToken = AntiforgeryField,
                    Password = password
                },
                Command = new
                {
                    ActionName = _actionName,
                    Parameter = new
                    {
                        Url = _url,
                        WithError = _withError
                    }
                }
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ServiceFilter(typeof(reCaptchaValid))]
        public async Task<IActionResult> RegisterAction(string regStuName, string regPhone,string regIDCard, string AntiforgeryField, string reCaptchaToken)
        {
            object resp;

            var _status = "Failure";
            var _message = "其他错误";
            var _url = "/";
            var _withError = true;
            var _actionName = "ShowError";
            var password = "";

            //查询数据库是否有用该身份证注册的
            if (_stuinfo.Any(s => s.身份证号 == regIDCard))
                _message = "该身份证号已被注册";
            else
            {
                //创建用户信息
                //https://localhost:44394/Account/registeraction?regstuname=%E4%BD%95%E6%B3%BD%E6%81%A9&regphone=19851937930&regidcard=460035200101121517
                
                string sex;
                if (Convert.ToInt16(regIDCard.Substring(16, 1)) % 2 == 1)
                    sex = "男";
                else
                    sex = "女";

                var userinfo = new Stuinfo
                {
                    姓名 = regStuName,
                    身份证号 = regIDCard,
                    性别 = sex,
                    出生年月 = regIDCard.Substring(6, 8)
                };
                _context.Stuinfo.Add(userinfo);
                await _context.SaveChangesAsync();

                IdentityUser _user = new IdentityUser
                {
                    UserName = userinfo.编号.ToString(),
                    PhoneNumber = regPhone
                };
                
                password = regIDCard.Substring(12, 6);
                var result = await _userManager.CreateAsync(_user, password);
                
                if (result.Succeeded)
                {
                    _message = "恭喜您注册成功！请您牢记以下信息</br>登记编号：<strong>" + userinfo.编号.ToString() +
                               "</strong></br>注册手机号：<strong>" + regPhone +
                               "</strong></br>密码：<strong>身份证后六位</strong>"+
                               "</br>请立即登录填写基本信息";
                    _status = "Succeeded";
                    _actionName = "ShowMessage";
                }
                else
                {
                    _context.Stuinfo.Remove(_stuinfo.First(e => e.身份证号 == regIDCard));
                    _message = "注册失败，请您稍后再试";
                }
                
            }
            
            return Json( new
            {
                ActionName = "Register",
                Result = new
                {
                    Status = _status,
                    Message = _message
                },
                Post = new
                {
                    reCaptchaToken = reCaptchaToken,
                    AntiforgeryToken = AntiforgeryField
                },
                Command = new
                {
                    ActionName = _actionName,
                    Parameter = new
                    {
                        Url = _url,
                        WithError = _withError
                    }
                }
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ServiceFilter(typeof(reCaptchaValid))]
        public IActionResult FindUid(string phone, string iDCard, string AntiforgeryField)
        {
            object resp;

            var _status = "Failure";
            var _message = "其他错误";
            var _url = "/";
            var _withError = true;
            var _actionName = "ShowError";
            var uid = "";
            

            if (_stuinfo.Any(e => e.身份证号 == iDCard))
            {
                uid = _stuinfo.First(e => e.身份证号 == iDCard).编号.ToString();
                if (_userManager.FindByNameAsync(uid).Result.PhoneNumber == phone)
                {
                    _message = "请您牢记以下信息</br>登记编号：<strong>" + uid +
                               "</strong></br>注册手机号：<strong>" + phone +
                               "</strong></br>密码：<strong>身份证后六位</strong>";
                    _status = "Succeeded";
                    _actionName = "ShowMessage";
                }
                else
                    _message = "登记信息不匹配，请您查证后再试";
            }
            else
                _message = "未找到登记信息";

            return Json(new
            {
                ActionName = "FindUID",
                Result = new
                {
                    Status = _status,
                    Message = _message
                },
                Post = new
                {
                    AntiforgeryToken = AntiforgeryField
                },
                Command = new
                {
                    ActionName = _actionName,
                    Parameter = new
                    {
                        Url = _url,
                        WithError = _withError
                    }
                }
            });
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}