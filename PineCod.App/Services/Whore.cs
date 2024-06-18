using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PineCod.Services.Services
{
    public class Whore : Personal
    {
        public decimal Price { get; set; }
        public Whore(string name, int age, decimal price)
        : base(name, age)
        {
            Price = price;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Цена: {Price}");
        }
        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age} ,Цена: {Price}";
        }
    }
    public static class WhoreService
    {
        public static List<Whore> whores = new List<Whore>();
        public static List<Whore> GetAllWhores()
        {
            return new List<Whore>(whores);
        }
        public static void AddWhore(Whore whore)
        {
            if (whore != null)
            {
                AddWhore(whore);
            }
            bool allWhores = whores.All(w => w.Age > 18);
        }
        public static void RemoveWhoreByName(List<Whore> whore, string name)
        {
            var Whore = whore.FirstOrDefault(W => W.Name == name);
            if (Whore != null)
            {
                whore.Remove(Whore);
            }
        }

        public static List<Whore> SearchWhoresByName(string name)
        {
            return whores.Where(w => w.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public static List<Whore> SearchWhoresByPrice(decimal price)
        {
            return whores.Where(w => w.Price == price).ToList();
        }
        
        public static void SortWhoreByPrice(List<Whore> whore, decimal price)
        {
            var sortWhoreDesc = whores.OrderBy(w=> w.Price).ToList();
        }
        static void PrintWhore(IEnumerable<Whore> whores)
        {
            foreach (var whore in whores)
            {
                Console.WriteLine($"{whore.Name}, {whore.Age}, {whore.Price}");
            }
        }
        
    }
    
}

    

    


