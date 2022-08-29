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
    public partial class DashSearchContact : Form
    {
        public DashSearchContact()
        {
            InitializeComponent();
            dgContactSearch.writeDataGridHeaders(new List<string>() { "Id", "Nombre", "Email", "Telefono" });
        }

        #region These methods are onClick events
        private void btnIdUserSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdContactSearch.Text))
            {
                dgContactSearch.writeDataGridRows(DashboardController.getContactById(Int32.Parse(txtIdContactSearch.Text)));
                txtIdContactSearch.Text = null;
            }
        }

        private void btnEmailSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmailSearch.Text))
            {
                dgContactSearch.writeDataGridRows(DashboardController.getContactByEmail(txtEmailSearch.Text));
                txtEmailSearch.Text = null;
            }
        }

        private void btnTelephoneSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTelephoneSearch.Text))
            {
                dgContactSearch.writeDataGridRows(DashboardController.getContactByTelephone(txtTelephoneSearch.Text));
                txtTelephoneSearch.Text = null;
            }
        }

        private void btnNicknameSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNicknameSearch.Text))
            {
                dgContactSearch.writeDataGridRows(DashboardController.getContactByNickname(txtNicknameSearch.Text));
                txtNicknameSearch.Text = null;
            }
        }

        #endregion

    }
}
