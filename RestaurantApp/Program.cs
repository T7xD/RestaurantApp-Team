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
            Console.WriteLine("pongsakorn hongsiri no.11");
            Console.WriteLine("tiw");
            Console.WriteLine("thanawat chantawat no.4");
            Console.WriteLine("Dingdome");
            List<Restaurant> restaurants = new List<Restaurant>
        {
            new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
            new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
            new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
        };
            
            {
                if (restaurants == null || restaurants.Count == 0)
                {
                    Console.WriteLine("ไม่พบข้อมูลร้านอาหารในระบบ");
                    return;
                }

                
                Restaurant maxRestaurant = restaurants[0];
                Restaurant minRestaurant = restaurants[0];

                
                foreach (var item in restaurants)
                {
                    if (item.Rate > maxRestaurant.Rate)
                    {
                        maxRestaurant = item;
                    }

                    if (item.Rate < minRestaurant.Rate)
                    {
                        minRestaurant = item;
                    }
                }

                
                Console.WriteLine("=== สรุปข้อมูลร้านอาหาร ===");
                Console.WriteLine($"ร้านคะแนนสูงสุด: {maxRestaurant.Name} (คะแนน: {maxRestaurant.Rate})");
                Console.WriteLine($"ร้านคะแนนต่ำสุด: {minRestaurant.Name} (คะแนน: {minRestaurant.Rate})");

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
