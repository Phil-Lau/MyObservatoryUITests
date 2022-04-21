using MyObservatoryUITests.Drivers;
using TechTalk.SpecFlow;

namespace MyObservatoryUITests.Hooks
{
    [Binding]
    class InitializeHook
    {

        private readonly ScenarioContext _scenarioContext;

        public InitializeHook(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario()]
        public void Initialize()
        {
            AppiumDriver appiumDriver = new AppiumDriver();
            //appiumDriver.InitializeAppium();

            
            _scenarioContext.Set(appiumDriver.InitializeAppium());
        }

    }
}
