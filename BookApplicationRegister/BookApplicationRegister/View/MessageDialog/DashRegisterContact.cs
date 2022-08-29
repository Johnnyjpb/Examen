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
    public partial class DashRegisterContact : Form
    {
        private bool _canSend = false;
        public DashRegisterContact()
        {
            InitializeComponent();
            cbGetUser.DataSource = DashboardController.askToBringAllUsers().toGetUsersNickname();

        }

        #region These methods are onClick events
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTelephone.Text))
            {
                lbWarning.Text = DashboardController.toRegisterContact(txtTelephone.Text, cbGetUser.Text);
                txtTelephone.Text = null;
                cbGetUser.Text = null;
            }
        }

        #endregion

        #region These methods are onLeave events
        private void cbGetUser_Leave(object sender, EventArgs e) => _canSend = cbGetUser.toValidateInputLength(userError, userCorrect, "Usuario");
        private void txtTelephone_Leave(object sender, EventArgs e) => _canSend = txtTelephone.toValidateInputLength(telephoneError, telephoneCorrect, "Telefono");

        #endregion
    }
}
