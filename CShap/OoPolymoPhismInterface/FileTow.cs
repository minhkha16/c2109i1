using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoPolymoPhismInterface;
internal class FileTow : IBinaryFile, ITextFile
{
    public void ReadFile() => Console.WriteLine("read file");

    void ITextFile.ReadFile()
    {
        Console.WriteLine("read file");
    }

    void IBinaryFile.WriteBinaryFile() => Console.WriteLine("write binary dile");

    void ITextFile.WriteTextFile()
    {
        Console.WriteLine("write file");
    }

    //void ITextFile.WriteTextFile() => Console.WriteLine("write file");
}
