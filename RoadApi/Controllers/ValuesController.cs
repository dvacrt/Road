using Microsoft.AspNetCore.Mvc;

namespace RoadApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ValuesController: ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new[] { "value1", "value2", "value3"});
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok($"Wybrano ID: {id}");
    }

    [HttpGet("add/{a}/{b}")]
    public IActionResult Add(int a, int b)
    {
        return Ok(a+b);
    }
}
