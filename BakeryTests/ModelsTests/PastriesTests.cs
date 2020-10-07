using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace BakeryTests
{
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