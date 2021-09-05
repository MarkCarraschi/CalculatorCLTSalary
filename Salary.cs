using System;

namespace SalaryCalculator
{
    class Salary
    {
        public double GrossSalary { get; set; }
        public double InssTax { get; set; }
        public double IrpfTax { get; set; }
        public double FgtsTax { get; set; }
        public double NetSalary { get; set; }

        public Salary(double Salary)
        {
            CalculateNetSalary(Salary);
            Console.WriteLine(this.NetSalary);
            Console.WriteLine(String.Format("{0}", this.NetSalary));
            //Console.ReadLine();
        }

        public void CalculateNetSalary(double GrossSalary)
        {
            this.InssTax = CalculateInssTax(GrossSalary);
            double NewSalary = GrossSalary - this.InssTax;
            this.IrpfTax = CalculateIrpfTax(NewSalary);
            this.NetSalary = NewSalary - this.IrpfTax;
        }

        public double CalculateIrpfTax(double GrossSalary)
        {
            if (GrossSalary <= 1903.98)
                return 0;
            else if (GrossSalary >= 1903.99 && GrossSalary <= 2826.65)
                return GrossSalary * 0.075 - 142.80;
            else if (GrossSalary >= 2026.66 && GrossSalary <= 3751.05)
                return GrossSalary * 0.15 - 354.80;
            else if (GrossSalary >= 3751.06 && GrossSalary <= 4664.68)
                return GrossSalary * 0.225 - 636.13;
            else
                return GrossSalary * 0.275 - 869.36;
        }

        public double CalculateInssTax(double GrossSalary)
        {
            if (GrossSalary <= 1100)
                return GrossSalary * 0.075;
            else if (GrossSalary >= 1101.01 && GrossSalary <= 2203.48)
                return GrossSalary * 0.09;
            else if (GrossSalary >= 2089.61 && GrossSalary <= 3305.22)
                return GrossSalary * 0.12;
            else if (GrossSalary >= 3305.23 && GrossSalary <= 6433.57)
                return GrossSalary * 0.14;
            else
                return 751.96;
        }

    }
}

