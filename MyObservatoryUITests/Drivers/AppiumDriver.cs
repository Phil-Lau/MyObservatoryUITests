using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;

namespace MyObservatoryUITests.Drivers
{
    public class AppiumDriver
    {
        public AppiumDriver<AppiumWebElement> Driver { get; set; }

        public AndroidDriver<AppiumWebElement> InitializeAppium()
        {
            var appPath =
                @"C:\Users\philip.lau\source\repos\MyObservatoryUITests\myobservatory-4-20-4.apk";

            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel 5");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, appPath);
            driverOptions.AddAdditionalCapability("autoGrantPermissions", true);

            //var AppiumService = new AppiumServiceBuilder().WithIPAddress("127.0.0.1").UsingPort(4723).Build();
            //AppiumService.Start();

            //return new AndroidDriver<AppiumWebElement>(AppiumService, driverOptions);
            return new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"), driverOptions);
        }
    }
}
