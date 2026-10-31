using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MU HA HA HA HA");
            Console.WriteLine("pattanan mullamom no.10");
            Console.WriteLine("kang");
            Console.WriteLine("pongsakorn hong no.11");
            Console.WriteLine("thanawat chantawat no.4");
            List<Restaurant> restaurants = new List<Restaurant>
        {
            new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
            new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
            new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
        };
            foreach (var item in restaurants)
            {
                Console.WriteLine($"{item.Name} Type:{item.Type} -- {item.Rate}");
            }
        }
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rate { get; set; }

        public Restaurant(int id,string name,string type,double rate) 
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Rate = rate;
        }
    }
}
