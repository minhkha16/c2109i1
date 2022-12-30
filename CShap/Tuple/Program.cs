using Tuple;

Person per = new()
{
    Id = 1,
    FirstName = "kha",
    LastName = "minh",
};
Console.WriteLine(per.Id);
// dungf tuole ko cần đến class (struct)

ValueTuple<int, string, string> p1 = (1, "kha", "kha");
Console.WriteLine(p1.Item1);
// mới hơn 
(int, string, string) p2 = (1, "a", "a");
// dùng var 
var p3 = (1, "b", "b");//value tuple
// net core dùng name thay thế item1, item2,...
(int id , string name, string last) p5 = (1, "b", "b");
Console.WriteLine(p5.id);
// hoặc dùng name phía trước
var p6 = (id: 1, firstname: "c",lastname: "a");
Console.WriteLine(p6.firstname);
p6.firstname = "kha";
Console.WriteLine(p6.firstname);
// không phải là tuple => anonymous type 
var p7 = new{id= 1, name= "d", lastname= "kaha" };
Console.WriteLine(p7.id);
Console.WriteLine(p7.lastname);



