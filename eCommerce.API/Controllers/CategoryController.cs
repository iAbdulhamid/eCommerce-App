using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.API.Data;
using eCommerce.API.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly DataContext _context;
        List<CategoryDTO> cats = new List<CategoryDTO>();

        public CategoryController(DataContext context)
        {
            _context = context;

        }
        // GET api/category
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var Categories = await _context.Categories.ToListAsync();

            Categories.ForEach(cat => {
                var Cat = new CategoryDTO();

                Cat.ID = cat.ID;
                Cat.Name = cat.Name;
                Cat.ParentCategory = cat.ParentCategory;
                Cat.parentCategory_ID = cat.parentCategory_ID;
                cats.Add(Cat);
            });
            return Ok(cats);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var Category = await _context.Categories.FirstOrDefaultAsync(x => x.ID == id);

            var Cat = new CategoryDTO();
            Cat.ID = Category.ID;
            Cat.Name = Category.Name;
            Cat.ParentCategory = Category.ParentCategory;
            Cat.parentCategory_ID = Category.parentCategory_ID;
            
            return Ok(Cat);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}