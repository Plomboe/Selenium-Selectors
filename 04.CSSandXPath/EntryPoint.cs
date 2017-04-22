
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        string url = "http://testing.todvachev.com/selectors/css-path/";
        string cssPath = "#post-108 > div > fig img"; //This is wrong
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement cssPathElement;//Can't be initialized here, must be initialized in try catch block
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

        try
        {
            cssPathElement = driver.FindElement(By.CssSelector(cssPath));//Have to state this in try catch

            if (cssPathElement.Displayed)
            {
                GreenMessage("I can see the CSS Path Element!"); 
            }

        }
        catch (NoSuchElementException)
        {
            RedMessage("I can't see the CSS Path Element!");
        }

        
        if (xPathElement.Displayed)
        {
            GreenMessage("I can see the xPath Element");
        }
        else
        {
            RedMessage("I can't see the xPath Element");
        }

        driver.Quit();
    }
    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

