using BookApplicationRegister.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApplicationRegister.View.MessageDialog
{
    public partial class DashSureDeleteContact : Form
    {
        private int _IdContact;
        public DashSureDeleteContact(string dataIdContact)
        {
            InitializeComponent();
            List<string[]> contactToDelete = DashboardController.getContactById(Int32.Parse(dataIdContact));
            lbContact.Text = contactToDelete[0].GetValue(1).ToString();
            _IdContact = Int32.Parse(contactToDelete[0].GetValue(0).ToString());
        }

        #region These methods are onClick events
        private void btnAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DashboardController.toDeleteContact(_IdContact), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
