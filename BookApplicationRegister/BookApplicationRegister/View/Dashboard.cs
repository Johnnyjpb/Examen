using BookApplicationRegister.Controller;
using BookApplicationRegister.Resources.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApplicationRegister.View
{
    public partial class Dashboard : Form
    {
        public Dashboard(string nickname)
        {
            InitializeComponent();
            lbWelcome.Text += nickname;
            dgContacts.writeDataGridHeaders(new List<string>() { "Id", "Nombre", "Email", "Telefono" });
            dgContacts.writeDataGridRows(DashboardController.askToBringContacts());
        }

        #region These methods are onClick events
        private void btnRegisterContact_Click(object sender, EventArgs e)
        {
            DashboardController.toShowRegisterDialog();
        }

        private void btnSearchContact_Click(object sender, EventArgs e)
        {
            DashboardController.toShowSearchDialog();
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dgContacts.CurrentRow.Cells[0].Value.ToString())) DashboardController.toShowDeleteDialog(dgContacts.CurrentRow.Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgContacts.writeDataGridRows(DashboardController.askToBringContacts());
        }

        #endregion

    }
}
