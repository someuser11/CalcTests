using CalculatorFramework.Calculator;
using CalculatorFramework.Calculator.Web;
using CalculatorFramework.Elements.WebImps;
using CalculatorFramework.Form.Web;

namespace CalcTests.Pages
{
    class SimpleCalcRuPage : BaseWebPage
    {
        public readonly string url = "https://simplecalc.ru";

        public WebCalculator Calculator { get; protected set; }
        public WebElement CalcBtnZero { get { return elements["Calc button 0"]; } }
        public WebElement CalcBtnOne { get { return elements["Calc button 1"]; } }
        public WebElement CalcBtnTwo { get { return elements["Calc button 2"]; } }
        public WebElement CalcBtnThree { get { return elements["Calc button 3"]; } }
        public WebElement CalcBtnFour { get { return elements["Calc button 4"]; } }
        public WebElement CalcBtnFive { get { return elements["Calc button 5"]; } }
        public WebElement CalcBtnSix { get { return elements["Calc button 6"]; } }
        public WebElement CalcBtnSeven { get { return elements["Calc button 7"]; } }
        public WebElement CalcBtnEight { get { return elements["Calc button 8"]; } }
        public WebElement CalcBtnNine { get { return elements["Calc button 9"]; } }
        public WebElement CalcBtnPoint { get { return elements["Calc button ."]; } }
        public WebElement CalcBtnAdd { get { return elements["Calc button +"]; } }
        public WebElement CalcBtnSubtract { get { return elements["Calc button -"]; } }
        public WebElement CalcBtnMultiply { get { return elements["Calc button *"]; } }
        public WebElement CalcBtnDivide { get { return elements["Calc button /"]; } }
        public WebElement CalcBtnEquals { get { return elements["Calc button ="]; } }
        public WebElement CalcFieldResult { get { return elements["Calc field result"]; } }

        public SimpleCalcRuPage() : base()
        {
            Calculator = new WebCalculator(new CalculatorBuilder<WebElement>().
                SetNumElements(CalcBtnZero, CalcBtnOne, CalcBtnTwo, CalcBtnThree, CalcBtnFour, CalcBtnFive, CalcBtnSix,
                    CalcBtnSeven, CalcBtnEight, CalcBtnNine, CalcBtnPoint)
                .SetActionElements(CalcBtnAdd, CalcBtnSubtract, CalcBtnMultiply, CalcBtnDivide, CalcBtnEquals)
                .SetResultElement(CalcFieldResult));
        }

        public SimpleCalcRuPage GoTo()
        {
            Driver.Navigate().GoToUrl(url);
            return this;
        }
    }
}
