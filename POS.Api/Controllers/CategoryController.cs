using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS.Application.Dtos.Category.Request;
using POS.Application.Interfaces;
using POS.Infraestructure.Commons.Bases.Request;
using POS.Utilities.Static;
using System.Text.Json;

namespace POS.Api.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryApplication _categoryApplication;
        private readonly IGenerateExelApplication _generateExelApplication;
        public CategoryController(ICategoryApplication categoryApplication, IGenerateExelApplication generateExelApplication)
        {
            _categoryApplication = categoryApplication;
            _generateExelApplication = generateExelApplication;
        }
        [HttpGet]
        public async Task<IActionResult> ListCategories([FromQuery]BaseFiltersRequest filters)
        {
            
            var response = await _categoryApplication.ListCategories(filters);
            if ((bool)filters.Download!)
            {
                var columnNames = ExelColumnNames.GetColumnsCategories();
                var fileBytes = _generateExelApplication.GenerateToExel(response.Data!,columnNames);
                return File(fileBytes,ContentType.ContentTypeExel);
            }
            return Ok(response);
        }
        [HttpGet("Select")]
        public async Task<IActionResult> ListSelectCategories()
        {
            var response = await _categoryApplication.ListSelectCategories();
            return Ok(response);
        }
        [HttpGet("{categoryId:int}")]
        public async Task<IActionResult>CategoryById(int categoryId)
        {
            var response = await _categoryApplication.CategoryById(categoryId);
            return Ok(response);
        }
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterCategory([FromBody] CategoryRequestDto requestDto)
        {
            var response = await _categoryApplication.RegisterCategory(requestDto);
            return Ok(response);
        }
        [HttpPut("Edit/{categoryId:int}")]
        public async Task<IActionResult> EditCategory(int categoryId,[FromBody] CategoryRequestDto requestDto)
        {
            var response = await _categoryApplication.EditCategory(categoryId,requestDto);
            return Ok(response);
        }
        [HttpPut("Remove/{categoryId:int}")]
        public async Task<IActionResult> RemoveCategory(int categoryId)
        {
            var response = await _categoryApplication.RemoveCategory(categoryId);
            return Ok(response);
        }

    }
}
