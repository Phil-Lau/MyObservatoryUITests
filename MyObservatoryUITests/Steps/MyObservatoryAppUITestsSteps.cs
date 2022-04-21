using System;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace MyObservatoryUITests.Steps
{
    [Binding]
    public sealed class MyObservatoryAppUITestsSteps
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public MyObservatoryAppUITestsSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        private AndroidDriver<AppiumWebElement> GetAndroidDriver => _scenarioContext.Get<AndroidDriver<AppiumWebElement>>();

        [Given(@"I Launch the application")]
        public void GivenILaunchTheApplication()
        {
        }

        [Given(@"Agree to the T&C's on Disclaimer Screen")]
        public void GivenAgreeToTheTCSOnDisclaimerScreen()
        {
            GetAndroidDriver.FindElementById("hko.MyObservatory_v1_0:id/btn_agree").Click();
        }
        
        [Given(@"Agree to the T&C's on Policy Screen")]
        public void GivenAgreeToTheTCSOnPolicyScreen()
        {
            GetAndroidDriver.FindElementById("hko.MyObservatory_v1_0:id/btn_agree").Click();
        }

        [Given(@"Clicked OK to the Location Information Screen")]
        public void GivenClickedOkToTheLocationInformationScreen()
        {
            GetAndroidDriver.FindElementById("android:id/button1").Click();
        }

        [Given(@"Closed the What's new menu")]
        public void GivenClosedTheWhatSNewMenu()
        {
            GetAndroidDriver.FindElementById("hko.MyObservatory_v1_0:id/btn_friendly_reminder_skip").Click();
        }

        [When(@"I select the main hamburger menu")]
        public void WhenISelectTheMainHamburgerMenu()
        {
            GetAndroidDriver.FindElementByAccessibilityId("Navigate up").Click();
        }

        [When(@"I scroll down to tap the (.*)-Day Forecast option")]
        public void WhenIScrollDownToTapThe_DayForecastOption(int p0)
        {
            GetAndroidDriver.FindElement(MobileBy.AndroidUIAutomator(
                "new UiScrollable(new UiSelector().resourceId(\"hko.MyObservatory_v1_0:id/left_drawer\")).scrollIntoView("
                + "new UiSelector().text(\"9-Day Forecast\"))")).Click();
        }

        [Then(@"I can see weather forecast for tomorrow's date")]
        public void ThenICanSeeWeatherForecastForTomorrowSDate()
        {
            //Assert.AreEqual(DateTime.Today.AddDays(1).ToString("dd MMMM"), GetAndroidDriver.FindElementByXPath().FindElementByAccessibilityId("18 April"));
            //Assert.That(GetAndroidDriver.FindElementByXPath("//android.widget.LinearLayout").Text.Contains(DateTime.Today.AddDays(1).ToString("dd MMMM")));
        }

        [Then(@"I can see the temperature forecast for tomorrow")]
        public void ThenICanSeeTheTemperatureForecastForTomorrow()
        {
        }

        [Then(@"I can see the humidity forecast for tomorrow")]
        public void ThenICanSeeTheHumidityForecastForTomorrow()
        {
        }

        [Then(@"I can see a short description for tomorrow's weather")]
        public void ThenICanSeeAShortDescriptionForTomorrowSWeather()
        {
        }


    }
}
