using System.ComponentModel.DataAnnotations;
delegate void Display();
internal class Program
{
    //method
    public static int Sub(int a, int b) => a+b;
    public static void Show() => Console.WriteLine("kieu minh kha");
    public static int ReturnNumber() => 5;
    private static void Main(string[] args)
    {
        //local function
        void Add(int a, int b) => Console.WriteLine(a + b);
        //func vaf action => đều là delegate
        //action dùng cho các phương thức là void
        //func dùng cho phương thức khác void
        // Display a = Show;
        //a();  
        //Action act = Show;
        //Action<int, int> ac = Sub;

        //act();
        Func<int,int,int> fun = Sub ;
        Console.WriteLine(fun(1,2));
        Action<string> action = (str) =>
        {
            Console.WriteLine(str);
        };
        action("hehe");
        //action.Invoke();
    }
}