using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace SeleniumSampleProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            IWebDriver driver;

            switch (this.comboBox1.Text )
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

            driver.Navigate().GoToUrl("https://ogawakenji.github.io/meeting/");

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //SeleniumUtil.browserScale(driver);
            //SeleniumUtil.browserScale(driver);


            SeleniumUtil.elementSendKeysById(driver, "txtid1", "abcdefg");

            SeleniumUtil.elementSendKeysById(driver, "passid1", "1234567890");

            SeleniumUtil.elementSendKeysById(driver, "textareaid1", "abcdefg" + Environment.NewLine + "hijklmn");

            SeleniumUtil.elementSelectTextById(driver, "dropdownid1", "ドロップ２");

            System.Threading.Thread.Sleep(1000);

            IWebElement chkelement = driver.FindElement(By.Id("radioid1"));
            chkelement.SendKeys(OpenQA.Selenium.Keys.Space);

            System.Threading.Thread.Sleep(1000);

            //driver.FindElement(By.Id("radioid1")).Click();
            driver.FindElement(By.Id("chkid1")).SendKeys(OpenQA.Selenium.Keys.Space);

            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.Id("chkid2")).SendKeys(OpenQA.Selenium.Keys.Space);

            System.Threading.Thread.Sleep(1000);

            IWebElement element = driver.FindElement(By.Id("listid1"));
            SelectElement listMultiple = new SelectElement(element);
            listMultiple.SelectByText("リスト１");
            listMultiple.SelectByText("リスト３");


            //SeleniumUtil.browserScaleDown(driver);
            //SeleniumUtil.browserScaleDown(driver);
            //SeleniumUtil.browserScaleDown(driver);
            //SeleniumUtil.browserScaleDown(driver);

            //SeleniumUtil.browserScaleClear(driver);


            System.Threading.Thread.Sleep(5000);

            driver.Quit();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            ChromeOptions chOptions = new ChromeOptions();
            ChromeDriver webDriver = new ChromeDriver(chOptions);


            webDriver.Navigate().GoToUrl("https://ogawakenji.github.io/meeting/");

            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));

            webDriver.FindElementById("txtid1").SendKeys("abcdefg");


            //SeleniumUtil.browserScale(webDriver);
            //SeleniumUtil.browserScale(webDriver);


            //SeleniumUtil.elementSendKeysById(webDriver, "txtid1", "abcdefg");

            //SeleniumUtil.elementSendKeysById(webDriver, "passid1", "1234567890");

            //SeleniumUtil.elementSendKeysById(webDriver, "textareaid1", "abcdefg" + Environment.NewLine + "hijklmn");

            //SeleniumUtil.elementSelectTextById(webDriver, "dropdownid1", "ドロップ２");

            //SeleniumUtil.browserScaleDown(webDriver);
            //SeleniumUtil.browserScaleDown(webDriver);
            //SeleniumUtil.browserScaleDown(webDriver);
            //SeleniumUtil.browserScaleDown(webDriver);

            //SeleniumUtil.browserScaleClear(webDriver);


            System.Threading.Thread.Sleep(5000);

            webDriver.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChromeOptions chOptions = new ChromeOptions();
            ChromeDriver chDriver = new ChromeDriver(chOptions);


            chDriver.Navigate().GoToUrl("https://ogawakenji.github.io/meeting/todosample1.html");

            System.Threading.Thread.Sleep(5000);

            chDriver.FindElement(By.XPath("//input[@type='text']")).Clear();
            System.Threading.Thread.Sleep(2000);
            chDriver.FindElement(By.XPath("//input[@type='text']")).SendKeys("１１１１１１");
            System.Threading.Thread.Sleep(2000);
            chDriver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            System.Threading.Thread.Sleep(2000);
            chDriver.FindElement(By.XPath("//input[@type='text']")).Clear();
            System.Threading.Thread.Sleep(2000);
            chDriver.FindElement(By.XPath("//input[@type='text']")).SendKeys("２２２２２");
            System.Threading.Thread.Sleep(2000);
            chDriver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            System.Threading.Thread.Sleep(2000);
            chDriver.FindElement(By.XPath("//input[@type='text']")).Clear();
            System.Threading.Thread.Sleep(2000);
            chDriver.FindElement(By.XPath("//input[@type='text']")).SendKeys("３３３３３３");
            System.Threading.Thread.Sleep(2000);
            chDriver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            System.Threading.Thread.Sleep(2000);
            chDriver.FindElement(By.CssSelector("button")).Click();
            System.Threading.Thread.Sleep(2000);
            chDriver.FindElement(By.XPath("//tr[2]/td[2]/button")).Click();
            System.Threading.Thread.Sleep(2000);
            chDriver.FindElement(By.XPath("//tr[3]/td[2]/button")).Click();
            System.Threading.Thread.Sleep(2000);


            chDriver.Quit();

            //FirefoxProfile profile = new FirefoxProfile();
            //profile.Port = 9996;


            IWebDriver fiDriver = new FirefoxDriver();

            fiDriver.Navigate().GoToUrl("https://ogawakenji.github.io/meeting/todosample1.html");


            fiDriver.FindElement(By.XPath("//input[@type='text']")).Clear();
            System.Threading.Thread.Sleep(2000);
            fiDriver.FindElement(By.XPath("//input[@type='text']")).SendKeys("１１１１１１");
            System.Threading.Thread.Sleep(2000);
            fiDriver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            System.Threading.Thread.Sleep(2000);
            fiDriver.FindElement(By.XPath("//input[@type='text']")).Clear();
            System.Threading.Thread.Sleep(2000);
            fiDriver.FindElement(By.XPath("//input[@type='text']")).SendKeys("２２２２２");
            System.Threading.Thread.Sleep(2000);
            fiDriver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            System.Threading.Thread.Sleep(2000);
            fiDriver.FindElement(By.XPath("//input[@type='text']")).Clear();
            System.Threading.Thread.Sleep(2000);
            fiDriver.FindElement(By.XPath("//input[@type='text']")).SendKeys("３３３３３３");
            System.Threading.Thread.Sleep(2000);
            fiDriver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            System.Threading.Thread.Sleep(2000);
            fiDriver.FindElement(By.CssSelector("button")).Click();
            System.Threading.Thread.Sleep(2000);
            fiDriver.FindElement(By.XPath("//tr[2]/td[2]/button")).Click();
            System.Threading.Thread.Sleep(2000);
            fiDriver.FindElement(By.XPath("//tr[3]/td[2]/button")).Click();
            System.Threading.Thread.Sleep(2000);


            fiDriver.Quit();

            InternetExplorerOptions ieOptions = new InternetExplorerOptions();
            ieOptions.IgnoreZoomLevel = true;

            InternetExplorerDriver webDriver = new InternetExplorerDriver(ieOptions);
            webDriver.FindElement(By.XPath("//input[@type='text']")).Clear();
            System.Threading.Thread.Sleep(2000);
            webDriver.FindElement(By.XPath("//input[@type='text']")).SendKeys("１１１１１１");
            System.Threading.Thread.Sleep(2000);
            webDriver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            System.Threading.Thread.Sleep(2000);
            webDriver.FindElement(By.XPath("//input[@type='text']")).Clear();
            System.Threading.Thread.Sleep(2000);
            webDriver.FindElement(By.XPath("//input[@type='text']")).SendKeys("２２２２２");
            System.Threading.Thread.Sleep(2000);
            webDriver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            System.Threading.Thread.Sleep(2000);
            webDriver.FindElement(By.XPath("//input[@type='text']")).Clear();
            System.Threading.Thread.Sleep(2000);
            webDriver.FindElement(By.XPath("//input[@type='text']")).SendKeys("３３３３３３");
            System.Threading.Thread.Sleep(2000);
            webDriver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            System.Threading.Thread.Sleep(2000);
            webDriver.FindElement(By.CssSelector("button")).Click();
            System.Threading.Thread.Sleep(2000);
            webDriver.FindElement(By.XPath("//tr[2]/td[2]/button")).Click();
            System.Threading.Thread.Sleep(2000);
            webDriver.FindElement(By.XPath("//tr[3]/td[2]/button")).Click();
            System.Threading.Thread.Sleep(2000);



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedText  = "IE";

        }

        private void btnSample1_Click(object sender, EventArgs e)
        {
            // WebDriverを取得
            IWebDriver driver = SeleniumUtil.GetWebDriver(this.comboBox1.Text);

            // 指定したURLを開く
            driver.Navigate().GoToUrl("http://www.jmacsoft.co.jp/index.html");
            SeleniumUtil.elementClick(driver, driver.FindElement(By.Id("menu_02")));        // 事業内容
            SeleniumUtil.elementClick(driver, driver.FindElement(By.Id("menu_03")));        // 開発事例
            SeleniumUtil.elementClick(driver, driver.FindElement(By.Id("menu_04")));        // 会社情報
            SeleniumUtil.elementClick(driver, driver.FindElement(By.Id("menu_05")));        // 採用情報
            SeleniumUtil.elementClick(driver, driver.FindElement(By.Id("menu_01")));        // ホーム
            SeleniumUtil.elementClick(driver, driver.FindElement(By.CssSelector("a[href='relatis.html']")));        // relatis dataworks  
            foreach (IWebElement element in driver.FindElements(By.CssSelector("a[href='http://relatis.jp']")))     // relatisホームページ
            {
                SeleniumUtil.elementClick(driver, element);
                break;
            }
            SeleniumUtil.elementClick(driver, driver.FindElement(By.LinkText("データシェル")));                     // データシェル
            SeleniumUtil.elementClick(driver, driver.FindElement(By.LinkText("Hello world の例題")));               // Hello world
            SeleniumUtil.elementClick(driver, driver.FindElement(By.ClassName("button")));                          // 計算

            driver.Quit();   // 終了
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // WebDriverを取得
            IWebDriver driver = SeleniumUtil.GetWebDriver(this.comboBox1.Text);

            // 指定したURLを開く
            driver.Navigate().GoToUrl("http://www.jmacsoft.co.jp/relatis.html");
            System.Threading.Thread.Sleep(2000);

            foreach (IWebElement element in driver.FindElements(By.CssSelector("a[href='http://relatis.jp']")))
            {
                if (driver is InternetExplorerDriver)
                {
                    element.SendKeys(OpenQA.Selenium.Keys.Control);
                }
                element.SendKeys(OpenQA.Selenium.Keys.Enter);
                break;
            }
            System.Threading.Thread.Sleep(2000);

        }
    }
}
