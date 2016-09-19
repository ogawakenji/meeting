using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Winium;
using Winium.Cruciatus.Core;
using System.Windows.Automation;
using Winium.Cruciatus.Extensions;

namespace WiniumSampleProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var options = new DesktopOptions();
            options.ApplicationPath = @"C:\Windows\System32\notepad.exe";
            //Winium.Desktop.Driver.exeの場所指定
            WiniumDriver driver = new WiniumDriver(@"C:\dev\svn\trunk\meeting\meeting\WiniumSampleProject\WiniumSampleProject\bin\Debug", options);
            //driver.FindElementByClassName("Edit").SendKeys("Hello World.");
            driver.FindElementById("15").SendKeys("aiueo");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var calc = new Winium.Cruciatus.Application("C:/windows/system32/calc.exe");
            calc.Start();

            var winFinder = By.Name("Calculator").AndType(ControlType.Window);
            var win = Winium.Cruciatus.CruciatusFactory.Root.FindElement(winFinder);
            var menu = win.FindElementByUid("MenuBar").ToMenu();

            menu.SelectItem("View$Scientific");
            menu.SelectItem("View$History");

            win.FindElementByUid("132").Click(); // 2
            win.FindElementByUid("93").Click(); // +
            win.FindElementByUid("134").Click(); // 4
            win.FindElementByUid("97").Click(); // ^
            win.FindElementByUid("138").Click(); // 8
            win.FindElementByUid("121").Click(); // =

            calc.Close();
        }
    }
}
