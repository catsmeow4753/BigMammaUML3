using BigMammaUML3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MenuCatalogTestProject
{
    [TestClass]
    public class MenuCatalogTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            IMenuCatalog iMenuCatalog = new MenuCatalog();

            IMenuItem menuItem_1 = new Pizza(0, "Pizza 1", "A pizza", 19.99, MenuType.Pizza, false, true, true);
            IMenuItem menuItem_2 = new Pizza(1, "Pizza 2", "A pizza", 39.99, MenuType.Pizza, true, false, false);
            IMenuItem menuItem_3 = new Pizza(2, "Pizza 3", "A pizza", 9.99, MenuType.Pizza, true, false, false);

            iMenuCatalog.Add(menuItem_1);
            iMenuCatalog.Add(menuItem_2);
            iMenuCatalog.Add(menuItem_3);

            int expectedResult_1 = 2;
            int expectedResult_2 = 1;
            int expectedResult_3 = 1;

            //Act
            int actualResult_1 = iMenuCatalog.FindAllVegan(MenuType.Pizza).Count;
            int actualResult_2 = iMenuCatalog.FindAllOrganic(MenuType.Pizza).Count;
            int actualResult_3 = iMenuCatalog.MostExpensiveMenuItem().Number;

            //Assert
            Assert.AreEqual(expectedResult_1, actualResult_1);
            Assert.AreEqual(expectedResult_2, actualResult_2);
            Assert.AreEqual(expectedResult_3, actualResult_3);
        }
    }
}