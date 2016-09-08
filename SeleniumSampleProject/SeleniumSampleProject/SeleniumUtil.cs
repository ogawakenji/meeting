using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;


namespace SeleniumSampleProject
{
    class SeleniumUtil
    {
        #region Idで要素検索し操作

        public static void elementClickById(InternetExplorerDriver driver, string id)
        {
            driver.FindElementById(id).Click();
        }

        public static void elementSendKeysById(InternetExplorerDriver driver, string id,string text)
        {
            driver.FindElementById(id).SendKeys(text);
        }

        public static void elementSelectTextById(InternetExplorerDriver driver, string id ,string text )
        {
            IWebElement element = driver.FindElementById(id);
            SelectElement dropdown = new SelectElement(element);
            dropdown.SelectByText(text);

        }



        #endregion

        public static void browserScale(InternetExplorerDriver driver)
        {
            IWebElement element = driver.FindElement(By.TagName("html"));
            element.SendKeys(OpenQA.Selenium.Keys.Control + "+");
        }

        public static void browserScaleDown(InternetExplorerDriver driver)
        {
            IWebElement element = driver.FindElement(By.TagName("html"));
            element.SendKeys(OpenQA.Selenium.Keys.Control + "-");
        }

        public static void browserScaleClear(InternetExplorerDriver driver)
        {
            // IEのCtrl+0のデフォルトが125%の場合 JavaScriptを埋め込んで100%にする
            IWebElement element = driver.FindElement(By.TagName("html"));
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
