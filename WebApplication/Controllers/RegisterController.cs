using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChangeManager.Domain.Entities;
using ChangeManager.Service.Services;
using ChangeManager.Service.Validators;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChangeManager.WebApplication.Controllers
{

    public class RegisterController : Controller
    {
        private readonly BaseService<Register> _service = new BaseService<Register>();
        public IActionResult Index()
        {
            return View(_service.Get());
        }

        public IActionResult AddRegister()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult AddRegister([Bind("Id,Name")] Register register)
        {
            if (!ModelState.IsValid) return View(register);

            var coinList = new BaseService<Coin>().Get();
            register.RegisterCoins = new List<RegisterCoin>();
            foreach (var coin in coinList)
            {
                register.RegisterCoins.Add(new RegisterCoin()
                {
                    Quantity = 0,
                    CoinId = coin.Id,
                    //Coin = coin
                });
            }

            Post(register);
            //await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            return View(_service.Get(id));
        }

        public IActionResult Post([FromBody] Register item)
        {
            try
            {
                _service.Post<RegisterValidator>(item);

                return new ObjectResult(item.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public IActionResult Put([FromBody] Register item)
        {
            try
            {
                _service.Put<RegisterValidator>(item);

                return new ObjectResult(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);

                return new NoContentResult();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(_service.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(_service.Get(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}