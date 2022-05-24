using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
	internal class PizzaConfigRepository : IPizzaRepository
	{
		public PizzaConfigRepository(string filename)
		{

		}

		public IEnumerable<PizzaBase> GetPizzaBases()
		{
			// load pizza bases from config file
			return null;
		}

		public IEnumerable<PizzaTopping> GetPizzaToppings()
		{
			// load pizza toppings from config file
			return null;
		}
	}
}
