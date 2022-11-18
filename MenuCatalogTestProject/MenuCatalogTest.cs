using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UML3;

namespace MenuCatalogTestProject
{
    [TestClass]
    public class MenuCatalogTest
    {
        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            IMenuCatalog catalog = new MenuCatalog();
            Pizza p1 = new Pizza(1, "Margherita", "-Tomat og Ost", 52, MenuType.Pizza, false);
            Pizza p2 = new Pizza(2, "Vesuvio", "-Tomat og Ost", 68, MenuType.Pizza, false);

            //Act
            int antalBefore = catalog.Count;
            catalog.Add(p1);
            catalog.Add(p2);
            int antalAfter = catalog.Count;
            
            //Assert
            Assert.AreEqual(antalBefore + 2, antalAfter);

        }

        public void TestDelete()
        {
            //Arrange
            IMenuCatalog catalog = new MenuCatalog();
            Pizza p1 = new Pizza(1, "Margherita", "-Tomat og Ost", 52, MenuType.Pizza, false);
            Pizza p2 = new Pizza(2, "Vesuvio", "-Tomat og Ost", 68, MenuType.Pizza, false);

            //Act
            int countBefore = catalog.Count;
            catalog.Add(p1);
            catalog.Add(p2);
            catalog.Delete(1);
            catalog.Delete(2);
            int countAfter = catalog.Count;

            //Assert
            Assert.AreEqual(countBefore - 2, countAfter);

        }
}