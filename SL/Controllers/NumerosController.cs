using Microsoft.AspNetCore.Mvc;


namespace SL.Controllers
{
    public class NumerosController : Controller
    {

        [HttpGet]
        [Route("api/Numeros/Suma/{numeroUno}/{numeroDos}")]
        public IActionResult Suma(int numeroUno, int numeroDos)
        {
            ML.Result result = BL.Numeros.Suma(numeroUno,numeroDos);
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
