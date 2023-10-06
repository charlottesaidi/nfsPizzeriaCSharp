using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCsharp.pizzeria.pizza {
    internal class FourCheeses : Pizza {
        public FourCheeses(string name, string dough, string cheese1, string cheese2, string cheese3, string cheese4) : base(dough, name) {
            this.Toppings.Add(cheese1);
            this.Toppings.Add(cheese2);
            this.Toppings.Add(cheese3);
            this.Toppings.Add(cheese4);
        }
    }
}
