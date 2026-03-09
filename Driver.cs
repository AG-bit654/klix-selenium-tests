#nullable enable
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace vjezba
{
    public static class Driver
    {
        public static IWebDriver? Instance { get; set; }

        public static void Initialize()
        {
            var options = new ChromeOptions();
            // Dodajemo ove dvije linije da zaobiđemo probleme sa sistemom
            options.AddArgument("--remote-allow-origins=*");
            
            // Inicijalizacija bez ikakvih putanja - Selenium 4.24 će sam uraditi ostalo
            Instance = new ChromeDriver(options);
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void Close()
        {
            if (Instance != null)
            {
                Instance.Quit();
                Instance.Dispose();
            }
        }
    }
}