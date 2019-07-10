using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioBrutoCalculo.Model
{
    class DebtToPay{

        public DebtToPay(DeductionCLT creditValue, double billBank, double educationCourse, double INSS){

            //Console.WriteLine("\nValor das dividas previstas: R$" + GetTotalOfDebt());

            ///*SetValues -- Test*/
            ////Simulation of month August

            //SetEducationCourses(330.50);
            //SetOthersPayment(160);
            //SetBillBank(171.50);
            //SetSaveMoney(creditValue.GetSalaryLiquido() * 0.4);

            SetBillBank(billBank);
            SetSaveMoney(creditValue.GetSalaryLiquido() * 0.4);
            SetEducationCourses(educationCourse);
            SetOthersPayment(INSS);

            if(creditValue.GetSalaryLiquido() > GetTotalOfDebt()){
                Console.WriteLine("\nValor restante: R$" + ((creditValue.GetSalaryLiquido() - GetSaveMoney())- GetTotalOfDebt()));
            }else{
                Console.WriteLine("Valor das dívidas supera o valor disponível ... ");
            }
        }

        public double GetTotalOfDebt(){

            double totalDebts = GetBillBank() + GetBillHouse() + 
                                GetBillOthers() + GetBillRecreation() + 
                                GetEducationCourses() + GetOthersPayment();
            return totalDebts;
        }  

        //SET
        public void SetBillBank(double billBank){
            this.billBank = billBank;
        }

        public void SetBillHouse(double billHouse){
            this.billHouse = billHouse;
        }

        public void SetBillRecreation(double billRecreation){
            this.billRecreation = billRecreation;
        }

        public void SetBillOthers(double billOthers){
            this.billOthers = billOthers;
        }

        public void SetOthersPayment(double othersPayments){
            this.othersPayments= othersPayments;
        }

        public void SetEducationCourses(double educationCourses){
            this.educationCourses = educationCourses;
        }

        public void SetSaveMoney(double saveMoney){
            this.saveMoney = saveMoney;
        }

        //GET
        public double GetBillBank(){
            return billBank;
        }

        public double GetBillHouse(){
            return billHouse;
        }

        public double GetBillRecreation(){
            return billRecreation;
        }

        public double GetBillOthers(){
            return billOthers;
        }

        public double GetOthersPayment(){
            return othersPayments;
        }

        public double GetEducationCourses(){
            return educationCourses;
        }

        public double GetSaveMoney(){
            return saveMoney;
        }

        //Atribbutes
        double billBank = 0 , billHouse = 0, billRecreation = 0, billOthers = 0; //fixed debts per peple 
        double othersPayments = 0; //food, restaurants, gifts
        double educationCourses = 0;

        double saveMoney = 0;

    }
}
