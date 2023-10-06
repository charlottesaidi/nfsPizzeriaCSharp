using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCsharp.pizzeria.pizza {
    internal class Calzone : Pizza {
        public Calzone(string name, string dough, string tomatoe, string ham, string mozarella, string egg) : base(dough, name) {
            this.Toppings.Add(tomatoe);
            this.Toppings.Add(ham);
            this.Toppings.Add(mozarella);
            this.Toppings.Add(egg);
        }
    }
}
