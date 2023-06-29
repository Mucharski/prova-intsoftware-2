using System.Text;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Metadata;
using Newtonsoft.Json;
using ProvaSoftware.Data;
using ProvaSoftware.Data.Models;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using IModel = RabbitMQ.Client.IModel;

namespace ProvaSoftware.Services;

public class ConsumeQueue : IHostedService
{
    private readonly IServiceScopeFactory _scopeFactory;
    
    public ConsumeQueue(IServiceScopeFactory service)
    {
        _scopeFactory = service;
    }
    async Task ConsumirFila()
    {
        var factory = new ConnectionFactory { HostName = "localhost" };
        var connection = factory.CreateConnection();
        var channel = connection.CreateModel();
        var fila = "folhaPagamento";
        
        var consumer = new EventingBasicConsumer(channel);
        consumer.Received += async (model, message)  =>
        {
            var body = message.Body.ToArray();
            var mensagem = Encoding.UTF8.GetString(body);
            
            var modelDatabase = JsonConvert.DeserializeObject<FolhaDePagamento>(mensagem);
            
            using (var scope = _scopeFactory.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<Context>();
                await context.AddAsync(modelDatabase);
                await context.SaveChangesAsync();
            }//scope (and context) gets destroyed here

        };
        channel.BasicConsume(
            queue: fila,
            autoAck: true,
            consumer: consumer
        );
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("CONSUMO DE FILA INICIADO");
        await ConsumirFila();
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("CONSUMO DE FILA INTERROMPIDO");
    }
}