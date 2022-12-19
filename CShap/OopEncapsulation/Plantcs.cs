

namespace OopEncapsulation;
internal class Plantcs
{
    //encapsulation thể hiện ở 2 chỗ
    //a) access modify b) property

    // a) access modify
    private void Private() => Console.WriteLine("private");
    protected void Protected() => Console.WriteLine("Protected");
    internal void Internal() => Console.WriteLine("internal");
    private protected void PrivateProtected() => Console.WriteLine("PrivateProtected");
    protected internal void ProtectedInternal() => Console.WriteLine("ProtectedInternal");
    public void Public() => Console.WriteLine("public");

}
