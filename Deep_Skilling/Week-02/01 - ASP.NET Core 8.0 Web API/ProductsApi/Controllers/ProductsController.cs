// Deep Skilling - Cognizant Practice
// Author: thrills154
// Module: Controllers

using Microsoft.AspNetCore.Mvc;
using ProductsApi.Models;

namespace ProductsApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> _itemsList = new()
    {
        new Product { Id = 1, Name = "Smartphone", Price = 1299.99m, Category = "Mobile Devices" },
        new Product { Id = 2, Name = "Tablet", Price = 599.99m, Category = "Wearables" },
        new Product { Id = 3, Name = "Smartwatch", Price = 349.99m, Category = "Wearables" }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll() => Ok(_itemsList);

    [HttpGet("{id}")]
    public ActionResult<Product> GetById(int id)
    {
        var product = _itemsList.FirstOrDefault(p => p.Id == id);
        return product == null ? NotFound() : Ok(product);
    }

    [HttpPost]
    public ActionResult<Product> Create(Product product)
    {
        product.Id = _itemsList.Max(p => p.Id) + 1;
        _itemsList.Add(product);
        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Product product)
    {
        var existing = _itemsList.FirstOrDefault(p => p.Id == id);
        if (existing == null) return NotFound();
        existing.Name = product.Name;
        existing.Price = product.Price;
        existing.Category = product.Category;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var product = _itemsList.FirstOrDefault(p => p.Id == id);
        if (product == null) return NotFound();
        _itemsList.Remove(product);
        return NoContent();
    }
}
