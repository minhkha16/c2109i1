 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

namespace OopEncapsulationPropety;
internal class HumaBeing
{
    //fields cac field phair laf private
    private string fullname;
    public  string Address {  get; set; }//web
    private int Age { get; set; }

    //public void SetFullName (string fullname) { this.fullname = fullname; }
    //public String GetFullname() { return fullname; }
    //cac phuong thuc get set
    public String FullName {
        set => fullname = value; 
        get =>  fullname; 
    }//=> dung cho mobile
    public void ShowProper()
    {
        Console.WriteLine($"{nameof(Address)} = {Address}");
        Console.WriteLine($"{nameof(fullname)} = {fullname}");
    }
}
