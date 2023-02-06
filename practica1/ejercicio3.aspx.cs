using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practica1
{
    public partial class ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CalculateButton_Click(object sender, EventArgs e)
        {
            double primerNumero =Convert.ToDouble( txtNumber1.Text);
            double segundoNumero = Convert.ToDouble(txtNumber2.Text);
            double total = 0;
            if (rbSuma.Checked)
            {
                total = primerNumero + segundoNumero;
            }else if (rbResta.Checked)
            {
                total=primerNumero - segundoNumero; 
            }else if (rbMultiplicacion.Checked)
            {
                total = primerNumero * segundoNumero;
            }else if (rbDivision.Checked)
            {
                total = primerNumero / segundoNumero;
            }
            resultLabel.Text = total.ToString();
        }
    }
}