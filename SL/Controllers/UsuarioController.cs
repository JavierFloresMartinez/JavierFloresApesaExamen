using Microsoft.AspNetCore.Mvc;

namespace SL.Controllers
{
    public class UsuarioController : Controller
    {

        [HttpPost]
        [Route("api/Usuario/Add")]
        public IActionResult Add([FromBody] ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            result = BL.Usuario.Add(usuario);
            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }
            
        }
    }
}
