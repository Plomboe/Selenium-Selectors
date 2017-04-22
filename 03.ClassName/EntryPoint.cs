
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        string url = "http://testing.todvachev.com/selectors/class-name/";
        string className = "testClass";


        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.ClassName(className));

        Console.WriteLine(element.Text);//Take it's text, and output it in the console

        driver.Quit();
    }
    
}

