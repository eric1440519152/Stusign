using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;
using Stusign.Libraries;
using Stusign.Models;

namespace Stusign.Controllers
{
    [Authorize]
    public class FileController : Controller
    {
        private readonly StusignContext _context;
        private readonly SystemOptions _systemOptions;
        private readonly DbSet<Stuinfo> _stuinfo;

        public FileController(StusignContext context,SystemOptions systemOptions)
        {
            _context = context;
            _stuinfo = context.Stuinfo;
            _systemOptions = systemOptions;
        }

        public IActionResult Upload(IFormFile file)
        {
            var uid = Convert.ToInt16(User.Identity.Name);

            if (_systemOptions.GetState(uid) == "已锁定")
            {
                return Json(new
                {
                    statue = "Error",
                    message = "您的信息已锁定"
                });
            }

            using (Image image = Image.Load(file.OpenReadStream()))
            {
                image.Mutate(x => x.Resize(295,413));
                image.SaveAsJpeg("Avatar/" + User.Identity.Name + ".jpg");
            }

            var stuinfo = _stuinfo.Where(e => e.编号 == uid).First();
            stuinfo.头像文件 = "Avatar/" + User.Identity.Name + ".jpg";

            _context.SaveChanges();

            return Ok(new
            {
                statue = "OK",
                filename = "Avatar/" + User.Identity.Name + ".jpg",
                size = file.Length.ToString()
            });
        }

        public IActionResult Avatar()
        {
            var file = System.IO.File.ReadAllBytes("Avatar/" + User.Identity.Name + ".jpg");
            return File(file,"image/jpeg");
        }

        public IActionResult Delete()
        {
            var uid = Convert.ToInt16(User.Identity.Name);

            if (_systemOptions.GetState(uid) == "已锁定")
            {
                return Json(new
                {
                    statue = "Error",
                    message = "您的信息已锁定"
                });
            }

            var stuinfo = _stuinfo.Where(e => e.编号 == uid).First();
            stuinfo.头像文件 = "";

            _context.SaveChanges();
            return Ok(new
            {
                statue = "OK",
                filename = "Avatar/" + User.Identity.Name + ".jpg"
            });
        }
    }
}
