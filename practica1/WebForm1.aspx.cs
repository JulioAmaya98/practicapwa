using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practica1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            respuesta.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            respuesta.Visible = true;
            if (txtNombreProducto.Text=="" || txtCantidad.Text=="" || txtPrecio.Text=="")
            {
                respuesta.InnerHtml = "<div class='text-bg-danger p-3'>No deje vacias las cajas de texto</div>";
            }
            else
            {
                respuesta.InnerHtml = "<div class='text-bg-success p-3'> <p>El nombre del producto es: " + txtNombreProducto.Text +"</p><p>El precio del producto es: "+txtPrecio.Text+"</p>  </div>";
            }
        }
    }
}