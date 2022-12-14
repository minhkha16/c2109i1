double a = 0.1;
double b = 0.2;
Console.WriteLine(a + b == 0.3 ? "true" : "false");
decimal c = 0.1M;
decimal d = 0.2M;
Console.WriteLine(c+d==0.3M?"true":"false");
// ?: => ternary operator
// ? nullable value type
string? fullname = null;
//int i = null;
//c# cu
Nullable<int> i = null;
//C# moi
bool?check =null;
//int length = fullname !=null ? fullname.Length : 0;
//int? length = fullname is not null ? fullname.Length : 0;
//var f = 10;
//if (f is 10) { 

//}

// null-conditional operator ? tuong tu != , fullname ma khac null thi tra ve ve sau
int? length = fullname?.Length;

// null-coalescing ?? tuong tu nhu dau == , fullname bang null thi tra ve ve sau
int? chieudai = fullname?.Length ?? 0;