using Gaming.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gaming.Controllers.V1
{
    public class AuthenticationController : Controller
    {

        public IActionResult Register(UserRegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                var errors = string.Join(',', ModelState.Select(x => x.Value.Errors)
                        .Where(y => y.Count > 0)
                        .ToList());
                return Ok(errors);
            }

            return Ok("Success");
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
