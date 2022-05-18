using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class PizzaFactory
    {
        private List<PizzaBase> _pizzaBases = new List<PizzaBase>();
        private List<PizzaTopping> _pizzaToppings = new List<PizzaTopping>();

        public PizzaFactory()
        {
            _pizzaBases.Add(new PizzaBase("Thin & Crispy", 1));
            _pizzaBases.Add(new PizzaBase("Stuffed Crust", 1.5m));
            _pizzaBases.Add(new PizzaBase("Deep Pan", 2));

            _pizzaToppings.Add(new PizzaTopping("Ham and Mushroom"));
            _pizzaToppings.Add(new PizzaTopping("Pepperoni"));
            _pizzaToppings.Add(new PizzaTopping("Vegetable"));
        }

        public Pizza GenerateRandomPizza()
        {
            Random rnd = new Random();

            int randomBaseIndex = rnd.Next(0, _pizzaBases.Count - 1);
            PizzaBase randomBase = _pizzaBases[randomBaseIndex];

            int randomToppingIndex = rnd.Next(0, _pizzaToppings.Count() - 1);
            PizzaTopping randomTopping = _pizzaToppings[randomToppingIndex];

            return new Pizza(randomBase, randomTopping);
        }
    }
}
