using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChangeManager.Domain.Entities;
using ChangeManager.Service.Services;
using ChangeManager.Service.Validators;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChangeManager.WebApplication.Controllers
{
    public class RegisterController : Controller
    {
        private readonly RegisterService _service = new RegisterService();
        
        public IActionResult Index()
        {
            var r = _service.Get();
            foreach (var item in r)
            {
                item.RegisterCoins = _service.GetRegisterCoins(item.Id);
            }
            return View(_service.Get());
        }

        public IActionResult AddRegister()
        {
            return View();
        }

        public IActionResult Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var register =  _service.Get(id??0);
            if (register == null)
            {
                return NotFound();
            }

            if (register.RegisterCoins.Count == 0)
            {
                register.RegisterCoins = _service.GetRegisterCoins(id ?? 0);
            }
            return View(register);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,RegisterCoins")] Register register, 
            //[FromBody] ICollection<RegisterCoin> quantityRegisterCoins
            int[] list
            )
        {
            if (id != register.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid) return View(register);

            if (register.RegisterCoins == null || register.RegisterCoins.Count==0)
            {
                register.RegisterCoins = _service.GetRegisterCoins(register.Id);
            }

            var index = 0;
            foreach (var registerCoin in register.RegisterCoins)
            {
                registerCoin.Quantity += list[index];
                if(registerCoin.Quantity < 0) throw  new ArgumentOutOfRangeException("Quantity can't be negative.");
                index++;
                _service.Repository.Context.RegisterCoins.Update(registerCoin);
            }

            Put(register);
            _service.Repository.Context.SaveChanges();
            return RedirectToAction(nameof(Index));
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