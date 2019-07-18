using NUnit.Framework;
using RetirementCalc.Service;


namespace Tests
{
    public class Tests
    {
        [Test]
        public void RetirementCalculatorReturns_TypeInt()
        {
            var client = new Client
            {
                currentAge = 47,
                targetRetirementAge = 65,
                netWorth = 500000,
                desiredMonthlySpending = 2500,
                yearlySavingContribution = 22000,
                yearlyExpenses = 55000
            };
            var calculator = new Calculator();
            var output = calculator.RetirementYears(client);
            Assert.That(output, Is.TypeOf<int>());
        }

        [Test]
        public void a_SimpleClientReturns_CorrectYears()
        {
            var client = new Client
            {
                currentAge = 47,
                targetRetirementAge = 65,
                netWorth = 350000,
                desiredMonthlySpending = 2500,
                yearlySavingContribution = 22000,
                yearlyExpenses = 35000
            };
            var calculator = new Calculator();
            var actual = calculator.RetirementYears(client);
            var expected = 11;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void b_SimpleClientReturns_CorrectYears()
        {
            var client = new Client
            {
                currentAge = 50,
                targetRetirementAge = 65,
                netWorth = 500000,
                desiredMonthlySpending = 2500,
                yearlySavingContribution = 22000,
                yearlyExpenses = 55000
            };
            var calculator = new Calculator();
            var actual = calculator.RetirementYears(client);
            var expected = 10;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ComplicatedClientReturns_CorrectYears()// client with educational expense to be paid off before retirement
        {
            var client = new Client
            {
                currentAge = 30,
                targetRetirementAge = 65,
                netWorth = 95000,
                desiredMonthlySpending = 2500,
                yearlySavingContribution = 8000,
                yearlyExpenses = 40000
            };
            var educationExpense = new EducationExpense
            {
                amount = 10000,
                numberofYears = 10,


            };
            var calculator = new Calculator(educationExpense);
           
            var actual = calculator.RetirementYears(client);
            var expected = 4;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void NotEnoughForRetirementReturns_Zero()
        {
            var client = new Client
            {
                currentAge = 45,
                targetRetirementAge = 65,
                netWorth = 65000,
                desiredMonthlySpending = 3000,
                yearlySavingContribution = 7500,
                yearlyExpenses = 50000
            };
            var educationExpense = new EducationExpense
            {
                amount = 20000,
                numberofYears = 15,


            };
            var calculator = new Calculator(educationExpense);

            var actual = calculator.RetirementYears(client);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfAlreadyRetiredAssumeNoAdditionalIncome_SavingsWillBeGained()
        {

        }

        [Test]
        public void AddExpenseReturns_CorrectYears()
        {

        }

    }
}