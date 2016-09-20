using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // InternetExplorerDriver
            InternetExplorerOptions ieOptions = new InternetExplorerOptions();
            ieOptions.IgnoreZoomLevel = true;
            IWebDriver IEDriver = new InternetExplorerDriver(ieOptions);

            Execute(IEDriver);

            // ChromeDriver
            IWebDriver ChromeDriver = new ChromeDriver();

            Execute(ChromeDriver);

            // FirefoxDriver
            IWebDriver FirefoxDriver = new FirefoxDriver();

            Execute(FirefoxDriver);
               
        }

        private void Execute(IWebDriver driver)
        {

            //Googleの画像検索にアクセス
            driver.Navigate().GoToUrl("https://www.google.co.jp/imghp");

            System.Threading.Thread.Sleep(2000); //待機

            //  最大化
            driver.Manage().Window.Maximize();

            System.Threading.Thread.Sleep(2000); //待機

            // 検索ボックスの要素を取得
            IWebElement element1 = driver.FindElement(By.Name("q"));

            // 検索ボタンの要素を取得
            IWebElement element2 = driver.FindElement(By.Name("btnG"));

            // 検索ボックスに値を設定
            element1.SendKeys("パンケーキ");

            System.Threading.Thread.Sleep(1000); //待機

            // 検索ボタンクリック
            if (driver is InternetExplorerDriver)
            {
                element2.SendKeys(OpenQA.Selenium.Keys.Enter);
            }
            else
            {
                element2.Click();
            }

            System.Threading.Thread.Sleep(5000); //待機

            string currentFilepath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), DateTime.Now.ToString("yyyyMMddhhmmss") + ".jpg");

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(currentFilepath, ImageFormat.Jpeg);

            System.Threading.Thread.Sleep(2000); //待機

            // 終了
            driver.Quit();

        }


    }
}
