using Microsoft.AspNetCore.Mvc;
using MockEcommerce.Entities;
using MockEcommerce;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;
    private readonly IRabbitMqPublisher _rabbitMqPublisher;

    public OrdersController(IOrderService orderService, IRabbitMqPublisher rabbitMqPublisher)
    {
        _orderService = orderService;
        _rabbitMqPublisher = rabbitMqPublisher;
    }

    [HttpPost]
    public async Task<IActionResult> PlaceOrder([FromBody] OrderDto orderDto)
    {
        var order = await _orderService.PlaceOrder(orderDto);

        if (order == null)
            return BadRequest("Unable to place order, check product availability.");

        _rabbitMqPublisher.PublishOrderMessage($"Order placed: {order.OrderId}");

        return Ok(order);
    }
}
