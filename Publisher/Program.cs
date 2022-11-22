// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Core.Messages;
using Publisher.Pubhisher;
using StackExchange.Redis;

ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(
            new ConfigurationOptions
            {
                EndPoints = { "localhost:6379" }
            });
Console.WriteLine("Redis connected");
string text = Console.ReadLine();
var message = new TextMessage(text);
new Subscribe2Publisher(redis).Publish(message);
new Subscribe1Publisher(redis).Publish(message);
new Subscribe3Publisher(redis).Publish(message);
Console.ReadKey();
