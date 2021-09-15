using System;

namespace SalaryCalculator
{
    class Output
    {
        public double GrossWage { get; set; } //The total amount before you withhold taxes and other deductions
        public double NetSalary { get; set; }
        public double InssTax { get; set; }
        public double IrpfTax { get; set; }
        public double FgtsEarn { get; set; }

        public Output(double Salary)
        {
            CalculateNetSalary(Salary);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(String.Format("Salário bruto: R$ {0:0.##}", this.GrossWage));
            Console.WriteLine(String.Format("Salário líquido : R$ {0:0.##}", this.NetSalary));
            Console.WriteLine(String.Format("Taxa INSS : R$ {0:0.##}", this.InssTax));
            Console.WriteLine(String.Format("Taxa IRPF: R$ {0:0.##}", this.IrpfTax));
            Console.WriteLine(String.Format("FGTS: R$ {0:0.##}", this.FgtsEarn));
            Console.WriteLine("-------------------------------------------------------\n\n");
        }

        public void CalculateNetSalary(double GrossWage)
        {
            this.GrossWage = GrossWage;
            this.FgtsEarn = GrossWage * 0.08;
            this.InssTax = CalculateInssTax(GrossWage);
            this.IrpfTax = CalculateIrpfTax(GrossWage - this.InssTax);
            this.NetSalary = (GrossWage - this.InssTax) - this.IrpfTax;
        }

        public double CalculateIrpfTax(double GrossWage)
        {
            if (GrossWage <= 1903.98)
                return 0;
            else if (GrossWage >= 1903.99 && GrossWage <= 2826.65)
                return GrossWage * 0.075 - 142.80;
            else if (GrossWage >= 2026.66 && GrossWage <= 3751.05)
                return GrossWage * 0.15 - 354.80;
            else if (GrossWage >= 3751.06 && GrossWage <= 4664.68)
                return GrossWage * 0.225 - 636.13;
            else
                return GrossWage * 0.275 - 869.36;
        }

        public double CalculateInssTax(double GrossWage)
        {
            if (GrossWage <= 1100)
                return 1100 * 0.075;
            else if (GrossWage >= 1101.01 && GrossWage <= 2203.48)
                return (GrossWage * 0.09) - 16.50;
            else if (GrossWage >= 2089.61 && GrossWage <= 3305.22)
                return (GrossWage * 0.12) - 82.61;
            else
                return (GrossWage * 0.14) - 148.72;
        }

    }
}

