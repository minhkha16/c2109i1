using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass;
internal class ClassOne <T>
{
    public T Field { get; set; }
    public void Show() => Console.WriteLine(Field);
}
