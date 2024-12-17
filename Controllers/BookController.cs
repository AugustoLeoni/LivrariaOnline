using LivrariaOnline.Communication.Request;
using LivrariaOnline.Entities;
using Microsoft.AspNetCore.Mvc;
using LivrariaOnline.DataBase;

namespace LivrariaOnline.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(string), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        DataBaseBook.AddBook(request);

        return Created(string.Empty, "Ok");
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = DataBaseBook.GetAllBooks();

        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update(
        [FromRoute] int id,
        [FromBody] RequestRegisterBookJson request)
    {
        DataBaseBook.Update(id, request);
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete(int id)
    {
        DataBaseBook.Delete(id);
        return NoContent();
    }
}
