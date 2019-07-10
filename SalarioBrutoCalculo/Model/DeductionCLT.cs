using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioBrutoCalculo.Model
{
    class DeductionCLT{
        public DeductionCLT(double value, double transport){
            //Sem a reforma da previdencia
            CalculateInss(value);
            SetSalaryBase(value);
            CalculateIr();
            CalculateVt(transport);
            //Console.WriteLine("Valor do salário líquido: " + GetSalaryLiquido());
        }
        
        public void CalculateVt(double value){
            if( (GetSalaryLiquido() * 0.06) <= value){
                SetSalaryLiquido(GetSalaryLiquido() - (GetSalaryLiquido() * 0.06));
            }
            else{
                SetSalaryLiquido(GetSalaryLiquido() - value);
            }
        }

        public void CalculateInss(double value){
            
            //Cálculo do INSS
            if (value <= 1751.81)
            { // 8%
                value = value * 0.08;
                SetInssValue(value);
            }
            else if (value >= 1751.82 && value <= 2919.72)
            { // 9%
                value = value * 0.09;
                SetInssValue(value);
            }
            else
            { //else if ( value >= 2919.73  && 5839.45) { // 11%
                value = value * 0.11;
                SetInssValue(value);
            }
            
        }

        public void CalculateIr(){
            //Valor do IR é o que excede do valor da tabela
            if (GetSalaryBase() <= 1903.98) {
                SetSalaryLiquido(GetSalaryBase());
            }
            else if (GetSalaryBase() >= 1903.99 && GetSalaryBase() <= 2826.65) {
                SetSalaryLiquido(GetSalaryBase() - ((GetSalaryBase() * 0.075) - 142.80));
            }
            else if (GetSalaryBase() >= 2826.66 && GetSalaryBase() <= 3751.05) {
                SetSalaryLiquido(GetSalaryBase() - ((GetSalaryBase() * 0.15) - 354.80));
            }
            else if (GetSalaryBase() >= 3751.06 && GetSalaryBase() <= 4664.68) {
                SetSalaryLiquido(GetSalaryBase() - ((GetSalaryBase() * 0.225) - 636.13));
            }
            else if (GetSalaryBase() >= 4664.68) {
                SetSalaryLiquido(GetSalaryBase() - ((GetSalaryBase() * 0.275) - 869.36));
            }
        }

        //SET Methods
        public void SetIrValue(double irValue){
            this.irValue = irValue;
        }

        public void SetInssValue(double inssValue){
            this.inssValue = inssValue;
        }

        public void SetVtValue(double vtValue){
            this.vtValue = vtValue;
        }

        public void SetSalaryBase(double salaryBruto){
            salaryBase = salaryBruto - GetInssValue();
        }

        public void SetSalaryLiquido (double salaryLiquido){
            this.salaryLiquido = salaryLiquido;
        }

        //GET Methods
        public double GetIrValue() { return irValue; }
        public double GetInssValue() { return inssValue; }
        public double GetVtValue () { return vtValue; }
        public double GetSalaryBase() { return salaryBase; }
        public double GetSalaryLiquido () { return salaryLiquido; }

        //Variables
        double irValue = 0, inssValue = 0, vtValue = 0;
        double salaryBase = 0;
        double salaryLiquido = 0;
    }
}
