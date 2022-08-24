namespace LinqTest
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAscListB = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnCousinNumbers = new System.Windows.Forms.Button();
            this.btnAscList = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtNumberN = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCoupleNumbers = new System.Windows.Forms.Button();
            this.btnNoCoupleNumbers = new System.Windows.Forms.Button();
            this.txtRepNumber = new System.Windows.Forms.TextBox();
            this.btnRepNum = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRepNumC = new System.Windows.Forms.TextBox();
            this.btnCalRepNum = new System.Windows.Forms.Button();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "LINQ TEST";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnNoCoupleNumbers);
            this.panel1.Controls.Add(this.btnCoupleNumbers);
            this.panel1.Controls.Add(this.btnAscListB);
            this.panel1.Controls.Add(this.btnSum);
            this.panel1.Controls.Add(this.btnCousinNumbers);
            this.panel1.Controls.Add(this.btnAscList);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 335);
            this.panel1.TabIndex = 1;
            // 
            // btnAscListB
            // 
            this.btnAscListB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAscListB.Location = new System.Drawing.Point(3, 84);
            this.btnAscListB.Name = "btnAscListB";
            this.btnAscListB.Size = new System.Drawing.Size(88, 36);
            this.btnAscListB.TabIndex = 3;
            this.btnAscListB.Text = "Lista ascendente";
            this.btnAscListB.UseVisualStyleBackColor = true;
            this.btnAscListB.Click += new System.EventHandler(this.btnAscListB_Click);
            // 
            // btnSum
            // 
            this.btnSum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSum.Location = new System.Drawing.Point(224, 31);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "Sumar";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnCousinNumbers
            // 
            this.btnCousinNumbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCousinNumbers.Location = new System.Drawing.Point(119, 18);
            this.btnCousinNumbers.Name = "btnCousinNumbers";
            this.btnCousinNumbers.Size = new System.Drawing.Size(82, 48);
            this.btnCousinNumbers.TabIndex = 1;
            this.btnCousinNumbers.Text = "Numeros primos ascendentes";
            this.btnCousinNumbers.UseVisualStyleBackColor = true;
            this.btnCousinNumbers.Click += new System.EventHandler(this.btnCousinNumbers_Click);
            // 
            // btnAscList
            // 
            this.btnAscList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAscList.Location = new System.Drawing.Point(3, 24);
            this.btnAscList.Name = "btnAscList";
            this.btnAscList.Size = new System.Drawing.Size(88, 37);
            this.btnAscList.TabIndex = 0;
            this.btnAscList.Text = "Lista descendente";
            this.btnAscList.UseVisualStyleBackColor = true;
            this.btnAscList.Click += new System.EventHandler(this.btnAscList_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcess.Location = new System.Drawing.Point(144, 32);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Calcular";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtNumberN
            // 
            this.txtNumberN.Location = new System.Drawing.Point(14, 34);
            this.txtNumberN.Name = "txtNumberN";
            this.txtNumberN.Size = new System.Drawing.Size(116, 20);
            this.txtNumberN.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnClean);
            this.panel2.Controls.Add(this.btnGetInfo);
            this.panel2.Controls.Add(this.btnCalRepNum);
            this.panel2.Controls.Add(this.txtRepNumC);
            this.panel2.Controls.Add(this.btnRepNum);
            this.panel2.Controls.Add(this.txtRepNumber);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnProcess);
            this.panel2.Controls.Add(this.txtNumberN);
            this.panel2.Location = new System.Drawing.Point(544, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 335);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numeros mayores a: ";
            // 
            // btnCoupleNumbers
            // 
            this.btnCoupleNumbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoupleNumbers.Location = new System.Drawing.Point(122, 84);
            this.btnCoupleNumbers.Name = "btnCoupleNumbers";
            this.btnCoupleNumbers.Size = new System.Drawing.Size(75, 36);
            this.btnCoupleNumbers.TabIndex = 4;
            this.btnCoupleNumbers.Text = "Numeros pares";
            this.btnCoupleNumbers.UseVisualStyleBackColor = true;
            this.btnCoupleNumbers.Click += new System.EventHandler(this.btnCoupleNumbers_Click);
            // 
            // btnNoCoupleNumbers
            // 
            this.btnNoCoupleNumbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoCoupleNumbers.Location = new System.Drawing.Point(224, 84);
            this.btnNoCoupleNumbers.Name = "btnNoCoupleNumbers";
            this.btnNoCoupleNumbers.Size = new System.Drawing.Size(75, 36);
            this.btnNoCoupleNumbers.TabIndex = 5;
            this.btnNoCoupleNumbers.Text = "Numeros inpares";
            this.btnNoCoupleNumbers.UseVisualStyleBackColor = true;
            this.btnNoCoupleNumbers.Click += new System.EventHandler(this.btnNoCoupleNumbers_Click);
            // 
            // txtRepNumber
            // 
            this.txtRepNumber.Location = new System.Drawing.Point(14, 87);
            this.txtRepNumber.Name = "txtRepNumber";
            this.txtRepNumber.Size = new System.Drawing.Size(116, 20);
            this.txtRepNumber.TabIndex = 7;
            // 
            // btnRepNum
            // 
            this.btnRepNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepNum.Location = new System.Drawing.Point(144, 85);
            this.btnRepNum.Name = "btnRepNum";
            this.btnRepNum.Size = new System.Drawing.Size(75, 23);
            this.btnRepNum.TabIndex = 8;
            this.btnRepNum.Text = "Calcular";
            this.btnRepNum.UseVisualStyleBackColor = true;
            this.btnRepNum.Click += new System.EventHandler(this.btnRepNum_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero repeticiones de:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero repeticiones en: ";
            // 
            // txtRepNumC
            // 
            this.txtRepNumC.Location = new System.Drawing.Point(14, 152);
            this.txtRepNumC.Name = "txtRepNumC";
            this.txtRepNumC.Size = new System.Drawing.Size(116, 20);
            this.txtRepNumC.TabIndex = 9;
            // 
            // btnCalRepNum
            // 
            this.btnCalRepNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalRepNum.Location = new System.Drawing.Point(144, 150);
            this.btnCalRepNum.Name = "btnCalRepNum";
            this.btnCalRepNum.Size = new System.Drawing.Size(75, 23);
            this.btnCalRepNum.TabIndex = 10;
            this.btnCalRepNum.Text = "Calcular";
            this.btnCalRepNum.UseVisualStyleBackColor = true;
            this.btnCalRepNum.Click += new System.EventHandler(this.btnCalRepNum_Click);
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetInfo.Location = new System.Drawing.Point(39, 195);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetInfo.TabIndex = 11;
            this.btnGetInfo.Text = "Recuperar";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // btnClean
            // 
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.Location = new System.Drawing.Point(144, 189);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 36);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "Limpiar campos";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "LINQ TEST";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnCousinNumbers;
        private System.Windows.Forms.Button btnAscList;
        private System.Windows.Forms.Button btnAscListB;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtNumberN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNoCoupleNumbers;
        private System.Windows.Forms.Button btnCoupleNumbers;
        private System.Windows.Forms.Button btnRepNum;
        private System.Windows.Forms.TextBox txtRepNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalRepNum;
        private System.Windows.Forms.TextBox txtRepNumC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnGetInfo;
    }
}

