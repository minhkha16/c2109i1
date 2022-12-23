

namespace BaiTap;
internal class StudentDao
{
    public static void  Students()
    {
        Quantity: Console.WriteLine("Nhập số lượng sinh viên: ");
        string i = Console.ReadLine();
        if (!Validatetion.CheckRegex(Regexs.num, i))
        {
            goto Quantity;
        }
        
        List<Student> students = new ();
        for (int a = 0; a < int.Parse(i); a++)
        {   
            Student stu = new();
            ID_student: Console.WriteLine("Nhập Id sinh viên: ");
            string id_student = Console.ReadLine();
            if (!Validatetion.CheckRegex(Regexs.num, id_student))
            {
                goto ID_student;
            }
            if(( students.Where (s => s.Id == Int32.Parse(id_student))).Count() == 1)
            {
                goto ID_student;
            }
            stu.Id = int.Parse(id_student);
            Fullname_student: Console.WriteLine("Nhập họ và sinh viên: ");
            stu.FullName = Console.ReadLine();
            if (!Validatetion.CheckRegex(Regexs.chars, stu.FullName))
            {
                goto Fullname_student;
            }
            Sex_student: Console.WriteLine("Nhập giới tính ( 1 : nam hoặc 0 :nữ ): ");
            string sex_student = Console.ReadLine();
            if (!Validatetion.CheckRegex(Regexs.bools, sex_student))
            {
                goto Sex_student;
            }
            stu.Sex = sex_student == "1"?true:false;
            Brithday_student: Console.WriteLine("Nhập ngày sinh (yyyy-MM-dd): ");
            string brithday_student = Console.ReadLine();
            if(!Validatetion.CheckRegex(Regexs.dates, brithday_student))
            {
                goto Brithday_student;
            }
            stu.BirthDay = DateTime.Parse(brithday_student);
            students.Add(stu);
        }
        int menu = Int32.Parse(Menu.Menus());
        while (menu < 7) 
        {
                switch (menu)
                {
                    case 1:
                        {
                            Student stu = new();
                            ID_insert: Console.WriteLine("Nhập Id sinh viên: ");
                            string id_insert = Console.ReadLine();
                            if (!Validatetion.CheckRegex(Regexs.num, id_insert))
                            {
                                goto ID_insert;
                            }
                            if ((students.Where(s => s.Id == Int32.Parse(id_insert))).Count() == 1)
                            {
                                goto ID_insert;
                            }
                             stu.Id = int.Parse(id_insert);
                            Fullname_student: Console.WriteLine("Nhập họ và sinh viên: ");
                            stu.FullName = Console.ReadLine();
                            if (!Validatetion.CheckRegex(Regexs.chars, stu.FullName))
                            {
                                goto Fullname_student;
                            }
                            Sex_insert: Console.WriteLine("Nhập giới tính ( 1 : nam hoặc 0 :nữ ): ");
                            string sex_insert = Console.ReadLine();
                            if (!Validatetion.CheckRegex(Regexs.bools, sex_insert))
                            {
                                goto Sex_insert;
                            }
                            stu.Sex = sex_insert == "1" ? true : false;
                            Brithday_insert: Console.WriteLine("Nhập ngày sinh (yyyy-MM-dd): ");
                            string brithday_insert = Console.ReadLine();
                            if (!Validatetion.CheckRegex(Regexs.dates, brithday_insert))
                            {
                                goto Brithday_insert;
                            }
                            stu.BirthDay = DateTime.Parse(brithday_insert);
                            students.Add(stu);
                            Console.WriteLine("Thêm thành công");
                            break;
                        }
                    case 2:
                        {
                            var count = (from s in students select s).Count();
                            ID_delete: Console.WriteLine("Nhập Id sinh viên cần xóa: ");
                            var id = Console.ReadLine();
                        if (!Validatetion.CheckRegex(Regexs.num,id))
                        {
                            goto ID_delete;
                        }
                        if ((students.Where(s => s.Id == Int32.Parse(id))).Count() == 0)
                        {
                            Console.WriteLine("Id không tồn tại.");
                            goto ID_delete;
                        }
                        for (int b = 0; b < count; b++)
                            {
                                if (students[b].Id == Int32.Parse(id))
                                {
                                    students.RemoveAt(b);
                                    Console.WriteLine("xóa thành công.");
                                    break;
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            ID_Seach: Console.WriteLine("Nhập Id sinh viên cần tìm");
                            int id = int.Parse(Console.ReadLine());
                            if (!Validatetion.CheckRegex(Regexs.num, id.ToString()))
                            {
                                goto ID_Seach;
                            }
                            if ((students.Where(s => s.Id == id)).Count() == 0)
                            {
                                Console.WriteLine("Id không tồn tại.");
                                goto ID_Seach;
                            }
                        students.Where(stu => stu.Id == id).ToList().ForEach(Console.WriteLine);
                            break;
                        }
                    case 4:
                        {
                            ID_Update: Console.WriteLine("Nhập Id sinh viên cần sữa");
                            int id = int.Parse(Console.ReadLine());
                        if (!Validatetion.CheckRegex(Regexs.num, id.ToString()))
                        {
                            goto ID_Update;
                        }
                        if ((students.Where(s => s.Id == id)).Count() == 0)
                        {
                            Console.WriteLine("Id không tồn tại.");
                            goto ID_Update;
                        }
                        students.Where(stu => stu.Id == id).ToList().ForEach(Console.WriteLine);
                            var result = students.Where(stu => stu.Id == id);
                        string? sex_update = null;
                        string? fullname_update = null;
                        string? brithday_update = null;
                        switch (Menu.Menu_update())
                        {
                            case 1:
                                {   
                                    
                                    Fullname_update: Console.WriteLine("Nhập họ và sinh viên: ");
                                    fullname_update = Console.ReadLine();
                                    if (!Validatetion.CheckRegex(Regexs.chars, fullname_update))
                                    {
                                        goto Fullname_update;
                                    }
                                    result.First().FullName = fullname_update;
                                    break;
                                }
                            case 2:
                                {
                                    
                                    Sex_update: Console.WriteLine("Nhập giới tính ( 1 : nam hoặc 0 :nữ ):  ");
                                    sex_update = Console.ReadLine();
                                    if (!Validatetion.CheckRegex(Regexs.bools, sex_update))
                                    {
                                        goto Sex_update;
                                    }
                                    result.First().Sex = sex_update == "1" ? true : false;
                                    break;
                                }
                            case 3:
                                {
                                   
                                    Brithday_update: Console.WriteLine("Nhập ngày sinh (yyyy-MM-dd):  ");
                                    brithday_update = Console.ReadLine();
                                    if (!Validatetion.CheckRegex(Regexs.dates, brithday_update))
                                    {
                                        goto Brithday_update;
                                    }
                                    result.First().BirthDay = DateTime.Parse(brithday_update);
                                    break;
                                }
                            case 4:
                                {
                                    
                                    Fullname_update: Console.WriteLine("Nhập họ và sinh viên: ");
                                    fullname_update = Console.ReadLine();
                                    if (!Validatetion.CheckRegex(Regexs.chars, fullname_update))
                                    {
                                        goto Fullname_update;
                                    }
                                    result.First().FullName = fullname_update;
                                    
                                    Sex_update: Console.WriteLine("Nhập giới tính ( 1 : nam hoặc 0 :nữ ):");
                                    sex_update = Console.ReadLine();
                                    if (!Validatetion.CheckRegex(Regexs.bools, sex_update))
                                    {
                                        goto Sex_update;
                                    }
                                    result.First().Sex = sex_update == "1" ? true : false;
                      
                                    Brithday_update: Console.WriteLine("Nhập ngày sinh (yyyy-MM-dd):");
                                    brithday_update = Console.ReadLine();
                                    if (!Validatetion.CheckRegex(Regexs.dates, brithday_update))
                                    {
                                        goto Brithday_update;
                                    }
                                    result.First().BirthDay = DateTime.Parse(brithday_update);
                                    break;
                                }
                            default:
                                break;
                        }
                            break;
                        }
                    case 5:
                        {
                            students.ForEach(Console.WriteLine);
                            break;
                        }
                    case 6:
                        {
                            students.OrderByDescending(stu => stu.Id).ToList().ForEach(Console.WriteLine);
                            break;
                        }
                    default:
                        break;
                }
            menu = Int32.Parse(Menu.Menus());
        } 
        
       
    }

}
