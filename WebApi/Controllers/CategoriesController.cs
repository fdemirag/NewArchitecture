using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
        {
            ICategoryService _categoryService;

            public CategoriesController(ICategoryService categoryService)
            {
                _categoryService = categoryService;
            }
            [HttpPost]
            public async Task<IActionResult> Add([FromBody] Category category)
            {
                await _categoryService.Add(category);
                return Ok();
            }

            [HttpGet]
            public async Task<IActionResult> GetList()
            {
                var result = await _categoryService.GetListAsync();
                return Ok(result);
            }
        }
    }


