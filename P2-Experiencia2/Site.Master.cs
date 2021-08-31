using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConversorDeTemperturas1
{
    public partial class SiteMaster : MasterPage
    {
        protected void Convertir_ServerClick(Object sender, EventArgs e, object valor, object Resultado, object Temperaturas)
        {
            decimal Fahrenheit = decimal.Parse(valor.Value);
            decimal conversion = 0;
            ListItem elemento = Temperaturas.Items[Temperaturas.SelectedIndex];
            if (elemento.Value == "1")
            {
                conversion = (Fahrenheit - 32) / (decimal)1.8;
                Resultado.InnerText = Fahrenheit.ToString() + " Fahrenheit = ";
                Resultado.InnerText += conversion.ToString() + " Centigrados";
            }
            if (elemento.Value == "2")
            {
                Resultado.InnerText = Fahrenheit.ToString() + " Fahrenheit = ";
                Resultado.InnerText += Fahrenheit.ToString() + " Fahrenheit";
            }
            if (elemento.Value == "3")
            {
                conversion = ((Fahrenheit - 32) / (decimal)1.8) + (decimal)273.15;
                Resultado.InnerText = Fahrenheit.ToString() + " Fahrenheit = ";
                Resultado.InnerText += conversion.ToString() + " " + elemento.Text;
            }
        }

            protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                object Temperaturas = null;
                Temperaturas.Items.Add("Centigrados");
                Temperaturas.Items.Add("Fahrenheit");
                Temperaturas.Items.Add("Kelvin");
            }
        }

    }
}