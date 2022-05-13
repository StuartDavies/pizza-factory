using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class PizzaBase
    {
        private int BASE_COOKING_TIME_MS = 3000;

        public string? Name { get; }

        public decimal BaseCookingTimeMultiplier { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="multiplier"></param>
        public PizzaBase(string name, decimal multiplier)
		{
            Name = name;
            BaseCookingTimeMultiplier = multiplier;
		}

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
