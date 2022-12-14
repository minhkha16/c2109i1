using System.Collections;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

string[] arrs = { "kha", "quan", "loi", "thái", "thảo" };
foreach(var  i in arrs)
{
    Console.WriteLine($"{i} có chiều dài {i.Length}");
}
//int a = 0;

//while(a< arrs.Length) { Console.WriteLine($"{a} có chiều dài {arrs[a].Length}"); a++; }

IEnumerator e = arrs.GetEnumerator();
while( e.MoveNext()) {
    String s = (string)e.Current;
    Console.WriteLine($"{s} có chiều dài {s.Length}");

}
