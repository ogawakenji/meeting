using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    using System.Diagnostics;
    using System.Threading;
    using System.Windows.Automation;
    using Winium.Cruciatus.Core;
    using Winium.Cruciatus.Extensions;

    class Program
    {
        private static readonly string PROCESS_NAME = @"calc";
        private static readonly int DEFAULT_WAIT_TIME = 1000;

        static void Main(string[] args)
        {
            Process process = Process.Start(PROCESS_NAME);
            try
            {
                // 電卓を起動します
                Thread.Sleep(DEFAULT_WAIT_TIME);
                var mainForm = AutomationElement.FromHandle(process.MainWindowHandle);

                // クリアボタン押します
                var btnClear = FindElementsByName(mainForm, "クリア").First()
                    .GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
                btnClear.Invoke();

                // 「7」ボタンを7回押します
                var btn7 = FindButtonsByName(mainForm, "7").First()
                    .GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;

                foreach (var _ in Enumerable.Repeat(0, 7))
                {
                    btn7.Invoke();
                }

                // 電卓に表示されている計算結果を、標準出力に表示します
                const string DISPLAY_AREA_ID = "150";
                var resultArea = FindElementById(mainForm, DISPLAY_AREA_ID);

                // 結果が想定通りかをチェックします
                const string EXPECTED_VALUE = "7777777";
                string actualValue = resultArea.Current.Name;

                Console.WriteLine("期待値 {0} に対して、結果値は {1} です", EXPECTED_VALUE, actualValue);
                Console.WriteLine("テスト結果は {0} です", EXPECTED_VALUE == actualValue ? "OK" : "NG");
            }
            finally
            {
                process.CloseMainWindow();
            }
        }

        // 指定したID属性に一致するAutomationElementを返します
        private static AutomationElement FindElementById(AutomationElement rootElement, string automationId)
        {
            return rootElement.FindFirst(
                TreeScope.Element | TreeScope.Descendants,
                new PropertyCondition(AutomationElement.AutomationIdProperty, automationId));
        }

        // 指定したName属性に一致するAutomationElementをすべて返します
        private static IEnumerable<AutomationElement> FindElementsByName(AutomationElement rootElement, string name)
        {
            return rootElement.FindAll(
                TreeScope.Element | TreeScope.Descendants,
                new PropertyCondition(AutomationElement.NameProperty, name))
                .Cast<AutomationElement>();
        }

        // 指定したName属性に一致するボタン要素をすべて返します
        private static IEnumerable<AutomationElement> FindButtonsByName(AutomationElement rootElement, string name)
        {
            const string BUTTON_CLASS_NAME = "Button";
            return from x in FindElementsByName(rootElement, name)
                   where x.Current.ClassName == BUTTON_CLASS_NAME
                   select x;
        }
    }
}
