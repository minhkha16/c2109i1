
using RefOut;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int a = 10;
int b = 5;

UsRefOut.ChangeNumber(ref a, ref b);
Console.WriteLine($"program : {nameof(a)} = {a}, {nameof(b)} = {b}");