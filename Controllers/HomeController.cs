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

        public async Task<IActionResult> Index()
        {
            uid = Convert.ToInt16(User.Identity.Name);
            var stuinfo = await _context.Stuinfo.AsNoTracking().FirstAsync(e => e.编号==uid);

            ViewBag.FileSizeMax = 5;
            ViewBag.Avatar = (stuinfo.头像文件 == "")||(stuinfo.头像文件 == null)?"":Url.Action("Avatar","File");
            ViewBag.Print = _systemOptions.打印开放 && (bool)stuinfo.审核结果;


            IndexViewModel _indexView = new IndexViewModel();
            _indexView.From(stuinfo,_systemOptions);
            return View(_indexView);
        }

        [HttpPost]
        public async Task<IActionResult> SaveInfo(IndexViewModel indexView)
        {
            if (!ModelState.IsValid)
            {
                var c = ModelState.Keys;
                return RedirectToAction("Index","Account",new{error = "您的数据不符合规范，被判定为有攻击行为，已将您注销登录！"});
            }

            var sum = Convert.ToInt16(indexView.五县三好)  + Convert.ToInt16(indexView.五县优干) +Convert.ToInt16(indexView.五县优少) +
                      Convert.ToInt16(indexView.五市三好) + Convert.ToInt16(indexView.五市优干) + Convert.ToInt16(indexView.五市优少) +
                      Convert.ToInt16(indexView.五校三好) + Convert.ToInt16(indexView.五校优干) + Convert.ToInt16(indexView.五校优少) +
                      Convert.ToInt16(indexView.六县三好)  + Convert.ToInt16(indexView.六县优干) +Convert.ToInt16(indexView.六县优少) +
                      Convert.ToInt16(indexView.六市三好) + Convert.ToInt16(indexView.六市优干) + Convert.ToInt16(indexView.六市优少) +
                      Convert.ToInt16(indexView.六校三好) + Convert.ToInt16(indexView.六校优干) + Convert.ToInt16(indexView.六校优少);

            uid = Convert.ToInt16(User.Identity.Name);
            var stuinfo = await _context.Stuinfo.FirstAsync(e => e.编号==uid);

            if (sum > 24)
            {
                ViewBag.FileSizeMax = 5;
                ViewBag.Avatar = (stuinfo.头像文件 == "")||(stuinfo.头像文件 == null)?"":Url.Action("Avatar","File");
                ViewBag.Print = _systemOptions.打印开放 && (bool)stuinfo.审核结果;
                indexView.错误信息 = "您的获奖次数之和大于24次，请您挑选您认为最重要的次数填写。";
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
                return RedirectToAction(nameof(Index));
            }
        }

    }
}
