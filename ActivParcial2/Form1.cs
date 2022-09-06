using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivParcial2
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

        private void button1_Click(object sender, EventArgs e)
        {
            BorrarError();
            if(ValidarCampos())
            {
                MessageBox.Show("datos ok");
            }

            //Persona persona = new Persona();
            //persona.dni = int.Parse(Console.ReadLine());
            //persona.nombre = Console.ReadLine();
            //persona.fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
        }

        private bool ValidarCampos()
        {
            bool validarOk = true;
            if(TextNombre.Text=="")
            {
                validarOk = false;
                errorProvider1.SetError(TextNombre, "Ingresar Nombre");
            }
            if (TextDni.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(TextDni, "Ingresar Dni");
            }
            if (TextFecha.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(TextFecha, "Ingresar Fecha");
            }
            DateTime fecha;
            if (!DateTime.TryParse(TextFecha.Text, out fecha))
            {
                validarOk = false;
                errorProvider1.SetError(TextFecha, "Ingrese formato fecha DD-MM-AA");
            }
            int num;
            if (!int.TryParse(TextDni.Text, out num))
            {
                validarOk = false;
                errorProvider1.SetError(TextDni, "Ingrese el valor pero en numeros");
            }
            return validarOk;
        }

        private void BorrarError()
        {
            errorProvider1.SetError(TextNombre, "");
            errorProvider1.SetError(TextDni, ""); 
            errorProvider1.SetError(TextFecha, "");
        }

        private void TextDni_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if(!int.TryParse(TextDni.Text, out num))
            {
                errorProvider1.SetError(TextDni, "Ingrese el valor pero en numeros");
            }
            else
            {
                errorProvider1.SetError(TextDni, "");
            }
        }

        private void TextFecha_Validating(object sender, CancelEventArgs e)
        {
            DateTime fecha ;
            if (!DateTime.TryParse(TextFecha.Text, out fecha))
            {
                errorProvider1.SetError(TextFecha, "Ingrese formato fecha DD-MM-AA");
            }
            else
            {
                errorProvider1.SetError(TextFecha, "");
            }
        }
    }
}
