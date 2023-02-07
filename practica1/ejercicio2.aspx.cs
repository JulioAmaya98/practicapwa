using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practica1
{
    public partial class ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            respuesta.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            respuesta.Visible = true;
            if (TextBox1.Text=="Amaya" && TextBox2.Text=="julio")
            {
                respuesta.InnerText = "Ha ingresado los datos correctos";
            }
            else
            {
                respuesta.InnerText = "Ha ingresado los datos incorrectos";

            }
        }
    }
}