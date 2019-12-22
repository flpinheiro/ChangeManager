using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChangeManager.Domain.Entities;
using ChangeManager.Infra.Data.Repository;
using ChangeManager.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ChangeManager.WebApplication.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ChangeController : Controller
    {
        private readonly  BaseRepository<Register> register = new BaseRepository<Register>();
        public IActionResult Index()
        {
            ViewBag.Register = register
                .Context
                .Registers
                .Select(r => new SelectListItem ()
                {
                    Text = r.Name, 
                    Value = r.Id.ToString()
                })
                .ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CalculateChange([Bind("TotalValue,ValuePaid,RegisterId"), FromBody]
            Change change)
        {
            return View();
        }
    }
}