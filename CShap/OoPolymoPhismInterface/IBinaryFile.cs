using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoPolymoPhismInterface;
internal interface IBinaryFile
{
    // co kieu tra ve va phuong thuc ko co bo tu
    void WriteBinaryFile();
    void ReadFile();
    //phuong thuc mat dinh cua interface
    void ShowInfo() => Console.WriteLine("this is binary file");
}
