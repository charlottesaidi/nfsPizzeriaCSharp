using PizzeriaCsharp.pizzeria.pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCsharp.pizzeria {
    internal class Pizzeria: IPizzeria {
        private List<PizzaFactory> pizzaFactories = new List<PizzaFactory>();

        public Pizza makePizza(string pizzaName)
        {
            foreach(PizzaFactory factory in this.pizzaFactories)
            {
                if(factory.isPizzaMade(pizzaName))
                {
                    return factory.make();
                }
            }

            throw new Exception("Y a pas cette pizza");
        }

        public void registerPizzaFactory(PizzaFactory pizzaFactory)
        {
            this.pizzaFactories.Add(pizzaFactory);
        }

        public List<string> getAllPizzaNames()
        {
            List<string> names = new List<string>();

            foreach(PizzaFactory factory in this.pizzaFactories)
            {
                names.Add(factory.PizzaMadeName);
            }

            return names;
        }
    }
}
