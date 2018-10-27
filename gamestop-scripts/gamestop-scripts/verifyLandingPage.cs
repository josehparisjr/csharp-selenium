using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace gamestop_scripts
{
    [TestFixture]
    public class verifyLandingPage
    {

        [Test]
        public void siteHeaderIsDisplayed()
        {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("http://gamestop.com");
            IWebElement header = browser.FindElement(By.Id("Img1"));
    
            Assert.True(header.Displayed);
            browser.Close();
        }
    }
}