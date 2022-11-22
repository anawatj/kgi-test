using Core.Events;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.Pubhisher
{
    public class Subscribe3Publisher : BasePublisher
    {
        public Subscribe3Publisher(ConnectionMultiplexer redis) : base(redis)
        {
        }

        public override Subjects Subjects { get; set; } = Subjects.Subscribe3;


    }
}
