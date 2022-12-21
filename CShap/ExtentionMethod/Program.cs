using ExtentionMethod;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("vui lòng nhập con số: ");
int i = int.TryParse(Console.ReadLine(), out var result )?result:0;

//CheckNumber.Check(i, 100);
i.IsGreaterThan(100);
int abc = 500;
abc.IsGreaterThan(100);
// extention method không thông qua đối tượng của class đang chứa mà thông qua cái muốn sử dụng 
Program program= new Program();
program.Hi();