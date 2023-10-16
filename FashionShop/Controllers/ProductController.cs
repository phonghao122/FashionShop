using Infrastructure.Categories;
using Infrastructure.Enums;
using Infrastructure.Products;
using Microsoft.AspNetCore.Mvc;
using FashionShop.Models;

namespace FashionShop.Controllers
{
    public class ProductController : Controller
    {
		private readonly IProductService _productService;
		private readonly ICategoryService _categoryService;

		public ProductController(IProductService productService, ICategoryService categoryService)
		{
			_productService = productService;
			_categoryService = categoryService;
		}
		public IActionResult Index(string categoryId, string keyWord)
        {
			var model = new ProductIndexModel();
			model.Categories = _categoryService.GetCategories();
			model.SelectPageSize = new List<int> { 16, 20, 28, 36 };
			model.OrderBys = new List<ProductOrderByModel>
			{
			new ProductOrderByModel { Name = SortEnum.Name.ToString(),  Value = (int)SortEnum.Name },
			new ProductOrderByModel { Name = SortEnum.Price.ToString(),  Value = (int)SortEnum.Price }
			};

			model.CategoryId = !string.IsNullOrEmpty(categoryId) ? categoryId : string.Empty;
			model.KeyWord = !string.IsNullOrEmpty(keyWord) ? keyWord : string.Empty;

			return View(model);
		}

		public IActionResult ProductListPartial([FromBody] ProductFilterModel model)
		{
			var result = _productService.SearchProduct(model);
			return PartialView(result);
		}

		public IActionResult Detail()
        {
            return View();
        }
    }
}
