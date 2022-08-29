namespace BookApplicationRegister.View
{
    partial class DashRegisterContact
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashRegisterContact));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGetUser = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbWarning = new System.Windows.Forms.Label();
            this.userError = new System.Windows.Forms.ErrorProvider(this.components);
            this.telephoneError = new System.Windows.Forms.ErrorProvider(this.components);
            this.userCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.telephoneCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Contacto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar usuario:";
            // 
            // cbGetUser
            // 
            this.cbGetUser.FormattingEnabled = true;
            this.cbGetUser.Location = new System.Drawing.Point(38, 140);
            this.cbGetUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGetUser.Name = "cbGetUser";
            this.cbGetUser.Size = new System.Drawing.Size(190, 24);
            this.cbGetUser.TabIndex = 2;
            this.cbGetUser.Leave += new System.EventHandler(this.cbGetUser_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ingresar telefono:";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(43, 229);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(185, 22);
            this.txtTelephone.TabIndex = 3;
            this.txtTelephone.Leave += new System.EventHandler(this.txtTelephone_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Location = new System.Drawing.Point(99, 284);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbWarning.Location = new System.Drawing.Point(55, 337);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(0, 16);
            this.lbWarning.TabIndex = 5;
            // 
            // userError
            // 
            this.userError.ContainerControl = this;
            // 
            // telephoneError
            // 
            this.telephoneError.ContainerControl = this;
            // 
            // userCorrect
            // 
            this.userCorrect.ContainerControl = this;
            this.userCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("userCorrect.Icon")));
            // 
            // telephoneCorrect
            // 
            this.telephoneCorrect.ContainerControl = this;
            this.telephoneCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("telephoneCorrect.Icon")));
            // 
            // DashRegisterContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 358);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.cbGetUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DashRegisterContact";
            this.Text = "DashRegisterContact";
            ((System.ComponentModel.ISupportInitialize)(this.userError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGetUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.ErrorProvider userError;
        private System.Windows.Forms.ErrorProvider telephoneError;
        private System.Windows.Forms.ErrorProvider userCorrect;
        private System.Windows.Forms.ErrorProvider telephoneCorrect;
    }
}