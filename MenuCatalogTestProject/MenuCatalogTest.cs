using UML3;

namespace MenuCatalogTestProject
{
    [TestClass]
    public class MenuCatalogTest
    {
        [TestMethod]
        public void TestAddItem()
        {
            //Arrange
            IMenuCatalog catalog = new MenuCatalog();
            Pizza p1 = new Pizza(1, "Margherita", "-Tomat og Ost", 52, MenuType.Pizza, false);

            //Act
            catalog.Add(p1);

            //Assert

        }
    }
}