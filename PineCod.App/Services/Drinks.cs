using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineCod.Services.Services
{
    public class Drinks:Food
    {
        public Drinks(string name, string description, decimal price)
        :base (name, description, price)
            { }
    }
    public static class DrinksService
    {
        private static List<Drinks>drinks = new List<Drinks>();
        public static List<Drinks> GetAllDrinks()
        {
            return new List<Drinks>(drinks);
        }
    }
}
