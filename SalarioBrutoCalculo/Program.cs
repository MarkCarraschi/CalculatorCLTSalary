using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using SalarioBrutoCalculo.Model;

namespace SalarioBrutoCalculo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main(string[] args){

            /*In below it's a application of windows form application*/

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new mainForm());

            double[] var = { 2800, 2900, 3200, 2000 };

            Console.Write("\nValor Bruto: " + var[3] + "\nLíquido");
            DeductionCLT actualTest = new DeductionCLT(var[3], 334.40);

            Console.Write("\nValor Bruto: " + var[0] + "\nLíquido");
            DeductionCLT firstTest = new DeductionCLT(var[0], 334.40);

            Console.Write("\nValor Bruto: " + var[1] + "\nLíquido");
            DeductionCLT secondTest = new DeductionCLT(var[1], 334.40);

            Console.Write("\nValor Bruto: " + var[2] + "\nLíquido");
            DeductionCLT thirdTest = new DeductionCLT(var[2], 334.40);

            /*--------------Comparativo------------------------*/

            Comparative comparActual = new Comparative(actualTest, secondTest);
            Console.ReadLine();
        }
    }
}
