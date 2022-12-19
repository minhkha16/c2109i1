using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymophismOveride;
internal class Child:Parent
{
    public override void Display()
    {
        base.Display();
        Console.WriteLine("child display");
    }
    public void Show()
    {
        Console.WriteLine("Child show");
    }
}
