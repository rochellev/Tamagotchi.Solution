using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class TamagotchiAnimal
  {
    public string Name { get; set; }
    private static List<TamagotchiAnimal> _instances = new List<TamagotchiAnimal> {};
    public int Id {get;}

    public TamagotchiAnimal (string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<TamagotchiAnimal> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}