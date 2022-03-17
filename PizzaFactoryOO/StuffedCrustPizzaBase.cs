using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryOO
{
    public class StuffedCrustPizzaBase : PizzaBase
    {
        public override string Name { get; } = "Stuffed Crust";

        protected override decimal BaseCookingTimeMultiplier { get; } = 1.5m;
    }
}
