using ApiFirstEx.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//IMPORTANT!! intsall automapper nuget package!!
namespace ApiFirstEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtentiController : ControllerBase
    {
        private readonly IMapper _mapper;

        public UtentiController(IMapper mapper)
        {
            _mapper = mapper;
        }


        // GET: api/<UtentiController>
        [HttpGet]
        public ActionResult<UtenteDto> GetUtente()
        {
            var utente = new Utente { Id= 1, Name = "Marco Andreucci", Email = "Marco.Andreucci@example.com"};
            var utentiDto = _mapper.Map<UtenteDto>(utente);


            return Ok(utentiDto);
/*
 * it's possible to add a field in the response 👇🏼
 * 
            var result = new
            {
                Utente = utentiDto,
                CampoAggiuntivo = "Valore del campo aggiuntivo"
            };

            return Ok(result);
*/
        }

    }
}
