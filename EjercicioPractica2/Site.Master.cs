using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPractica2
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                Productos.Items.Add(new ListItem("Microondas", "1"));
                Productos.Items.Add(new ListItem("Refrigerador", "2"));
                Productos.Items.Add(new ListItem("Batidora", "3"));
                Productos.Items.Add(new ListItem("Licuadora", "4"));
                Productos.Items.Add(new ListItem("Lavadora", "5"));
            }
            Grafico.Visible = false;
        }
        protected void Convertir_ServerClick(Object sender, EventArgs e)
        {
            ListItem elemento = Productos.Items[Productos.SelectedIndex];
            if (elemento.Value == "1")
            {
                Resultado.InnerText = " Usted está eligiendo:  ";
                Resultado.InnerText += elemento.Text;
                Resultado.InnerText += " Código: 194875647 ";
                Resultado.InnerText += " Descripción: Es un electrodoméstico destinado a cocinar o calentar alimentos, funciona mediante la generación de ondas de radio de alta frecuencia. ";
                Resultado.InnerText += " Marca: Samsung ";
                Resultado.InnerText += " Precio: 239.00 ";
            }
            if (elemento.Value == "2")
            {
                Resultado.InnerText = " Usted está eligiendo:  ";
                Resultado.InnerText += elemento.Text;
                Resultado.InnerText += " Código: 245638548 ";
                Resultado.InnerText += " Descripción: Nos permite conservar alimentos o también enfriar bebidas para hacer su consumo más agradable. ";
                Resultado.InnerText += " Marca: LG ";
                Resultado.InnerText += " Precio: 1749.00 ";
            }
            if (elemento.Value == "3")
            {
                Resultado.InnerText = " Usted está eligiendo:  ";
                Resultado.InnerText += elemento.Text;
                Resultado.InnerText += " Código: 159874685 ";
                Resultado.InnerText += " Descripción: Utensilio de preparación provisto de accesorios giratorios que sirven para batir, mezclar o emulsionar ";
                Resultado.InnerText += " Marca: Oster ";
                Resultado.InnerText += " Precio: 219.00 ";
            }
            if (elemento.Value == "4")
            {
                Resultado.InnerText = " Usted está eligiendo:  ";
                Resultado.InnerText += elemento.Text;
                Resultado.InnerText += " Código: 238954129 ";
                Resultado.InnerText += " Descripción: Electrodoméstico con un motor eléctrico que hace girar unas cuchillas que trituran los alimentos ";
                Resultado.InnerText += " Marca: Oster ";
                Resultado.InnerText += " Precio: 199.00 ";
            }
            if (elemento.Value == "5")
            {
                Resultado.InnerText = " Usted está eligiendo:  ";
                Resultado.InnerText += elemento.Text;
                Resultado.InnerText += " Código: 256987459 ";
                Resultado.InnerText += " Descripción: Electrodoméstico que sirve para lavar ropa ahorrándonos tiempo, esfuerzo y agua ";
                Resultado.InnerText += " Marca: LG ";
                Resultado.InnerText += " Precio: 1049.00 ";
            }
        }
        protected void MostrarGrafico_ServerClick(Object sender, EventArgs e)
        {
            Grafico.Src = "imagen" + Productos.SelectedIndex.ToString() + ".jpg";
            Grafico.Alt = "Grafico Electrodomestico";
            Grafico.Visible = true;
        }
    }
}