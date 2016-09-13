Imports OpenQA.Selenium
Imports OpenQA.Selenium.IE
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Firefox
'Imports OpenQA.Selenium.Support.UI
Imports OpenQA.Selenium.Interactions
Imports OpenQA.Selenium.Winium

Imports Codeer.Friendly.Windows
Imports Codeer.Friendly.Dynamic





Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim driver As IWebDriver
        Dim ieOption As InternetExplorerOptions = New InternetExplorerOptions
        ieOption.IgnoreZoomLevel = True
        driver = New InternetExplorerDriver(ieOption)

        driver.Navigate().GoToUrl("https://ogawakenji.github.io/meeting/")

        driver.FindElement(By.Id("txtid1")).SendKeys("adcdefg")

        driver.Quit()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim options = New DesktopOptions()
        options.ApplicationPath = "C:\dev\svn\trunk\meeting\meeting\SeleniumVB\WiniumVB\bin\Debug\WiniumVB.exe"
        Dim driver As WiniumDriver = New WiniumDriver("C:\dev\svn\trunk\meeting\meeting\SeleniumVB\SeleniumVB\bin\Debug", options)
        driver.FindElementByClassName("txtTest").SendKeys("abcde")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim _app As WindowsAppFriend
        _app = New WindowsAppFriend(Process.Start("C:\dev\svn\trunk\meeting\meeting\SeleniumVB\WiniumVB\bin\Debug\WiniumVB.exe"))
        Dim _process As Process
        _process = Process.GetProcessById(_app.ProcessId)






        _app.Dispose()
        _process.CloseMainWindow()



    End Sub
End Class
