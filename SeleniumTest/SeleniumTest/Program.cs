using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

using (IWebDriver driver = new EdgeDriver())
{
    driver.Navigate().GoToUrl("https://mts-the-encoder.github.io/Form/");

    var name = driver.FindElement(By.Id("name"));
    name.SendKeys("Rick Sanchez");

    var email = driver.FindElement(By.Id("email"));
    email.SendKeys("rick@email.com");

    var message = driver.FindElement(By.Id("message"));
    message.SendKeys("Wubba Lubba Dub Dub.");

    var button = driver.FindElement(By.CssSelector("input[type='submit']"));
    button.Click();

    Console.WriteLine("DEU BOM!");

    driver.Quit();
}

Console.ReadLine();