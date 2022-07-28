using ExamenPractico.Controllers;
using ExamenPractico.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPractico.Views
{
    public partial class Contactos : Form
    {
        protected int idContacto = 0;
        public Contactos()
        {
            InitializeComponent();
        }
        public Contactos(int IdContacto)
        {
            InitializeComponent();
            idContacto = IdContacto;
        }

        private async void Contactos_Load(object sender, EventArgs e)
        {
            btnEliminar.Click += null;
            btnGuardar.Click += null;
            btnEliminar.Click += new EventHandler(EliminarContacto);
            btnGuardar.Click += new EventHandler(GuardarContacto);
            var usuario = await ContactoController.Instance.ObteneContacto(idContacto);
            textBox1.Text = usuario != null ? usuario.Nombre : string.Empty;
            textBox2.Text = usuario != null ? usuario.Telefono : string.Empty;
        }
        private async void EliminarContacto(object sender, EventArgs e)
        {
            await ContactoController.Instance.EliminarContacto(idContacto);
            Close();
        }
        private async void GuardarContacto(object sender, EventArgs e)
        {
            await ContactoController.Instance.GuardarContacto(new Contacto
            {
                IdConctacto = idContacto,
                Nombre = textBox1.Text.ToUpper(),
                Telefono = textBox2.Text.ToUpper()
            });
            Contactos_Load(sender, e);
        }
    }
}
