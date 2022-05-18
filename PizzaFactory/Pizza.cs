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
        private static List<PizzaTopping> _pizzaToppings = new List<PizzaTopping>();

        public PizzaBase Base { get; }
        public PizzaTopping Topping { get; }

        public Pizza(PizzaBase pizzaBase, PizzaTopping pizzaTopping)
        {
            Base = pizzaBase;
            Topping = pizzaTopping;
        }

        public void Cook()
        {
            System.Threading.Thread.Sleep(CookingTimeMs);
        }

        public int CookingTimeMs
		{
            get
			{
                return (int)(Base.CookingTimeMs) + (Topping.CookingTimeMs);
            }
		}

        public override string ToString()
        {
            return $"{Base} with {Topping}";
        }
    }
}
