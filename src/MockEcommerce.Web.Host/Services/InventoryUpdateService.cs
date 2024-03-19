using Microsoft.Extensions.Hosting;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MockEcommerce;

public class InventoryUpdateService : BackgroundService
{
    private readonly IConnection _connection;
    private readonly IModel _channel;
    private readonly IInventoryService _inventoryService;

    public InventoryUpdateService(IInventoryService inventoryService)
    {
        _inventoryService = inventoryService;
        var factory = new ConnectionFactory() { HostName = "localhost" }; // Use your RabbitMQ connection details
        _connection = factory.CreateConnection();
        _channel = _connection.CreateModel();

        _channel.QueueDeclare(queue: "orders", durable: false, exclusive: false, autoDelete: false, arguments: null);
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        stoppingToken.ThrowIfCancellationRequested();

        var consumer = new EventingBasicConsumer(_channel);
        consumer.Received += (ch, ea) =>
        {
            var content = Encoding.UTF8.GetString(ea.Body.ToArray());
            var updateMessage = ParseMessage(content);
            _inventoryService.UpdateInventory(updateMessage.ProductId, updateMessage.Quantity);

            _channel.BasicAck(ea.DeliveryTag, false);
        };

        _channel.BasicConsume("orders", false, consumer);

        return Task.CompletedTask;
    }

    private (int ProductId, int Quantity) ParseMessage(string message)
    {
        // Implement message parsing logic here
        return (1, 10); // Example return
    }

    public override void Dispose()
    {
        _channel.Close();
        _connection.Close();
        base.Dispose();
    }
}
