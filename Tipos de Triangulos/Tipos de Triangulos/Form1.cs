using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipos_de_Triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image triangulo;
            int ladoa, ladob, ladoc;

            ladoa = Convert.ToInt32(lado1.Text);
            ladob = Convert.ToInt32(lado2.Text);
            ladoc = Convert.ToInt32(lado3.Text);

            if ((ladoa != ladob) && (ladob != ladoc) && (ladoc != ladoa))
            {
                triangulo = Image.FromFile("escaleno.png");
            }
            else if ((ladoa == ladob) && (ladob == ladoc))
            {
                triangulo = Image.FromFile("equilatero.png");
            }
            else
            {
                triangulo = Image.FromFile("isosceles.png");
            }
                

             imagen.Image = triangulo;   
        }

        private void label2_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image triangulo=Image.FromFile("triangulos.jpg");
            imagen.Image = triangulo;

            Limpiar borrar = new Limpiar();

            borrar.BorrarCampos(this);


        }
    }
}
