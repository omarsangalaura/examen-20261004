using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiSimple.Controllers
{
    [Route("api/operations")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetState()
        {
            return Ok("Estado: Activo");
        }
    }
}
