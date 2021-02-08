﻿using System;
using System.Text;
using RabbitMQ.Client;

namespace HelloWorldClient
{
    public class Sender
    {
        public void Start()
        {
            var factory = new ConnectionFactory() {HostName = "localhost"};
            using IConnection connection = factory.CreateConnection();
            using IModel channel = connection.CreateModel();
            
            channel.QueueDeclare(queue: "hello",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            string message = "Hello World!";
            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: "",
                routingKey: "hello",
                basicProperties: null,
                body: body);
            Console.WriteLine(" [x] Sent {0}", message);

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}