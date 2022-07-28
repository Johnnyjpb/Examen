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
    public partial class ListaContactos : Form
    {
        protected int idContacto = 0;
        private List<Contacto> Contactos = new List<Contacto>();
        public ListaContactos()
        {
            InitializeComponent();
        }
        private void ListaContactos_Load(object sender, EventArgs e)
        {
            btnNuevoContacto.Click += new EventHandler(MostrarFormularioContacto);
            Contactos = ContactoController.Instance.ObtenerContactos().ToList();
            dataGridView1.DataSource = Contactos;
        }
        private void MostrarFormularioContacto(object sender, EventArgs e)
        {
            try
            {
                Hide();
                var fmContactos = new Contactos(idContacto);
                fmContactos.Text = $"Editar Contacto - Num. {idContacto}";
                fmContactos.ShowDialog(this);
                ListaContactos_Load(sender, e);
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al mostrar formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idContacto = Contactos[e.RowIndex].IdConctacto;
            MostrarFormularioContacto(sender, e);
        }
        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBuscador.Text))
                {
                    throw new Exception("Sin patron a buscar");
                }
                Contactos = ContactoController.Instance.ObtenerContactos().ToList();
                Contactos = Contactos
                    .Where(x => x.Nombre.ToUpper().Contains(txtBuscador.Text.ToUpper()) || x.Telefono.Contains(txtBuscador.Text))
                    .GroupBy(x => x.IdConctacto)
                    .Select(x => x.FirstOrDefault())
                    .ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Contactos;
            }
            catch (Exception ex)
            {
                ListaContactos_Load(sender, e);
            }
        }
    }
}
