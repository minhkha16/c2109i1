
namespace BaiTap;
internal class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public bool Sex { get; set; }
    public DateTime BirthDay{ get; set; }

    public override string ToString()
    {
        return $"{{{nameof(Id)}={Id.ToString()}, {nameof(FullName)}={FullName}, Gender={(Sex?"Nam":"Nữ")}, {nameof(BirthDay)}={BirthDay.ToString("yyyy-MM-dd")}}}";
    }
}
