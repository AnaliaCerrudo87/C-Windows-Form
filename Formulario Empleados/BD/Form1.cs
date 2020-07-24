using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Empleadoconexion conexion = new Empleadoconexion();
            dgvEmpleados.DataSource = conexion.ListarEmpleados();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleados nuevo = new Empleados();
            Empleadoconexion conexion = new Empleadoconexion();
            nuevo.Nombrecompleto = textNombre.Text;
            nuevo.Dni = textDni.Text;
            nuevo.Edad = int.Parse(textEdad.Text);
            nuevo.Casado = checkBoxcasado.Checked;
            nuevo.Salario = decimal.Parse(textSalario.Text);

            conexion.agregarAlbum(nuevo);
            Dispose();
        }
    }
}
