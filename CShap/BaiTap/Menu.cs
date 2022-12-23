namespace BaiTap;
internal class Menu
{
    public static string Menus() {
        Console.WriteLine("======================================");
        Console.WriteLine("1 : Thêm 1 sinh viên vào danh sách list");
        Console.WriteLine("2 : Xóa 1 sinh viên trong list");
        Console.WriteLine("3 : Tìm kiếm sinh viên trong list");
        Console.WriteLine("4 : Cập nhật lại sinh viên trong list");
        Console.WriteLine("5 : Hiễn thị toàn bộ sinh viên trong list");
        Console.WriteLine("6 : Sắp xếp sinh viên giảm dần theo Id");
        Console.WriteLine("7 : Để thoát");
        string i = Console.ReadLine();
        
            if (!Validatetion.CheckRegex(Regexs.num,i))
            {
                i = Menu.Menus();
            }
        return i;
    }
    public static int Menu_update() {
        Console.WriteLine("=====================================");
        Console.WriteLine("1 : Sửa tên sinh viên");
        Console.WriteLine("2 : Sửa giới tính sinh viên");
        Console.WriteLine("3 : Sửa năm sinh của sinh viên");
        Console.WriteLine("4 : Sửa tất cả thông tin của sinh viên");
        int i = Int32.Parse(Console.ReadLine());
        if (!Validatetion.CheckRegex(Regexs.num, i.ToString()))
        {
            i = Menu.Menu_update();
        }
        return i;
    }
}
