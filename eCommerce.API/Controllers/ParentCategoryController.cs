using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentCategoryController : ControllerBase
    {
        private readonly DataContext _context;
        public ParentCategoryController(DataContext context)
        {
            _context = context;

        }
        // GET api/parentcategory
        [HttpGet]
        public async Task<IActionResult> GetParentCategories()
        {
            var ParentCategories = await _context.ParentCategories.ToListAsync();
            return Ok(ParentCategories);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetParentCategory(int id)
        {
            var ParentCategory = await _context.ParentCategories.FirstOrDefaultAsync(x => x.ID == id);
            return Ok(ParentCategory);
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

