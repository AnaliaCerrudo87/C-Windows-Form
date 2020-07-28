using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace EmpleadosApp
{
    public partial class AgregarEmpleado : Form
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                             Empleados nuevo = new Empleados();
                             Empleadoconexion conexion = new Empleadoconexion();
                             nuevo.Nombrecompleto = textNombre.Text;
                             nuevo.Dni = textDni.Text;
                             nuevo.Edad = Int32.Parse(textEdad.Text);
                             nuevo.Casado = checkCasado.Checked;
                             nuevo.Salario = decimal.Parse(textSalario.Text);

                            conexion.agregarEmpleado(nuevo);
                            MessageBox.Show("El Empleado fue agregado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void checkCasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
