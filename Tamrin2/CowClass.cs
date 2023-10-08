using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin2
{
    internal class CowClass : Animal
    {
        public CowClass(string name, int age, double weight, double height,
           string sound, string food, string sex, bool eyes, bool ears, bool wings)
           : base(name, age, weight, height, sound, food, sex, eyes, ears, wings)
        {

        }
        public override void Introduction()
        {
            Console.WriteLine("{0} is an Cow and it's {1} years old. \n" +
                "It has {2} kilogram wheight and {3} Centimeters Height \n" +
                "This Animal makes a {4} and eats {5}. \n {6} is a {7} and has eyes, ears But not wings."
                , name, age, weight, height, sound, food, name, sex);
        }
        public static void Flying()
        {
            Console.WriteLine("A Cow can't fly");
        }
    }
}
