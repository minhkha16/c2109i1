using System.Text;
using System.Text.RegularExpressions;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

//string? str = null;
//Console.WriteLine("vui lòng nhập số: ");
//str= Console.ReadLine();
//var formula = new Regex("^[0-9]+$");
//if (formula.IsMatch(str))
//{
//    int result = Convert.ToInt32(str);
//    result++;
//    Console.WriteLine(++result);
//}
//if (int.TryParse(str,out int i))
//{
//    Console.WriteLine($"i là số: {i}");
//}
Console.WriteLine("vui lòng nhập số lượng: ");
string? amount = Console.ReadLine();
// dùng try catch
// mệnh đề "gurard clause"
if (string.IsNullOrEmpty(amount)){
    return;
}
try
{
    int total = int.Parse(amount);
    if (total <= 0) throw new Exception("phải lớn hơn 0");
    Console.WriteLine($"{nameof(total)}={total}");
}
catch (Exception) when (amount.Contains("$"))
{
    Console.WriteLine("chuỗi không được có dấu $");
}
catch (Exception e)
{
    Console.WriteLine($"{e.GetType()},{e.Message}");
}