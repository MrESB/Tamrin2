using System.ComponentModel;
using Tamrin2;

internal class Program
{
    private static void Main(string[] args)
    {
        BatClass bat = new BatClass("Battie", 1, 0.25, 34, "", "meat", "male", false, true, true);
        bat.Introduction();
        Console.WriteLine("************************************************************************");
        CowClass cow = new CowClass("Daisy", 13, 23, 100, "Moo", "grass", "female", true, true, false);
        cow.Introduction();
        Console.ReadKey();
    }
}