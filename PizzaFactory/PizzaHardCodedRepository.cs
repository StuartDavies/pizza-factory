using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
	internal class PizzaHardCodedRepository : IPizzaRepository
	{
		public IEnumerable<PizzaBase> GetPizzaBases()
		{
			return new PizzaBase[] { new PizzaBase("Thin & Crispy", 1), 
									 new PizzaBase("Stuffed Crust", 1.5m),
									 new PizzaBase("Deep Pan", 2) };
		}

		public IEnumerable<PizzaTopping> GetPizzaToppings()
		{
			return new PizzaTopping[] { new PizzaTopping("Ham and Mushroom"),
										new PizzaTopping("Pepperoni"),
										new PizzaTopping("Vegetable") };
		}
	}
}
