using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Messages
{
    public class TextMessage : Message
    {
      public TextMessage(string text)
        {
            this.Data = text;
        }
      public override object Data { get; set; }
    }
}
