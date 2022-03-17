using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryOO
{
    public class ThinAndCrispyPizzaBase : PizzaBase
    {
        public override string Name { get; } = "Thin & Crispy";

        protected override decimal BaseCookingTimeMultiplier { get; } = 1;
    }
}
