using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
			IWebDriver driver;
			ChromeOptions options = new ChromeOptions()
			options.addArgument("start-maximized");
			
			options.setExperimentalOption("excludeSwitches",Arrays.asList("disable-popup-blocking"));			
			
			ChromeDriver driver = new ChromeDriver(options);
			//driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl("http://www.google.com/ncr");
			
			Console.WriteLine(driver.Title);

			IWebElement query = driver.FindElement(By.Name("q"));
			query.SendKeys("TestingBot");
			query.Submit();
			Console.WriteLine(driver.Title);
			driver.Quit();
			
            // driver.Navigate().GoToUrl("https://makitweb.com/create-simple-login-page-with-php-and-mysql/");
            // Thread.Sleep(2000);
            // IWebElement ele = driver.FindElement(By.Name("s"));
            // ele.SendKeys("sql");
            // Thread.Sleep(2000);
            // IWebElement ele1 = driver.FindElement(By.ClassName("search-submit"));
            // Thread.Sleep(2000);
            // ele1.Click();
            // IWebElement ele2 = driver.FindElement(By.ClassName("entry-title"));
            // Thread.Sleep(2000);
            // while(ele2.Text.Contains("No search"))
            // {                
                // IWebElement ele3 = driver.FindElement(By.Name("s"));
                // ele3.SendKeys("hoho");
                // Thread.Sleep(2000);
                // IWebElement ele4 = driver.FindElement(By.ClassName("search-submit"));
                // Thread.Sleep(2000);
                // ele4.Click();
                // driver.Navigate().Refresh();
            // }
            // Thread.Sleep(30000);
            // driver.Close();
        }
    }
}
