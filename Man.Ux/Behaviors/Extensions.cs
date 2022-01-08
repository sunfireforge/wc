using stonkbot.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace stonkbot.Behaviors
{
    public static class Extensions
    {

        public static Selectable<T> ToSelectable<T>(this T thing)
        {
            return new Selectable<T> { Value = thing };
        }
    }
}
