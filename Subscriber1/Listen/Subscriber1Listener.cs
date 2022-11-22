using Core.Events;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber1.Listen
{
    public class Subscriber1Listener : BaseListener
    {
        public Subscriber1Listener(ConnectionMultiplexer redis) : base(redis)
        {
           
        }

        public override Subjects Subjects { get; set; } = Subjects.Subscribe1;

    }
}
