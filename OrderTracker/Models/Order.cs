using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Date { get; set; }
    public int Id {get; set; }

    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string description, double price, int date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId -1];
    }
  }
}