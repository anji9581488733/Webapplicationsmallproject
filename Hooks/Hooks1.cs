using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebCalculator.StepDefinitions;
using WebCalulator.Features;

namespace WebCalulator.Hooks
{
    [Binding]
    public sealed class Hooks1
    { 
        private readonly ScenarioContext scenarioContext;
        private IWebDriver _driver;
       // private ChromeDriver chromeDriver;
        //public WebDriver Driver;
        //public Hooks1(ScenarioContext _scenariocontext)
        //{
        //    scenarioContext = _scenariocontext;

        //}
        //public Hooks1(WebDriver _webdriver)
        //{
        //    Driver = _webdriver;
        //}



        [BeforeScenario("@mytag")]
        public void BeforeScenarioWithTag()
        {
           
           YoutubeSearchFeatureFeature driver1 = new YoutubeSearchFeatureFeature();
            //driver1.YoutubeShouldSearchForTheGivenKeywordAndShouldNavigateToSearchResultsPage();
            //Hooks1 seleniumdriver = new Hooks1(scenarioContext);
            //scenarioContext.Set(seleniumdriver, "SeleniumDriver");
            ////IWebDriver driver = _driver;
            //driver.As<IWebDriver>();

        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {


        }

        [AfterScenario]
        public void AfterScenario()
        {
            //Console.WriteLine("Selenium webdriver quit");
            //scenarioContext.Get<IWebDriver>("driver").Quit();



        }
    }
}