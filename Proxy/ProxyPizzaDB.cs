using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyPizzaDB : IProxyPizzaDB
    {
        private PizzaDB _PizzaDB;
        public ProxyPizzaDB(PizzaDB pizza)
        {
            this._PizzaDB = pizza;

        }

        public void Delete(Pizza pizza)
        {
            _PizzaDB.Delete(pizza);
        }

        public void Insert(Pizza pizza)
        {
            _PizzaDB.Insert(pizza);
        }

        public List<Pizza> Select()
        {
            return _PizzaDB.Select();
        }
    }
}
