using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoPolymoPhismInterface;
internal class FileOne : IBinaryFile, ITextFile
{
    public void ReadFile() => Console.WriteLine("read file");

    public void WriteBinaryFile() => Console.WriteLine("write binary dile");

    public void WriteTextFile() => Console.WriteLine("write file");
}
