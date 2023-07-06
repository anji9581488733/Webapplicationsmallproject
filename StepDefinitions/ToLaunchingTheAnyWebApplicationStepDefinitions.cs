using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace WebCalculator.StepDefinitions
{  
    
    [Binding]
    
    public class YoutubeSearchFeatureSteps
    {
        private ChromeDriver chromeDriver;
        IWebDriver driver;

        public YoutubeSearchFeatureSteps()
        {
            WebDriver drive = new WebDriver();
            

        }
       
        [Given(@"I have navigated to youtube website")]
        public void GivenIHaveNavigatedToYoutubeWebsite()
        {
            
            YoutubeSearchFeatureSteps drive = new YoutubeSearchFeatureSteps();
            //WebDriver webDriver = new WebDriver();
            chromeDriver.Navigate().GoToUrl("https://www.google.com/");
            Assert.IsTrue(chromeDriver.Title.ToLower().Contains("google"));


                //webDriver.Navigate().GoToUrl("https://www.google.com/");
                // Assert.IsTrue(chromeDriver.Title.ToLower().Contains("google"));

            
            //var chromeDriver = new ChromeDriver();

        }

        [When(@"I have entered India as search keyword")]
        public void GivenIHaveEnteredIndiaAsSearchKeyword()
        {
            


        }

        [When(@"I press the search button")]
        public void WhenIPressTheSearchButton()
        {
            

        }

        [Then(@"I should be navigate to search results page")]
        public void ThenIShouldBeNavigateToSearchResultsPage()
        {

            System.Threading.Thread.Sleep(2000);
            // After search is complete the keyword should be present in url as well as page title`
            //    Assert.IsTrue(chromeDriver.Url.ToLower().Contains(searchKeyword));
            //    Assert.IsTrue(chromeDriver.Title.ToLower().Contains(searchKeyword));
        }
         public void Dispose()
         {
            if (chromeDriver != null)
            {
                chromeDriver.Dispose();
                chromeDriver = null;
            }
         }
    }
}








