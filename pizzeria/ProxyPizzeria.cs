using PizzeriaCsharp.pizzeria.pizza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCsharp.pizzeria
{
    class ProxyPizzeria: IPizzeria
    {
        private static IPizzeria instance;
        private Pizzeria pizzeria;

        private ProxyPizzeria()
        {
            this.pizzeria = new Pizzeria();
        }

        public static IPizzeria getInstance() { 
            if(instance == null)
            {
                instance = new ProxyPizzeria();
                instance.registerPizzaFactory(new CalzoneFactory());
            }
            return instance;
        }

        public List<string> getAllPizzaNames()
        {
            return this.pizzeria.getAllPizzaNames();    
        }

        public Pizza makePizza(string pizzaName)
        {
            if (this.pizzeria.getAllPizzaNames().Contains(pizzaName))
            {
                return this.pizzeria.makePizza(pizzaName);
            } else
            {
                return this.pizzeria.makePizza(this.pizzeria.getAllPizzaNames()[0]);
            }
        }

        public void registerPizzaFactory(PizzaFactory pizzaFactory)
        {
            this.pizzeria.registerPizzaFactory(pizzaFactory);
        }
    }
}
