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

        public async Task<IActionResult> Index(string message)
        {
            uid = Convert.ToInt16(User.Identity.Name);
            var stuinfo = await _context.Stuinfo.AsNoTracking().FirstAsync(e => e.编号==uid);

            ViewBag.FileSizeMax = 5;
            ViewBag.Avatar = stuinfo.头像文件 == ""?"":Url.Action("Avatar","File");
            ViewBag.Print = _systemOptions.打印开放 && (bool)stuinfo.审核结果;

            IndexViewModel indexView = new IndexViewModel();
            indexView.From(stuinfo,_systemOptions);
            return View(indexView);
        }

        [HttpPost]
        public async Task<IActionResult> SaveInfo(IndexViewModel indexView)
        {
            if (!ModelState.IsValid)
            {
                var c = ModelState.Keys;
                return RedirectToAction("Index","Account",new{error = "您的数据不符合规范，被判定为有攻击行为，已将您注销登录！"});
            }

            uid = Convert.ToInt16(User.Identity.Name);
            var stuinfo = await _context.Stuinfo.FirstAsync(e => e.编号==uid);

            if (_systemOptions.IsLocked(uid))
            {
                return StatusCode(403);
            }
            else
            {
                
                indexView.To(stuinfo);
                await _context.SaveChangesAsync();
                //return Content(JsonConvert.SerializeObject(indexView));
                return RedirectToAction(nameof(Index));
            }
        }

    }
}
