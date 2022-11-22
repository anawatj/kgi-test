using StackExchange.Redis;
using Subscriber2.Listen;

ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(
            new ConfigurationOptions
            {
                EndPoints = { "localhost:6379" }
            });
Console.WriteLine("Redis connected");

new Subscriber2Listener(redis).Listen();

Console.ReadKey();
