using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCsharp.pizzeria.pizza
{
    abstract class PizzaFactory
    {
        public string PizzaMadeName { get; } 

        public PizzaFactory(string pizzaMadeName) {
            this.PizzaMadeName = pizzaMadeName; 
        }

        public abstract Pizza make();

        public bool isPizzaMade(string pizzaMadeName)
        {
            return this.PizzaMadeName.Equals(pizzaMadeName);
        } 
    }
}
