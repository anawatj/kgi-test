using Core.Messages;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Events
{
    public abstract class BaseListener
    {
      
        public abstract Subjects Subjects {get;set;}
      

       

        private ConnectionMultiplexer redis;
      

        public BaseListener(ConnectionMultiplexer redis)
        {
            this.redis = redis;
            
        }
        public void Listen()
        {
            ISubscriber subscriber = redis.GetSubscriber();
            subscriber.Subscribe(Subjects.ToString(), (channel, message) =>
            {
                Console.WriteLine(message.HasValue ? message.ToString().ToLower().Replace("hello", "World"):"");
                var now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                Console.WriteLine($"End:{now}");
            });
        }
    }
}
