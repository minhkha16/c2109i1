
using ArgumentAndParsms;
//pure oop
//ArgumentClass argu = new ArgumentClass();

//dung var
//var argu = new ArgumentClass();

//target-type
ArgumentClass argu = new();

//
argu.Dislay(1, 2, 3);
argu.Dislay(a:1, b:2, 3); // đảo chiều dc

argu.Show(10);
argu.Show(b:10,a:5,c:4);
argu.SumParam(1);
argu.SumParam(1, 2, 3, 4, 5, 6);
