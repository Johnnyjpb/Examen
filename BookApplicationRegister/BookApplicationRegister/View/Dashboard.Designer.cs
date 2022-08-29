namespace BookApplicationRegister.View
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgContacts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.btnSearchContact = new System.Windows.Forms.Button();
            this.btnRegisterContact = new System.Windows.Forms.Button();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(382, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgContacts);
            this.panel1.Location = new System.Drawing.Point(357, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 307);
            this.panel1.TabIndex = 1;
            // 
            // dgContacts
            // 
            this.dgContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContacts.Cursor = System.Windows.Forms.Cursors.No;
            this.dgContacts.Location = new System.Drawing.Point(24, 22);
            this.dgContacts.Name = "dgContacts";
            this.dgContacts.ReadOnly = true;
            this.dgContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgContacts.Size = new System.Drawing.Size(447, 261);
            this.dgContacts.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnDeleteContact);
            this.panel2.Controls.Add(this.btnSearchContact);
            this.panel2.Controls.Add(this.btnRegisterContact);
            this.panel2.Controls.Add(this.lbWelcome);
            this.panel2.Location = new System.Drawing.Point(28, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 386);
            this.panel2.TabIndex = 2;
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteContact.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteContact.Location = new System.Drawing.Point(191, 78);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(75, 44);
            this.btnDeleteContact.TabIndex = 3;
            this.btnDeleteContact.Text = "Eliminar Contacto";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // btnSearchContact
            // 
            this.btnSearchContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchContact.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchContact.Location = new System.Drawing.Point(99, 78);
            this.btnSearchContact.Name = "btnSearchContact";
            this.btnSearchContact.Size = new System.Drawing.Size(78, 44);
            this.btnSearchContact.TabIndex = 2;
            this.btnSearchContact.Text = "Buscar Contacto";
            this.btnSearchContact.UseVisualStyleBackColor = true;
            this.btnSearchContact.Click += new System.EventHandler(this.btnSearchContact_Click);
            // 
            // btnRegisterContact
            // 
            this.btnRegisterContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterContact.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterContact.Location = new System.Drawing.Point(9, 78);
            this.btnRegisterContact.Name = "btnRegisterContact";
            this.btnRegisterContact.Size = new System.Drawing.Size(75, 44);
            this.btnRegisterContact.TabIndex = 1;
            this.btnRegisterContact.Text = "Registrar Contacto";
            this.btnRegisterContact.UseVisualStyleBackColor = true;
            this.btnRegisterContact.Click += new System.EventHandler(this.btnRegisterContact_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.White;
            this.lbWelcome.Location = new System.Drawing.Point(15, 20);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(113, 25);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Bienvenido ";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(757, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Recargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Menu Principal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgContacts;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnRegisterContact;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Button btnSearchContact;
        private System.Windows.Forms.Button button1;
    }
}