

namespace OopEncapsulation;
internal class SunFlower : Plantcs
{
    static void Main(string[] args)
    {
        Plantcs sf = new();
        sf.Public();
        sf.Internal();
        sf.ProtectedInternal();

        SunFlower s = new();
        s.Public();
    }
}
