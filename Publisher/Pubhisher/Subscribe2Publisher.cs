using Core.Events;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.Pubhisher
{
    public class Subscribe2Publisher : BasePublisher
    {
        public Subscribe2Publisher(ConnectionMultiplexer redis) : base(redis)
        {
        }

        public override Subjects Subjects { get; set; } = Subjects.Subscribe2;


    }
}
