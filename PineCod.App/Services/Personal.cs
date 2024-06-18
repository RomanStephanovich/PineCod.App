using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineCod.Services.Services
{
    public class Personal 
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Personal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
        }
    }
}
