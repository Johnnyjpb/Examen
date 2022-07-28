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
    public partial class RegistrarUsuario : Form
    {
        protected UsuarioController usuario;
        public RegistrarUsuario()
        {
            InitializeComponent();
            usuario = UsuarioController.Instance;
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {
            btnRegistrar.Click += new EventHandler(RegistrarNuevoUsuario);
        }

        private async void RegistrarNuevoUsuario(object sender, EventArgs e)
        {
            try
            {
                if (!txtNickname.Text.ValidarTexto() || !txtCorreo.Text.ValidarEmail() || !txtPassword.Text.ValidarContrasena() || !txtRepPassword.Text.ValidarContrasena())
                    throw new Exception("Validar informacion ingresada");
                if (!txtPassword.Text.Contains(txtRepPassword.Text))
                    throw new Exception("Contraseñas no son Iguales");
                Usuario user = new Usuario
                {
                    Correo = txtCorreo.Text.ToUpper(),
                    Nickname = txtNickname.Text.ToUpper(),
                    Contrasena = txtPassword.Text.ToUpper().CifrarAES256()
                };
                bool registrado = await usuario.RegistrarUsuario(user);
                if (!registrado) throw new Exception("No se Guardo el Usuario");
                MessageBox.Show("Se Registro Usuario", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al verificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
