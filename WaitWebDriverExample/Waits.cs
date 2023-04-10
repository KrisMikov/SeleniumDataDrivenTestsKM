using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net.WebSockets;

namespace WaitWebDriverExample
{
    public class WebDriverWaitTests
    {
        private WebDriver driver;
        private const string BaseUrl = "http://www.uitestpractice.com/";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = BaseUrl;
        }

        [Test]
        public void Wait_Thred_Sleep()
        {
            var AjaxLink = driver.FindElement(By.LinkText("AjaxCall"));
            AjaxLink.Click();

            var internalAjaxLink = driver.FindElement(By.LinkText("This is a Ajax link"));
            internalAjaxLink.Click();

            var textElementText = driver.FindElement(By.ClassName("ContactUs")).Text;
            Assert.That(textElementText.Contains("Selenium is a portable software testing"));

            driver.Quit();
        }
    }
}