using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1.Utils
{
    public static class ListExtensions
    {
        public static T RemoveAndReturnFirst<T>(this List<T> list)
        {
            T currentFirst = list.First();
            list.RemoveAt(0);
            return currentFirst;
        }
    }
}