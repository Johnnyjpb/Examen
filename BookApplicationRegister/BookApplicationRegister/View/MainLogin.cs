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
    public partial class MainLogin : Form
    {
        private bool _canSend = false;
        public MainLogin()
        {
            InitializeComponent();
        }

        #region Those methods will be onClick events
        private void btnToRegister_Click(object sender, EventArgs e)
        {
            MainController.changeToRegister(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Text) && _canSend != false)
            {
                lbDanger.Text = MainController.toLogInUser(txtEmail.Text, txtPassword.Text, this);
                txtEmail.toDanger(emailError, emailCorrect);
                txtPassword.toDanger(passwordError, passwordCorrect);
            }
        }

        #endregion

        #region Those methods will be onLeave
        private void txtEmail_Leave(object sender, EventArgs e) => _canSend = txtEmail.toValidateEmail(emailError, emailCorrect);
        private void txtPassword_Leave(object sender, EventArgs e) => _canSend = txtPassword.toValidateInputLength(passwordError, passwordCorrect, "contraseña");

        #endregion

    }
}
