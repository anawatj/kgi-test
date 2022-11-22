using StackExchange.Redis;
using Subscriber3.Listen;

ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(
            new ConfigurationOptions
            {
                EndPoints = { "localhost:6379" }
            });
Console.WriteLine("Redis connected");

new Subscriber3Listener(redis).Listen();

Console.ReadKey();
