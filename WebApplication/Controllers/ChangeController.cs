using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using ChangeManager.Domain.Entities;
using ChangeManager.Infra.Data.Repository;
using ChangeManager.Service.Services;
using ChangeManager.Service.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ChangeManager.WebApplication.Controllers
{
    public class ChangeController : Controller
    {
        private readonly BaseRepository<Register> _register = new BaseRepository<Register>();
        private readonly BaseService<Coin> _service = new BaseService<Coin>();
        public IActionResult Index()
        {
            ViewBag.Register = _register
                .Context
                .Registers
                .Select(r => new SelectListItem()
                {
                    Text = r.Name,
                    Value = r.Id.ToString()
                })
                .ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CalculateChange([Bind("TotalValue,ValuePaid,RegisterId")] Change change)
        {

            var register = _register.Context.Registers
                .Where(r => r.Id == change.RegisterId)
                .Include(rc => rc.RegisterCoins)
                .ThenInclude(c => c.Coin)
                .FirstOrDefault();
            if (register == null)
                throw new Exception();

            var rc = ChangeService.CalculateChange(change, register);

            foreach (var item in rc)
            {
                foreach (var coins in register.RegisterCoins)
                {
                    if (coins.CoinId != item.CoinId) continue;
                    coins.Quantity -= item.Quantity;
                    item.Coin = coins.Coin;

                }
            }

            _register.Update(register);

            return View(rc);
        }
    }
}