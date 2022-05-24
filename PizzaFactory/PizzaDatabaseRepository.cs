using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
	internal class PizzaDatabaseRepository : IPizzaRepository
	{
		public IEnumerable<PizzaBase> GetPizzaBases()
		{
			// load pizza bases from database
			return null;
		}

		public IEnumerable<PizzaTopping> GetPizzaToppings()
		{
			// load pizza toppings from database
			return null;
		}
	}
}
