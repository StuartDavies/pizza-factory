using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryOO
{
    public abstract class PizzaBase
    {
        private int BASE_COOKING_TIME_MS = 3000;

        public abstract string Name { get; }

        // force any dervied classes to provide a cooking time multiplier by
        // making this property abstract
        protected abstract decimal BaseCookingTimeMultiplier { get; }

        /// <summary>
        /// 
        /// </summary>
        public int CookingTimeMs 
        { 
            get
            {
                // we implement this logic in the base class as we'd only have to repeat
                // it in each derived class otherwise
                return (int)(BASE_COOKING_TIME_MS * BaseCookingTimeMultiplier);
            }
        }
    }
}
