using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using SalarioBrutoCalculo.Model;

namespace SalarioBrutoCalculo
{
    static class Program{
        /// <summary>
        
        /// </summary>
        [STAThread]
        static void Main(string[] args){

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainFormCalculatorSalaryBruto());

            //double[] var = { 2800, 3000, 3200, 2000 };  
            //Console.Write("\nValor Bruto: " + var[3] + "\nLíquido");
            //DeductionCLT actualTest = new DeductionCLT(var[3], 334.40);

            //Console.Write("\nValor Bruto: " + var[0] + "\nLíquido");
            //DeductionCLT firstTest = new DeductionCLT(var[0], 334.40);

            //Console.Write("\nValor Bruto: " + var[1] + "\nLíquido");
            //DeductionCLT secondTest = new DeductionCLT(var[1], 334.40);

            //Console.Write("\nValor Bruto: " + var[2] + "\nLíquido");
            //DeductionCLT thirdTest = new DeductionCLT(var[2], 334.40);

            ///*--------------Comparativo------------------------*/
            //Comparative comparActual = new Comparative(actualTest, thirdTest);

            //Console.WriteLine("-----------------------------SAVE MONEY PREDICTION-----------------------------------------");

            //string[] months = {"Janeiro","Fevereiro","Março","Abril","Maio","Junho",
            //                   "Julho","Agosto","Setembro","Outubro","Novembro","Dezembro",
            //                   "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
            //                   "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            ////List of my wills
            //DesiredProduct[] productsArray = new DesiredProduct[8];

            //productsArray[0] = new DesiredProduct(179.00, "Resident Evil 2 Remake", "NOTHING HERE", 5);
            //productsArray[1] = new DesiredProduct(149.00, "Red Dead Redemption", "NOTHING HERE", 4); 
            //productsArray[2] = new DesiredProduct(79.99, "BELT", "NOTHING HERE", 8);
            //productsArray[3] = new DesiredProduct(80.00, "TROUSERS", "NOTHING HERE", 8);
            //productsArray[4] = new DesiredProduct(159.00, "SOCIAL SHOE", "NOTHING HERE", 6);
            //productsArray[5] = new DesiredProduct(1310.00, "ODONTO", "NOTHING HERE", 6);
            //productsArray[6] = new DesiredProduct(200.00, "Books", "tehcnology", 5);
            //productsArray[7] = new DesiredProduct(300.00, "Sneakers for mt", "I don't know",10);

            //double totalPriority = 0, totalNotPriority = 0;

            //for (int i = 0; i < productsArray.Length; i++){              
            //    if(productsArray[i].GetNecessityProduct() >= 7){
            //        totalPriority = totalPriority + productsArray[i].GetValueProduct();
            //    }    
            //}

            //for (int i = 0; i < productsArray.Length; i++){              
            //    if(productsArray[i].GetNecessityProduct() <= 5){
            //        totalNotPriority = totalNotPriority + productsArray[i].GetValueProduct();
            //    }    
            //}

            //Console.WriteLine("This is the final value of products priority: " + totalPriority);

            ////This products need to check the black friday            
            //Console.WriteLine("This is the final value of products priority: " + totalNotPriority);

            //PredictionForSaveMoney july = new PredictionForSaveMoney(months[6], actualTest, 4900);
            //PredictionForSaveMoney august = new PredictionForSaveMoney(months[7], actualTest, july.GetTotalValue());
            //PredictionForSaveMoney september = new PredictionForSaveMoney(months[8], actualTest, august.GetTotalValue());
            //PredictionForSaveMoney october = new PredictionForSaveMoney(months[9], actualTest, september.GetTotalValue());
            //PredictionForSaveMoney november = new PredictionForSaveMoney(months[10], actualTest, october.GetTotalValue());
            //PredictionForSaveMoney december = new PredictionForSaveMoney(months[11], actualTest, november.GetTotalValue());

            //double actualBalanceTemp = 4900;
            //PredictionForSaveMoney[] varibleObjects = new PredictionForSaveMoney[18];
            //DebtToPay[] variablesBill = new DebtToPay[6];

            //Console.Write("\nSimulation about the actual ...\n");
            ////Simulation with actual -- 1.7
            //for (int i = 5; i < 18; i += 1){
            //    varibleObjects[i] = new PredictionForSaveMoney(months[i], actualTest, actualBalanceTemp);
            //    actualBalanceTemp = varibleObjects[i].GetTotalValue();
            //}

            //double tempAccValue = 13327;

            ////Simulation another -- 3.2
            //Console.Write("\n\nSimulation about the perspective ...\n\n");
            //for(int i = 6; i < 18; i++){
            //    varibleObjects[i] = new PredictionForSaveMoney(months[i], thirdTest, tempAccValue);
            //    tempAccValue = varibleObjects[i].GetTotalValue();
            //}

            //Console.Write("\nSimulation about bills ://///// ...\n");
            ////Simulation with actual -- 1.7
            //int auxMonth = 7;
            //double[] billBank = { 390, 171, 125, 125, 125, 125 };
            //for (int i = 0; i < 6; i ++){
            //    variablesBill[i] = new DebtToPay(actualTest, billBank[i], 330, 170);
            //}

            ////Register the bill
            //Bill bank = new Bill("Test","Bank","Example of note", new DateTime(2019,7,25),120.10,false);
            //bank.SaveFileBill(bank);
            //Console.WriteLine("Data da conta: " + bank.GetDateBill().Day + "/" + bank.GetDateBill().Month + "/" + bank.GetDateBill().Year);
            //Console.ReadLine();            
        }
    }
}
