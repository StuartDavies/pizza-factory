using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class Pizza
    {
        private static IDictionary<string, decimal> _pizzaBases = new Dictionary<string, decimal>();
        private static string[] _pizzaToppings = new string[] { "Ham and Mushroom", "Pepperoni", "Vegetable" };

        private const int BASE_COOKING_TIME_MS = 3000;

        public string Base { get; set; }
        public string Topping { get; set; }
        public int CookingTimeMs { get; private set; }

        static Pizza()
        {
            _pizzaBases.Add("Thin and Crispy", 1);
            _pizzaBases.Add("Stuffed Crust", 1.5m);
            _pizzaBases.Add("Deep Pan", 2);
        }

        public static Pizza GenerateRandomPizza()
        {
            Random rnd = new Random();
            int randomBaseIndex = rnd.Next(0, _pizzaBases.Count - 1);
            string randomBase = _pizzaBases.Keys.ElementAt(randomBaseIndex);

            int randomToppingIndex = rnd.Next(0, _pizzaToppings.Count() - 1);
            string randomTopping = _pizzaToppings[randomToppingIndex];

            int cookingTimeMs = (int)(BASE_COOKING_TIME_MS * _pizzaBases[randomBase]) + (randomTopping.Length * 100);
            return new Pizza() { Base = randomBase, Topping = randomTopping, CookingTimeMs = cookingTimeMs };
        }

        public void Cook()
        {
            System.Threading.Thread.Sleep(CookingTimeMs);
        }

        public override string ToString()
        {
            return $"{Base} with {Topping}";
        }
    }
}
