using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCsharp.pizzeria.pizza {
    internal class Roman : Pizza {
        public Roman(string name, string dough, string tomatoe, string hips, string mozarella) : base(dough, name) {
            this.Toppings.Add(tomatoe);
            this.Toppings.Add(hips);
            this.Toppings.Add(mozarella);
        }
    }
}
