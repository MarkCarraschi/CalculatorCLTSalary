using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SalarioBrutoCalculo.Model;

namespace SalarioBrutoCalculo
{
    public partial class mainFormCalculatorSalaryBruto : Form{
        public mainFormCalculatorSalaryBruto(){
            InitializeComponent();

        }

        private void btnReset_Click(object sender, EventArgs e){

            txtSalarioBruto.Clear();
            txtTransportBack.Clear();
            txtTransportGo.Clear();
            txtTransportTotal.Clear();

            txtSalarioBruto.Focus();
        }

        private void mainFormCalculatorSalaryBruto_Load(object sender, EventArgs e){
            //Set disable components
            chkTransport.Enabled = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DeductionCLT clt;
            double salaryB = Double.Parse(txtSalarioBruto.Text);
            double transportation;

            if(chkTransportTotal.Checked == true)
            {
                transportation = Double.Parse(txtTransportTotal.Text);
            }
            else
            {
                transportation = (Double.Parse(txtTransportGo.Text) + Double.Parse(txtTransportBack.Text)) * 22;
            }

            clt = new DeductionCLT(salaryB, transportation);

            MessageBox.Show("This is a result value: " + clt.GetSalaryLiquido());
        }

        private void txtTransportGo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTransportBack_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTransportBack_Click(object sender, EventArgs e)
        {

        }

        private void lblTransportGo_Click(object sender, EventArgs e)
        {

        }

        private void chkTransportGoBack_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransportGoBack.Checked == true)
            {
                txtTransportGo.Enabled = true;
                txtTransportBack.Enabled = true;

                chkTransportTotal.Checked = false;
            }
            else
            {
                txtTransportGo.Enabled = false;
                txtTransportBack.Enabled = false;
            }
              
        }

        private void txtTransportTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTransportTotal_Click(object sender, EventArgs e)
        {

        }

        private void chkTransportTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransportTotal.Checked == true)
            {
                txtTransportTotal.Enabled = true;
                chkTransportGoBack.Checked = false;
            }  
            else
            {
                txtTransportTotal.Enabled = false;
            }
                

        }

        protected virtual void chkTransport_CheckedChanged(object sender, EventArgs e){
            if (chkTransport.Checked == true){
                chkTransportGoBack.Enabled = true;
                chkTransportTotal.Enabled = true;
            }
            else
            {
                chkTransportGoBack.Enabled = false;
                chkTransportTotal.Enabled = false;

                chkTransportGoBack.Checked = false;
                chkTransportTotal.Checked = false;
            }
        }

        private void lblSalarioBruto_Click(object sender, EventArgs e)
        {

        }

        private void txtSalarioBruto_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
