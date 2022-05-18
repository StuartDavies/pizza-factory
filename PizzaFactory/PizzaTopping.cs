using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class PizzaTopping
    {
        public string Name { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public PizzaTopping(string name)
		{
            Name = name;
		}

        /// <summary>
        /// 
        /// </summary>
        public int CookingTimeMs 
        { 
            get
            {
                return (int)(Name.Length * 100);
            }
        }
    }
}
