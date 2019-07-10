using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioBrutoCalculo.Model
{
    class Bill{
        //Constructor --> your only resposabilitie it's set the all values of the class 
        public Bill(    string nameBill, string typeBill, string noteBill, 
                        DateTime dateBill, double priceBill, bool statusBill) {
            SetDateBill(dateBill);
            SetNameBill(nameBill);
            SetTypeBill(typeBill);
            SetNoteBill(noteBill);
            SetPriceBill(priceBill);
            SetStatusBill(statusBill);
        }

        public Bill()
        {
        }

        public void SaveFileBill(Bill bill){


            String jsonFile = "{" +
                "\n\"Name\": " + "\"" + GetNameBill() + "\"" + "," +
                "\n\"Type\": " + "\"" + GetTypeBill() + "\"" + "," +
                "\n\"Status\": " + GetStatusBill() + "," +
                "\n\"Price\": " + Convert.ToDouble(GetPriceBill()) +  "," +
                "\n\"Note\": " + "\"" + GetNoteBill() + "\"" + "\n}";
           
            string JSONresult = JsonConvert.SerializeObject(jsonFile);
            string path = @"..\..\Data\Bill\file.json";

            using (var tw = new StreamWriter(path, true)){
                tw.WriteLine(jsonFile);
                tw.Close();
            }

            //write string to file
            //System.IO.File.WriteAllText(@"..\\Data\\Bill\\" + GetNameBill() + "_" + GetType() + ".json", json);
            //System.IO.File.WriteAllText(@"..\..\Data\Bill\file.json", json);
        }

        public void PercentageBillSalary(DeductionCLT salary){
            Console.WriteLine("Percentual da conta: " + (GetPriceBill()*100) / salary.GetSalaryLiquido());
        }

        public void OutPutBill(){
            Console.WriteLine("Conta: " + GetNameBill());
            Console.WriteLine("Tipo: " + GetTypeBill());
            Console.WriteLine("Valor da conta: " + GetPriceBill());
            Console.WriteLine("Data de vencimento: " + GetDateBill());
            Console.WriteLine("Status: " + GetStatusBill());
            Console.WriteLine("Observação: " + GetNoteBill() + "\n");
        }

        //set methods
        public void SetNameBill(string nameBill){
            this.nameBill = nameBill;
        }

        public void SetTypeBill(string typeBill){
            this.typeBill = typeBill;
        }

        public void SetNoteBill(string noteBill){
            this.noteBill = noteBill;
        }

        public void SetDateBill(DateTime dateBill){
            this.dateBill = dateBill;
        }

        public void SetPriceBill(double priceBill){
            this.priceBill = priceBill;
        }

        public void SetStatusBill(bool statusBill){
            this.statusBill = statusBill;
        }

        //get methods
        public string GetNameBill(){
            return nameBill;
        }

        public string GetTypeBill(){
            return typeBill;
        }

        public string GetNoteBill(){
            return noteBill;
        }

        public DateTime GetDateBill(){
            return dateBill;
        }

        public double GetPriceBill(){
            return priceBill;
        }

        public bool GetStatusBill(){
            return statusBill;
        }

        //Atribbutes
        private string nameBill, typeBill, noteBill;
        private DateTime dateBill;
        private double priceBill;
        private bool statusBill;
    }
}
