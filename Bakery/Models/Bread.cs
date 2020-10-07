namespace Bakery.Models
{
  public class Bread
  {
    public int Count { get; set; }
    public int Price { get; set; }

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