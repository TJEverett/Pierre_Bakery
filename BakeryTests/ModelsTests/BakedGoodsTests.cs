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
  }
}