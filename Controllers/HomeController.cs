using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Stusign.Models;
using Stusign.Libraries;
using Stusign.ViewModels.Home;


namespace Stusign.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SystemOptions _systemOptions;
        private readonly StusignContext _context;
        private short uid;

        public HomeController(ILogger<HomeController> logger, SystemOptions systemOptions,StusignContext context)
        {
            _logger = logger;
            _systemOptions = systemOptions;
            _context = context;
        }

        public async Task<IActionResult> Index(String successMsg)
        {
            uid = Convert.ToInt16(User.Identity.Name);
            var stuinfo = await _context.Stuinfo.AsNoTracking().FirstAsync(e => e.编号==uid);

            ViewBag.FileSizeMax = 5;
            ViewBag.Avatar = (stuinfo.头像文件 == "")||(stuinfo.头像文件 == null)?"":Url.Action("Avatar","File");
            ViewBag.Print = _systemOptions.打印开放 && (bool)stuinfo.审核结果;


            IndexViewModel _indexView = new IndexViewModel();
            _indexView.From(stuinfo,_systemOptions);
            _indexView.提示信息 = successMsg;
            return View(_indexView);
        }

        [HttpPost]
        public async Task<IActionResult> SaveInfo(IndexViewModel indexView)
        {
            uid = Convert.ToInt16(User.Identity.Name);
            var stuinfo = await _context.Stuinfo.FirstAsync(e => e.编号==uid);

            if (!ModelState.IsValid)
            {
                ViewBag.FileSizeMax = 5;
                ViewBag.Avatar = (stuinfo.头像文件 == "")||(stuinfo.头像文件 == null)?"":Url.Action("Avatar","File");
                ViewBag.Print = _systemOptions.打印开放 && (bool)stuinfo.审核结果;
                indexView.错误信息 = "您的数据不符合规范，请检查后再提交！";
                return View("Index", indexView);
            }

            if (_systemOptions.IsLocked(uid))
            {
                return StatusCode(403);
            }
            else
            {
                
                indexView.To(stuinfo);
                await _context.SaveChangesAsync();
                //return Content(JsonConvert.SerializeObject(indexView));
                return RedirectToAction(nameof(Index),new {successMsg = "您的信息已经提交成功，您可以在信息锁定前多次修改信息"});
            }
        }

    }
}
