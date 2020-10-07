namespace Bakery
{
  public class Pastry
  {
    public int Count;
    public int Price;

    public Pastry(int amount)
    {
      Count = amount;
    }

    public void CalculatePrice()
    {
      Price = 0;
      int notCounted = Count;
      Price += (notCounted % 3) * 2;
      notCounted -= notCounted % 3;
      Price += (notCounted / 3) * 5;
    }
  }
}