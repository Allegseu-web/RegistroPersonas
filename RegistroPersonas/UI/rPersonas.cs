using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RegistroPersonas.Entidades;
using RegistroPersonas.BLL;

namespace RegistroPersonas.UI
{
    public partial class rPersonas : Form
    {
        private Personas Persona = new Personas();
        public rPersonas()
        {
            InitializeComponent();
        }

        private void LlenaCampos(Personas Persona)
        {
            PersonaIdTextBox.Text = Convert.ToString(Persona.PersonaID);
            NombreTextBox.Text = Persona.Nombre;
        }

        private Personas LlenarClases()
        {
            Persona = new Personas();
            Persona.PersonaID = Convert.ToInt32(PersonaIdTextBox.Text);
            Persona.Nombre = NombreTextBox.Text;
            return Persona;
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            var Contacto = PersonasBLL.Buscar(Convert.ToInt32(PersonaIdTextBox.Text));
            if(Contacto != null)
            {
                LlenaCampos(Contacto);
            }
            else
            {
                MessageBox.Show("No existe en la base de datos", "no encontrado");
            }
        }

        private void Limpiar()
        {
            Persona = new Personas();
            LlenaCampos(Persona);
        }

        private bool Validar()
        {
            bool esOkay = true;

            if(NombreTextBox.Text.Length == 0)
            {
                MessageBox.Show("Los campos no pueden estar vacios...");
                esOkay = false;
            }
            return esOkay;
        }

        private void GuardarButtom_Click(object sender, EventArgs e)
        {
            if (!Validar()) { return; }

            var proceso = PersonasBLL.Guardar(Persona);

            if(proceso == true)
            {
                Limpiar();
                MessageBox.Show("Se guardo!");
            }
            else
            {
                MessageBox.Show("Ocurrio un error.");
            }
        }

        private void EliminarButtom_Click(object sender, EventArgs e)
        {
            if (PersonasBLL.Eliminar(Convert.ToInt32(PersonaIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Se elimino Correctamente.");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar!");
            }
        }

        private void AñadirButtom_Click(object sender, EventArgs e)
        {
            var Data = new PersonasDetalle(NombreConctacto.Text, NumeroContactoTextBox.Text);
            Persona.Detalles.Add(Data);
            Limpiar();
            ContactosDataGrid.DataSource = Data;
        }

        private void rPersonas_Load(object sender, EventArgs e)
        {

        }
    }
}
