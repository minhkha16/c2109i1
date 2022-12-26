

using ExeciseOop.ExtentionMethod;
using ExeciseOop.Service;

namespace ExeciseOop.Dal;
internal class DalProduct: IProduct
{
    public List <Product> list { get; set; } = new ();
    public void AddProduct()
    {
        list.ChangColor(ConsoleColor.Black, ConsoleColor.Red);
        Console.WriteLine("nhaapj id");

    }
}
