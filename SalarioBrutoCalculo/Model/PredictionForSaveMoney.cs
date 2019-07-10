using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioBrutoCalculo.Model
{
    class PredictionForSaveMoney{

        public PredictionForSaveMoney(String month,DeductionCLT actualSalary, double valueBalance){

            //Simulator
            SetActualBalance(valueBalance);
            SetDepositMonthly(actualSalary);
            SetIrProfitability(0.225);
            SetTaxProfitability(0.064);

            SetTotalValue(GetActualBalance() + GetDepositMonthly());
            double totalInvesment = (GetTotalValue() * GetTaxProfitability() / 12) * (1 - GetIrProfitability());
            Console.Write("\nValor da merreca : " + totalInvesment);
            SetTotalValue(GetTotalValue() + totalInvesment);
            Console.Write("||||||||||||||| Valor do mês ["+month+"]: R$" + GetTotalValue());
        }

        //SET - methods
        public void SetIrProfitability(double irProfitability){
            this.irProfitability = irProfitability;
        }

        public void SetTaxProfitability(double taxProfitability){
            this.taxProfitability = taxProfitability;
        }

        public void SetActualBalance(double actualBalance){
            this.actualBalance = actualBalance;
        }

        public void SetDepositMonthly(DeductionCLT actualSalary){
            depositMonthly = actualSalary.GetSalaryLiquido() * 0.4;
        }

        public void SetTotalValue(double totalValue){
            this.totalValue = totalValue;
        }

        //GET - methods
        public double  GetIrProfitability(){
            return irProfitability;
        }

        public double GetTaxProfitability(){
            return taxProfitability;
        }

        public double GetActualBalance(){
            return actualBalance;
        }

        public double GetDepositMonthly(){
            return depositMonthly;
        }
        public double GetTotalValue(){
            return totalValue;
        }

        //double IOF --> don't apply
        double irProfitability = 0; //22.5
        double taxProfitability = 0; //6.4
        double actualBalance = 0, depositMonthly = 0;

        double totalValue = 0;

    }
}
