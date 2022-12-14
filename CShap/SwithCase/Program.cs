//using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
int number1 = Random.Shared.Next(0, 9);
int number2 = Random.Shared.Next(0, 9);
Console.WriteLine($"{nameof(number1)} = {number1}");
Console.WriteLine($"{nameof(number2)} = {number2}");
Console.WriteLine("vui lòng nhập dấu: ");
var pheptoan = Console.ReadLine();
switch (pheptoan)
{
    case "+" :
        Console.WriteLine(number1 + number2);
        break;
    case "-":
        Console.WriteLine(number1 - number2);
        break;
    case "*":
        Console.WriteLine(number1 * number2);
        break;
    case "/" when number2!= 0 :
        Console.WriteLine(number1 / number2);
        break;
    default: Console.WriteLine("ko tinh dc");
        break;
}
// switch expression => bieu thuc switch
Console.WriteLine(pheptoan switch { 
    "+" when number1 >0 && number2>0 =>number1 + number2,
     "-" when number1 > number2 => number1 - number2,
    "*" => number1 * number2,
    "+" when number2 != 0 => number1 / number2,
    _ => "hi, i can't ..."
});