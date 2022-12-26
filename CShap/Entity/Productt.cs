using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity;
public class Productt
{
    public string Proid { get; set; }
    public string ProName { get; set; }
    public double ProRice { get; set; }
    public int ProQuantity { get; set; }
    public DateTime ProDate { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(Proid)}={Proid}, {nameof(ProName)}={ProName}, {nameof(ProRice)}={ProRice.ToString()}, {nameof(ProQuantity)}={ProQuantity.ToString()}, {nameof(ProDate)}={ProDate.ToString()}}}";
    }
}
