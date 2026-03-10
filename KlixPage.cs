using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace vjezba
{
    public class KlixPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public KlixPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void Otvori()
        {
            driver.Navigate().GoToUrl("https://www.klix.ba");
            wait.Until(d => d.FindElement(By.TagName("body")).Displayed);
        }

        public void SkrolajNaDno()
{
    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
    
    long lastHeight = 0;
    while (true)
    {
        js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        Thread.Sleep(1500);
        
        long newHeight = (long)js.ExecuteScript("return document.body.scrollHeight;");
        if (newHeight == lastHeight) break;
        lastHeight = newHeight;
    }
}
        public void KlikniNaSearch ()
        {
            driver.FindElement(By.Id("sidebar-open")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("sidebar-search")).SendKeys("Sarajevo");
            driver.FindElement(By.Id("sidebar-search")).SendKeys(Keys.Enter);
            Thread.Sleep(3000);

        }

        public void KlikniNaVijesti()
        {
            wait.Until(d => d.FindElement(By.LinkText("Vijesti")).Displayed);
        
            driver.FindElement(By.LinkText("Vijesti")).Click();
            Thread.Sleep(5000);
        }


        public void KlikniNaBiznis()
        {
            wait.Until(d => d.FindElement(By.LinkText("Biznis")).Displayed);
            
            driver.FindElement(By.LinkText("Biznis")).Click();
            Thread.Sleep(5000);
        }
        public void KlikniNaSport ()
        {
            wait.Until(d => d.FindElement(By.LinkText("Sport")).Displayed);
            
            driver.FindElement(By.LinkText("Sport")).Click();
            Thread.Sleep(5000);
        }
        
    
}
}