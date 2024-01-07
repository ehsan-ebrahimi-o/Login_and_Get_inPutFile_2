using Microsoft.AspNetCore.Mvc;
using Login_and_Get_inPutFile_2.Models;
using System;




namespace Login_and_Get_inPutFile_2.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Users(PersonViewModel model)
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

            }
            Repository.Peaple.Add(model);
            return View("TableUsers",Repository.Peaple);
        }

    }
}
