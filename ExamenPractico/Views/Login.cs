using ExamenPractico.Controllers;
using ExamenPractico.Models;
using ExamenPractico.Utilities;
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
    public partial class Login : Form
    {
        protected UsuarioController usuario;
        public Login()
        {
            InitializeComponent();
            usuario = UsuarioController.Instance;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            llbRegistrar.Click += new EventHandler(MostrarFormularioRegistro);
            btnLogIn.Click += new EventHandler(ValidarUsuario);
        }

        private async void ValidarUsuario(object sender, EventArgs e)
        {
            try
            {
                Hide();
                if (!txtCorreo.Text.ValidarEmail() || !txtContrasena.Text.ValidarContrasena()) throw new Exception("Campos no Validos");
                await usuario.LogIn(new Usuario() { Contrasena = txtContrasena.Text.ToUpper().CifrarAES256(), Correo = txtCorreo.Text.ToUpper() });
                if (Utilidades.IdUsuario > 0)
                {
                    var fmListarContactos = new ListaContactos();
                    fmListarContactos.ShowDialog(this);
                }
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al verificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Show();
            }
        }

        private void MostrarFormularioRegistro(object sender, EventArgs e)
        {
            try
            {
                Hide();
                var fmRegistrarUsuario = new RegistrarUsuario();
                fmRegistrarUsuario.ShowDialog(this);
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al mostrar formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Show();
            }
        }
    }
}
