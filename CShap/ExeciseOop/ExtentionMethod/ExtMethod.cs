using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeciseOop.ExtentionMethod;
internal static class ExtMethod
{
    public static void ChangColor<T>(this T ojb , params ConsoleColor[] cw)
    {
        Console.BackgroundColor = cw[0];
        Console.BackgroundColor = cw[1];
    }
    public static bool In<T>(this T obj , params T[] items) { 
        return items.Contains(obj);
            
    } 
}
