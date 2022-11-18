using DotnetWeb.Models;
using DotnetWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetWeb.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public JsonFileFoodsService FoodService;
    public IEnumerable<Food> Foods { private set; get; }
    public JsonFileProductService ProductService;
    public IEnumerable<Product> Products { private set; get; }


    public IndexModel(ILogger<IndexModel> logger,
        JsonFileFoodsService foodService,
        JsonFileProductService productService)
    {
        _logger = logger;
        FoodService = foodService;
        ProductService = productService;
    }

    public void OnGet()
    {
        Foods = FoodService.GetFoods();
        Products = ProductService.GetProducts();
    }
}

