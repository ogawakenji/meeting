using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codeer.Friendly.Windows;
using Codeer.Friendly.Dynamic;
using System.Diagnostics;
using System.Windows.Forms;

namespace FriendlyTestCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsAppFriend _app = new WindowsAppFriend(Process.Start(@"C:\dev\svn\trunk\meeting\meeting\SeleniumVB\WiniumVB\bin\Debug\WiniumVB.exe"));
            Process _process = Process.GetProcessById(_app.ProcessId);

            dynamic sampleForm = _app.Type<Control>().FromHandle(_process.MainWindowHandle);

            sampleForm.txtTest.Text = "123";

            sampleForm.ComboBox1.Text = "ドロップ３";

            System.Threading.Thread.Sleep(2000);

            _app.Dispose();
            _process.CloseMainWindow();


        }
    }
}
