using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //-- Attribute C# -- Annotation Java 

    public class CategoriesController : ControllerBase
    {
        //Loosely couple - gevşek bağımlılık
        //naming convention
        //IoC Container -- Inversion of Control
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }



        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult Get(int categoryId)
        {
            var result = _categoryService.GetById(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
