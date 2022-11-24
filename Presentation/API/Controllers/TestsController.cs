using Application.Repositories.CategoryRepository;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly ICategoryWriteRepository _categoryWriteRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        public TestsController(ICategoryWriteRepository categoryWriteRepository, ICategoryReadRepository categoryReadRepository)
        {
            _categoryWriteRepository = categoryWriteRepository;
            _categoryReadRepository = categoryReadRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            //_categoryWriteRepository.AddRange(new List<Category>()
            //{
            //    new() {Name = "Yazılım",Description="Burası açıklama alanıdır.",IsActive = true,CreatedDate = DateTime.UtcNow,UpdatedDate = DateTime.UtcNow},
            //    new() {Name = "Teknoloji",Description="Burası açıklama alanıdır.",IsActive = true,CreatedDate = DateTime.UtcNow,UpdatedDate = DateTime.UtcNow},
            //    new() {Name = "Tiyatro",Description="Burası açıklama alanıdır.",IsActive = true,CreatedDate = DateTime.UtcNow,UpdatedDate = DateTime.UtcNow},
            //    new() {Name = "Sinema & Film",Description="Burası açıklama alanıdır.",IsActive = true,CreatedDate = DateTime.UtcNow,UpdatedDate = DateTime.UtcNow},
            //    new() {Name = "Oyun",Description="Burası açıklama alanıdır.",IsActive = false,CreatedDate = DateTime.UtcNow,UpdatedDate = DateTime.UtcNow}
            //});
            //_categoryWriteRepository.Save();
            var category = _categoryReadRepository.GetById(6,false);
            category.Name = "Test";
            _categoryWriteRepository.Save();
            return Ok();
        }
    }
}
