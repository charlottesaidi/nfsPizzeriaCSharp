using PizzeriaCsharp.pizzeria.pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCsharp.pizzeria
{
    interface IPizzeria
    {
        Pizza makePizza(string pizzaName);

        void registerPizzaFactory(PizzaFactory pizzaFactory);

        List<string> getAllPizzaNames();
    }
}
