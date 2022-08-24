using LinqTest.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqTest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAscList_Click(object sender, EventArgs e)
        {
            string data = "";
            MainController.getDescNumberList().ForEach((number) =>
            {
                data += number + ",";
            });
            MessageBox.Show(data, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCousinNumbers_Click(object sender, EventArgs e)
        {
            string data = "";
            MainController.getCousinsNumbersAsc(MainController.getDescNumberList()).ForEach((number) =>
            {
                data += number + ",";
            });
            MessageBox.Show(data, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MainController.sumList(MainController.getDescNumberList()).ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAscListB_Click(object sender, EventArgs e)
        {
            string data = "";
            MainController.getAscNumberList().ForEach((number) =>
            {
                data += number + ",";
            });
            MessageBox.Show(data, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {   
            if(!string.IsNullOrEmpty(txtNumberN.Text))
            {
                string data = "";
                MainController.getNumberUpThan(Int32.Parse(txtNumberN.Text), MainController.getDescNumberList()).ForEach((number) =>
                {
                    data += number + ",";
                });
                MessageBox.Show(data, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCoupleNumbers_Click(object sender, EventArgs e)
        {
            string data = "";
            MainController.getCoupleNumbers(MainController.getDescNumberList()).ForEach((number) =>
            {
                data += number + ",";
            });
            MessageBox.Show(data, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNoCoupleNumbers_Click(object sender, EventArgs e)
        {
            string data = "";
            MainController.getNoCoupleNumbers(MainController.getDescNumberList()).ForEach((number) =>
            {
                data += number + ",";
            });
            MessageBox.Show(data, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRepNum_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRepNumber.Text))
            {
                string data = "";
                MainController.getInfoFromListOfRepetition(MainController.getDescNumberList(), Int32.Parse(txtRepNumber.Text)).ForEach((number) =>
                {
                    data += number.number.ToString() + " y " + number.timesOf.ToString() + ",";
                });
                MessageBox.Show(data, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCalRepNum_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRepNumC.Text))
            {
                MessageBox.Show(MainController.getRepeatItValue(Int32.Parse(txtRepNumC.Text), MainController.getDescNumberList()).ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRepNumC.Text))
            {
                MessageBox.Show(MainController.sumListOfRepetition(MainController.getInfoFromListOfRepetition(MainController.getDescNumberList(), Int32.Parse(txtRepNumC.Text))).ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNumberN.Text = null;
            txtRepNumber.Text = null;
            txtRepNumC.Text = null;
        }
    }
}
