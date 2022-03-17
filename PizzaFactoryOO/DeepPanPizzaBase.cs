using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryOO
{
    public class DeepPanPizzaBase : PizzaBase
    {
        public override string Name { get; } = "Deep Pan";

        protected override decimal BaseCookingTimeMultiplier { get; } = 2;
    }
}
