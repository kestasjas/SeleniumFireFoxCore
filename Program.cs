using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumFireFoxCore
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver ffox = new FirefoxDriver(
                           Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), 
                           new FirefoxOptions());

            ffox.Manage().Window.Maximize();
            ffox.Navigate().GoToUrl("https://www.google.com/");
            ffox.Quit();
        }
    }
}
