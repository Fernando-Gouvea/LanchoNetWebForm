using Data;
using Model;
using Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LanchoNet
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            refresh();
         
        }

        private List<Pizza> GetPizza()
        {
            IProxyPizzaDB proxy = new Proxy.ProxyPizzaDB(new PizzaDB());
            return proxy.Select();
        }

        protected void BtnDescricao_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza
            {
               // Id = int.Parse(TextId.Text),
                Descricao = TextDescricao.Text,
                Valor = double.Parse(TextValor.Text)
            };

            new PizzaDB().Insert(pizza);
            refresh();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void refresh()
        {
            GVPizza.DataSource = GetPizza();
            List<Pizza> pizzas = GetPizza();
            double total = (pizzas.Sum(x => x.Valor));
            TextTotal.Text = total.ToString();
            GVPizza.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Pizza pizza = new Pizza
            {
                Id = int.Parse(TextId.Text),
              
            };

            new PizzaDB().Delete(pizza);
            refresh();

        }
    }
}