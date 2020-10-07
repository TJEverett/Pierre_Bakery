using System;

namespace Bakery
{
  public class Bread
  {
    public int Count;
    public int Price;

    public Bread(int amount)
    {
      Count = amount;
    }

    public void CalculatePrice()
    {
      Price = 0;
      int notCounted = Count;
      Price += (notCounted % 3) * 5;
      notCounted -= notCounted % 3;
      Price += (notCounted / 3) * 10;
    }
  }
}