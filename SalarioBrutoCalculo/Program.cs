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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new mainForm());

            Console.Write("\nValor Bruto: 2500\nLiquído");
            DeductionCLT firstTest = new DeductionCLT(2500, 334.40);

            Console.Write("\nValor Bruto: 2800\nLiquído");
            DeductionCLT secondTest = new DeductionCLT(2800, 334.40);

            Console.Write("\nValor Bruto: 2200\nLiquído");
            DeductionCLT thirdTest = new DeductionCLT(2200, 334.40);

            Console.ReadLine();
        }
    }
}
