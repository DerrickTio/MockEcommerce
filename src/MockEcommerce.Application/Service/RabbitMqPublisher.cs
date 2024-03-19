using Microsoft.Extensions.Options;
using MockEcommerce.Configuration;
using RabbitMQ.Client;
using System.Text;

namespace MockEcommerce.Service
{
    public class RabbitMqPublisher
    {
        private readonly RabbitMQOptions _options;

        public RabbitMqPublisher(IOptions<RabbitMQOptions> options)
        {
            _options = options.Value;
        }

        public void PublishOrderMessage(string message)
        {
            var factory = new ConnectionFactory()
            {
                HostName = _options.HostName,
                UserName = _options.UserName,
                Password = _options.Password
            };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "orders",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                     routingKey: "orders",
                                     basicProperties: null,
                                     body: body);
            }
        }
    }
}
