// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using StackExchange.Redis;
using Subscriber1.Listen;

ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(
            new ConfigurationOptions
            {
                EndPoints = { "localhost:6379" }
            });
Console.WriteLine("Redis connected");

new Subscriber1Listener(redis).Listen();

Console.ReadKey();


