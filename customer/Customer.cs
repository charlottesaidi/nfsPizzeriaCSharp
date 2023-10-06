using PizzeriaCsharp.pizzeria;
using PizzeriaCsharp.pizzeria.pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCsharp.customer {
    internal class Customer {

        public void live() {
            IPizzeria pizzeria = ProxyPizzeria.getInstance();
            foreach(string pizzaName in pizzeria.getAllPizzaNames())
            {
                this.eat(pizzeria.makePizza(pizzaName));
            }
            this.eat(pizzeria.makePizza("Michel"));
        }

        public void eat(Pizza pizza) {
            Console.WriteLine("Je mange une pizza " + pizza.getName()); 
        }
    }
}
