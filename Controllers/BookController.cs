using ApiGestaoDeLivraria.Comunication.Request;
using ApiGestaoDeLivraria.Comunication.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiGestaoDeLivraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredBookJson), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RequestRegisterBookJson request)
        {
            var response = new ResponseRegisteredBookJson
            {
                Id = request.Id,
                Title = request.Title,
                Author = request.Author,
                Gender = request.Gender,
                Price = request.Price,
                Quantity = request.Quantity
            };

            return Created(string.Empty, response);
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<RequestRegisterBookJson>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var response = new List<ResponseRegisteredBookJson>()
            {
                new ResponseRegisteredBookJson {Id = 1, Title = "ASP.NET", Author = "Microsoft", Gender = "Programação", Price = 50.49f, Quantity = 1},
                new ResponseRegisteredBookJson {Id = 2, Title = "A Cabana", Author = "William", Gender = "Ficção", Price = 31.99f, Quantity = 7},
            };

            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateBookJson request)
        {
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete([FromRoute] int id)
        {
            return NoContent();
        }
    }
}
