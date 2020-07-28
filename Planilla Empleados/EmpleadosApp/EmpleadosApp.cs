using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace EmpleadosApp

{
    public partial class EmpleadosApp : Form
    {
        public EmpleadosApp()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Empleadoconexion conexion = new Empleadoconexion();
            DataGridViewColumn Columna;
            dgvEmpleados.DataSource = (conexion.ListarEmpleados());
            Columna = dgvEmpleados.Columns[0];
            Columna.Visible = false;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarEmpleado alta = new AgregarEmpleado();
            alta.ShowDialog();
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            try
            {
                Empleadoconexion conexion = new Empleadoconexion();
                dgvEmpleados.DataSource = conexion.ListarEmpleados();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarEmpleado alta = new ModificarEmpleado();
            alta.ShowDialog();
            cargarGrilla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarEmpleado alta = new EliminarEmpleado();
            alta.ShowDialog();
            cargarGrilla();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
