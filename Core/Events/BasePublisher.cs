using Core.Messages;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Events
{
    public abstract class BasePublisher
    {
        public abstract Subjects Subjects { get; set; }


        private ConnectionMultiplexer redis;

        public BasePublisher(ConnectionMultiplexer redis)
        {
            this.redis = redis;
        }
        public void Publish(Message data)
        {
            ISubscriber sub = this.redis.GetSubscriber();
            var now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Random random = new Random();
            int increte = random.Next(200, 1000);
            // Console.Write(increte);
            var end = now + increte;
            Console.WriteLine(end);
            while (now <= end)
            {
                now = DateTimeOffset.Now.ToUnixTimeMilliseconds() ;
                Console.WriteLine($"Start:{now}");
                sub.Publish(this.Subjects.ToString(), data.ToString());
                Console.WriteLine($"{data.ToString()} has published");
            }
           
        }

    }
}
