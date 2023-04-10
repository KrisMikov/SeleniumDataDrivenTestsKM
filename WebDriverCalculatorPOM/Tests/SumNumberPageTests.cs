using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverCalculatorPOM.Pages;

namespace WebDriverCalculatorPOM.Tests
{
    public class SumNumberPageTests
    {
        private WebDriver driver;
        private SumNumbersPage page;

        [SetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            this.page = new SumNumbersPage(driver);
            
        }
        [TearDown]
        public void CloseVrowser()
        {
            driver.Quit();
        }
 [Test]
       
        public void Test_SumNumberPage_Check_Title()
        {
            page.Open();
            Assert.That(page.GetPageTitle, Is.EqualTo("Number Calculator"));
        }

        [Test]
        public void Test_Sum_Two_Positive_Numbers()
        {
            page.Open();
            var actualResult = page.CalculateNumbers("5", "+", "15");
            Assert.That(actualResult, Is.EqualTo("Result: 20"));
        }

        [Test]
        public void Test_Multiply_Two_Positive_Numbers()
        {
            page.Open();
            var actualResult = page.CalculateNumbers("5", "*", "5");
            Assert.That(actualResult, Is.EqualTo("Result: 25"));
        }
    }
}