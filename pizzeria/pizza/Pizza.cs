using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCsharp.pizzeria.pizza {
    internal abstract class Pizza {
        protected string Dough { get; }
        protected List<string> Toppings;
        protected string Name;

        public Pizza(string dough, string name)
        {
            this.Dough = dough;
            this.Toppings = new List<string>();
            this.Name = name;
        }

        public string getName() {
            return this.Name;
        }
    }
}
