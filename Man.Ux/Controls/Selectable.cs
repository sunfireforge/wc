using System;
using System.Collections.Generic;
using System.Text;

namespace stonkbot.Controls
{
    public class Selectable<T>
    {
        public T Value {get;set;}
        public bool IsSelected { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
      
}
