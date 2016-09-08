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
using OpenQA.Selenium.Support.UI;


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
            // IEの場合 すべてのゾーンで保護モードを有効にするチェックONに設定する必要がある。
            InternetExplorerOptions ieOptions = new InternetExplorerOptions();
            ieOptions.IgnoreZoomLevel = true;

            InternetExplorerDriver webDriver = new InternetExplorerDriver(ieOptions);

            webDriver.Navigate().GoToUrl("https://ogawakenji.github.io/meeting/");

            var wait = new WebDriverWait(webDriver,TimeSpan.FromSeconds(10));

            SeleniumUtil.browserScale(webDriver);
            SeleniumUtil.browserScale(webDriver);


            SeleniumUtil.elementSendKeysById(webDriver, "txtid1", "abcdefg");

            SeleniumUtil.elementSendKeysById(webDriver, "passid1", "1234567890");

            SeleniumUtil.elementSendKeysById(webDriver, "textareaid1", "abcdefg" + Environment.NewLine + "hijklmn");

            SeleniumUtil.elementSelectTextById(webDriver, "dropdownid1", "ドロップ２");

            SeleniumUtil.browserScaleDown(webDriver);
            SeleniumUtil.browserScaleDown(webDriver);
            SeleniumUtil.browserScaleDown(webDriver);
            SeleniumUtil.browserScaleDown(webDriver);

            SeleniumUtil.browserScaleClear(webDriver);


            System.Threading.Thread.Sleep(5000);

            webDriver.Quit();


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
    }
}
