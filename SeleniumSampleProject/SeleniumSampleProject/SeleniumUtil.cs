using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace SeleniumSampleProject
{
    class SeleniumUtil
    {
        private static int SleepTime = 2000;
         
        public static IWebDriver GetWebDriver(string browser )
        {

            IWebDriver driver;

            switch (browser)
            {
                case "IE":
                    // IEの場合 すべてのゾーンで保護モードを有効にするチェックONに設定する必要がある。
                    InternetExplorerOptions ieOptions = new InternetExplorerOptions();
                    ieOptions.IgnoreZoomLevel = true;
                    driver = new InternetExplorerDriver(ieOptions);
                    break;

                case "Chrome":
                    ChromeOptions chOptions = new ChromeOptions();
                    driver = new ChromeDriver(chOptions);
                    break;

                case "Firefox":
                    driver = new FirefoxDriver();
                    break;

                default:
                    // IEの場合 すべてのゾーンで保護モードを有効にするチェックONに設定する必要がある。
                    InternetExplorerOptions ieOptions2 = new InternetExplorerOptions();
                    ieOptions2.IgnoreZoomLevel = true;
                    driver = new InternetExplorerDriver(ieOptions2);
                    break;

            }

            return driver;
        }

        #region Idで要素検索し操作

        public static void elementClickById(IWebDriver driver, string id)
        {
            //driver.FindElementById(id).Click();
            if (driver is InternetExplorerDriver)
            {
                driver.FindElement(By.Id(id)).SendKeys(OpenQA.Selenium.Keys.Control);
            }
            driver.FindElement(By.Id(id)).Click();


        }

        public static void elementSendKeysById(IWebDriver driver, string id,string text)
        {
            //driver.FindElementById(id).SendKeys(text);
            driver.FindElement(By.Id(id)).SendKeys(text);
        }

        public static void elementSelectTextById(IWebDriver driver, string id ,string text )
        {
            //IWebElement element = driver.FindElementById(id);
            IWebElement element = driver.FindElement(By.Id(id));
            SelectElement dropdown = new SelectElement(element);
            dropdown.SelectByText(text);

        }


        public static void elementClick(IWebDriver driver ,IWebElement element)
        {
            if (driver is InternetExplorerDriver)
            {
                if (element.TagName == "a")
                {
                    element.SendKeys(OpenQA.Selenium.Keys.Control);
                    element.SendKeys(OpenQA.Selenium.Keys.Enter);
                }
                else
                {
                    element.SendKeys(OpenQA.Selenium.Keys.Control);
                    element.Click();
                }
            }
            else
            {
                element.Click();

            }

            System.Threading.Thread.Sleep(SleepTime);

        }

        public static void elementSenKeys(IWebDriver driver ,IWebElement element,string text)
        {

            element.SendKeys(text);

        }


        #endregion

        public static void browserScale(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.TagName("body"));
            //element.SendKeys(OpenQA.Selenium.Keys.Control + "+");

            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Click();
            actions.SendKeys(OpenQA.Selenium.Keys.Control + "+").Perform();
            //actions.SendKeys(OpenQA.Selenium.Keys.Control).SendKeys("+").Perform();
            //actions.Build().Perform();

        }

        public static void browserScaleDown(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.TagName("body"));
            element.SendKeys(OpenQA.Selenium.Keys.Control + "-");
        }

        public static void browserScaleClear(IWebDriver driver)
        {
            // IEのCtrl+0のデフォルトが125%の場合 JavaScriptを埋め込んで100%にする
            IWebElement element = driver.FindElement(By.TagName("body"));
            element.SendKeys(OpenQA.Selenium.Keys.Control + "0");

            System.Threading.Thread.Sleep(1000);

            ((IJavaScriptExecutor)driver).ExecuteScript("document.body.style.zoom = '100%';");

            System.Threading.Thread.Sleep(1000);

            ((IJavaScriptExecutor)driver).ExecuteScript("document.body.style.zoom = '70%';");

            System.Threading.Thread.Sleep(1000);

            ((IJavaScriptExecutor)driver).ExecuteScript("document.body.style.zoom = '100%';");

        }

    }
}
