using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineCod.Services.Services
{
    public class Food
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Food(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
    
}
