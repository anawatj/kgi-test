using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Messages
{
    public abstract class Message
    {
        public abstract Object  Data { get; set; }

        public override string ToString()
        {
            return this.Data.ToString();
        }
    }
}
