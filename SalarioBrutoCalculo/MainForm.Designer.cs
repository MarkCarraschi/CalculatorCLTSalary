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
            this.btnReset = new System.Windows.Forms.Button();
            this.tbc_SalaryObjects = new System.Windows.Forms.TabControl();
            this.tabSalary = new System.Windows.Forms.TabPage();
            this.tabProf = new System.Windows.Forms.TabPage();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pnlTransport.SuspendLayout();
            this.tbc_SalaryObjects.SuspendLayout();
            this.tabSalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(127, 22);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(109, 20);
            this.lblSalarioBruto.TabIndex = 0;
            this.lblSalarioBruto.Text = "Salário Bruto: ";
            this.lblSalarioBruto.Click += new System.EventHandler(this.lblSalarioBruto_Click);
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBruto.Location = new System.Drawing.Point(252, 19);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(100, 26);
            this.txtSalarioBruto.TabIndex = 1;
            this.txtSalarioBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalarioBruto.TextChanged += new System.EventHandler(this.txtSalarioBruto_TextChanged);
            // 
            // chkTransport
            // 
            this.chkTransport.AutoSize = true;
            this.chkTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTransport.Location = new System.Drawing.Point(15, 59);
            this.chkTransport.Name = "chkTransport";
            this.chkTransport.Size = new System.Drawing.Size(166, 24);
            this.chkTransport.TabIndex = 2;
            this.chkTransport.Text = "Uso vale transporte";
            this.chkTransport.UseVisualStyleBackColor = true;
            this.chkTransport.CheckedChanged += new System.EventHandler(this.chkTransport_CheckedChanged);
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
            this.pnlTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTransport.Location = new System.Drawing.Point(15, 89);
            this.pnlTransport.Name = "pnlTransport";
            this.pnlTransport.Size = new System.Drawing.Size(415, 137);
            this.pnlTransport.TabIndex = 3;
            // 
            // txtTransportTotal
            // 
            this.txtTransportTotal.Enabled = false;
            this.txtTransportTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransportTotal.Location = new System.Drawing.Point(84, 76);
            this.txtTransportTotal.Name = "txtTransportTotal";
            this.txtTransportTotal.Size = new System.Drawing.Size(73, 26);
            this.txtTransportTotal.TabIndex = 7;
            this.txtTransportTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTransportTotal.TextChanged += new System.EventHandler(this.txtTransportTotal_TextChanged);
            // 
            // lblTransportTotal
            // 
            this.lblTransportTotal.AutoSize = true;
            this.lblTransportTotal.Location = new System.Drawing.Point(22, 79);
            this.lblTransportTotal.Name = "lblTransportTotal";
            this.lblTransportTotal.Size = new System.Drawing.Size(63, 20);
            this.lblTransportTotal.TabIndex = 6;
            this.lblTransportTotal.Text = "TOTAL:";
            this.lblTransportTotal.Click += new System.EventHandler(this.lblTransportTotal_Click);
            // 
            // txtTransportBack
            // 
            this.txtTransportBack.Enabled = false;
            this.txtTransportBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransportBack.Location = new System.Drawing.Point(315, 96);
            this.txtTransportBack.Name = "txtTransportBack";
            this.txtTransportBack.Size = new System.Drawing.Size(73, 26);
            this.txtTransportBack.TabIndex = 5;
            this.txtTransportBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTransportBack.TextChanged += new System.EventHandler(this.txtTransportBack_TextChanged);
            // 
            // lblTransportBack
            // 
            this.lblTransportBack.AutoSize = true;
            this.lblTransportBack.Location = new System.Drawing.Point(243, 99);
            this.lblTransportBack.Name = "lblTransportBack";
            this.lblTransportBack.Size = new System.Drawing.Size(65, 20);
            this.lblTransportBack.TabIndex = 4;
            this.lblTransportBack.Text = "VOLTA:";
            this.lblTransportBack.Click += new System.EventHandler(this.lblTransportBack_Click);
            // 
            // txtTransportGo
            // 
            this.txtTransportGo.Enabled = false;
            this.txtTransportGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransportGo.Location = new System.Drawing.Point(315, 61);
            this.txtTransportGo.Name = "txtTransportGo";
            this.txtTransportGo.Size = new System.Drawing.Size(73, 26);
            this.txtTransportGo.TabIndex = 3;
            this.txtTransportGo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTransportGo.TextChanged += new System.EventHandler(this.txtTransportGo_TextChanged);
            // 
            // lblTransportGo
            // 
            this.lblTransportGo.AutoSize = true;
            this.lblTransportGo.Location = new System.Drawing.Point(253, 64);
            this.lblTransportGo.Name = "lblTransportGo";
            this.lblTransportGo.Size = new System.Drawing.Size(41, 20);
            this.lblTransportGo.TabIndex = 2;
            this.lblTransportGo.Text = "IDA:";
            this.lblTransportGo.Click += new System.EventHandler(this.lblTransportGo_Click);
            // 
            // chkTransportGoBack
            // 
            this.chkTransportGoBack.AutoSize = true;
            this.chkTransportGoBack.Enabled = false;
            this.chkTransportGoBack.Location = new System.Drawing.Point(257, 21);
            this.chkTransportGoBack.Name = "chkTransportGoBack";
            this.chkTransportGoBack.Size = new System.Drawing.Size(105, 24);
            this.chkTransportGoBack.TabIndex = 1;
            this.chkTransportGoBack.Text = "Ida e volta:";
            this.chkTransportGoBack.UseVisualStyleBackColor = true;
            this.chkTransportGoBack.CheckedChanged += new System.EventHandler(this.chkTransportGoBack_CheckedChanged);
            // 
            // chkTransportTotal
            // 
            this.chkTransportTotal.AutoSize = true;
            this.chkTransportTotal.Enabled = false;
            this.chkTransportTotal.Location = new System.Drawing.Point(26, 22);
            this.chkTransportTotal.Name = "chkTransportTotal";
            this.chkTransportTotal.Size = new System.Drawing.Size(104, 24);
            this.chkTransportTotal.TabIndex = 0;
            this.chkTransportTotal.Text = "Valor total:";
            this.chkTransportTotal.UseVisualStyleBackColor = true;
            this.chkTransportTotal.CheckedChanged += new System.EventHandler(this.chkTransportTotal_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(454, 160);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 48);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Limpar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbc_SalaryObjects
            // 
            this.tbc_SalaryObjects.Controls.Add(this.tabSalary);
            this.tbc_SalaryObjects.Controls.Add(this.tabProf);
            this.tbc_SalaryObjects.Controls.Add(this.tabBill);
            this.tbc_SalaryObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_SalaryObjects.Location = new System.Drawing.Point(12, 12);
            this.tbc_SalaryObjects.Name = "tbc_SalaryObjects";
            this.tbc_SalaryObjects.SelectedIndex = 0;
            this.tbc_SalaryObjects.Size = new System.Drawing.Size(569, 269);
            this.tbc_SalaryObjects.TabIndex = 6;
            this.tbc_SalaryObjects.Tag = "";
            // 
            // tabSalary
            // 
            this.tabSalary.Controls.Add(this.txtSalarioBruto);
            this.tabSalary.Controls.Add(this.btnReset);
            this.tabSalary.Controls.Add(this.lblSalarioBruto);
            this.tabSalary.Controls.Add(this.btnCalculate);
            this.tabSalary.Controls.Add(this.chkTransport);
            this.tabSalary.Controls.Add(this.pnlTransport);
            this.tabSalary.Location = new System.Drawing.Point(4, 25);
            this.tabSalary.Name = "tabSalary";
            this.tabSalary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalary.Size = new System.Drawing.Size(561, 240);
            this.tabSalary.TabIndex = 0;
            this.tabSalary.Text = "Cadastro de salário";
            this.tabSalary.UseVisualStyleBackColor = true;
            // 
            // tabProf
            // 
            this.tabProf.Location = new System.Drawing.Point(4, 25);
            this.tabProf.Name = "tabProf";
            this.tabProf.Padding = new System.Windows.Forms.Padding(3);
            this.tabProf.Size = new System.Drawing.Size(561, 240);
            this.tabProf.TabIndex = 1;
            this.tabProf.Text = "Controle de rendimentos";
            this.tabProf.UseVisualStyleBackColor = true;
            // 
            // tabBill
            // 
            this.tabBill.Location = new System.Drawing.Point(4, 25);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabBill.Size = new System.Drawing.Size(561, 240);
            this.tabBill.TabIndex = 2;
            this.tabBill.Text = "Controle de contas";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(454, 90);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 45);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // mainFormCalculatorSalaryBruto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 287);
            this.Controls.Add(this.tbc_SalaryObjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainFormCalculatorSalaryBruto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora salário líquido";
            this.Load += new System.EventHandler(this.mainFormCalculatorSalaryBruto_Load);
            this.pnlTransport.ResumeLayout(false);
            this.pnlTransport.PerformLayout();
            this.tbc_SalaryObjects.ResumeLayout(false);
            this.tabSalary.ResumeLayout(false);
            this.tabSalary.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TabControl tbc_SalaryObjects;
        private System.Windows.Forms.TabPage tabSalary;
        private System.Windows.Forms.TabPage tabProf;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.Button btnCalculate;
    }
}

