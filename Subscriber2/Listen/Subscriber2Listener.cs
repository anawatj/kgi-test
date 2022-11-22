using Core.Events;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber2.Listen
{
    public class Subscriber2Listener : BaseListener
    {
        public Subscriber2Listener(ConnectionMultiplexer redis) : base(redis)
        {
           
        }

        public override Subjects Subjects { get; set; } = Subjects.Subscribe2;

    }
}
