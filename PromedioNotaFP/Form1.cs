using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioNotaFP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            Alumno A = new Alumno();
            A.Pnota1 = Convert.ToInt32(txtNota1.Text);
            A.Pnota2 = Convert.ToInt32(txtNota2.Text);
            A.Pnota3 = Convert.ToInt32(txtNota3.Text);
            double promedio = A.Promedio();
            lblPromedio.Text = Convert.ToString(promedio);


            if (promedio >= 7)
            {
                lblCondicion.Text = "Promocionado";
            }
            else if ((promedio < 7) && (promedio >= 4))
            {
                lblCondicion.Text = "Regular";
            }
            else
            {
                lblCondicion.Text = "Desaprobado";
            }


        }
        private void lblCondicion_Click(object sender, EventArgs e)
        {

        }
    }

}
