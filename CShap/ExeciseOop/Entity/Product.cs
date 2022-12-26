

namespace ExeciseOop.Entity;
internal class Product
{
    public string Proid { get; set; }   
    public string ProName { get; set; }
    public double ProRice { get; set; }
    public int ProQuantity { get; set; }
    public DateTime ProDate { get; set; }

    public override string ToString() => $"{{{nameof(Proid)}={Proid}, {nameof(ProName)}={ProName}, {nameof(ProRice)}={ProRice.ToString()}, {nameof(ProQuantity)}={ProQuantity.ToString()}, {nameof(ProDate)}={ProDate.ToString()}}}";
}
