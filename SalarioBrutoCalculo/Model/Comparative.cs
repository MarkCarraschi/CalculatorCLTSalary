using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioBrutoCalculo.Model
{
    class Comparative{

        public Comparative(DeductionCLT actualSalary, DeductionCLT salaryToCompare){

            SetActualSalary(actualSalary);
            SetSalaryToCompare(salaryToCompare);

            if (GetActualSalary() < GetSalaryToCompare()){
                Console.WriteLine("Percentual ganho: " + (GetSalaryToCompare() - GetActualSalary()) / GetActualSalary() + " %");
                Console.WriteLine("Diferença líquida: R$" + (GetSalaryToCompare()-GetActualSalary()) );
            }
            else Console.WriteLine("O salário atual é maior.");              
        }

        //SET method
        public void SetActualSalary (DeductionCLT actualSalary){
            this.actualSalary = actualSalary.GetSalaryLiquido();
        }

        public void SetSalaryToCompare(DeductionCLT salaryToCompare){
            this.salaryToCompare = salaryToCompare.GetSalaryLiquido();
        }

        //GET method
        public double GetActualSalary() { return actualSalary; }
        public double GetSalaryToCompare() { return salaryToCompare; }             
          
        double actualSalary, salaryToCompare;
    }
}
