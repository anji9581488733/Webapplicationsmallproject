using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebCalulator.Drivers
{

    public class WebDriver
    {

        // private String searchKeyword;

        private ChromeDriver chromeDriver;
        IWebDriver driver;
        public WebDriver()
        {
            chromeDriver = new ChromeDriver(@"C:\\Users\\xxdayred\\Downloads\\chromedriver_win32\\chromedriver.exe");
            //chromeDriver = new ChromeDriver(@"C:\\Users\\xxdayred\\Downloads\\chromedriver_win32\\chromedriver.exe");
            return;
        
        }

       


    }
}
