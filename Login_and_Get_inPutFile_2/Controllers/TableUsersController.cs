using Microsoft.AspNetCore.Mvc;
using Login_and_Get_inPutFile_2.Models;
using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;




namespace Login_and_Get_inPutFile_2.Controllers
{
    public class TableUsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Obsolete]
        public IActionResult TableUsers(PersonViewModel model)
        {
            if (model.File != null)
            {
                using (var ms = new MemoryStream())
                {
                    model.File.CopyTo(ms);
                    var fileByte = ms.ToArray();
                    string s = Convert.ToBase64String(fileByte);
                    model.ImageName = s;
                }

                string uploads = Path.Combine(IHostingEnvironment.WebRootPath, "Images");
                string filePath = Path.Combine(uploads, model.File.FileName);
                using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.File.CopyToAsync(fileStream);
                }
                model.Hust = HttpContext.Request.Scheme + "://" +  HttpContext.Request.Host.Value;
            }
            Repository.Peaple.Add(model);
            return View("TableUsers", Repository.Peaple);
        }

    }
}
