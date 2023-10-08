using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tamrin2
{
    internal class BatClass : Animal
    {
        public BatClass(string name, int age, double weight, double height,
            string sound, string food, string sex, bool eyes, bool ears, bool wings)
            : base(name, age, weight, height, sound, food, sex, eyes, ears, wings)
        {
        }
        public override void Introduction()
        {
            Console.WriteLine("{0} is a Bat and it's {1} years old. \n" +
                "It has {2} kilogram wheight and {3} Centimeters Height \n" +
                "This Animal makes no sound and eats {5}. \n" +
                "{6} is a {7} and hasn't eyes but has ears and wings.",
            name, age, weight, height, sound, food, name, sex);
        }
        public static void Flying()
        {
            Console.WriteLine("A Bat can fly.");
        }

    }
}
