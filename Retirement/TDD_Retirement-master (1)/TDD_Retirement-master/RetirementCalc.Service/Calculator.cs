using System;

namespace RetirementCalc.Service
{
    public class Calculator
    {

        // bring in dependency of Education expense
        public EducationExpense educationExpense { get; set; }

        public Calculator()
        {

        }
        public Calculator(EducationExpense eE)
        {
            this.educationExpense = eE;
        }
        

       public int RetirementYears(Client client)
       {

            int yearsToRetire = client.targetRetirementAge - client.currentAge;
            Console.WriteLine("yearsToRetire " + yearsToRetire);
            
            double netWorthAtRetirement = client.netWorth + (client.yearlySavingContribution * yearsToRetire);
            Console.WriteLine("netWorthAtRetirement " + netWorthAtRetirement);

            // if educational expense is there deduct that from netWorthAtRetirement
            if(this.educationExpense != null)
            {
                double totalEducationExpense = 0;
                totalEducationExpense = this.educationExpense.totalExpense();
                netWorthAtRetirement -= totalEducationExpense;
                Console.WriteLine("Net worth after education expense " + netWorthAtRetirement);
            }

            double yearlySpendingExpense = (client.desiredMonthlySpending * 12) + client.yearlyExpenses;
            Console.WriteLine("yearlySpendingExpense " + yearlySpendingExpense);


            double yearsFundWillLast = netWorthAtRetirement / yearlySpendingExpense;
            Console.WriteLine("yearsFundWillLast " + yearsFundWillLast);


            if (Convert.ToInt32(yearsFundWillLast) < 0)
                return 0;
            else
               return Convert.ToInt32(yearsFundWillLast);
       }
    }
}

