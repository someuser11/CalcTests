using CalcTests.Pages;
using CalculatorFramework.Parameters;
using CalculatorFramework.Parameters.Web;
using CalculatorFramework.Test.Web;
using NUnit.Framework;

namespace CalcTests.Tests
{
    [TestFixture]
    public class SimpleCalcRuTest : BaseTest
    {
        [Test]
        [Parallelizable]
        public void Test([ValueSource(typeof(WebParameters), "DriverToRun")] DriverType driverType,
            [ValueSource(typeof(WebParameters), "ExpressionToRun")] CalcExpression expression)
        {
            TestInitialize(
                name: "Test simplecalc.ru",
                driverType: driverType,
                expression: expression);
            Assert.AreEqual(
                expression.ExpectedResult,
                new SimpleCalcRuPage().GoTo().Calculator.Execute(expression.Actions).Result);
        }
    }
}
