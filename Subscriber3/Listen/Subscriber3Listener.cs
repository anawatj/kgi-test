using Core.Events;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber3.Listen
{
    public class Subscriber3Listener : BaseListener
    {
        public Subscriber3Listener(ConnectionMultiplexer redis) : base(redis)
        {
        }

        public override Subjects Subjects { get; set; } = Subjects.Subscribe3;
    }
}
