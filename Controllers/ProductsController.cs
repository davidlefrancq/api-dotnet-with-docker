using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Price = 999.99m },
        new Product { Id = 2, Name = "Smartphone", Price = 499.99m }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Product>> Get()
    {
        return Ok(_products);
    }

    [HttpGet("{id}")]
    public ActionResult<Product> Get(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            return NotFound();
        return Ok(product);
    }

    [HttpPost]
    public ActionResult<Product> Post([FromBody] Product product)
    {
        product.Id = _products.Max(p => p.Id) + 1;
        _products.Add(product);
        return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
    }
}