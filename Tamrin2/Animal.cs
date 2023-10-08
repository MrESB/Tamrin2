using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin2
{
    internal class Animal
    {
        protected string name;
        protected int age;
        protected double weight;
        protected double height;
        protected string sound;
        protected string food;
        protected string sex;
        protected bool eyes;
        protected bool ears;
        protected bool wings;
        public Animal(string name, int age, double weight, double height,
            string sound, string food, string sex, bool eyes, bool ears, bool wings)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
            this.sound = sound;
            this.food = food;
            this.sex = sex;
            this.eyes = eyes;
            this.ears = ears;
            this.wings = wings;

        }
        public virtual void Introduction()
        {

            Console.WriteLine("{0} is a animal and it's {1} years old. \n" +
                "It has {2} kilogram wheight and {3} Centimeters Height \n" +
                "This Animal {4}s and eats {5}. \n {6} is a {7} and has eyes, ears and wings."
                , name, age, weight, height, sound, food, name, sex);

        }





    }
}
