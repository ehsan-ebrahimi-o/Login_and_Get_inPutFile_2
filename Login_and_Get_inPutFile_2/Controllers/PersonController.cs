using Microsoft.AspNetCore.Mvc;
using Login_and_Get_inPutFile_2.Models;
using System;



namespace Login_and_Get_inPutFile_2.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterPerson()
        {
            var model = new PersonViewModel();
            return View("TableUsers",model);
        }

        

    }
}
