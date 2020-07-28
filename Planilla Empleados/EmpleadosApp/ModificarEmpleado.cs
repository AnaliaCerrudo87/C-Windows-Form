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
    public partial class ModificarEmpleado : Form
    {
        public ModificarEmpleado()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow dgv = dgvModificar.Rows[e.RowIndex];

            textNombre.Text = dgv.Cells[1].Value.ToString();
            textDni.Text = dgv.Cells[2].Value.ToString();
            textEdad.Text = dgv.Cells[3].Value.ToString();
            checkCasado.Checked = (bool)dgv.Cells[4].Value;
            textSalario.Text = dgv.Cells[5].Value.ToString();
            
        }

        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {
            Empleadoconexion conexion = new Empleadoconexion();
            DataGridViewColumn Columna;
            dgvModificar.DataSource = (conexion.ListarEmpleados());
            Columna = dgvModificar.Columns[0];
            Columna.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkCasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkCasado_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBox b;
            b = checkCasado;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textNombre.Text != "")
            {
                if (textDni.Text != "")
                {
                    if (textEdad.Text != "")
                    {
                        if (textSalario.Text != "")
                        {

                            try
                            {
                                Empleados actualizarEmpleado = new Empleados();
                                Empleadoconexion conexion = new Empleadoconexion();
                                actualizarEmpleado.Nombrecompleto = textNombre.Text;
                                actualizarEmpleado.Dni = textDni.Text;
                                actualizarEmpleado.Edad = Int32.Parse(textEdad.Text);
                                actualizarEmpleado.Casado = checkCasado.Checked;
                                actualizarEmpleado.Salario = decimal.Parse(textSalario.Text);

                                conexion.modificarEmpleado(actualizarEmpleado, actualizarEmpleado.Dni);
                                MessageBox.Show("El Empleado fue Modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Dispose();
                            }
                            catch
                            {
                                MessageBox.Show("El valor de Edad o Salario no es un valor númerico válido", "Error valor invalido");
                            }

                        }
                        else MessageBox.Show("Ingrese Salario", "Error campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else MessageBox.Show("Ingrese Edad", "Error campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else MessageBox.Show("Ingrese Dni", "Error campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else MessageBox.Show("Ingrese Nombre y Apellido", "Error campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void textDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
