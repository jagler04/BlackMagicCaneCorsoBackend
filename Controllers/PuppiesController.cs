using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackMagicCaneCorsoBackend.Business;
using Microsoft.AspNetCore.Mvc;

namespace BlackMagicCaneCorsoBackend.Controllers
{
    public class PuppiesController : Controller
    {
        private readonly Puppies _puppies;
        public PuppiesController(Puppies puppies)
        {
            _puppies = puppies;
        }
        [Route("Request")]
        [HttpPost]
        public IActionResult RequestAPuppy()
        {
            _puppies.Register();
            return Ok();
        }
    }
}
