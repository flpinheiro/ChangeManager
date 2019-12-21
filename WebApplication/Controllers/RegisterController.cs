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

namespace ChangeManager.WebApplication.Controllers
{
    public class RegisterController : Controller
    {
        private readonly BaseService<Register> _service = new BaseService<Register>();
        public IActionResult Index()
        {
            var register = _service.Get();
            return View(register);
        }

        public IActionResult AddRegister()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var get = Get(id);

            return View();
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