using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_libros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto;
            string opcion;
            int paginas;
            



            if (checkBox1.Checked )
                opcion = "Importado";
            else
                opcion = "Nacional";

            

            try
            
            { 
            paginas = int.Parse(textPaginas.Text);
            texto = String.Concat(textNombre.Text, "-", textAutor.Text, "-", comboGenero.SelectedItem.ToString(), "-", textPaginas.Text, "-", opcion, "-", textPrecio.Text);

                ListaLibros.Items.Add(texto);

                textNombre.Clear();
                textAutor.Clear();
                textPaginas.Clear();
                checkBox1.Checked = false;
                comboGenero.ResetText();
                textPrecio.Clear();
            }

            catch (Exception ex)
            {

                MessageBox.Show("El valor de Páginas no es un valor númerico válido","Error");
                MessageBox.Show(ex.Message, "Ingresar un valor entero");
            }




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
