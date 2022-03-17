using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryOO
{
    public class Pizza
    {
        private static string[] _pizzaToppings = new string[] { "Ham and Mushroom", "Pepperoni", "Vegetable" };

        public PizzaBase Base { get; }
        public string Topping { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pizzaBase"></param>
        /// <param name="pizzaTopping"></param>
        public Pizza(PizzaBase pizzaBase, string pizzaTopping)
        {
            Base = pizzaBase;
            Topping = pizzaTopping;
        }

        /// <summary>
        /// 
        /// </summary>
        public int CookingTimeMs 
        { 
            get
            {
                return (int)(Base.CookingTimeMs + (Topping.Length * 100));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Pizza GenerateRandomPizza()
        {
            Random rnd = new Random();
            int randomBaseIndex = rnd.Next(0, 2);

            PizzaBase randomBase;

            switch (randomBaseIndex)
            {
                case 0:
                    randomBase = new ThinAndCrispyPizzaBase();
                    break;

                case 1:
                    randomBase = new StuffedCrustPizzaBase();
                    break;

                case 2:
                    randomBase = new DeepPanPizzaBase();
                    break;

                default:
                    randomBase = new ThinAndCrispyPizzaBase();
                    break;
            }

            int randomToppingIndex = rnd.Next(0, _pizzaToppings.Count() - 1);
            string randomTopping = _pizzaToppings[randomToppingIndex];

            return new Pizza(randomBase, randomTopping);
        }

        public void Cook()
        {
            System.Threading.Thread.Sleep(CookingTimeMs);
        }

        public override string ToString()
        {
            return $"{Base} with {Topping}";
        }
    }
}
