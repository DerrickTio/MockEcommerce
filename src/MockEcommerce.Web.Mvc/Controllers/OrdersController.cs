using Microsoft.AspNetCore.Mvc;
using MockEcommerce.Entities;
using MockEcommerce;
using System.Threading.Tasks;
using MockEcommerce.Product;

public class OrdersController : Controller
{
    private readonly IProductAppService _productAppService;

    public OrdersController(IProductAppService productAppService)
    {
        _productAppService = productAppService;
    }

    public async Task<IActionResult> Orders()
    {
        var orders = await _productAppService.GetAllOrdersAsync();
        var viewModel = orders.Select(o => new OrderViewModel
        {
            OrderId = o.Id,
            ProductName = o.Product.Name,
            Quantity = o.Quantity,
            OrderAmount = o.OrderAmount
        }).ToList();

        return View(viewModel);
    }

}
