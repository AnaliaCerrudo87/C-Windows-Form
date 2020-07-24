using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distancia_entre_2_Puntos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double AA, AB, BA, BO, distancia;

            AA = Convert.ToDouble(puntoAA.Text);
            AB = Convert.ToDouble(puntoBA.Text);
            BA = Convert.ToDouble(puntoAO.Text);
            BO = Convert.ToDouble(puntoBO.Text);
            distancia=Math.Round(Math.Sqrt(Math.Pow((AB-AA),2)+Math.Pow((BO-BA),2)),2);

            distanciaAB.Text =Convert.ToString(distancia);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar borrar = new Limpiar();
            borrar.BorrarCampos(this);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
