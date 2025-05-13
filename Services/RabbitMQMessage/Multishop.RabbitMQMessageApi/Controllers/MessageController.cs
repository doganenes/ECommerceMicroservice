using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Multishop.RabbitMQMessageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        [HttpPost]
        public async Task <IActionResult> CreateMessage()
        {
            var connectionFactory = new ConnectionFactory()
            {
                HostName = "localhost",
            };

            var connection= await connectionFactory.CreateConnectionAsync();
            var channel = await connection.CreateChannelAsync();
            await channel.QueueDeclareAsync(
                queue: "hello2",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);
            var messageContent = "Hello World2!";
            var byteMessageContent = Encoding.UTF8.GetBytes(messageContent);
            await channel.BasicPublishAsync(exchange: "", routingKey: "hello2", body: byteMessageContent);


            return Ok("Your message receive to queueing!");
        }

        [HttpGet]
        public async Task<IActionResult> ReadMessage()
        {
            string message = "";
            var factory = new ConnectionFactory() { HostName = "localhost" };

            var connection = await factory.CreateConnectionAsync();
            var channel = await connection.CreateChannelAsync();

            var tcs = new TaskCompletionSource<string>();

            var consumer = new AsyncEventingBasicConsumer(channel);
            consumer.ReceivedAsync += async (model, ea) =>
            {
                var body = ea.Body.ToArray();
                message = Encoding.UTF8.GetString(body);
                tcs.SetResult(message);
            };

            channel.BasicConsumeAsync(queue: "hello2", autoAck: true, consumer: consumer);
            message = await tcs.Task;
            return Ok(message);
        }
    }
}
