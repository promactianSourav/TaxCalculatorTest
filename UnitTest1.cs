using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTaxCalculator;

namespace TaxCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod,Description("salary < 0")]
        public void SalaryLessThanZero()
        {
            double Salary = -10000;
            int Age = 58;
            var taxCal = new TaxCalculator(Salary, Age);
            Assert.AreEqual(taxCal.CalculateTax(),0);
        }

        [TestMethod,Description("salary = 0")]
        public void SalaryEqualToZero()
        {
            double Salary = 0;
            int Age = 58;
            var taxCal = new TaxCalculator(Salary, Age);
            Assert.AreEqual(taxCal.CalculateTax(), 0);
        }

        [TestMethod,Description("age < 0")]
        public void AgeLessThanZero()
        {
            double Salary = 250000;
            int Age = -49;
            TaxCalculator taxCal = new TaxCalculator(Salary, Age);
            Assert.AreEqual(taxCal.CalculateTax(), 0);

        }

        [TestMethod,Description("age = 0")]
        public void AgeEqualToZero()
        {
            double Salary = 250000;
            int Age = 0;
            TaxCalculator taxCal = new TaxCalculator(Salary, Age);
            Assert.AreEqual(taxCal.CalculateTax(), 0);
        }

        [TestMethod, Description("age <= 60 and salary <= 250000")]
        public void AgeLessThanSixtyAndSalaryLessthanTwoPointFiveLakh()
        {
            double Salary = 200000;
            int Age = 58;
            TaxCalculator taxCal = new TaxCalculator(Salary, Age);
            Assert.AreEqual(taxCal.CalculateTax(), 0);
        }
        [TestMethod, Description("age <= 60 and salary <= 500000")]
        public void AgeLessThanSixtyAndSalaryLessthanFiveLakh()
        {
            double Salary = 400000;
            int Age = 58;
            TaxCalculator taxCal = new TaxCalculator(Salary, Age);
            Assert.AreEqual(taxCal.CalculateTax(), 7500);
        }
        [TestMethod, Description("age <= 60 and salary <= 1000000")]
        public void AgeLessThanSixtyAndSalaryLessthanTenLakh()
        {
            double Salary = 800000;
            int Age = 58;
            TaxCalculator taxCal = new TaxCalculator(Salary, Age);
            Assert.AreEqual(taxCal.CalculateTax(), 72500);
        }
        [TestMethod, Description("age <= 60 and salary > 1000000")]
        public void AgeLessThanSixtyAndSalaryMoreThanTenLakh()
        {
            double Salary = 1200000;
            int Age = 58;
            TaxCalculator taxCal = new TaxCalculator(Salary, Age);
            Assert.AreEqual(taxCal.CalculateTax(), 172500);
        }

        [TestMethod, Description("age <= 80 and salary <= 300000")]
        public void AgeLessThanEightyAndSalaryLessthanThreeLakh()
        {
            double Salary = 250000;
            int Age = 75;
            TaxCalculator taxCal = new TaxCalculator(Salary, Age);
            Assert.AreEqual(taxCal.CalculateTax(), 0);
        }

        [TestMethod, Description("age <= 80 and salary <= 500000")]
        public void AgeLessThanEightyAndSalaryLessthanFiveLakh()
        {
            double Salary = 400000;
            int Age = 75;
            TaxCalculator taxCal = new TaxCalculator(Salary, Age);
            Assert.AreEqual(taxCal.CalculateTax(), 5000);
        }
        [TestMethod, Description("age <= 80 and salary <= 1000000")]
        public void AgeLessThanEightyAndSalaryLessthanTenLakh()
        {
            double Salary = 800000;
            int Age = 75;
            TaxCalculator taxCal = new TaxCalculator(Salary, Age);
            Assert.AreEqual(taxCal.CalculateTax(), 70000);
        }
        [TestMethod, Description("age <= 80 and salary > 1000000")]
        public void AgeLessThanEightyAndSalaryMorethanTenLakh()
        {
            double Salary = 1200000;
            int Age = 75;
            TaxCalculator taxCal = new TaxCalculator(Salary, Age);
            Assert.AreEqual(taxCal.CalculateTax(), 170000);
        }

        [TestMethod, Description("age > 80 and salary <= 500000")]
        public void AgeMoreThanEightyAndSalaryLessthanFiveLakh()
        {
            double Salary = 400000;
            int Age = 85;
            TaxCalculator taxCal = new TaxCalculator(Salary, Age);
            Assert.AreEqual(taxCal.CalculateTax(), 0);
        }
        [TestMethod, Description("age > 80 and salary <= 1000000")]
        public void AgeMoreThanEightyAndSalaryLessthanTenLakh()
        {
            double Salary = 800000;
            int Age = 85;
            TaxCalculator taxCal = new TaxCalculator(Salary, Age);
            Assert.AreEqual(taxCal.CalculateTax(), 60000);
        }
        [TestMethod, Description("age > 80 and salary > 1000000")]
        public void AgeMoreThanEightyAndSalaryMorethanTenLakh()
        {
            double Salary = 1200000;
            int Age = 85;
            TaxCalculator taxCal = new TaxCalculator(Salary, Age);
            Assert.AreEqual(taxCal.CalculateTax(), 160000);
        }
    }
}
