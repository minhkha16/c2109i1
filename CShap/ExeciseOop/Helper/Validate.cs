using ExeciseOop.ExtentionMethod;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeciseOop.Helper;
internal class Validate<T>
{
    public static T CheckReadLine()
    {
        var typeCode = Type.GetTypeCode(typeof(T));
        var obj = new Object();
        bool flag;
        do
        {
            flag= true;
            try
            {
                var str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    throw new Exception("error, null or empty");
                }
                switch (typeCode)
                {
                    case TypeCode.Empty:
                        break;
                    case TypeCode.Object:
                        break;
                    case TypeCode.DBNull:
                        break;
                    case TypeCode.Boolean:
                        break;
                    case TypeCode.Char:
                        obj = Convert.ToChar(str.ToLower());
                        if (!obj.In("y", "o")) throw new Exception("error , must be y or o");
                        break;
                    case TypeCode.SByte:
                        break;
                    case TypeCode.Byte:
                        break;
                    case TypeCode.Int16:
                        break;
                    case TypeCode.UInt16:
                        break;
                    case TypeCode.Int32:
                        obj = Convert.ToInt32(str);
                        if ((int)obj < 0) throw new Exception("value must be greater than zero");
                        break;
                    case TypeCode.UInt32:
                        break;
                    case TypeCode.Int64:
                        break;
                    case TypeCode.UInt64:
                        break;
                    case TypeCode.Single:
                        break;
                    case TypeCode.Double:
                        obj = Convert.ToInt32(str);
                        if ((int)obj < 0) throw new Exception("value must be greater than zero");
                        break;
                    case TypeCode.Decimal:
                        break;
                    case TypeCode.DateTime:
                        var date = DateTime.TryParseExact(str, new[] {"d/M/yyy","d-M-yyyy"}, new CultureInfo("vi-VN"), DateTimeStyles.None, out var t)?t: throw new Exception("datetime wrong (d-M-yyyy or d/M/yyyy)");
                        obj= date.Add(DateTime.Now.TimeOfDay);
                        break;
                    case TypeCode.String:
                        obj = str;
                        break;
                    default:
                        obj = null;
                        break; 
                }
            }
            catch (Exception e)
            {

                Console.WriteLine($"{e.GetType()}:{e.Message},please enter again");
                flag= false;
            }
            
        } while (!flag);
        return (T)obj;
    }
}
