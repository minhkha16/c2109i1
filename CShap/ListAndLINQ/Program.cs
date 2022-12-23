using ListAndLINQ;
using System.Collections;
using System.Diagnostics;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
List<Student> list = new()
{
    new Student(){RollNumber = 1 , FullName = "minh kha", Section = "dãy số 1",HostelNumber =1},
    new Student(){RollNumber = 2 , FullName = "minh", Section = "dãy số 1",HostelNumber =2},
    new Student(){RollNumber = 3 , FullName = "kha", Section = "dãy số 2",HostelNumber =3},
    new Student(){RollNumber = 4 , FullName = "haaa", Section = "dãy số 2",HostelNumber =4},
    new Student(){RollNumber = 5 , FullName = "aaaa", Section = "dãy số 3",HostelNumber =5},
     new Student(){RollNumber = 6 , FullName = "minh kha", Section = "dãy số 1",HostelNumber =6},
    new Student(){RollNumber = 7 , FullName = "minh", Section = "dãy số 1",HostelNumber =7},
    new Student(){RollNumber = 8 , FullName = "kha", Section = "dãy số 2",HostelNumber =7},
    new Student(){RollNumber = 9 , FullName = "haaa", Section = "dãy số 2",HostelNumber =8},
    new Student(){RollNumber = 10 , FullName = "aaaa", Section = "dãy số 3",HostelNumber =9},
    new Student(){RollNumber = 5 , FullName = "aaaa", Section = "dãy số 3",HostelNumber =5},
     new Student(){RollNumber = 6 , FullName = "minh kha", Section = "dãy số 1",HostelNumber =6},
    new Student(){RollNumber = 7 , FullName = "minh", Section = "dãy số 1",HostelNumber =7},
    new Student(){RollNumber = 8 , FullName = "kha", Section = "dãy số 2",HostelNumber =7},
    new Student(){RollNumber = 9 , FullName = "haaa", Section = "dãy số 2",HostelNumber =8},
    new Student(){RollNumber = 5 , FullName = "aaaa", Section = "dãy số 3",HostelNumber =5},
     new Student(){RollNumber = 6 , FullName = "minh kha", Section = "dãy số 1",HostelNumber =6},
    new Student(){RollNumber = 7 , FullName = "minh", Section = "dãy số 1",HostelNumber =7},
    new Student(){RollNumber = 8 , FullName = "kha", Section = "dãy số 2",HostelNumber =7},
    new Student(){RollNumber = 9 , FullName = "haaa", Section = "dãy số 2",HostelNumber =8},
    new Student(){RollNumber = 5 , FullName = "aaaa", Section = "dãy số 3",HostelNumber =5},
     new Student(){RollNumber = 6 , FullName = "minh kha", Section = "dãy số 1",HostelNumber =6},
    new Student(){RollNumber = 7 , FullName = "minh", Section = "dãy số 1",HostelNumber =7},
    new Student(){RollNumber = 8 , FullName = "kha", Section = "dãy số 2",HostelNumber =7},
    new Student(){RollNumber = 9 , FullName = "haaa", Section = "dãy số 2",HostelNumber =8}
};
Stopwatch sw = new Stopwatch();
sw.Restart();
foreach (var stu in list)
{
    Console.WriteLine(stu);
}
Console.WriteLine($"foreach time: {sw.ElapsedMilliseconds}");
sw.Restart();

// tất cả các dạng của collection đều có mẫu để duyệt qua dữ liệu mà ko for hay foreach => ienumarator

IEnumerator<Student> enu = list.GetEnumerator();
while (enu.MoveNext())
{
    Console.WriteLine(enu.Current);
}
Console.WriteLine($"IEnumerator time: {sw.ElapsedMilliseconds}");
sw.Restart();
//linq => lauguage Intergrated query 
//linq to sql 
// linq to object
//linq xml, json
//parallel linq =>plinq

//linq to object có 2 dạng 
// style 1) theo trường phái sql => query syntax , dễ học , dễ hiểu 
// style 2) theo trường phái lamda => method syntax , khó học , rất khó hiểu

//liệt kê tất cả sinh viên với mã sinh viên lớn hơn 2
foreach (var stu in list)
{
    if (stu.RollNumber > 2)
    {
        Console.WriteLine(stu);
    }
}
Console.WriteLine("==================================");
//linq to object style 1
//var liststu = (from stu in list
//              where stu.RollNumber > 2
//              select stu).Count();
//Console.WriteLine(liststu);
foreach (var st in from s in list
                   where s.RollNumber > 2
                   select s)
{
    Console.WriteLine(st);
}

//linq to object style 2
//var liststu = list.Where(stu => stu.RollNumber > 2);
//foreach (var st in liststu)
//{
//    Console.WriteLine(st);
//}

foreach (var st in list.Where(stu => stu.RollNumber > 2))
{
    Console.WriteLine(st);
}
// các phương thức có sẵn trong list
list.ForEach(Console.WriteLine);
list.ForEach(
        stu =>
        {
            if (stu.RollNumber > 2)
            {
                Console.WriteLine(stu);
            }
        }
    );
// kết hợp lamda với phương thức có sẵn của list
//list.Where(stu => stu.RollNumber > 2).ToList().ForEach(Console.WriteLine);

//var r = from stu in list
//        where stu.RollNumber > 2
//        select new //anonymustype 
//        {
//            StudentDetail = $"{stu.RollNumber} : {stu.FullName}", 
//            StudentRoom = $"{stu.Section} = {stu.HostelNumber}"
//        };
//r.ToList().ForEach(Console.WriteLine);

list.Select(stu => new
{
    StudentDetail = $"{stu.RollNumber} : {stu.FullName}",
    StudentRoom = $"{stu.Section} = {stu.HostelNumber}"
}).ToList().ForEach(Console.WriteLine);
// lần đầu tiên thực thi trên server và trả kết quả về bộ nhớ
IEnumerable<Student> i = from stu in list where stu.RollNumber > 2 select stu;
//là bộ nhớ loại bỏ chỉ lấy ư dòng đầu tiên
i = i.Take(2);
//===========
IQueryable<Student> u = from stu in list.AsQueryable() where stu.RollNumber > 2  select stu;
u = u.Take(2);
//sẽ chạy lên server dùng dễ phân trang với loading khi cuộn trang 
// ------------------------------
var a = from stu in list where stu.RollNumber > 2 select stu;
a.ToList().ForEach(Console.WriteLine);
