using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCsharp.pizzeria.pizza
{
    internal class CalzoneFactory : PizzaFactory
    {
        public CalzoneFactory() : base("Calzone")
        {
        }

        public override Pizza make()
        {
            return new Calzone("Calzone", "pâte", "tomates", "jambon", "mozarella", "egg");
        }
    }
}
