
namespace BaiTap;
internal class Validatetion
{
    public static bool CheckRegex(string regex , string str)
    {
        var regexs = new Regex(regex);
        if (regexs.IsMatch(str)){
            return true;
        }
        return false;
    }
}
