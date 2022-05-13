using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class Pizza
    {
        private static List<PizzaBase> _pizzaBases = new List<PizzaBase>();
        private static string[] _pizzaToppings = new string[] { "Ham and Mushroom", "Pepperoni", "Vegetable" };

        public PizzaBase Base { get; set; }
        public string Topping { get; set; }

        static Pizza()
        {
            _pizzaBases.Add(new PizzaBase("Thin & Crispy", 1));
            _pizzaBases.Add(new PizzaBase("Stuffed Crust", 1.5m));
            _pizzaBases.Add(new PizzaBase("Deep Pan", 2));
        }

        public static Pizza GenerateRandomPizza()
        {
            Random rnd = new Random();
            int randomBaseIndex = rnd.Next(0, _pizzaBases.Count - 1);

            PizzaBase randomBase = _pizzaBases[randomBaseIndex];

            int randomToppingIndex = rnd.Next(0, _pizzaToppings.Count() - 1);
            string randomTopping = _pizzaToppings[randomToppingIndex];

            return new Pizza() { Base = randomBase, Topping = randomTopping };
        }

        public void Cook()
        {
            System.Threading.Thread.Sleep(CookingTimeMs);
        }

        public int CookingTimeMs
		{
            get
			{
                return (int)(Base.CookingTimeMs) + (Topping.Length * 100);
            }
		}

        public override string ToString()
        {
            return $"{Base} with {Topping}";
        }
    }
}
