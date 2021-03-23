using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyPizza
    {
        private Pizza _Pizza;
        public ProxyPizza(Pizza pizza)
        {
            this._Pizza = pizza;

        }


    }
}
