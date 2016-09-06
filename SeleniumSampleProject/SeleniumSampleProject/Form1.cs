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
            InternetExplorerDriver webDriver = new InternetExplorerDriver();

            webDriver.Navigate().GoToUrl("https://ogawakenji.github.io/meeting/");

            var wait = new WebDriverWait(webDriver,TimeSpan.FromSeconds(10));

            System.Threading.Thread.Sleep(5000);

            webDriver.Quit();


        }
    }
}
