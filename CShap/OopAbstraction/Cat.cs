

namespace OopAbstraction;
internal abstract class Cat:Animal
{
    private bool gender;
    public void ShowInfoCat()
    {
        Console.WriteLine($"{nameof(gender)}={gender}");
    }
}
