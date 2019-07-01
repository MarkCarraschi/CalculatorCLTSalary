namespace SalarioBrutoCalculo
{
    partial class mainFormCalculatorSalaryBruto
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
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.chkTransport = new System.Windows.Forms.CheckBox();
            this.pnlTransport = new System.Windows.Forms.Panel();
            this.txtTransportTotal = new System.Windows.Forms.TextBox();
            this.lblTransportTotal = new System.Windows.Forms.Label();
            this.txtTransportBack = new System.Windows.Forms.TextBox();
            this.lblTransportBack = new System.Windows.Forms.Label();
            this.txtTransportGo = new System.Windows.Forms.TextBox();
            this.lblTransportGo = new System.Windows.Forms.Label();
            this.chkTransportGoBack = new System.Windows.Forms.CheckBox();
            this.chkTransportTotal = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlTransport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(169, 39);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(73, 13);
            this.lblSalarioBruto.TabIndex = 0;
            this.lblSalarioBruto.Text = "Salário Bruto: ";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(248, 36);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioBruto.TabIndex = 1;
            // 
            // chkTransport
            // 
            this.chkTransport.AutoSize = true;
            this.chkTransport.Location = new System.Drawing.Point(11, 82);
            this.chkTransport.Name = "chkTransport";
            this.chkTransport.Size = new System.Drawing.Size(118, 17);
            this.chkTransport.TabIndex = 2;
            this.chkTransport.Text = "Uso vale transporte";
            this.chkTransport.UseVisualStyleBackColor = true;
            // 
            // pnlTransport
            // 
            this.pnlTransport.Controls.Add(this.txtTransportTotal);
            this.pnlTransport.Controls.Add(this.lblTransportTotal);
            this.pnlTransport.Controls.Add(this.txtTransportBack);
            this.pnlTransport.Controls.Add(this.lblTransportBack);
            this.pnlTransport.Controls.Add(this.txtTransportGo);
            this.pnlTransport.Controls.Add(this.lblTransportGo);
            this.pnlTransport.Controls.Add(this.chkTransportGoBack);
            this.pnlTransport.Controls.Add(this.chkTransportTotal);
            this.pnlTransport.Enabled = false;
            this.pnlTransport.Location = new System.Drawing.Point(12, 116);
            this.pnlTransport.Name = "pnlTransport";
            this.pnlTransport.Size = new System.Drawing.Size(423, 138);
            this.pnlTransport.TabIndex = 3;
            // 
            // txtTransportTotal
            // 
            this.txtTransportTotal.Location = new System.Drawing.Point(84, 55);
            this.txtTransportTotal.Name = "txtTransportTotal";
            this.txtTransportTotal.Size = new System.Drawing.Size(73, 20);
            this.txtTransportTotal.TabIndex = 7;
            // 
            // lblTransportTotal
            // 
            this.lblTransportTotal.AutoSize = true;
            this.lblTransportTotal.Location = new System.Drawing.Point(22, 58);
            this.lblTransportTotal.Name = "lblTransportTotal";
            this.lblTransportTotal.Size = new System.Drawing.Size(45, 13);
            this.lblTransportTotal.TabIndex = 6;
            this.lblTransportTotal.Text = "TOTAL:";
            // 
            // txtTransportBack
            // 
            this.txtTransportBack.Location = new System.Drawing.Point(326, 94);
            this.txtTransportBack.Name = "txtTransportBack";
            this.txtTransportBack.Size = new System.Drawing.Size(73, 20);
            this.txtTransportBack.TabIndex = 5;
            // 
            // lblTransportBack
            // 
            this.lblTransportBack.AutoSize = true;
            this.lblTransportBack.Location = new System.Drawing.Point(254, 97);
            this.lblTransportBack.Name = "lblTransportBack";
            this.lblTransportBack.Size = new System.Drawing.Size(45, 13);
            this.lblTransportBack.TabIndex = 4;
            this.lblTransportBack.Text = "VOLTA:";
            // 
            // txtTransportGo
            // 
            this.txtTransportGo.Location = new System.Drawing.Point(326, 59);
            this.txtTransportGo.Name = "txtTransportGo";
            this.txtTransportGo.Size = new System.Drawing.Size(73, 20);
            this.txtTransportGo.TabIndex = 3;
            // 
            // lblTransportGo
            // 
            this.lblTransportGo.AutoSize = true;
            this.lblTransportGo.Location = new System.Drawing.Point(264, 62);
            this.lblTransportGo.Name = "lblTransportGo";
            this.lblTransportGo.Size = new System.Drawing.Size(28, 13);
            this.lblTransportGo.TabIndex = 2;
            this.lblTransportGo.Text = "IDA:";
            // 
            // chkTransportGoBack
            // 
            this.chkTransportGoBack.AutoSize = true;
            this.chkTransportGoBack.Location = new System.Drawing.Point(257, 16);
            this.chkTransportGoBack.Name = "chkTransportGoBack";
            this.chkTransportGoBack.Size = new System.Drawing.Size(79, 17);
            this.chkTransportGoBack.TabIndex = 1;
            this.chkTransportGoBack.Text = "Ida e volta:";
            this.chkTransportGoBack.UseVisualStyleBackColor = true;
            // 
            // chkTransportTotal
            // 
            this.chkTransportTotal.AutoSize = true;
            this.chkTransportTotal.Location = new System.Drawing.Point(26, 16);
            this.chkTransportTotal.Name = "chkTransportTotal";
            this.chkTransportTotal.Size = new System.Drawing.Size(76, 17);
            this.chkTransportTotal.TabIndex = 0;
            this.chkTransportTotal.Text = "Valor total:";
            this.chkTransportTotal.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(459, 116);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 45);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(459, 194);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 48);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // mainFormCalculatorSalaryBruto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 269);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pnlTransport);
            this.Controls.Add(this.chkTransport);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.lblSalarioBruto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainFormCalculatorSalaryBruto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora salário líquido";
            this.Load += new System.EventHandler(this.mainFormCalculatorSalaryBruto_Load);
            this.pnlTransport.ResumeLayout(false);
            this.pnlTransport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.CheckBox chkTransport;
        private System.Windows.Forms.Panel pnlTransport;
        private System.Windows.Forms.CheckBox chkTransportGoBack;
        private System.Windows.Forms.CheckBox chkTransportTotal;
        private System.Windows.Forms.TextBox txtTransportTotal;
        private System.Windows.Forms.Label lblTransportTotal;
        private System.Windows.Forms.TextBox txtTransportBack;
        private System.Windows.Forms.Label lblTransportBack;
        private System.Windows.Forms.TextBox txtTransportGo;
        private System.Windows.Forms.Label lblTransportGo;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
    }
}

