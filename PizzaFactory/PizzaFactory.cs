using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class PizzaFactory
    {
        private IReadOnlyList<PizzaBase> _pizzaBases = new List<PizzaBase>();
        private IReadOnlyList<PizzaTopping> _pizzaToppings = new List<PizzaTopping>();

        public PizzaFactory(IPizzaRepository pizzaRepository)
        {
            _pizzaBases = pizzaRepository.GetPizzaBases().ToList();
            _pizzaToppings = pizzaRepository.GetPizzaToppings().ToList();
        }

        public Pizza GenerateRandomPizza()
        {
            Random rnd = new Random();

            int randomBaseIndex = rnd.Next(0, _pizzaBases.Count - 1);
            PizzaBase randomBase = _pizzaBases[randomBaseIndex];

            int randomToppingIndex = rnd.Next(0, _pizzaToppings.Count - 1);
            PizzaTopping randomTopping = _pizzaToppings[randomToppingIndex];

            return new Pizza(randomBase, randomTopping);
        }
    }
}
