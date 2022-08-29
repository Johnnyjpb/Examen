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

namespace BookApplicationRegister
{
    public partial class Main : Form
    {
        private bool _canSend = false;
        public Main()
        {
            InitializeComponent();
        }

        #region Those are the events onClick
        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtPassword.Text) && _canSend != false)
            {
                lbWarning.Text = MainController.saveUser(txtUser.Text, txtEmail.Text, txtPassword.Text);
                txtEmail.toDeleteValidation(emailError, correctEmail);
                txtUser.toDeleteValidation(errorUser, correctUsername);
                txtPassword.toDeleteValidation(errorPassword, correctPassword);
            }
        }

        private void redictToLogin_Click(object sender, EventArgs e)
        {
            MainController.changeToLogin(this);
        }

        #endregion

        #region Those are the events onLeaveInput
        private void txtEmail_Leave(object sender, EventArgs e) => _canSend = txtEmail.toValidateEmail(emailError, correctEmail);
        private void txtUser_Leave(object sender, EventArgs e) => _canSend = txtUser.toValidateInputLength(errorUser, correctUsername, "Usuario");
        private void txtPassword_Leave(object sender, EventArgs e) => _canSend = txtPassword.toValidateInputLength(errorPassword, correctPassword, "Contraseña");

        #endregion

    }
}
