using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap;
internal class Regexs
{
    public const String num = "^[0-9]+$";
    public const String bools = "^[0-1]+$";
    public const String chars = "^([a-zA-Z]\\s*)+$";
    public const String dates = "^\\d{4}[-|/]\\d{2}[-|/]\\d{2}$";

 
}
