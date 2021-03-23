using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
   public interface IProxyPizzaDB
    {
        List<Pizza> Select();

        void Delete(Pizza pizza);
        void Insert(Pizza pizza);
    }
}
