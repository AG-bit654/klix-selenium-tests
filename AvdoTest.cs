using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace vjezba
{
    [TestClass]
    public class AvdoTest
    {
        [TestInitialize]
        public void Init() => Driver.Initialize();

        [TestCleanup]
        public void Cleanup() => Driver.Close();

        [TestMethod]
        public void Test1_SkrolajNaKlixu()
        {
            Assert.IsNotNull(Driver.Instance, "Driver nije inicijaliziran!");

            KlixPage klix = new KlixPage(Driver.Instance);
            klix.Otvori();
            klix.SkrolajNaDno();
            
            Assert.IsTrue(Driver.Instance.FindElement(By.TagName("footer")).Displayed);
        }
        [TestMethod]
    
        public void Test2_KlikniNaSearch()
        {
            Assert.IsNotNull(Driver.Instance, "Driver nije inicijaliziran!");
            KlixPage klix = new KlixPage(Driver.Instance);
            klix.Otvori();
            klix.KlikniNaSearch();
            Thread.Sleep(3000);
            Console.WriteLine(Driver.Instance.Url);
            Assert.IsTrue(Driver.Instance.Url.ToLower().Contains("sarajevo"), "Pretraga nije radila!");
        
        }
        [TestMethod]
        public void Test3_KlikniNaVijesti()
        {
            Assert.IsNotNull(Driver.Instance, "Driver nije inicijaliziran!");
            KlixPage klix = new KlixPage(Driver.Instance);
            klix.Otvori();
            klix.KlikniNaVijesti();
            Thread.Sleep(3000);
            Console.WriteLine(Driver.Instance.Url);
            Assert.IsTrue(Driver.Instance.Url.ToLower().Contains("vijesti"), "Pretraga nije radila!");
        }
        [TestMethod]
        public void Test4_KlikniNaBiznis()
        {
            Assert.IsNotNull(Driver.Instance, "Driver nije inicijaliziran!");
            KlixPage klix = new KlixPage(Driver.Instance);
            klix.Otvori();
            klix.KlikniNaBiznis();
            Thread.Sleep(3000);
            Console.WriteLine(Driver.Instance.Url);
            Assert.IsTrue(Driver.Instance.Url.ToLower().Contains("Biznis"), "Pretraga nije radila!");
        }
    }
}
