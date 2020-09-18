using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace BakeryTests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Constructor_BuildBreadOrder_True()
    {
      Bread testBread = new Bread(17);
      Assert.AreEqual(17, testBread.Count);
    }

    [TestMethod]
    public void CalculatePrice_CalculatesBreadPrice_True()
    {
      Bread testBread = new Bread(17);
      testBread.CalculatePrice();
      Assert.AreEqual(60, testBread.Price);
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Constructor_BuildPastryOrder_True()
    {
      Pastry testPastry = new Pastry(17);
      Assert.AreEqual(17, testPastry.Count);
    }

    [TestMethod]
    public void CalculatePrice_CalculatesPastryPrice_True()
    {
      Pastry testPastry = new Pastry(17);
      testPastry.CalculatePrice();
      Assert.AreEqual(29, testPastry.Price);
    }
  }
}